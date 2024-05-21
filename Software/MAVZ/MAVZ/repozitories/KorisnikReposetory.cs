using System;
using MAVZ.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBLayer;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace MAVZ.repozitories
{
    public class KorisnikReposetory
    {
        public static Korisnik GetKorisnik(string korime)
        {
            string sql = $"SELECT * FROM Korisnik WHERE korime = '{korime}'";
            return FetchKorisnik(sql)
;        }
        public static Korisnik GetKorisnik(int id)
        {
            string sql = $"SELECT * FROM Korisnik WHERE id_korisnik = '{id}'";
            return FetchKorisnik(sql);
        }
        public  static List<Korisnik> GetKorsnik()
        {
            var korisnik = new List<Korisnik>();
            string sql = "SELECT * FROM Korisnik";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Korisnik korisniki = CreateObject(reader);
                korisnik.Add(korisniki);
            }
            reader.Close();
            DB.CloseConnection();

            return korisnik;
        }
        private static Korisnik FetchKorisnik (string sql)
        {
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            Korisnik korisnik = null;

            if(reader.HasRows == true)
            {
                reader.Read() ;
                korisnik = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();

            return korisnik;
        }

        private static Korisnik CreateObject(SqlDataReader reader)
        {
            //desno je iz baze(sql) , a lijevo iz klase
            int id = int.Parse(reader["id_korisnik"].ToString());
            string Ime = reader["Ime"].ToString();
            string Prezime = reader["Prezime"].ToString();
            string korime = reader["korime"].ToString();
            string lozinka = reader["lozinka"].ToString();

            var korisnik = new Korisnik
            {
                //lijevo imena iz klase , a desno iz ovog gore
                id = id,
                Ime = Ime,
                Prezime = Prezime,
                korime = korime,
                lozinka = lozinka
            };
            return korisnik;
        }

       

    }
}
