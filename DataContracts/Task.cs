namespace DataContracts
{
    public class Task
    {
        public int Id { get; set; }
		public int TaskGroupId { get; set; }
        public string Name { get; set; }
		public int? Duration { get; set; }

    }
}