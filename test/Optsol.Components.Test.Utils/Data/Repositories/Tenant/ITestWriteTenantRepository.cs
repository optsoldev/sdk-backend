﻿using Optsol.Components.Infra.Data;
using Optsol.Components.Test.Utils.Data.Entities;
using System;

namespace Optsol.Components.Test.Utils.Repositories.Tenant
{
    public interface ITestWriteTenantRepository : IWriteRepository<TestTenantEntity, Guid>
    {

    }
}
