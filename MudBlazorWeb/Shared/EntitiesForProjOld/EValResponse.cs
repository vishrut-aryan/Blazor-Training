namespace Shared.EntitiesForProj
{
    public class EValResponse
    {
        public int Id { get; set; }
        public int EValHeaderId { get; set; }
        public double? Score { get; set; }
        public string Comments { get; set; }
        public double? SupervisorScore { get; set; }
        public string SupervisorComment { get; set; }
        public int QuestionId { get; set; }
        public Question Question { get; set; }
    }
}