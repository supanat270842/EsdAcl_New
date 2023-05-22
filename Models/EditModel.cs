namespace EsdAcl_New.Models
{
    public class EditModel
    {
        public string txtHcardNo { get; set; }
        public string? txtEmp { get; set; }
        public string? txtName { get; set; }
        public string? txtPosition { get; set; }
        public string? txtCType { get; set; }
        public string? txtFront { get; set; }
        public string? txtBack { get; set; }
        public string? txtHupDateBy { get; set; }
        public string? txtHand { get; set; }
        public string? txtCardsts { get; set; }
        public string? txtRemark { get; set; }
        public string? txtHlastUpdate { get; set; }
    }

    public class ListEdit
    {
        public string carD_ID { get; set; }
        public string emP_NO { get; set; }
        public string emP_NAME { get; set; }
        public string depT_CODE { get; set; }
        public string depT_NAME { get; set; }
        public string position { get; set; }
        public string updatE_FLAG { get; set; }
        public string fronT_NO { get; set; }
        public string bacK_NO { get; set; }
        public string updatE_BY { get; set; }
        public DateTime lasT_UPDATE { get; set; }
        public string lasT_REMARK { get; set; }
        public string handicap { get; set; }
        public string carD_STS { get; set; }
        public string carD_TYPE { get; set; }
        public DateTime acL_CARD_ACTDATE { get; set; }
    }

    public class EditAPIModel
    {
        public bool results { get; set; }
        public string message { get; set; }
        public List<ListEdit> list { get; set; }
    }

    public class ListDelete
    {
        public string carD_ID { get; set; }
        public string emP_NO { get; set; }
        public string emP_NAME { get; set; }
        public string depT_CODE { get; set; }
        public string depT_NAME { get; set; }
        public string position { get; set; }
        public string updatE_FLAG { get; set; }
        public string fronT_NO { get; set; }
        public string bacK_NO { get; set; }
        public string updatE_BY { get; set; }
        public DateTime lasT_UPDATE { get; set; }
        public string lasT_REMARK { get; set; }
        public string handicap { get; set; }
        public string carD_STS { get; set; }
        public string carD_TYPE { get; set; }
        public DateTime acL_CARD_ACTDATE { get; set; }
    }

    public class DeleteAPIModel
    {
        public bool results { get; set; }
        public string message { get; set; }
        public List<ListDelete> list { get; set; }
    }
}
