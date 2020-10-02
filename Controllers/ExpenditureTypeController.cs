using System;
using System.Linq;
using ExpanditureApi.Models;
using ExpanditureApi29_sep.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExpanditureApi29_sep.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExpenditureTypeController:ControllerBase
    {
    private ExpanditureContext db;
public ExpenditureTypeController(ExpanditureContext context){
    db=context;
}

    [HttpPost]
    [Route("add")]
    public IActionResult Add([FromBody]ExpenditureType expenditureType){
        expenditureType.AddedOn=DateTime.Now;
        expenditureType.IsActive=true;
        db.ExpenditureTypes.Add(expenditureType);
        db.SaveChanges();
        return Ok(expenditureType);
    }
    
    [HttpGet]
    [Route("get-types")]
    public IActionResult Get(){
        return Ok(db.ExpenditureTypes.ToList());
    }


    }
}