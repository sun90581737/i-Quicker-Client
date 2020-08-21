using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFine.Domain._03_Entity.OperationMonitoring
{
    public class ElectrodeQualifiedRateEntity : IEntity<ElectrodeQualifiedRateEntity>
    {
        public int? id { get; set; }
        public string MonthDay { get; set; }
        public string DeviceName { get; set; }
        public double TrendRate { get; set; }
        public DateTime? CreationTime { get; set; }
        public int? IsEffective { get; set; }
    }
}
