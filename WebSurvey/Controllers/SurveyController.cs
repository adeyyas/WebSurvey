using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebSurvey.Data;

namespace WebSurvey.Controllers
{
    public class SurveyController : Controller
    {
        private readonly ApplicationDbContext _context;
       
        public SurveyController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index() 
        {
            var surveys = _context.surveys.Include(s=>s.Answers).ToList();
            return View(surveys);
        }

    }
}
