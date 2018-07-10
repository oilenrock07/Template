using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Template.Entities.Entities.Accounts;
using Template.Infrastructure.Interfaces;

namespace Template.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepository<User> _userRepository;
        private readonly IUnitOfWork _unitOfWork;

        public HomeController(IRepository<User> userRepository, IUnitOfWork unitOfWork)
        {
            _userRepository = userRepository;
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            var xy = _userRepository.FirstOrDefault(x => x.Id == "");
            return View();
        }

        public IActionResult Error()
        {
            ViewData["RequestId"] = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            return View();
        }
    }
}
