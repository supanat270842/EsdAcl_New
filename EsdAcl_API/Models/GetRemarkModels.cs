using Dapper;
using Oracle.ManagedDataAccess.Client;

namespace EsdAcl_API.Models
{
    public class GetRemarkModels
    {
        public string esd_remark_id { get; set; }
        public string esd_remark_desc { get; set; }
        public string esd_remark_sts { get; set; }
    }

    public class remark_nameModel
    {
        public string esd_remark_desc { get; set; }
    }

    public class GetRemark_Resposity
    {
        public List<GetRemarkModels> GetRemark ()
        {
            try
            {
                string str = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST= cthorap21.th-lcb.celestica.com)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=appstest))); User ID=robin;Password=pcjaws5t;";

                using (OracleConnection conn = new OracleConnection(str))
                {
                    string sql = @" select esd_remark_id, esd_remark_desc, esd_remark_sts 
                                    from engineer.esd_remark 
                                    where esd_remark_sts ='ACT'  order by esd_remark_desc 
                                    ";

                    return conn.Query<GetRemarkModels>(sql).ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<remark_nameModel> GetRemarkName(string remark)
        {
            try
            {
                string str = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST= cthorap21.th-lcb.celestica.com)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=appstest))); User ID=robin;Password=pcjaws5t;";

                using (OracleConnection conn = new OracleConnection(str))
                {
                    string sql = @" select  esd_remark_desc 
                                    from engineer.esd_remark 
                                    where esd_remark_id = '" + remark + "'";

                    return conn.Query<remark_nameModel>(sql).ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
