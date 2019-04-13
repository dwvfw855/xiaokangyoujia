using SqlSugar;

namespace Mk.Chain.Core.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class FILES
    {
        /// <summary>
        /// 
        /// </summary>
        public FILES()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.Int64 FILE_ID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String FILE_NAME { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String FILE_TYPE { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String TABLESPACE_NAME { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String TABLE_CATALOG { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String TABLE_SCHEMA { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String TABLE_NAME { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String LOGFILE_GROUP_NAME { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Int64? LOGFILE_GROUP_NUMBER { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String ENGINE { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String FULLTEXT_KEYS { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Int64? DELETED_ROWS { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Int64? UPDATE_COUNT { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Int64? FREE_EXTENTS { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Int64? TOTAL_EXTENTS { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Int64 EXTENT_SIZE { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.UInt64? INITIAL_SIZE { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.UInt64? MAXIMUM_SIZE { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.UInt64? AUTOEXTEND_SIZE { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.DateTime? CREATION_TIME { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.DateTime? LAST_UPDATE_TIME { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.DateTime? LAST_ACCESS_TIME { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Int64? RECOVER_TIME { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Int64? TRANSACTION_COUNTER { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.UInt64? VERSION { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String ROW_FORMAT { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.UInt64? TABLE_ROWS { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.UInt64? AVG_ROW_LENGTH { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.UInt64? DATA_LENGTH { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.UInt64? MAX_DATA_LENGTH { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.UInt64? INDEX_LENGTH { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.UInt64? DATA_FREE { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.DateTime? CREATE_TIME { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.DateTime? UPDATE_TIME { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.DateTime? CHECK_TIME { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.UInt64? CHECKSUM { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String STATUS { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String EXTRA { get; set; }
    }
}