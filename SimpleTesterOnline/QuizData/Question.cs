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
        
        public Question Clone()
        {
            Answer[] answersCopy = answers.Clone() as Answer[];
            return new Question() { number = number, title = title, answers = answersCopy, isMultipleCorrect = isMultipleCorrect };
        }
    }
}
