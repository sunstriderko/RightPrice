using System;
using System.Collections.Generic;
using System.Text;

namespace WPFCoreProject.Models
{
    public class Item
    {
        public int Id { get; set; }

        public string ItemName { get; set; }

        public int ItemValue { get; set; }

        public string ItemCategory { get; set; }

        public int CreatorId { get; set; }

        public string AuctionInfo
        {
            get
            {
                return $"{ItemName} {ItemValue}$";
            }
        }
    }
}
