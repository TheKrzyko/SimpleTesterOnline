using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleTesterOnline.QuizData
{
    public class Question
    {
        public int number;
        public string title;
        public string[] answers;
        public int[] correct;
        public override string ToString()
        {
            var nl = "<br/>";
            return number + nl + answers.Aggregate((s1, s2) => s1 + nl + s2) + nl + "Correct: " + correct.Select((i)=>i.ToString()).Aggregate((s1, s2) => s1+" "+s2);
        }
    }
}
