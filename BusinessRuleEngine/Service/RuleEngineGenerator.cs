using BusinessRuleEngine.Models;
using BusinessRuleEngine.Models.RuleEngineFactory;
using BusinessRuleEngine.Models.RuleEngineFactory.Interface;

namespace BusinessRuleEngine.Service
{
    public static class RuleEngineGenerator
    {
        public static IRuleEngine GetRuleEngineFromType(int type, string args = null)
        {
            switch ((RuleTypeEnum)type)
            {
                case RuleTypeEnum.PhysicalProduct:
                    return new PhysicalProduct();

                case RuleTypeEnum.Book:
                    return new Book();

                case RuleTypeEnum.Membership:
                    return new Membership();

                case RuleTypeEnum.MembershipUpgrade:
                    return new MembershipUpgrade();

                case RuleTypeEnum.Video:
                    return new Video(args);

                default:
                    return null;
            }
        }
    }
}