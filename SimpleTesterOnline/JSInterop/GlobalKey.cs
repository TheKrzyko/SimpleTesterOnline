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
        
        public static event Func<KeyboardEventArgs, Task> onKeyUp;
        public static event Func<KeyboardEventArgs, Task> onKeyDown;
        [JSInvokable]
        public static async Task TriggerKeyUp(KeyboardEventArgs args)
        {
            
            await onKeyUp?.Invoke(args);
        }
        [JSInvokable]
        public static async Task TriggerKeyDown(KeyboardEventArgs args)
        {
            await onKeyDown?.Invoke(args);
        }
        public static void ClearEventKeyUp()
        {
            onKeyUp = null;
        }
    }
}
