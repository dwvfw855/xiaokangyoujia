using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Mk.Chain.Core.Models
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("user_maininfo")]
    public partial class user_maininfo
    {
           public user_maininfo(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int Id {get;set;}

           /// <summary>
           /// Desc:姓名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Name {get;set;}

           /// <summary>
           /// Desc:性别
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Sex {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Guid {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Phone {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Adress {get;set;}

           /// <summary>
           /// Desc:邀请码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string InvitationCode {get;set;}

           /// <summary>
           /// Desc:用户类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Type {get;set;}

    }
}
