using NHibernate;
using System.Linq.Expressions;

namespace AgendaTelefonica.BackEnd.DAO._connect
{
    public class DAOBase<T> : IDisposable
    {
        private readonly NHibernate.ISession _session;
        private ITransaction? _transaction = null;

        public DAOBase()
        {
            _session = DAOConnect.OpenSession();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Pega objeto baseado no tipo informado
        /// </summary>
        /// <typeparam name="X">Objeto NHibernate que deseja pegar</typeparam>
        /// <param name="id">Chave que deseja pesquisar</param>
        /// <returns>Retonarna nulo se a chave não existir</returns>
        public X GetByKey<X>(object id)
        {
            X result;
            result = _session.Get<X>(id);
            return result;
        }

        public T GetByKey(object id)
        {
            return GetByKey<T>(id);
        }

        /// <summary>
        /// Lista de objetos NHibernate por Expression
        /// </summary>
        /// <typeparam name="X">Objetos NHibernate que deseja retornar na lista</typeparam>
        /// <param name="whereExpression">Expression Where</param>
        /// <param name="orderExpression">Expression Order</param>
        /// <param name="topN">Top n registros, quando não informado traz todos</param>
        /// <returns>Lista de objetos NHibernate)</returns>
        public List<X> ListByExpression<X>(Expression<Func<X, bool>>? whereExpression = null, Expression<Func<X, object>>? orderExpression = null, int topN = 0, bool descending = false)
        {
            List<X> result = new List<X>();
            IQueryable<X> q = _session.Query<X>();
            if (whereExpression != null) { q = q.Where(whereExpression); }
            if (orderExpression != null)
            {
                if (descending)
                {
                    q = q.OrderByDescending(orderExpression);
                }
                else
                {
                    q = q.OrderBy(orderExpression);
                }
            }
            if (topN == 0)
            {
                result = q.ToList();
            }
            else
            {
                result = q.Take(topN).ToList();
            }
            return result;
        }
        public List<T> ListByExpression(Expression<Func<T, bool>>? whereExpression = null, Expression<Func<T, object>>? orderExpression = null, int topN = 0)
        {
            return ListByExpression<T>(whereExpression, orderExpression, topN);
        }

        /// <summary>
        /// Salva objeto NHibernate na sessão atual, cria uma transaction caso não exista dar o commit ou rollback
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public bool SaveObject(object obj)
        {
            bool result = false;
            ITransaction? tranLocal = null;
            if (_transaction == null)
            {
                tranLocal = _session.BeginTransaction();
            }
            try
            {
                _session.SaveOrUpdate(obj);
                if (tranLocal != null)
                {
                    tranLocal.Commit();
                }
                result = true;
            }
            catch (Exception)
            {
                if (tranLocal != null)
                {
                    tranLocal.Rollback();
                }
                result = false;
                throw;
            }
            finally
            {
                if (tranLocal != null)
                {
                    tranLocal.Dispose();
                }
            }
            return result;
        }

        /// <summary>
        /// Exclui fisicamente um objeto da tabela
        /// </summary>
        /// <param name="obj">Objeto a ser excluido</param>
        /// <returns>True se o objeto tiver sido excluido corretamente</returns>
        public bool DeleteObject(object obj)
        {
            bool result = false;
            ITransaction? tranLocal = null;
            if (_transaction == null)
            {
                tranLocal = _session.BeginTransaction();
            }
            try
            {
                if (obj != null)
                {
                    _session.Delete(obj);
                    if (tranLocal != null)
                    {
                        tranLocal.Commit();
                    }
                    result = true;
                }
            }
            catch (Exception)
            {
                if (tranLocal != null)
                {
                    tranLocal.Rollback();
                }
                throw;
            }
            if (tranLocal != null)
            {
                tranLocal.Dispose();
            }
            return result;
        }

        /// <summary>
        /// Exclui fisicamente um objeto da tabela através do seu ID
        /// </summary>
        /// <typeparam name="X">Objeto a ser excluido</typeparam>
        /// <param name="id">ID do objeto</param>
        /// <returns>True se o objeto foi excluido</returns>
        public bool DeleteByKey<X>(object id)
        {
            bool result = false;

            var objeto = GetByKey<X>(id);

            if (objeto != null)
            {
                result = DeleteObject(objeto);
            }

            return result;
        }

        public bool DeleteByKey(object id)
        {
            return DeleteByKey<T>(id);
        }


    }
}
