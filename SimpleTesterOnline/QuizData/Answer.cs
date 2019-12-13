using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleTesterOnline.QuizData
{
    [Serializable]
    public class Answer
    {
        public int id { get; set; }
        public string text { get; set; }
        public bool isCorrect { get; set; }
    }
}
