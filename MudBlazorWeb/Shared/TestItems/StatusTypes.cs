using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.TestItems
{
    public enum StatusTypes
    {
        [Display(Name = "Draft")]
        Draft = 0,

        [Display(Name = "Returned To Employee")]
        ReturnedToEmployee = 10,

        [Display(Name = "Submitted To Supervisor")]
        SubmittedToSupervisor = 50,

        [Display(Name = "Returned To Supervisor")]
        ReturnedToSupervisor = 60,

        [Display(Name = "Review and Sign")]
        ReviewAndSign = 70,

        [Display(Name = "Submitted To Division Head")]
        SubmittedToDivisionHead = 90,

        [Display(Name = "Completed")]
        Completed = 100,
    }
}
