﻿using Microsoft.Extensions.Logging;
using Optsol.Components.Infra.Data;
using Optsol.Components.Test.Utils.Data.Entities;
using System;

namespace Optsol.Components.Test.Utils.Repositories.Tenant
{
    public class TestWriteTenantRepository : Repository<TestTenantEntity, Guid>, ITestWriteTenantRepository
    {
        public TestWriteTenantRepository(CoreContext context, ILogger<Repository<TestTenantEntity, Guid>> logger) 
            : base(context, logger)
        {
        }
    }
}
