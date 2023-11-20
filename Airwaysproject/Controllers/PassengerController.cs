using Airwaysproject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Airwaysproject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PassengerController : ControllerBase
    {
        db db = new db();

        [HttpGet]
        public List<Passenger> PasGet() 
        {
            var result = db.PassList();
            return result;
        }
        [HttpPost]
        public string PasPost(Passenger passenger)
        {
            string islem = db.PassCrud(passenger);
            return islem;
        }
        [HttpPut("id")]
        public string PasPut(int id,Passenger passenger)
        {
            string islem = "";
            passenger.PassengerId = id;
            islem = db.PassCrud(passenger);
            return islem;
        }
        [HttpDelete("id")]
        public string PasDelete(int id,Passenger passenger)
        {
            string islem = "";
            passenger.PassengerId = id;
            passenger.Type = "delete";
            islem=db.PassCrud(passenger);
            return islem;
        }
    }
}
