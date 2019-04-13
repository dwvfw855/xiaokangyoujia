using Met.Core.Util.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mk.Chain.Core.Repository.SqlServer
{
    /// <summary>
    /// 静态配置类
    /// </summary>
    public static class BaseDBConfig
    {
        /// <summary>
        /// 数据库连接字符串(私有字段)
        /// </summary>
        private static readonly string _connectionString = "Database=lifeserver;Data Source = 127.0.0.1; User Id = root; Password=123456;pooling=false;CharSet=utf8;port=3306";
        /// <summary>
        /// 数据库连接字符串(公有属性)
        /// </summary>
        public static string ConnectionString
        {
            get { return _connectionString; }
        }
    }
}
