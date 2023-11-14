using NHibernate;

namespace AgendaTelefonicaBackEnd.DAO._connect
{
    public class DAOBase<T> : IDisposable
    {
        private readonly NHibernate.ISession _session;
        private ITransaction? _transaction = null;

        //public DAOBase()
        //{
        //    _session = DAOConnect.OpenSession();
        //}

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
