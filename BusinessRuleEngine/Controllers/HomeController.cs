using BusinessRuleEngine.Models;
using BusinessRuleEngine.Service;
using System.Collections.Generic;
using System.Web.Mvc;

namespace BusinessRuleEngine.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            EngineModel engineModel = new EngineModel();
            ConfigureViewModel(engineModel);
            return View(engineModel);
        }

        public ActionResult Payment(EngineModel engineModel)
        {
           
            var ruleEngineService = new RuleEngineService(RuleEngineGenerator.GetRuleEngineFromType(engineModel.RuleType, engineModel.VideoName));
            ViewBag.Message = ruleEngineService.StartProcess();
            return View();
        }

        private void ConfigureViewModel(EngineModel model)
        {
            IEnumerable<RuleTypeLoopUp> products = RuleTypeLoopUp.FetchRuleTypeLoopUp();
            model.RuleTypeLoopUpList = new SelectList(products, "ID", "Name");
        }
    }
}