//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lorn.ADSP.AM.DataModels
{
    using System;
    using System.Collections.Generic;
    
    /// <summary>
    /// ThirdMonitorMode
    /// </summary>
    public partial class ThirdMonitorMode
    {
        public ThirdMonitorMode()
        {
            this.ThirdMonitorCodes = new HashSet<ThirdMonitorCode>();
        }
    
        /// <summary>
        /// ThirdMonitorModeId
        /// </summary>
        public System.Guid ThirdMonitorModeId { get; set; }
        /// <summary>
        /// ThirdMonitorModeName
        /// </summary>
        public string ThirdMonitorModeName { get; set; }
        /// <summary>
        /// MediaId
        /// </summary>
        public Nullable<System.Guid> MediaId { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        public string Description { get; set; }
    
         /// <summary>
        /// ThirdMonitorCodes
        /// </summary>
        public virtual ICollection<ThirdMonitorCode> ThirdMonitorCodes { get; set; }
    }
}