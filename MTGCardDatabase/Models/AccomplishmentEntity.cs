using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CWKAngular.Models
{
    public class AccomplishmentEntity : TableEntity
    {
        public AccomplishmentEntity(string accomplishment)
        {
            this.PartitionKey = "accomplishment_key";
            this.RowKey = accomplishment;
        }

        public AccomplishmentEntity() { }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
