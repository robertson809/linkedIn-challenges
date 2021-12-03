using System;
using System.Collections.Generic;
using Util;


namespace Challenge5_SurveyOOP
 
{
    class Program
    {
        static void Main(string[] args)
        {
            // list declared with parent class "Respondant"
            // style 0028 prefers I use a collection initializer with the two objects rather than empty parentheses. 
            var respondant_list = new List<Respondant> { new BasicRespondant("Michael", 23, "February"),
                new PreferredRespondant("Cullen", 24, "March", "Green", 850) };
            BasicRespondant.Count++;
            PreferredRespondant.Count++;
   

            for (var i = 0; i < 2; i++)
            {
                BasicRespondant.Count++;
                Respondant newRespondant = new BasicRespondant();


                // using the Q and A class defined in another file
                newRespondant.SetName(QandA.AskQuestion("What is your name?"));
                newRespondant.SetAge(int.Parse(QandA.AskQuestion("How old are you?")));
                newRespondant.SetBirthMonth(QandA.AskQuestion("What month were you born in?"));

                Console.WriteLine();

                respondant_list.Add(newRespondant);
                
            }

            Console.WriteLine("Printing Results, there were {0} basic respondants to the survey and {1} preferred respondants",
                BasicRespondant.Count, PreferredRespondant.Count);
            Console.WriteLine();
            Console.WriteLine();

            foreach (var respondant in respondant_list)
            {
                // display method of the respondant parent class is a virtual class, so it can and is overwritten by its child/extending
                // class preferred respondant
                respondant.Display();
                Console.WriteLine();
            }
        }

        class Respondant
        {
            // protected allows variables to be accessed by child classes
            protected string name;
            protected int age;
            protected string birth_month;
           

            // virtual allows the method to be overridden
            public virtual void Display()
            { 
                Console.WriteLine("Name:" + name);
                Console.WriteLine("Age:" + age);
                Console.WriteLine("Birth Month:" + birth_month);
   
            }

            // writing out getters. This can be refactored using auto properties to make cleaner
            public string GetName()
            {
                return this.name;
            }

            public int GetAge()
            {
                return this.age;
            }

            public string GetBirthMonth()
            {
                return this.birth_month;
            }

            public void SetAge(int age)
            {
                this.age = age;
            }

            public void SetName(string name)
            {
                this.name = name;
            }

            public void SetBirthMonth(string birth_month)
            {
                this.birth_month = birth_month;
            }
        }

        // how to extend a parent class, taking advantage of inheritance
        class PreferredRespondant : Respondant
        {
            static public int Count;
            
            public string Favorite_color  { get; set; }
            public int Credit_score { get; set; }

            // still allows for not entering the data at the time of creation. Possible to add some pre-conditioning here and 
            // in the setters
            public PreferredRespondant()
            {

            }


            // constructor use
            public PreferredRespondant(string name, int age, string month, string color, int credit_score)
            {
                this.name = name;
                this.age = age;
                this.birth_month = month;
                this.Favorite_color = color;
                this.Credit_score = credit_score;
            }

            // overriding display, but also keeping original functionality by using the "base.Display" call,
            // so it's really just adding to the exisiting method fo PreferreedRespondants. 
            public override void Display()
            {
                base.Display();
                Console.WriteLine("Favorite Color:" + Favorite_color);
                Console.WriteLine("Credit Score:" + Credit_score);
            }

        }

        class BasicRespondant : Respondant
        {
            // static variables are global to the class rather than bound to a specific instance
            static public int Count;
           

            public BasicRespondant()
            { 
            }
            public BasicRespondant(string name, int age, string birth_month)
            {
                Console.WriteLine("Using the constructor");
                BasicRespondant.Count++;
                this.Name = name;
                this.age = age;
                this.birth_month = birth_month;
            }
            public string Name
            {
                // example of C# auto implementation of the set method along with some added preconditioning of the data
                // to privledge the author.
                set 
                {
                    if (value == "Michael")
                        name = "Michael Robertson";
                    else
                        name = value;
                 }
            } 
        }
    }
}
