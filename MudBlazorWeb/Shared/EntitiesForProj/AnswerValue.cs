using System;

namespace Shared.EntitiesForProj
{
    public class AnswerValue
    {
        public int AnswerValueId { get; set; }
        public int AnswerTypeId { get; set; }
        public string AnswerValueText { get; set; }

        public AnswerType AnswerType { get; set; }
    }
}
