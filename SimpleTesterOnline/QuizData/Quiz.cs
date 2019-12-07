using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleTesterOnline.QuizData
{
    [Serializable]
    public class Quiz
    {
        public List<Question> questions { get; set; }
        public string version { get; set; }
        public string fileName { get; set; }
        public Quiz() { }
        public Quiz(List<Question> questions, string version)
        {
            this.questions = questions;
            this.version = version;
        }
        
    }
}
