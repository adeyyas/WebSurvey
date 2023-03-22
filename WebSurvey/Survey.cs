namespace WebSurvey
{
    public class Survey
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public List<Answers> Answers { get; set; }
    }

    public class Answers
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int VoteNumber { get; set; }
    }
}
