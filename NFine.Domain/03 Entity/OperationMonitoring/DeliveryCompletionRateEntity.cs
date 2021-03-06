﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFine.Domain._03_Entity.OperationMonitoring
{
    public class DeliveryCompletionRateEntity : IEntity<DeliveryCompletionRateEntity>
    {
        public int? id { get; set; }
        public string Month { get; set; }
        public double DeliveryRate { get; set; }
        public DateTime? CreationTime { get; set; }
        public int? IsEffective { get; set; }
    }
}
