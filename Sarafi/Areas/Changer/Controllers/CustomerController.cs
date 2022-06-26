using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Sarafi.DataAccess.Repository.IRepository;
using Sarafi.Models.DB;
using Sarafi.Models.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using Sarafi.Utility;

namespace Sarafi.Areas.Changer.Controllers
{
    [Authorize]
    [Area("Changer")]
    public class CustomerController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        dbgeneral db=new dbgeneral();
        public CustomerController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {

            return View();
        }

        [HttpGet]
        public IActionResult Upsert(string? customercode)
        {
            Customer customer;
            if (customercode == null || customercode=="")
            {
                customer = new Customer();
            }
            else
            {
              customer= _unitOfWork.Customer.GetFirstOrDefault(c => c.CustomerCode == customercode);  
            }
            return View(customer);
        }

        [HttpPost]
        public IActionResult Upsert(Customer obj)
        {
            if(ModelState.IsValid)
            {
                if(obj.CustomerCode!=null)
                {
                    obj.Username = User.Identity.Name;
                    _unitOfWork.Customer.Update(obj);
                }
                else
                {
                    obj.CustomerCode = FormatCustomerID(db.GetMaxID("Customer","Customercode"));
                    obj.Username=User.Identity.Name;
                    _unitOfWork.Customer.Add(obj);
                }
                _unitOfWork.Save();
            }
            return RedirectToAction("Index");

        }

        [HttpGet]
        public IActionResult Deposit(string? customercode)
        {
            CustomerVM customerVM = new CustomerVM()
            {
                Customer =new Customer(),
                Cashbook = new Cashbook(),
                Transaction = new Transaction(),
                CurrencyList = _unitOfWork.ZCurrency.GetAll().
                  Select(c => new SelectListItem { Text = c.Currency, Value = c.CurrencyId.ToString() })
            };
            if(customercode==null || customercode=="")
            {
                return View(customerVM);
            }
            else
            {
                customerVM.Customer=_unitOfWork.Customer.GetFirstOrDefault(c=>c.CustomerCode==customercode);
                return View(customerVM);
            }
  
        }


        [HttpGet]
        public IActionResult CustomerList()
        {
            return View();
        }
       private string FormatCustomerID(int maxid)
        {
            string Customercode = "";
            if(maxid.ToString().Length==1 && maxid<10)
            {
                Customercode="ID00000"+maxid.ToString();
            }
            else if (maxid.ToString().Length == 2)
                Customercode = "ID0000" + maxid.ToString();
            else if (maxid.ToString().Length == 3)
                Customercode = "ID000" + maxid.ToString();
            else if (maxid.ToString().Length == 4)
                Customercode = "ID00" + maxid.ToString();
            else if (maxid.ToString().Length == 5)
                Customercode = "ID0" + maxid.ToString();
            else if (maxid.ToString().Length == 6)
                Customercode = "ID" + maxid.ToString();

            return Customercode;

        }


        #region API Call
            [HttpGet]
            public IActionResult GetAll()
            {
                var customerlist = _unitOfWork.Customer.GetAll();
                JsonResult json = Json(new { data = customerlist });
                return Json(new { data = customerlist });
            }

            [HttpGet]
            public IActionResult EditCustomer(string customercode)
            {
                


                return Json(new { data = "" });
            }

        #endregion
    }
}
