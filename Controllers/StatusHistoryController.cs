using NewAPI.Classes;
using NewAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace NewAPI.Controllers
{
    public class StatusHistoryController : ApiController
    {
        NewSession1Entities DataBase = new NewSession1Entities();

        public IHttpActionResult GetStatusHistoryByTaskId(int taskId)
        {
            var HistoryList = DataBase.StatusHistory.Where(x => x.TaskId == taskId).ToList().ConvertAll(x => new StatusHistoryClass(x));

            return Ok(HistoryList);
        }
    }
}