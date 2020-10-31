using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Optsol.Components.Infra.Data;
using Optsol.Playground.Domain.Entidades;
using Optsol.Playground.Domain.Repositories;

namespace Optsol.Playground.Infra.Data.Repositories
{
    public class ClienteReadRepository : Repository<ClienteEntity, Guid>, IClienteReadRepository
    {
        public ClienteReadRepository(DbContext context, ILogger<Repository<ClienteEntity, Guid>> logger) : base(context, logger)
        {
        }
    }
}
