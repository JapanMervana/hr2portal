using HR2.EF.DAL;

namespace HR2.DAL
{
    public class DBFactory : IDatabaseFactory
    {
        private DatabaseContext context;

        public string DatabaseName { get; set; }

        /// <summary>
        /// Initializes a new instance of the DBFactory class.
        /// </summary>
        public DBFactory()
        {
            // TODO : Find out why this line of code is required
            //System.Data.Entity.Database.SetInitializer<HR2Entities>(null);
        }

        public override DatabaseContext DBContext
        {
            get
            {
                return this.context ?? (this.context = new HR2PortalEntities());
            }
        }

        protected override void DisposeCore()
        {
            if (this.context != null)
                this.context.Dispose();
        }
    }
}
