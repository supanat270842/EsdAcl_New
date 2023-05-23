namespace EsdAcl_New.Models
{
    public class DomainModel
    {
        public string name { get; set; }

    }

    public class Domain_Repository
    {
        public List<DomainModel> GetDomainName()
        {
            List<DomainModel> result = new List<DomainModel>();

            string[] data = { "ASIA" };

            foreach (var item in data)
            {
                DomainModel domainModel = new DomainModel();
                domainModel.name = item;

                result.Add(domainModel);
            }
            return result;
        }
    }
}
