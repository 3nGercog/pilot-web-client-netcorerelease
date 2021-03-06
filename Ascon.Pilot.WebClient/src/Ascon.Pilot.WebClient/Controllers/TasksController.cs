﻿

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Ascon.Pilot.WebClient.Controllers
{
    /// <summary>
    /// Контроллер задач
    /// </summary>
    [Authorize]
    public class TasksController : Controller
    {
        /// <summary>
        /// Открытие представление Index
        /// </summary>
        /// <returns>представление Index</returns>
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}
