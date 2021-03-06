using System;
using SnapObjects.Data;
using SnapObjects.Data.SqlServer;

namespace WebApplication1.Data
{
    public class SalesDataContext : SqlServerDataContext
	{
        public SalesDataContext(string connectionString)
            : this(new SqlServerDataContextOptions<SalesDataContext>(connectionString))
        {
        }

        public SalesDataContext(IDataContextOptions<SalesDataContext> options)
            : base(options)
        {
        }
        
        public SalesDataContext(IDataContextOptions options)
            : base(options)
        {
        }
    }
}
