using DBLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOI_Equipment_Manager.Repositories
{
    internal class ReposDelete
    {
        public void DeletePosudba(int IdPosudbe)
        {
            string sql = $"DELETE FROM Posudba WHERE ID_posudbe = {IdPosudbe}";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
    }
}
