using BusinessRuleEngine.Models.RuleEngineFactory.Helper;
using BusinessRuleEngine.Models.RuleEngineFactory.Interface;
using System.Text;

namespace BusinessRuleEngine.Models.RuleEngineFactory
{
    public class MembershipUpgrade : IRuleEngine
    {
        private CommonHelper _helper { get; set; } = new CommonHelper();

        public string ProcessRule()
        {
            StringBuilder messageToReturn = new StringBuilder();
            messageToReturn.Append("Applying the upgrade");

            messageToReturn.Append(" & ");

            messageToReturn.Append(_helper.StartCommonProcessForMembership());
            return messageToReturn.ToString();
        }
    }
}