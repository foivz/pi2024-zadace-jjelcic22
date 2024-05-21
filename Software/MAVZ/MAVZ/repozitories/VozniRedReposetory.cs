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
    public class VozniRedReposetory
    {
        public static VozniRed GetVozniRed(string linija)
        {
            string sql = $"SELECT * FROM VozniRed WHERE linija = '{linija}'";
            return FetchVozniRed(sql)
;        }
        public static VozniRed GetVozniRed(int id)
        {
            string sql = $"SELECT * FROM VozniRed WHERE id_vz = '{id}'";
            return FetchVozniRed(sql);
        }
        public  static List<VozniRed> GetVozniRed()
        {
            var voznired= new List<VozniRed>();
            string sql = "SELECT * FROM VozniRed";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                VozniRed vozniredi = CreateObject(reader);
                voznired.Add(vozniredi);
            }
            reader.Close();
            DB.CloseConnection();

            return voznired;
        }
        private static VozniRed FetchVozniRed (string sql)
        {
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            VozniRed voznired = null;

            if(reader.HasRows == true)
            {
                reader.Read() ;
                voznired = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();

            return voznired;
        }

        private static VozniRed CreateObject(SqlDataReader reader)
        {
            //desno je iz baze(sql) , a lijevo iz klase
            int id = int.Parse(reader["id_voznired"].ToString());
            string linija = reader["linija"].ToString();
            string vrijemepol = reader["vrijemepol"].ToString();
            string vrijemedol = reader["vrijemedol"].ToString();
            

            var voznired = new VozniRed
            {
                //lijevo imena iz klase , a desno iz ovog gore
                id = id,
                linija = linija,
                vrijemepol = vrijemepol,
                vrijemedol = vrijemedol,
                
            };
            return voznired;
        }

       

    }
}
