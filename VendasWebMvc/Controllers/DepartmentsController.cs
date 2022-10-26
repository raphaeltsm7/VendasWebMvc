using Microsoft.AspNetCore.Mvc;
using VendasWebMvc.Models;

namespace VendasWebMvc.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> list = new List<Department>();

            list.Add(new Department { id = 1, name = "Eletronics" });
            list.Add(new Department { id = 2, name = "Fashion" });
            
            return View(list);
        }
    }
}
