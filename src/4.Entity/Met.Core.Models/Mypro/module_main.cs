using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Mk.Chain.Core.Models
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("module_main")]
    public partial class module_main
    {
        public module_main()
        {


        }
        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:False
        /// </summary>           
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int ID { get; set; }

        /// <summary>
        /// Desc:模块名称
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string ModuleName { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string ModuleUrl { get; set; }

    }
}
