using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleTesterOnline.QuizData
{
    public interface IQuizParser
    {
        Quiz Load(MemoryStream memStream);
    }
}
