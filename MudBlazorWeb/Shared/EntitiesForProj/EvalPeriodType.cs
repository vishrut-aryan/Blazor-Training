using System;

namespace Shared.EntitiesForProj
{
    public class EvalPeriodType
    {
        public int EvalPeriodTypeID { get; set; }
        public string EvalPeriodTypeName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public List<Evaluation> Evaluations { get; set; }
    }
}
