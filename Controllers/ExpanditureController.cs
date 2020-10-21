using System;
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
    // validation for add expanditure page
    //redirect 
    // dinamic
    [HttpPost]
        [Route("epxanditure-with-amount")]
        public IActionResult Add([FromBody] Expanditure expanditure)
        {
            expanditure.CreatedDate = DateTime.Now;
            expanditure.IsActive = true;
            context.Expanditures.Add(expanditure);
            context.SaveChanges();
            return Ok(expanditure);
        }
        [HttpGet]
        [Route("detail-by-id")]
        public IActionResult detail(int typeId){
            var row = context.Expanditures.Where(x=>x.TypeId == typeId).ToList();
            return Ok(row);
        }
    }
}