using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Mk.Chain.Core.Models
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("module_relationformain")]
    public partial class module_relationformain
    {
           public module_relationformain(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int ID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? ModuleId {get;set;}

           /// <summary>
           /// Desc:子模块名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ModulechildenName {get;set;}

    }
}
