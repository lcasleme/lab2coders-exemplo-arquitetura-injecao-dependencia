using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace L2C.Exemplo.Curto.Arquitetura.ID.Modelo.Modelo.Interfaces
{
    public interface IRepositorio<TEntity> : IDisposable where TEntity : class
    {
        IEnumerable<TEntity> ObterTodos();

        TEntity Procurar(Expression<Func<TEntity, bool>> predicate);
    }
}