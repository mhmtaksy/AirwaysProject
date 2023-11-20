using Airwaysproject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Airwaysproject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PilotController : ControllerBase
    {
        db db = new db();

        [HttpGet]
        public List<Pilot> PilGet()
        {
            var result = db.PilList();
            return result;
        }
        [HttpPost]
        public string PilPost(Pilot pilot)
        {
            string islem = db.PilCrud(pilot);
            return islem;
        }
        [HttpPut("id")]
        public string PilPut(int id, Pilot pilot)
        {
            string islem = "";
            pilot.PilotId = id;
            islem = db.PilCrud(pilot);
            return islem;
        }
        [HttpDelete("id")]
        public string PilDelete(int id, Pilot pilot)
        {
            string islem = "";
            pilot.PilotId = id;
            pilot.Type = "delete";
            islem = db.PilCrud(pilot);
            return islem;
        }
    }
}
