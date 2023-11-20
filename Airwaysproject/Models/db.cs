using System.Data.SqlClient;
using System.Data;

namespace Airwaysproject.Models
{
    public class db
    {
        SqlConnection con = new SqlConnection("Server=MEHMETAKSOY\\SQLMHMT;Database=HatayAirways;Integrated Security=true;");

        public string AECrud(Aeroplane aeroplane)
        {
            string islem = "";
            con.Open();
            using (SqlCommand cmd = new SqlCommand("AeroCrud",con)) 
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@AeroplaneId", aeroplane.AeroplaneId);
                cmd.Parameters.AddWithValue("@AeroplaneName", aeroplane.AeroplaneName);
                cmd.Parameters.AddWithValue("@AeroplaneModel", aeroplane.AeroplaneModel);
                cmd.Parameters.AddWithValue("@AeroplaneNop", aeroplane.AeroplaneNop);
                cmd.Parameters.AddWithValue("@Type", aeroplane.Type);
                cmd.ExecuteNonQuery();
            }
            con.Close();
            return islem;
        }
        public List<Aeroplane> AEList()
        {
            List<Aeroplane> listem = new List<Aeroplane>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "AeroList";
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                Aeroplane aeroplane = new Aeroplane();
                aeroplane.AeroplaneId = Convert.ToInt32(rd["AeroplaneId"]);
                aeroplane.AeroplaneName = (rd["AeroplaneName"]).ToString();
                aeroplane.AeroplaneModel = (rd["AeroplaneModel"]).ToString();
                aeroplane.AeroplaneNop = Convert.ToInt32(rd["AeroplaneNop"]);
                listem.Add(aeroplane);
            }
            con.Close( );
            return listem;
        }
        public string PilCrud(Pilot pilot)
        {
            string islem = "";
            con.Open();
            using (SqlCommand cmd = new SqlCommand("PilotCrud", con))
            {
                cmd.CommandType=CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PilotId", pilot.PilotId);
                cmd.Parameters.AddWithValue("@PilotName", pilot.PilotName);
                cmd.Parameters.AddWithValue("@PilotSurname", pilot.PilotSurname);
                cmd.Parameters.AddWithValue("@PilotAdresss", pilot.PilotAdress);
                cmd.Parameters.AddWithValue("@PilotTel", pilot.PilotTel);
                cmd.Parameters.AddWithValue("@AeroplaneId", pilot.AeroplaneId);
                cmd.Parameters.AddWithValue("@Type", pilot.Type);
                cmd.ExecuteNonQuery();
            }
            con.Close();
            return islem;
        }
        public List<Pilot> PilList()
        {
            List<Pilot> Listem = new List<Pilot>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "PilotList";
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                Pilot pilot = new Pilot();
                pilot.PilotId = Convert.ToInt32(rd["PilotId"]);
                pilot.PilotName = (rd["PilotName"].ToString());
                pilot.PilotSurname = (rd["PilotSurname"].ToString());
                pilot.PilotAdress = (rd["PilotAdress"].ToString());
                pilot.PilotTel = (rd["PilotTel"].ToString());
                pilot.AeroplaneId = Convert.ToInt32(rd["AeroplaneId"]);
                Listem.Add(pilot);
            }
            con.Close ();
            return Listem;
        }
        public string PassCrud(Passenger passenger)
        {
            string islem = "";
            con.Open();
            using (SqlCommand cmd = new SqlCommand("PassCrud",con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PassengerId", passenger.PassengerId);
                cmd.Parameters.AddWithValue("@PassengerName", passenger.PassengerName);
                cmd.Parameters.AddWithValue("@PassengerSurname", passenger.PassengerSurname);
                cmd.Parameters.AddWithValue("@PassengerAdresss", passenger.PassengerAdress);
                cmd.Parameters.AddWithValue("@PassengerTel", passenger.PassengerTel);
                cmd.Parameters.AddWithValue("@PilotId", passenger.PilotId);
                cmd.Parameters.AddWithValue("@Type", passenger.Type);
                cmd.ExecuteNonQuery();
            }
            con.Close();
            return islem;
        }
        public List<Passenger> PassList()
        {
            List<Passenger> Listem = new List<Passenger>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType= CommandType.StoredProcedure;
            cmd.CommandText = "PassList";
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();            
            while (rd.Read())
            {
                Passenger passenger = new Passenger();
                passenger.PassengerId = Convert.ToInt32(rd["PassengerId"]);
                passenger.PassengerName = (rd["PassengerName"].ToString());
                passenger.PassengerSurname = (rd["PassengerSurname"].ToString());
                passenger.PassengerAdress = (rd["PassengerAdress"].ToString());
                passenger.PassengerTel = (rd["PassengerTel"].ToString());
                passenger.PilotId = Convert.ToInt32(rd["PilotId"]);
                Listem.Add(passenger);
            }
            con.Close ();
            return Listem;
        }
    }
}
