using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleTesterOnline.QuizData
{
    public class Quiz
    {
        public List<Question> questions;
        public string version;
        public Quiz(List<Question> questions, string version)
        {
            this.questions = questions;
            this.version = version;
        }
        
    }
}
