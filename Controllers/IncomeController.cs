using System.Linq;
using ExpanditureApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExpanditureApi.Controllers {
    [ApiController]
    [Route("[controller]")]    
    public class IncomeController : ControllerBase {
        private ExpanditureContext context;
        public IncomeController(ExpanditureContext _context) {
            context = _context;
        }
        [HttpPost]
        [Route("add")]
        public IActionResult AddIncome([FromBody]Income income) {
            context.Income.Add(income);
            context.SaveChanges();
            return Ok(context.Income.ToList());
        }
        [HttpGet]
        [Route("get-all")]
        public IActionResult GetAll() {
            return Ok(context.Income.ToList());
        }
    }
}