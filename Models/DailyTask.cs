using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DailyTasks.Models
{
    public class DailyTask
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public TaskCategory Category { get; set; }

        public DailyTask(int id, string name, string content, TaskCategory category)
        {
            Id = id;
            Name = name;
            Content = content;
            Category = category;
        }

    }
}
