namespace Airwaysproject.Models
{
    public class Passenger
    {
        public int PassengerId { get; set; }
        public string? PassengerName { get; set; }
        public string? PassengerSurname { get; set; }
        public string? PassengerAdress { get; set;}
        public string? PassengerTel { get; set;}

        public int PilotId { get; set; }
        public string? Type { get; set; }
    }
}
