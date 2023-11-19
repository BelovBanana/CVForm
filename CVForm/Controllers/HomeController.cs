using CVForm.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CVForm.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        //public IActionResult CV(CvViewModel model)
        //{
        //    return View();
        //}
        
        public IActionResult CvInput()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CvInput(CvInputViewModel viewModel) //CVMy
        {
            var model = new CvViewModel
            {
                Name = viewModel.Name,
                Surname = viewModel.Surname,
                Phone = viewModel.Phone,
                Email = viewModel.Email,
                Site = viewModel.Site,
                Summary = viewModel.Summary,
                Certification = viewModel.Certification,
            };

            if (viewModel.WorkPeriods.Any())
            {
                model.WorkPeriods = viewModel.WorkPeriods.Split("[;]").ToList();
            }

            if (viewModel.Avatar != null)
            {
                byte[] imageData = null;
                using (var binaryReader = new BinaryReader(viewModel.Avatar.OpenReadStream()))
                {
                    imageData = binaryReader.ReadBytes((int)viewModel.Avatar.Length);
                }

                model.Avatar = imageData;
            }

            return View("CVFull", model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}