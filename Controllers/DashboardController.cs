using ExpanditureApi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
namespace ExpanditureApi29_sep.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DashboardController:ControllerBase
    {
        private ExpanditureContext db;

    public DashboardController(ExpanditureContext context){
        db=context;
    }

        [HttpGet]
        [Route("get-income")]
        public IActionResult GetIncome(){
            return Ok(db.Income.Sum(x=>x.amount));
        }
        [HttpGet]
        [Route("get-expanditure")]
        public IActionResult getExpanditure(){
            return Ok(db.Expanditures.Sum(x=>x.Amount));
        }
    }

}