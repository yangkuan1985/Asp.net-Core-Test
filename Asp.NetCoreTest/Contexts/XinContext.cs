using Asp.NetCoreTest.Models;
using Microsoft.EntityFrameworkCore;
using MySQL.Data.EntityFrameworkCore;
using MySQL.Data.EntityFrameworkCore.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCoreTest.Contexts
{
    public class XinContext : DbContext
    {
        /// <summary>
        /// 数据库链接配置
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
        //optionsBuilder.UseSqlServer(@"Data Source=.\SQLEXPRESS;Initial Catalog=xindata;User Id=sa;Password=1;");
        optionsBuilder.UseMySQL(@"事实上.net core 2.0现在不能使用mysql");

        /// <summary>
        /// 用户表
        /// </summary>
        public DbSet<UserModel> Users { get; set; }

        /// <summary>
        /// 测试
        /// </summary>
        public DbSet<UserModel> Users1 { get; set; }
    }
}
