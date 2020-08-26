using BusinessRuleEngine.Models.RuleEngineFactory.Helper;
using BusinessRuleEngine.Models.RuleEngineFactory.Interface;
using System.Text;

namespace BusinessRuleEngine.Models.RuleEngineFactory
{
    public class Book : PhysicalProduct, IRuleEngine
    {
        private CommonHelper _helper { get; set; } = new CommonHelper();

        public new string ProcessRule()
        {
            StringBuilder messageToReturn = new StringBuilder();

            messageToReturn.Append(base.ProcessRule());
            messageToReturn.Append(" & ");
            messageToReturn.Append("Creating a duplicate packing slip for royalty department.");
            
            return messageToReturn.ToString();
        }
    }
}