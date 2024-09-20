using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWASMCRUD.Shared.Services
{
    public class ThemeService
    {
        public bool IsDarkMode { get; set; }
        public MudTheme CurrentTheme { get; private set; }

        public ThemeService()
        {
            IsDarkMode = false;
            CurrentTheme = new MudTheme();
        }

        public void ToggleDarkMode()
        {
            IsDarkMode = !IsDarkMode;
        }
    }

}
