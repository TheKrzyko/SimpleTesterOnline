using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

namespace SimpleTesterOnline.QuizData
{
    public class XMLQuizParser : IQuizParser
    {
        public Quiz Load(MemoryStream memStream)
        {
            var xDoc = new XmlDocument();
            xDoc.Load(memStream);
            var root = xDoc.DocumentElement;
            Quiz quiz = new Quiz() { version = "Plik nie ma wersji"};
            quiz.questions = new List<Question>();
            int i = 1;
            //XML...
            foreach(var elQuestion in root.SelectNodes("question").OfType<XmlElement>())
            {
                var question = new Question() { number = i};
                question.title = elQuestion.SelectSingleNode("description").InnerText;
                var answer1 = elQuestion.SelectSingleNode("answer1").InnerText;
                var answer2 = elQuestion.SelectSingleNode("answer2").InnerText;
                var answer3 = elQuestion.SelectSingleNode("answer3").InnerText;
                var answer4 = elQuestion.SelectSingleNode("answer4").InnerText;
                question.answers = new Answer[4];
                question.answers[0] = new Answer() { id = 0, isCorrect = true, text = answer1 };
                question.answers[1] = new Answer() { id = 1, isCorrect = false, text = answer2 };
                question.answers[2] = new Answer() { id = 2, isCorrect = false, text = answer3 };
                question.answers[3] = new Answer() { id = 3, isCorrect = false, text = answer4 };
                quiz.questions.Add(question);
                i++;
            }
            return quiz;
        }
    }
}
