using Dapper;
using Oracle.ManagedDataAccess.Client;

namespace EsdAcl_API.Models
{
    public class DeleteModel
    {
        public string CARD_ID { get; set; }

    }

    public class Delete_resposity
    {
        public List<DeleteModel> DeleteACL(DeleteModel deleteModel)
        {
            string cardID = deleteModel.CARD_ID;

            string str = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST= cthorap21.th-lcb.celestica.com)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=appstest))); User ID=robin;Password=pcjaws5t;";

            using (OracleConnection conn = new OracleConnection(str))
            {
                string sql = @"Delete From Engineer.ACL_CARD Where CARD_ID = '" + cardID + "'";

                conn.Execute(sql);

                string queryDB = $"select * from Engineer.ACL_CARD Where CARD_ID = '{cardID}'";

                return conn.Query<DeleteModel>(queryDB).ToList();
            }

        }
    }
}
