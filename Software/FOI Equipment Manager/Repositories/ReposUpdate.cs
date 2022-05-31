using DBLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOI_Equipment_Manager.Repositories
{
    public class ReposUpdate
    {
        public void UpdatePosudba(int Id,string unosPosudio, string unosDatum, string unosRazlog, string unosOprema)
        {
            string sql = $"UPDATE Posudba SET Posudio='{unosPosudio}'," +
                $"Datum_vrijeme='{unosDatum}'," +
                $"Razlog='{unosRazlog}'," +
                $"Posudena_oprema='{unosOprema}' " +
                $"WHERE ID_posudbe={Id}";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
    }
}
