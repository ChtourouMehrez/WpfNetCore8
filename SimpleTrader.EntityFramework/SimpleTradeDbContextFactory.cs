using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTrader.EntityFramework
{
    public class SimpleTradeDbContextFactory : IDesignTimeDbContextFactory<SimpleTraderDBContext>
    {
        public SimpleTraderDBContext CreateDbContext(string[]? args = null)
        {
            var options = new DbContextOptionsBuilder<SimpleTraderDBContext>();
            options.UseSqlServer("Data source=(localdb)\\MSSQLLocalDB;initial catalog=SimpleTrader;user id=sa;password=ideal2s;Trust Server Certificate=True");
            return new SimpleTraderDBContext(options.Options);
        }

    }
}
