using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleTesterOnline.JSInterop
{
    public static class GlobalKey
    {
        public delegate void OnKeyUp(KeyboardEventArgs args);
        public static event OnKeyUp onKeyUp;

        [JSInvokable]
        public static void TriggerKeyUp(KeyboardEventArgs args)
        {
            onKeyUp(args);
        }
    }
}
