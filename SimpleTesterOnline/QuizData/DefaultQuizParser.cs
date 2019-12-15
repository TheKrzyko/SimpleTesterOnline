using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleTesterOnline.QuizData
{
    public class DefaultQuizParser : IQuizParser
    {
        public Quiz Load(MemoryStream memStream)
        {
            using (var stream = new StreamReader(memStream, System.Text.Encoding.UTF8))
            {
                string version = stream.ReadLine();
                var questions = new List<Question>();
                while (!stream.EndOfStream)
                {
                    questions.Add(LoadQuestion(stream));
                }
                return new Quiz(questions, version);
            }
        }
        private Question LoadQuestion(StreamReader stream)
        {
            var question = new Question();
            

            string[] numberSplitter = stream.ReadLine().Split('.');
            question.number = int.Parse(numberSplitter[0]);
            question.title = numberSplitter[1];
            int answers = int.Parse(stream.ReadLine());
            question.answers = new Answer[answers];

            for(int i = 0; i < answers; i++)
            {
                string atext = stream.ReadLine();
                question.answers[i] = new Answer() { id=i, text=atext, isCorrect=false};
            }
            var corrects = stream.ReadLine().Split(' ').Select((s) => int.Parse(s)).ToArray();
            foreach(var i in corrects)
            {
                question.answers[i - 1].isCorrect = true;
            }
            return question;
        }
        
    }
}
