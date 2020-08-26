using BusinessRuleEngine.Models.RuleEngineFactory.Interface;
using System.Collections.Generic;
using System.Text;

namespace BusinessRuleEngine.Models.RuleEngineFactory
{
    public class Video : PhysicalProduct, IRuleEngine
    {
        public string VideoName { get; set; }
        
        public Video(string videoName)
        {
            this.VideoName = videoName;
        }
        public new string ProcessRule()
        {
            StringBuilder messageToReturn = new StringBuilder();

            messageToReturn.Append(base.ProcessRule());

            if (IsAdditionalVideoNeeded())
            {
                messageToReturn.Append(" & ");
                messageToReturn.Append("Adding a free \"First Aid\" video to packing slip (the result of court decision in 1997).");
            }
            return messageToReturn.ToString();
        }

        private bool IsAdditionalVideoNeeded()
        {
            List<string> VideoNameConditions = new List<string>() { "Learning to Ski" };

            return VideoNameConditions.Contains(VideoName);
        }
    }
}