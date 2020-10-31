using System;
using Optsol.Components.Infra.Data;
using Optsol.Playground.Domain.Entidades;

namespace Optsol.Playground.Domain.Repositories
{
    public interface IClienteWriteRepository : IWriteRepository<ClienteEntity, Guid>
    {
    }
}
