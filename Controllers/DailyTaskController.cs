using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DailyTasks.Models;
using Microsoft.AspNetCore.Mvc;

namespace DailyTasks.Controllers
{
    public class DailyTaskController : Controller
    {
        static List<DailyTask> tasksList = Tasks();
        public IActionResult Index()
        {
            return View(tasksList);
        }
        public IActionResult Details(int id)
        {
            return View(tasksList.Where(e=>e.Id==id).FirstOrDefault());
        }
        private static List<DailyTask> Tasks()
        {
            tasksList = new List<DailyTask>();
            for (int i=0; i<10; i++)
            {
                var urgency = (new Random().Next(1, 100)) % 2;
                var importance = (new Random().Next(1, 100)) % 2;
                TaskCategory tc = new TaskCategory()
                {
                    UrgencyStatus = (Urgency)urgency,
                    ImportanceStatus = (Importance)importance
                };
                tasksList.Add(new DailyTask(i,"task# "+i,"the content of task# "+i,tc));
            }
            tasksList = tasksList.OrderByDescending(i => i.Category.ImportanceStatus).ThenByDescending(u => u.Category.UrgencyStatus).ToList();
            return tasksList;
        }

       
    }
}