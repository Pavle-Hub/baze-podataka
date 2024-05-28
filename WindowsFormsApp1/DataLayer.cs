namespace WindowsFormsApp1
{
    static class DataLayer
    {
        private static ISessionFactory? _factory;
        private static object objLock;

        static DataLayer()
        {
            _factory = null;
            objLock = new object(); 
        }

        public static ISession? GetSession()
        {
            if (_factory == null)
            {
                lock (objLock)
                {
                    if (_factory == null)
                    {
                        _factory = CreateSessionFactory();
                    }
                }
            }
            return _factory?.OpenSession();
        }   

        private static ISessionFactory? CreateSessionFactory()
        {
            try
            {
                //string cs = ConfigurationManager.ConnectionStrings["OracleCs"].ConnectionString;

                var cfg = OracleManagedDataClientConfiguration.Oracle10
                    .ShowSql()
                    .ConnectionString(c =>
                    c.Is("Data Source=gislab-oracle.elfak.ni.ac.rs:1521/SBP_PDB;User Id=S18720;Password=S18720"));

                return Fluently.Configure()
                    .Database(cfg)
                    .Mappings(m => m.FluentMappings.AddFromAssemblyOf<FizickoObezbedjenjeMap>())
                    .BuildSessionFactory();
            }
            catch (Exception ec)
            {
                System.Windows.Forms.MessageBox.Show(ec.Message);
                return null;
            }
        }
    }
}
