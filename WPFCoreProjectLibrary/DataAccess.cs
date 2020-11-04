using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using WPFCoreProject.Models;
using Dapper;
using System.Configuration;
using System.IO;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Linq;
using System.Threading.Tasks.Dataflow;

namespace WPFCoreProjectLibrary
{
    public class DataAccess
    {
        public Item InsertAuction(Item model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString("Auction")))
            {
                var a = new DynamicParameters();
                a.Add("ItemName", model.ItemName);
                a.Add("ItemValue", model.ItemValue);
                a.Add("ItemCategory", model.ItemCategory);
                a.Add("@Id", 0, DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spItems_Insert", a, commandType: CommandType.StoredProcedure);

                model.Id = a.Get<int>("@Id");

                return model;
            }
        }

        public List<Item> GetItems()
        {
            List<Item> allItems = new List<Item>();
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString("Auction")))
            {
                allItems = connection.Query<Item>("dbo.spItems_GetAll").ToList();
            }

            return allItems;
        }

        public void RemoveItem(Item model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString("Auction")))
            {
                var a = new DynamicParameters();
                a.Add("Id", model.Id);

                connection.Execute("dbo.spItems_Remove", a, commandType: CommandType.StoredProcedure);
            }
        }

        public List<Item> GetByName(Item model)
        {
            List<Item> similarItems = new List<Item>();

            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString("Auction")))
            {
                var a = new DynamicParameters();
                a.Add("ItemName", model.ItemName);

                similarItems = connection.Query<Item>("dbo.spItems_GetByName", a, commandType: CommandType.StoredProcedure).ToList();

            }

            return similarItems;
        }
    }
}

