﻿using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MTGCardDatabase.Models
{
    public class PreviewCard : TableEntity
    {
        public PreviewCard(string cardSet, string cardName)
        {
            this.PartitionKey = cardSet;
            this.RowKey = cardName;
        }

        public PreviewCard() { }
        public string Name { get; set; }
        public string Image_Normal { get; set; }
        public string Rarity { get; set; }
        public string IronstreamRating { get; set; }
        public string AJSnipsRating { get; set; }
    }
}
