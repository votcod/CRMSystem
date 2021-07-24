using System;

namespace CRMSystem.Models
{
    public class WorkTask
    {
        public int WorkTaskId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ResponsiblePerson { get; set; }
        public string Status { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime DeadLineDate { get; set; }
    }
}
