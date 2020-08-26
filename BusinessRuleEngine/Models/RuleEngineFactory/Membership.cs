using BusinessRuleEngine.Models.RuleEngineFactory.Helper;
using BusinessRuleEngine.Models.RuleEngineFactory.Interface;
using System.Text;

namespace BusinessRuleEngine.Models.RuleEngineFactory
{
    public class Membership : IRuleEngine
    {
        private CommonHelper _helper { get; set; } = new CommonHelper();

        public string ProcessRule()
        {
            StringBuilder messageToReturn = new StringBuilder();
            messageToReturn.Append("Activating the membership");

            messageToReturn.Append(" & ");

            messageToReturn.Append(_helper.StartCommonProcessForMembership());
            return messageToReturn.ToString();
        }
    }
}