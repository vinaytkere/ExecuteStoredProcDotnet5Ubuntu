using System;
using System.Linq;
using console.Models;
using Microsoft.EntityFrameworkCore;
namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new testdbContext();

            //var res = context.Emps.Select(x => x).First().Id;

            //executing stored procedure
             //var res1= context.Emps.FromSqlRaw("[dbo].[getall]").AsEnumerable().FirstOrDefault().Name;
            var res2 = context.Emps.FromSqlRaw("[dbo].[getbyid] {0}",2).AsEnumerable().First().Name;
            Console.WriteLine(res2);
        }
    }
}
