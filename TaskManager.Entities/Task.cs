using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManager.Entities
{
    public class Task : DomainObject
    {
        [Required]
        [MaxLength(64)]
        public string Name { get; set; }

        [MaxLength(4096)]
        public string Description { get; set; }
        public int? DueDate { get; set; }
        public int? ActuallyCompleteDate { get; set; }
        [Required]
        public DateTime CreateDate { get; set; }
        [Required]
        public DateTime CompleteDate { get; set; }
        public Status Status { get; set; }
        [NotMapped]
        public bool IsTerminal { get; set; }
        [NotMapped]
        public bool IsRoot { get; set; }

        public int ParentTaskId { get; set; }
        public Task ParentTask { get; set; }

        public ICollection<Task> ChildTasks { get; set; }
        public ICollection<Task> Tasks { get; set; }
    }
}
