﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFine.Domain._03_Entity.OperationMonitoring
{
    public class DepartmentQualifiedRateEntity : IEntity<DepartmentQualifiedRateEntity>
    {
        public int? id { get; set; }
        public string DeviceType { get; set; }
        public string DeviceName { get; set; }
        public int? Number { get; set; }
        public DateTime? CreationTime { get; set; }
        public int? IsEffective { get; set; }
    }
}