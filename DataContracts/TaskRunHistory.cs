namespace DataContracts
{
	public class TaskRunHistory
    {
        public int Id { get; set; }
		public int TaskId { get; set; }
        public int SecondsElapsed { get; set; }
		public bool Completed { get; set; }

    }
}