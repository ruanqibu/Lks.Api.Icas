// <auto-generated>
using Lks.Enum;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace Lks.Api.Icas.Entity
{

    /// <summary>
    /// TeaReq
    /// </summary>
    [Serializable]
    public class TeaReq
    {

        ///<summary>
        /// 编号
        ///</summary>
        public int Id { get; set; } // Id (Primary key)

        ///<summary>
        /// 教师编号
        ///</summary>
        public int TeacherId { get; set; } // TeacherId
        public LevelType LevelType { get; set; } // LevelType
        public ClassType ClassType { get; set; } // ClassType

        ///<summary>
        /// 课程开始时间
        ///</summary>
        public DateTime BeginTime { get; set; } // BeginTime

        ///<summary>
        /// 课程结束时间
        ///</summary>
        public DateTime EndTime { get; set; } // EndTime
        public int MathingStatus { get; set; } // MathingStatus

        ///<summary>
        /// 状态（系统枚举）
        ///</summary>
        public Status Status { get; set; } // Status

        ///<summary>
        /// 更新人
        ///</summary>
        public int? UpdateBy { get; set; } // UpdateBy

        ///<summary>
        /// 更新时间
        ///</summary>
        public DateTime? UpdateTime { get; set; } // UpdateTime
        public long? UpdatePlatformType { get; set; } // UpdatePlatformType

        ///<summary>
        /// 创建人
        ///</summary>
        public int? CreateBy { get; set; } // CreateBy

        ///<summary>
        /// 创建时间
        ///</summary>
        public DateTime? CreateTime { get; set; } // CreateTime
        public long? CreatePlatformType { get; set; } // CreatePlatformType

        ///<summary>
        /// 备注
        ///</summary>
        public string Remark { get; set; } // Remark (length: 100)
        public byte[] RowVersion { get; set; } // RowVersion (length: 8)

        // Reverse navigation

        /// <summary>
        /// Child TeaReqMathings where [TeaReqMathing].[TeaReqId] point to this entity (FK_TeaReqMathing_TeaReq)
        /// </summary>
        public virtual ICollection<TeaReqMathing> TeaReqMathings { get; set; } // TeaReqMathing.FK_TeaReqMathing_TeaReq

        public TeaReq()
        {
            TeaReqMathings = new List<TeaReqMathing>();
        }
    }

}
// </auto-generated>