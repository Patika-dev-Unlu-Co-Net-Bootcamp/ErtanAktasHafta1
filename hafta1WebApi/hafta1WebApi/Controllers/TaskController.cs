using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace hafta1WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        
        private static List<Task> Tasks = new List<Task>()
        {
            new Task
            {
                Id = 1,
                Title = "Patika Dersleri",
                Description = ".Net patikasını takip et",
                Status = Status.getStatus()[0],
                Date = new DateTime(2022,01,22)


            },
             new Task
             {
                Id = 2,
                Title = "Office Hours ",
                Description = "Perşembe günü office hours katıp 20:00",
                Status = Status.getStatus()[1],
                Date = new DateTime(2022,01,13)

             },
             new Task
             {
                Id = 3,
                Title = "Ödev",
                Description = "Haft 1 ödevini yap!",
                Status = Status.getStatus()[0],
                Date = new DateTime(2022,01,15)
             },
             new Task{
                Id = 4,
                Title = "Oyun",
                Description = "Oyun oyna",
                Status = Status.getStatus()[0],
                Date = new DateTime(2022,01,14)
             },
        };
       

        [HttpGet]
        public List<Task> Get()
        {
            var tasks = Tasks.OrderBy(t => t.Date).ToList();
            return tasks;

        }
        [HttpGet("{status}")]
        public Task GetById(string status)
        {
            var task = Tasks.Where(x => x.Status == status).SingleOrDefault();
            return task;
        }



    }
}
