﻿using NFine.Domain._03_Entity.TeamTask;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFine.Mapping.TeamTask
{
    public class CapacityLoadMap : EntityTypeConfiguration<CapacityLoadEntity>
    {
        public CapacityLoadMap()
        {
            this.ToTable("Sys_CapacityLoad");
            this.HasKey(t => t.id);
        }
    }
}
