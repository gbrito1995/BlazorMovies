using Microsoft.JSInterop;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;


namespace BlazorMovies.Client.Helpers
{
    public static class IJSRuntimeExtensionMethods
    {
        public static async ValueTask<bool> Confirm(this IJSRuntime js, string message)
        {   
            await js.InvokeVoidAsync("console.log", "Example");
            return await js.InvokeAsync<bool>("confirm", message);
        }

        public static async ValueTask MyFunction(this IJSRuntime js, string message)
        {               
            await js.InvokeVoidAsync("my_function", message);
        }
    }
}