using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
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
            //ID.AutoIncrementStep = 1;

            DataColumn Name = new DataColumn("name", typeof(string));
            DataColumn Price = new DataColumn("price",typeof(float));

            // Adding DataColumns into datatable
            Table1.Columns.AddRange(new DataColumn[] {ID, Name, Price});

            // Adding DataRows
            //DataRow row1 = Table1.NewRow();
            //row1["name"] = String.Format("{0}{1}",row1[ID], Name);
            Random r = new Random();

            for (int i = 1; i <= 10; i++)
            {
                Table1.Rows.Add(new object[]{i, i.ToString() + "name", r.Next(1000)/100f});
            }
            DataSet1.Tables.Add(Table1);
            

            // Queries
            // Select from table all records with id > 3
            var Query1 = Table1.AsEnumerable().Where(x => (int)x["Id"] > 3);
            Console.WriteLine("Query1 :");
            foreach(var data in Query1)
            {
                Console.WriteLine("id: {0}, name: {1}, price: {2}", data[0], data[1], data[2]);
            }
            var Query2 = Table1.AsEnumerable().Where(x => (int)x["Id"] > 4);//.Select(x => x["price"]);
            Console.WriteLine("Query2 :");
            foreach (var data in Query2)
            {
                Console.WriteLine("price: {0}", data[2]);
            }
            var Query3 = Table1.AsEnumerable().OrderBy(x => x["price"]);
            Console.WriteLine("Query3 :");
            foreach (var data in Query3)
            {
                Console.WriteLine("price: {0}", data[2]);
            }
            var Query4 = Table1.AsEnumerable().Select(x => new { IdField = x["Id"], NameField = x["name"], PriceField = x["price"] });
            Console.WriteLine("Query4 :");
            foreach (var data in Query4)
            {
                Console.WriteLine(data);
            }
            var Query5 = Table1.AsEnumerable().Where(x => (int)x["Id"] > 2 && (int)x["Id"] < 8).OrderBy(x => x["price"]);
            Console.WriteLine("Query5 :");
            foreach (var data in Query5)
            {
                Console.WriteLine("id: {0}, name: {1}, price: {2}", data[0], data[1], data[2]);
            }
        }
    }
}
