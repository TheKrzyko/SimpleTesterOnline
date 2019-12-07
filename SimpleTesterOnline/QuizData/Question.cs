using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleTesterOnline.QuizData
{
    [Serializable]
    public class Question
    {
        public int number { get; set; }
        public string title { get; set; }
        public string[] answers { get; set; }
        public int[] correct { get; set; }
        public override string ToString()
        {
            var nl = "<br/>";
            return number + nl + answers.Aggregate((s1, s2) => s1 + nl + s2) + nl + "Correct: " + correct.Select((i)=>i.ToString()).Aggregate((s1, s2) => s1+" "+s2);
        }
    }
}
