using System;
using System.Collections.Generic;
using System.Text;

namespace Util
{
    class QandA
    {
        static public string AskQuestion(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }
    }
}
