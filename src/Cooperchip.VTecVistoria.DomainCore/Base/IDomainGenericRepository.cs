using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Cooperchip.VTecVistoria.DomainCore.Base
{

    public interface IDomainGenericRepository<TEntity, in TKey> : IDisposable
        where TEntity : class
    {
        //Task<List<TEntity>> SelecionarTodos(Expression<Func<TEntity, bool>> quando = null);
        IEnumerable<TEntity> SelecionarTodos(Expression<Func<TEntity, bool>> quando = null);
        TEntity SelecionarPorId(TKey id);

        void Inserir(TEntity obj);
        void Atualizar(TEntity obj);
        void Excluir(TEntity obj);
        void ExcluirPorId(TKey id);
    }

}