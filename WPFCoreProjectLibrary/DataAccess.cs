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
using WPFCoreProjectLibrary.Models;

namespace WPFCoreProjectLibrary
{
    public class DataAccess
    {
        public Item InsertAuction(Item itemModel)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString("Auction")))
            {
                var a = new DynamicParameters();
                a.Add("ItemName", itemModel.ItemName);
                a.Add("ItemValue", itemModel.ItemValue);
                a.Add("ItemCategory", itemModel.ItemCategory);
                a.Add("CreatorId", itemModel.CreatorId);
                a.Add("@Id", 0, DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spItems_Insert", a, commandType: CommandType.StoredProcedure);

                itemModel.Id = a.Get<int>("@Id");

                return itemModel;
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

        public List<Item> SearchByName(Item model)
        {
            List<Item> searchedByNameItems = new List<Item>();

            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString("Auction")))
            {
                var a = new DynamicParameters();
                a.Add("ItemName", model.ItemName);

                searchedByNameItems = connection.Query<Item>("dbo.spItems_SearchByName", a, commandType: CommandType.StoredProcedure).ToList();

            }

            return searchedByNameItems;
        }

        public List<Item> GetByCategory(Item model)
        {
            List<Item> categoryItems = new List<Item>();

            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString("Auction")))
            {
                var a = new DynamicParameters();

                a.Add("ItemCategory", model.ItemCategory);

                categoryItems = connection.Query<Item>("dbo.spItems_GetByCategory", a, commandType: CommandType.StoredProcedure).ToList();

            }

            return categoryItems;
        }

        public List<Item> GetByNameCategory(Item model)
        {
            List<Item> nameCategoryItems = new List<Item>();

            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString("Auction")))
            {
                var a = new DynamicParameters();

                a.Add("ItemName", model.ItemName);
                a.Add("ItemCategory", model.ItemCategory);

                nameCategoryItems = connection.Query<Item>("dbo.spItems_GetByNameCategory", a, commandType: CommandType.StoredProcedure).ToList();

            }

            return nameCategoryItems;
        }

        public User CreateUser(User model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString("Auction")))
            {
                var u = new DynamicParameters();

                u.Add("Username", model.Username);
                u.Add("Password", model.Password);
                u.Add("PhoneNumber", model.PhoneNumber);
                u.Add("Email", model.Email);
                u.Add("@Id", 0, DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spUsers_CreateNew", u, commandType: CommandType.StoredProcedure);

                model.Id = u.Get<int>("@Id");

                return model;

            }
        }

        public List<User> GetAvailibleUsers(User model)
        {
            List<User> availibleUser = new List<User>();

            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString("Auction")))
            {
                var a = new DynamicParameters();

                a.Add("Username", model.Username);
                a.Add("Password", model.Password);

                availibleUser = connection.Query<User>("dbo.spUsers_LoginProcess", a, commandType: CommandType.StoredProcedure).ToList();

            }

            return availibleUser;
        }

        public User GetContactInfo(Item model)
        {
            User userWithInfo = new User();

            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString("Auction")))
            {
                var u = new DynamicParameters();

                u.Add("Id", model.CreatorId);

                userWithInfo = connection.Query<User>("dbo.spUsers_GetContactInfo", u, commandType: CommandType.StoredProcedure).First();

            }

            return userWithInfo;
        }
    }
}

