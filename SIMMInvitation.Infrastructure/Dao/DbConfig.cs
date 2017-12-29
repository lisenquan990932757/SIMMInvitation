using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SyntacticSugar;
using SqlSugar;

namespace SIMMInvitation.Infrastructure.Dao
{
    public class DbConfig
    {
        public static string ConnectionString = ConfigSugar.GetConfigString("DefaultConnection");

        public static SqlSugarClient GetDbInstance()
        {
            try
            {
                var db = new SqlSugarClient(new ConnectionConfig()
                {
                    ConnectionString = ConnectionString,//连接字符串
                    DbType = DbType.SqlServer,//数据库类型
                    InitKeyType = InitKeyType.Attribute,//1.InitKeyType.Attribute 表示从属性中读取 主键和自增列的信息 2.InitKeyType.Attribute 表示从属性中读取 主键和自增列的信息
                    IsAutoCloseConnection = false  //是否自动关闭数据库连接, 默认不是, 如果设置为true, 则会在每次操作完数据库后, 即时关闭, 如果一个方法里面多次操作了数据库, 建议保持为false, 否则可能会引发性能问题
                });
                //db.Ado.CommandTimeOut = 30; //等待超时时间, 默认为30秒 (单位: 秒)
                return db;
            }
            catch (Exception ex)
            {
                throw new Exception("连接数据库出错，请检查您的连接字符串，和网络。 ex:".AppendString(ex.Message));
            }
        }

    }
}
