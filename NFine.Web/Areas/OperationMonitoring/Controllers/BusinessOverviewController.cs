using NFine.Application.OperationMonitoring;
using NFine.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NFine.Web.Areas.OperationMonitoring.Controllers
{
    public class BusinessOverviewController : ControllerBase
    {
        private TotalCycleCostApp tccApp = new TotalCycleCostApp();
        private CostByDepartmentApp cbdApp = new CostByDepartmentApp();
        private DeliveryCompletionRateApp dcrApp = new DeliveryCompletionRateApp();
        private MoldMakingProgressApp mmpApp = new MoldMakingProgressApp();
        private BOCapacityLoadApp boclApp = new BOCapacityLoadApp();
        private KeyCustomersApp kcApp = new KeyCustomersApp();
        private MoldProportionApp mpApp = new MoldProportionApp();
        private ElectrodeQualifiedRateApp eqrApp = new ElectrodeQualifiedRateApp();
        private DepartmentQualifiedRateApp dqrApp = new DepartmentQualifiedRateApp();

        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetDataTotalCycleCost(string keyValue)
        {
            var data = tccApp.GetList().Where(p => p.IsEffective == 1);// && p.PrType== Convert.ToInt32(keyValue)
            return Content(data.ToJson());
        }

        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetDataCostByDepartment(string keyValue)
        {
            var data = cbdApp.GetList().Where(p => p.IsEffective == 1);//&& p.PrType == Convert.ToInt32(keyValue)
            return Content(data.ToJson());
        }

        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetDataDeliveryCompletionRate()
        {
            var data = dcrApp.GetList().Where(p => p.IsEffective == 1);
            return Content(data.ToJson());
        }

        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetGridJson(Pagination pagination, string queryJson)
        {
            var data = new
            {
                rows = mmpApp.GetList(pagination, queryJson),
                total = pagination.total,
                page = pagination.page,
                records = pagination.records
            };
            return Content(data.ToJson());
        }

        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetDataBOCapacityLoad(string keyValue)
        {
            var data = boclApp.GetList().Where(p => p.IsEffective == 1);//&& p.PrType == Convert.ToInt32(keyValue)
            return Content(data.ToJson());
        }

        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetDataKeyCustomers()
        {
            var data = kcApp.GetList().Where(p => p.IsEffective == 1);
            return Content(data.ToJson());
        }

        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetDataMoldProportion()
        {
            var data = mpApp.GetList().Where(p => p.IsEffective == 1);
            return Content(data.ToJson());
        }

        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetDataElectrodeQualifiedRate()
        {
            var data = eqrApp.GetList().Where(p => p.IsEffective == 1);
            return Content(data.ToJson());
        }

        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetDataDepartmentQualifiedRate()
        {
            var data = dqrApp.GetList().Where(p => p.IsEffective == 1);
            return Content(data.ToJson());
        }
    }
}
