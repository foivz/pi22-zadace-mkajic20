using DBLayer;
using FOI_Equipment_Manager.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOI_Equipment_Manager.Repositories
{
    public class ReposPosudbe
    {
        public static Posudba GetPosudbe(int IdPosudbe)
        {
            Posudba posudba = null;
            string sql = $"SELECT * FROM Posudba WHERE ID_posudbe = {IdPosudbe}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                posudba = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();    
            return posudba;
        }

        public static List<Posudba> GetPosudbe()
        {
            var posudbe = new List<Posudba>();
            string sql = "SELECT * FROM Posudba";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Posudba posudba = CreateObject(reader);
                posudbe.Add(posudba);
            }
            reader.Close();
            DB.CloseConnection();

            return posudbe;
        }

        private static Posudba CreateObject(SqlDataReader reader)
        {
            int IdPosudbe = int.Parse(reader["ID_posudbe"].ToString());
            string Posudio = reader["Posudio"].ToString();
            string DatumVrijeme = reader["Datum_vrijeme"].ToString();
            string Razlog = reader["Razlog"].ToString();
            string PosudenaOprema = reader["Posudena_oprema"].ToString();
            var posudba = new Posudba
            {
                IdPosudbe = IdPosudbe,
                Posudio = Posudio,
                DatumVrijeme = DatumVrijeme,
                Razlog = Razlog,
                PosudenaOprema = PosudenaOprema
            };

            return posudba;
        }
    }
}