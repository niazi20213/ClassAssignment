using Microsoft.AspNetCore.Mvc;
using Sarafi.DataAccess.Repository.IRepository;

namespace Sarafi.Areas.Changer.Controllers
{
    public class HawalaController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public HawalaController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
          
            return View();
        }
    }
}
