using SimpleTesterOnline.QuizData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cloudcrate.AspNetCore.Blazor.Browser.Storage;
using Microsoft.AspNetCore.Components;

namespace SimpleTesterOnline.Services
{
    public class LocalAppStorage
    {
        private LocalStorage _storage;
        public LocalAppStorage(LocalStorage storage)
        {
            _storage = storage;
        }
        public delegate void OnStateChange();
        public event OnStateChange onQuizChange;
        public Quiz quiz {
            get {
                return _storage.GetItem<Quiz>("quiz");
            }
            set {
                _storage.SetItem("quiz", value);
                onQuizChange();
            } 
        }
    }
}
