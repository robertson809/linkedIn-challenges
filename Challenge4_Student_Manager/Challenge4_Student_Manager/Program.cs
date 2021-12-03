using System;

namespace Challenge4_Student_Manager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter piars of student names and grades. Enter \"0\" for the student name to exit");
            Console.WriteLine("Enter the first student name");
            var name = Console.ReadLine();
            Console.WriteLine("Enter the first student grade");
            int.TryParse(Console.ReadLine(), out var grade);

            Console.WriteLine("The name is {0} and the grade is {1}", name, grade);


            var student_count = 1;
            var old_student_name_grade = new (string, int)[] { (name,grade) };

            var adding = true;
            // this whole thing isn't very functional programming, but I also am not allow to use lists at this point,
            // so it's whatever
            while (adding)
            {
                Console.WriteLine("Enter the student name:");
                name = Console.ReadLine();
                Console.WriteLine("Enter the student grade:");
                grade = int.Parse(Console.ReadLine());

                student_count++;
                var user_response_tup = (name, grade);
                var new_student_name_grade = new (string, int)[student_count];

                // copy old info into new array
                for (var i = 0; i < student_count -1; i++)
               {
                    new_student_name_grade[i] = old_student_name_grade[i];
               }

                // add last response to the new array
                new_student_name_grade[student_count - 1] = user_response_tup;

                if (name == "Michael")
                {
                    Console.WriteLine("It's you!");
                }


                Console.WriteLine("Do you want to continue addding students? (y/n)");
                var response = Console.ReadLine();
                while (response != "y" && response != "n")
                {
                    Console.WriteLine("Unrecognized response, please enter \"y\" or \"n\"");
                    response = Console.ReadLine();
                }

                // practice with switch statements
                switch (response)
                {
                    case "y":
                        break;
                    case "n":
                        adding = false;
                        break;
                }
                old_student_name_grade = new_student_name_grade;

            }

            Console.WriteLine();
            Console.WriteLine("Now we will read back the input...");
            Console.WriteLine();

            foreach (var name_grade_tuple in old_student_name_grade)
            {
                (name, grade) = name_grade_tuple;
                Console.WriteLine("Student \"{0}\" has grade {1}.", name, grade);
            }
        }
    }
}
