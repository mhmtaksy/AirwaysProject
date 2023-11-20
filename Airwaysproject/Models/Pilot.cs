namespace Airwaysproject.Models
{
    public class Pilot
    {
        public int PilotId { get; set; }
        public string? PilotName { get; set; }
        public string? PilotSurname { get; set;}
        public string? PilotAdress { get; set;}
        public string? PilotTel { get; set;}

        public int AeroplaneId { get; set; }
        public string? Type { get; set; }
    }
}
