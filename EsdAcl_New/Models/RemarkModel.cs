// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
public class ListRemark
{
    public string esd_remark_id { get; set; }
    public string esd_remark_desc { get; set; }
    public string esd_remark_sts { get; set; }
}

public class RemarkModel
{
    public bool results { get; set; }
    public string message { get; set; }
    public List<ListRemark> list { get; set; }
}

public class ListNameRemark
{
    public string esd_remark_desc { get; set; }
}

public class RemarkNameModel
{
    public bool results { get; set; }
    public string message { get; set; }
    public List<ListNameRemark> list { get; set; }
}



