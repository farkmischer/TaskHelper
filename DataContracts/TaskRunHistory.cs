using System;

namespace DataContracts
{
	public class TaskRunHistory
    {
        public int Id { get; set; }
		public int TaskRunGroupHistoryId { get; set; }
        //public int SecondsElapsed { get; set; }
		public DateTime CalculatedCompletionTime { get; set;}
		public DateTime? CompletedAt { get; set; }
		public string Name { get; set; }
		//public int SecondsSinceStartOfGroup { get; set; }
		//public int TaskOrder { get; set; }

    }
}