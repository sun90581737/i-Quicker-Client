﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFine.Domain._03_Entity.ProductionManage
{
    public class PMHomeMoldProgressEntity : IEntity<PMHomeMoldProgressEntity>
    {	
        public int id { get; set; }
        public string ProgressStatus { get; set; }	
        public int Cost { get; set; }
        public string Display { get; set; }
        public DateTime CreationTime { get; set; }	
        public int IsEffective { get; set; }
    }
}
