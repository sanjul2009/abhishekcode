using BusinessRuleEngine.Models.RuleEngineFactory.Helper;
using BusinessRuleEngine.Models.RuleEngineFactory.Interface;
using System.Text;

namespace BusinessRuleEngine.Models.RuleEngineFactory
{
    public class PhysicalProduct : IRuleEngine
    {
        private CommonHelper _helper { get; set; } = new CommonHelper();

        public string ProcessRule()
        {
            StringBuilder messageToReturn = new StringBuilder();

            messageToReturn.Append("Here is your packing slip for shipping");
            messageToReturn.Append(" & ");
            messageToReturn.Append(_helper.CommisionToAgent());

            return messageToReturn.ToString();
        }
    }
}