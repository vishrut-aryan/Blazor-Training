using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace HiddenVilla.Helper
{
    public static class IJSRuntimeExtension
    {
        public static async ValueTask ToastrSuccess(this IJSRuntime JSRuntime, string message)
        {
            await JSRuntime.InvokeVoidAsync("ShowToastr", "success", "We did it!!!");
        }

        public static async ValueTask ToastrError(this IJSRuntime JSRuntime, string message)
        {
            await JSRuntime.InvokeVoidAsync("ShowToastr", "error", "Error Message");
        }

        public static async ValueTask SwalSuccess(this IJSRuntime JSRuntime, string message)
        {
            await JSRuntime.InvokeVoidAsync("ShowSwal", "success", "We did it!!!");
        }

        public static async ValueTask SwalError(this IJSRuntime JSRuntime, string message)
        {
            await JSRuntime.InvokeVoidAsync("ShowSwal", "error", "Error Message");
        }
    }
}
