using System.Linq;
using ExpanditureApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExpanditureApi29_sep.Controllers
{
     [ApiController]
    [Route("[controller]")]
    public class ExpanditureController : ControllerBase
    {
        private ExpanditureContext context;
        public ExpanditureController(ExpanditureContext _context) {
            context = _context;
        }
     [HttpGet]
    [Route("select")]
    public IActionResult Select() {
        var result = context.ExpenditureTypes.Where(x=>x.IsActive==true).Select(s => new
                        {
                            id = s.Id,
                            name = s.ExpenditureTypeName
                        }).ToList();
    return Ok(result);
    }
    
    }
}