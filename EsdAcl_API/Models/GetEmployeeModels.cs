using Dapper;
using Oracle.ManagedDataAccess.Client;

namespace EsdAcl_API.Models
{
    public class EmployeeModel
    {
        public string emp_no { get; set; }
        public string emp_name { get; set; }
        public string emp_deptshortname { get; set; }
        public string emp_operation { get; set; }
        public string emp_position { get; set; }
        public string emp_extension { get; set; }
        public string emp_email { get; set; }
        public string emp_supervisor { get; set; }
        public string mgr_name { get; set; }
        public string mgr_email { get; set; }
        public string mgr_extension { get; set; }
    }
    public class EmployeeOut
    {
        public string emp_no { get; set; }
        public string emp_name { get; set; }
        public string emp_deptshortname { get; set; }
        public string emp_operation { get; set; }
        public string emp_position { get; set; }
        public string emp_extension { get; set; }
        public string emp_email { get; set; }
        public string emp_supervisor { get; set; }
        public string mgr_name { get; set; }
        public string mgr_email { get; set; }
        public string mgr_extension { get; set; }
    }

    public class Employee_Resposity
    {
        public List<EmployeeModel> GetUserNoDB(string empNo)
        {

            List<EmployeeModel> result = new List<EmployeeModel>();

            string str = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST= cthorap21.th-lcb.celestica.com)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=appstest))); User ID=robin;Password=pcjaws5t;";

            using (OracleConnection conn = new OracleConnection(str))
            {
                string sql = @"select emp_no, initcap(emp_fnameen)||' '||initcap(emp_lnameen) emp_name, emp_position, emp_email, emp_extension, 
                                 emp_supervisor, emp_deptshortname,emp_operation, 
                                 master.get_supvname(emp_supervisor) mgr_name, 
                                 master.get_extension(emp_supervisor) mgr_extension, 
                                 master.get_email(emp_supervisor) mgr_email 
                                 from master.master_employee 
                                 where emp_no = '" + empNo + "'";

                result = conn.Query<EmployeeModel>(sql).ToList();

            }
            return result;
        }
    }
    public class ACL_Model
    {
        public string? CARD_ID { get; set; }
        public string? EMP_NO { get; set; }
        public string? EMP_NAME { get; set; }
        public string? UPDATE_BY { get; set; }
        public string? LAST_UPDATE { get; set; }
        public string? CARD_TYPE { get; set; }
        public string? LAST_REMARK { get; set; }
    }

    public class ACL_Resposity
    {
        public List<ACL_Model> GetACL()
        {
            try
            {
                List<ACL_Model> result = new List<ACL_Model>();
                string str = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST= cthorap21.th-lcb.celestica.com)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=appstest))); User ID=robin;Password=pcjaws5t;";


                using (OracleConnection conn = new OracleConnection(str))
                {
                    string sql = @"Select * From
                                    (Select CARD_ID,EMP_NO,EMP_NAME ,UPDATE_BY,LAST_UPDATE,CARD_TYPE,LAST_REMARK 
                                    From Engineer.ACL_CARD 
                                    Union 
                                    Select CARD_ID,EMP_NO,EMP_NAME ,UPDATE_BY,LAST_UPDATE,CARD_TYPE,LAST_REMARK 
                                    From Engineer.ACL_CARD_NEW ) 
                                    WHERE last_update> TO_DATE(TO_CHAR(sysdate,'DD-MM-YYYY'),'DD-MM-YYYY')+0.25 
                                    and last_update< TO_DATE(TO_CHAR(sysdate,'DD-MM-YYYY'),'DD-MM-YYYY')+0.99999 
                                    Order By LAST_UPDATE 
                                    ";

                    return conn.Query<ACL_Model>(sql).ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }


            return null;
        }
    }

}
