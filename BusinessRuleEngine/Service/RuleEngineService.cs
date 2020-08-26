using BusinessRuleEngine.Models.RuleEngineFactory.Interface;

namespace BusinessRuleEngine.Service
{
    public class RuleEngineService
    {
        public RuleEngineService(IRuleEngine ruleEngine)
        {
            this.ruleEngine = ruleEngine;
        }

        private IRuleEngine ruleEngine { get; set; }

        public string StartProcess()
        {
            return this.ruleEngine.ProcessRule();
        }
    }
}