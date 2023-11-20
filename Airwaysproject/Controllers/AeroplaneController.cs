using Airwaysproject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Airwaysproject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AeroplaneController : ControllerBase
    {
        db db = new db();



        [HttpGet]
        public List<Aeroplane> AEGet()
        {
            var result = db.AEList();
            return result;
        }
        [HttpPost]
        public string AEPost(Aeroplane aeroplane)
        {
            string islem = db.AECrud(aeroplane);
            return islem;
        }
        [HttpPut("id")]
        public string AEPut(int id,Aeroplane aeroplane)
        {
            string islem = "";
            aeroplane.AeroplaneId = id;
            islem = db.AECrud(aeroplane);
            return islem;
        }
        [HttpDelete("id")]
        public string AEDelete(int id,Aeroplane aeroplane)
        {
            string islem = "";
            aeroplane.AeroplaneId = id;
            aeroplane.Type = "delete";
            islem = db.AECrud(aeroplane);
            return islem;
        }
    }
}
