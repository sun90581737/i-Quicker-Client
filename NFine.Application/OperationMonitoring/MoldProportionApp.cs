﻿using NFine.Domain._03_Entity.OperationMonitoring;
using NFine.Domain._04_IRepository.OperationMonitoring;
using NFine.Repository.OperationMonitoring;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFine.Application.OperationMonitoring
{
    public class MoldProportionApp
    {
        private IMoldProportionRepository service = new MoldProportionRepository();

        public List<MoldProportionEntity> GetList()
        {
            return service.IQueryable().ToList();
        }
    }
}
