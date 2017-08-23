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
        /// 初始化
        /// </summary>
        /// <param name="options"></param>
        public XinContext(DbContextOptions options) : base(options)
        {
            return;
        }

        /// <summary>
        /// 用户表
        /// </summary>
        public DbSet<UserModel> Users { get; set; }
    }
}
