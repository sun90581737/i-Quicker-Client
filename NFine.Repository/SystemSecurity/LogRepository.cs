﻿/*******************************************************************************
 * Copyright © 2016
 * 
 * Description: MVC快速开发平台
 *
*********************************************************************************/
using NFine.Data;
using NFine.Domain.Entity.SystemSecurity;
using NFine.Domain.IRepository.SystemSecurity;
using NFine.Repository.SystemSecurity;

namespace NFine.Repository.SystemSecurity
{
    public class LogRepository : RepositoryBase<LogEntity>, ILogRepository
    {
       
    }
}
