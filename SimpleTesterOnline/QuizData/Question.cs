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
        public Answer[] answers { get; set; }
        public bool isMultipleCorrect { get; set; }
        
    }
}
