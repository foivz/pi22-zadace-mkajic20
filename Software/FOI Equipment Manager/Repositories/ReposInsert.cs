using DBLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOI_Equipment_Manager.Repositories
{
    internal class ReposInsert
    {
        public void InsertPosudba(int unosIdPosudbe, string unosPosudio, string unosDatum, string unosRazlog, string unosOprema)
        {

            string sql = $"INSERT INTO Posudba (ID_posudbe, Posudio, Datum_vrijeme, Razlog, Posudena_oprema) " +
                $"VALUES ({unosIdPosudbe},'{unosPosudio}','{unosDatum}','{unosRazlog}','{unosOprema}')";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
    }
}
