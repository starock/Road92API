using System;

using System.Data;
using System.Collections.Generic;

using MongoDB.Bson;
using MongoDB.Driver;

namespace STAROCK.DAL
{
    public static class Test
    {
      


    

        public static string Conn()
        {
            string result = "";

            List<DM_Test> list = new List<DM_Test>();

            var connectionString = "mongodb://stormer:skyline008@www.w-jing.com:27017/Road92";
            var client = new MongoClient(connectionString);
          
            var server = client.GetServer();
            var database = server.GetDatabase("Road92"); 

            //var collection = database.GetCollection<DM_Test>("user");

            //获取表
            MongoCollection<DM_Test> col = database.GetCollection<DM_Test>("user");
            //查询全部
            list.AddRange(col.FindAll());

            //--------------------------------
            foreach (DM_Test t in col.FindAll())
            {
                //string id = t.ID.ToString();
                string name = t.name;
               
                result += name;
            }

            return result;
        }



    }


    public class DM_Test
    {
        public ObjectId _id { get; set; }

        public string name { get; set; }
    }
}

