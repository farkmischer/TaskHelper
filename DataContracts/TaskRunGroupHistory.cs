using System;

namespace DataContracts
{
	public class TaskRunGroupHistory
    {
        public int Id { get; set; }
		public int TaskGroupId { get; set; }
		public DateTime? TimeRunStarted { get; set; }
		public DateTime? TimeRunCompleted { get; set; }
		public DateTime? TimeRunCanceled { get; set; }
    }
}