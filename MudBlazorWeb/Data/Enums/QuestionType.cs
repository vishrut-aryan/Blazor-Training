using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Enums
{
    public enum QuestionType
    {
        [Display(Name = "General (30 day evaluation Only)")]
        General_30day = 0,

        [Display(Name = "General")]
        General = 1,

        [Display(Name = "Technical")]
        Technical = 2,
        
        [Display(Name = "Performance")]
        Performance = 3,
    }
}
