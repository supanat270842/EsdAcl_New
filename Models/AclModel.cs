namespace EsdAcl_New.Models
{
    public class ListAcl
    {
        public string carD_ID { get; set; }
        public string emP_NO { get; set; }
        public string emP_NAME { get; set; }
        public string updatE_BY { get; set; }
        public string lasT_UPDATE { get; set; }
        public string carD_TYPE { get; set; }
        public string lasT_REMARK { get; set; }
    }

    public class AClModel
    {
        public bool results { get; set; }
        public string message { get; set; }
        public List<ListAcl> list { get; set; }
    }

}
