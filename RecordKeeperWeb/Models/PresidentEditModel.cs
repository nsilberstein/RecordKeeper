using RecordKeeperBizObjects;
namespace RecordKeeperWeb.Models
{
    public class PresidentEditModel : BizPresident
    {
        public List<BizParty> PartyList()
        {
            return BizParty.GetAll();
        }
    }
}
