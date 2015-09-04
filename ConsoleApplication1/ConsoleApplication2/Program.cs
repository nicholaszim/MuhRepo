using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Creating DataSet
            DataSet DataSet1 = new DataSet("LINQSET");
            // Creating DataTable
            DataTable Table1 = new DataTable("Info");
            // Creating DataColumns
            DataColumn ID = new DataColumn("Id", typeof(int));
            ID.Unique = true;
            ID.AutoIncrement = true;
            ID.AllowDBNull = false;
            ID.AutoIncrementSeed = 1;
            ID.AutoIncrementStep = 1;

            DataColumn Name = new DataColumn("name", typeof(string));
            DataColumn Price = new DataColumn("price", typeof(float));

            Table1.Columns.AddRange(new DataColumn[] { ID, Name, Price });

            Random r = new Random();

            RowConstructor(Table1, ID, Name, r);

            DataSet1.Tables.Add(Table1);

            SelectAllQuery(Table1);

            FirstQuery(Table1);

            SecondQuery(Table1);

            ThirdQuery(Table1);

            Query4(Table1);

            FifthQuery(Table1);
            Console.ReadLine();
        }

        private static void RowConstructor(DataTable Table1, DataColumn ID, DataColumn Name, Random r)
        {
            for (int i = 1; i <= 10; i++)
            {
                DataRow row = Table1.NewRow();
                row["name"] = String.Format("{0}{1}", row[ID], Name);
                row["price"] = r.Next(1000) / 100f;
                Table1.Rows.Add(row);
            }
        }

        private static void FifthQuery(DataTable Table1)
        {
            // all records with id > 2 and id < 8 ordered by price descending
            var Query5 = Table1.AsEnumerable().Where(x => (int)x["Id"] > 2 && (int)x["Id"] < 8).OrderByDescending(x => x["price"]);
            Console.WriteLine("Query5 :");
            foreach (var data in Query5)
            {
                Console.WriteLine("id: {0}, name: {1}, price: {2}", data[0], data[1], data[2]);
            }
        }

        private static void Query4(DataTable Table1)
        {
            // select anonimous types with field names: idName, NameField, PriceField
            var Query4 = Table1.AsEnumerable().Select(x => new { IdField = x["Id"], NameField = x["name"], PriceField = x["price"] });
            Console.WriteLine("Query4 :");
            foreach (var data in Query4)
            {
                Console.WriteLine(data);
            }
        }

        private static void ThirdQuery(DataTable Table1)
        {
            // Select al prices in ascending order
            var Query3 = Table1.AsEnumerable().OrderBy(x => x["price"]);
            Console.WriteLine("Query3 :");
            foreach (var data in Query3)
            {
                Console.WriteLine("price: {0}", data[2]);
            }
        }

        private static void SecondQuery(DataTable Table1)
        {
            // Select all prices for records with id > 4
            var Query2 = Table1.AsEnumerable().Where(x => (int)x["Id"] > 4);//.Select(x => x["price"]);
            Console.WriteLine("Query2 :");
            foreach (var data in Query2)
            {
                Console.WriteLine("price: {0}", data[2]);
            }
        }

        private static void FirstQuery(DataTable Table1)
        {
            // Select from table all records with id > 3
            var Query1 = Table1.AsEnumerable().Where(x => (int)x["Id"] > 3);
            Console.WriteLine("Query1 :");
            foreach (var data in Query1)
            {
                Console.WriteLine("id: {0}, name: {1}, price: {2}", data[0], data[1], data[2]);
            }
        }

        private static void SelectAllQuery(DataTable Table1)
        {
            //Queries
            // Select all records 
            var selectAllQuery = Table1.AsEnumerable().Select(x => x);
            Console.WriteLine("Query0 :");
            foreach (var data in selectAllQuery)
            {
                Console.WriteLine("id: {0}, name: {1}, price: {2}", data[0], data[1], data[2]);
            }
        }
    }
}
