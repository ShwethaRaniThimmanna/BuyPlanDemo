using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ADONetHelper.Postgres;
using BuyPlan.Automation.Framework.Config;
using BuyPlan.Automation.Framework.Extensions;

namespace BuyPlan.Automation.Framework.Helpers
{
    public static class PostgresHelper
    {
        private static string ConnectionString { get; }
        static PostgresHelper()
        {
            //to do : initialize connection string
            ConnectionString = Settings.AppSettings.DbConnectionString;
        }

        private static PostgresClient InstantiateClient(string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString))
            {
                throw new ArgumentNullException(nameof(connectionString));
            }
            return new PostgresClient(connectionString);
        }

        public static void Execute(Action<PostgresClient> action)
        {
           using (var client = InstantiateClient(ConnectionString))
            {
                try
                {
                   
                    client.Open();
                    action.Invoke(client);
                    client.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }

        }

        /// <summary>
        /// the client is responsible to open and dispose connection 
        /// to avoid db connection leak
        /// </summary>
        public static PostgresClient PostgresClient => InstantiateClient(ConnectionString);
    }
}
