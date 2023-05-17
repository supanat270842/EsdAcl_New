namespace EsdAcl_New.Models
{// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);

    public class InputSearch
    {
        public string txtEmpNo { get; set; }
        public string txtEmpName { get; set; }
        public string txtFront { get; set; }
        public string txtBack { get; set; }
        public string txtCard { get; set; }
        public string txtCType { get; set; }
        public string txtCreateBy { get; set; }
        public string txtDateSt { get; set; }
        public string txtDateEn { get; set; }
        public string txtCardStatus { get; set; }
        public string txtRemark { get; set; }
    }
    public class ListSearch
    {
        public string carD_ID { get; set; }
        public string emP_NO { get; set; }
        public string emP_NAME { get; set; }
        public object depT_CODE { get; set; }
        public object depT_NAME { get; set; }
        public string position { get; set; }
        public string updatE_FLAG { get; set; }
        public string fronT_NO { get; set; }
        public string bacK_NO { get; set; }
        public string updatE_BY { get; set; }
        public string lasT_UPDATE { get; set; }
        public string lasT_REMARK { get; set; }
        public string handicap { get; set; }
        public string carD_TYPE { get; set; }
        public string carD_STS { get; set; }
    }

    public class SearchModel
    {
        public bool results { get; set; }
        public string message { get; set; }
        public List<ListSearch> list { get; set; }
    }

}
