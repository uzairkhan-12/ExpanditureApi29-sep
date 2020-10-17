using System;
using System.Linq;
using ExpanditureApi.Models;
//using ExpanditureApi29_sep.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExpanditureApi29_sep.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExpenditureTypeController : ControllerBase
    {
        private ExpanditureContext db;
        public ExpenditureTypeController(ExpanditureContext context)
        {
            db = context;
        }

        [HttpPost]
        [Route("add")]
        public IActionResult Add([FromBody] ExpenditureType expenditureType)
        {
            expenditureType.AddedOn = DateTime.Now;
            expenditureType.IsActive = true;
            db.ExpenditureTypes.Add(expenditureType);
            db.SaveChanges();
            return Ok(expenditureType);
        }

        [HttpGet]
        [Route("get-types")]
        public IActionResult Get()
        {
            return Ok(db.ExpenditureTypes.ToList());

        }
        [HttpGet]
        [Route("toggle-type")]
        public IActionResult ToggleType([FromQuery] int typeId)
        {
            var row = db.ExpenditureTypes.FirstOrDefault(x => x.Id == typeId);
            if (row != null)
            {
                row.IsActive = !row.IsActive;
            }
            db.SaveChanges();
            return Ok(true);
        }
        //idhar aik function bnana ha js men id pas kr k wo data show krana ha jski id pas ki ha
        [HttpGet]
        [Route("get-data-by-id")]
        public IActionResult getDataById(int typeId) {
            var row = db.ExpenditureTypes.FirstOrDefault(x =>x.Id == typeId);
            return Ok(row);
        }
        
        [HttpPost]
        [Route("update")]
        public IActionResult Update([FromBody] ExpenditureType expenditureType)
        {
            var row=db.ExpenditureTypes.FirstOrDefault(x=>x.Id==expenditureType.Id);
            if(row==null) return BadRequest("record not found");
            row.ExpenditureTypeName=expenditureType.ExpenditureTypeName;
            db.SaveChanges();
            return Ok(expenditureType);
        }
        [HttpDelete]
        [Route("delete")]
        public IActionResult Delete([FromQuery] int typeId)
        {
            var row=db.ExpenditureTypes.FirstOrDefault(x=>x.Id==typeId);
            if(row==null) return BadRequest("record not found");
            db.ExpenditureTypes.Remove(row);
            db.SaveChanges();
            return Ok(row);
        }
        
    }
}