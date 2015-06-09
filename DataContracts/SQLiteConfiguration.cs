//using System;
//using System.Data;
//using System.Data.Entity;
////using System.Data.SQLite.EF6;
//using System.Data.SQLite;
//using System.Data.Entity.Core.Common;
//using System.Data.Entity.Infrastructure;
//using System.Data.Common;
//
//namespace DataContracts
//{
//	public class SQLiteConfiguration : DbConfiguration 
//	{ 
//		public SQLiteConfiguration() 
//		{ 
//			SetDefaultConnectionFactory(new SQLiteConnectionFactory());
//
//			//DbProviderFactory f1 = System.Data.SQLite.EF6.SQLiteProviderFactory.Instance;
//			//DbProviderFactory factory = System.Data.SQLite.SQLiteFactory.Instance;
//			SetProviderFactory("System.Data.SQLite", SQLiteFactory.Instance);
//
//
//			//SetProviderFactory("System.Data.SQLite.EF6", SQLiteProviderFactory.Instance);
//			//SetProviderServices("System.Data.SQLite", (DbProviderServices)SQLiteProviderFactory.Instance.GetService(typeof(DbProviderServices)));
//
//			//System.Data.Common.DbConnection conn = new System.Data.Common.DbConnection ("Data Source=.\\Chinook_Sqlite_AutoIncrementPKs.sqlite");
//			//SetProviderServices( 
//			//	"System.Data.SQLite.EF6",
//			//	System.Data.SQLite.EF6.SQLiteProviderServices.GetProviderServices(conn)); 
//		} 
//
//	}
//	public class SQLiteConnectionFactory : IDbConnectionFactory
//	{
//		public DbConnection CreateConnection(string connectionString)
//		{
//			return new SQLiteConnection("Data Source=.\\test.sqlite");
//		}
//	}
//}

//SqlCeProviderServices.ProviderInvariantName, 
//SqlCeProviderServices.Instance