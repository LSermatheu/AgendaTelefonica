using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;

namespace AgendaTelefonicaBackEnd.DAO._connect
{
    //public static class DAOConnect
    //{
    //    static ISessionFactory? factory = null;

    //    public static ISessionFactory GetFactory()
    //    {
    //        if (factory == null)
    //        {
    //            var server = "localhost";
    //            var database = "agendatelefonica";
    //            var user = "agenda";
    //            var password = "1234";

    //            string connectionString = $"Server={server};uid={user};pwd={password};database={database}";

    //            factory = Fluently.Configure()
    //                .Database(MySQLConfiguration.Standard.ConnectionString(connectionString))
    //                .Mappings(m => m.FluentMappings
    //                        .Add<>()
    //                    ).BuildSessionFactory();

    //        }
    //    }

    //    return factory;

    //}

    //public static NHibernate.ISession OpenSession()
    //{
    //    NHibernate.ISession result = GetFactory().OpenSession();
    //    return result;
    //}
}
