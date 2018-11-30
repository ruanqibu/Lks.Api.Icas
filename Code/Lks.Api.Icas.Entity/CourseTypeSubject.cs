// <auto-generated>
using Lks.Enum;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace Lks.Api.Icas.Entity
{

    /// <summary>
    /// CourseTypeSubject
    /// </summary>
    [Serializable]
    public class CourseTypeSubject
    {
        public int CourseTypeId { get; set; } // CourseTypeId (Primary key)
        public int CourseSubjectId { get; set; } // CourseSubjectId (Primary key)
        public Status Status { get; set; } // Status

        // Foreign keys

        /// <summary>
        /// Parent CourseSubject pointed by [CourseTypeSubject].([CourseSubjectId]) (FK_CourseTypeSubject_CourseSubject)
        /// </summary>
        public virtual CourseSubject CourseSubject { get; set; } // FK_CourseTypeSubject_CourseSubject

        /// <summary>
        /// Parent CourseType pointed by [CourseTypeSubject].([CourseTypeId]) (FK_CourseTypeSubject_CourseType)
        /// </summary>
        public virtual CourseType CourseType { get; set; } // FK_CourseTypeSubject_CourseType
    }

}
// </auto-generated>