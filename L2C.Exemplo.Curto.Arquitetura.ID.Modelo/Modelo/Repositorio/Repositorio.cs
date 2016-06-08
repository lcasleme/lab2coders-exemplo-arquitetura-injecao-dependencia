using L2C.Exemplo.Curto.Arquitetura.ID.Modelo.Modelo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace L2C.Exemplo.Curto.Arquitetura.ID.Modelo.Modelo.Repositorio
{
    public class Repositorio<TEntity> : IRepositorio<TEntity> where TEntity : class
    {
        public IEnumerable<TEntity> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public TEntity Procurar(Expression<System.Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}