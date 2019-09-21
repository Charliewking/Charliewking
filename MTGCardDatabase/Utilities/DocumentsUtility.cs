using Microsoft.Extensions.Options;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
using MTGDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CWKAngular.Utilities
{
    public class DocumentsUtility
    {
        private readonly WebConfiguration config = new WebConfiguration();

        public DocumentsUtility() 
        {
       
        }

        public CloudTable GetCloudTable(string tableName)
        {
            return GetStorageAccount().CreateCloudTableClient().GetTableReference(tableName);
        }

        private CloudStorageAccount GetStorageAccount()
        {
            return CloudStorageAccount.Parse(config.mtgdatabaseConnectionString);
        }
    }
}
