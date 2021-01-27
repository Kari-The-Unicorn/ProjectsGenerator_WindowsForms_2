namespace ProjectsGenerator_WindowsForms_2.Objects
{
    public class Issue
    {
        public int id { get; set; }
        public string IssueName { get; set; }
        public int? ProjectId { get; set; }
        public string IssueDescription { get; set; }
        public string IssuePlace { get; set; }
        public int? ImageId { get; set; }
        public int? IssueCoordinateX { get; set; }
        public int? IssueCoordinateY { get; set; }

    }
}
