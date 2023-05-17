namespace EsdAcl_New.Models
{
    public class ListEm
    {
        public string emp_no { get; set; }
        public string emp_name { get; set; }
        public object emp_deptshortname { get; set; }
        public string emp_operation { get; set; }
        public string emp_position { get; set; }
        public string emp_extension { get; set; }
        public string emp_email { get; set; }
        public string emp_supervisor { get; set; }
        public object mgr_name { get; set; }
        public object mgr_email { get; set; }
        public object mgr_extension { get; set; }
    }

    public class EmployeeModel
    {
        public bool results { get; set; }
        public string message { get; set; }
        public List<ListEm> list { get; set; }
    }

    public class INPUT_Employee
    {
        public string txtEmp { get; set; }
    }

    public class ADD_EmployeeModel
    {
        public string txtEmp { get; set; }
        public string? txtName { get; set; }
        public string? txtPosition { get; set; }
        public string? txtFront { get; set; }
        public string? txtBack { get; set; }
        public string? txtCType { get; set; }
        public string? txtRemark { get; set; }
        public string? txtHand { get; set; }
    }


}
