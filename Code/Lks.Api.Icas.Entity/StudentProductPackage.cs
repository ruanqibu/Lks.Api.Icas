// <auto-generated>
using Lks.Enum;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace Lks.Api.Icas.Entity
{

    /// <summary>
    /// StudentProductPackage
    /// </summary>
    [Serializable]
    public class StudentProductPackage
    {
        public int Id { get; set; } // Id (Primary key)
        public int StudentProductId { get; set; } // StudentProductId
        public ClassType ClassType { get; set; } // ClassType
        public bool IsComplete { get; set; } // IsComplete
        public bool IsSerial { get; set; } // IsSerial
        public int OrderNum { get; set; } // OrderNum
        public Status Status { get; set; } // Status

        // Reverse navigation

        /// <summary>
        /// Child StudentProductPackageCourses where [StudentProductPackageCourse].[StudentProductPackageId] point to this entity (FK_StudentProductPackageCourse_StudentProductPackage)
        /// </summary>
        public virtual ICollection<StudentProductPackageCourse> StudentProductPackageCourses { get; set; } // StudentProductPackageCourse.FK_StudentProductPackageCourse_StudentProductPackage

        // Foreign keys

        /// <summary>
        /// Parent StudentProduct pointed by [StudentProductPackage].([StudentProductId]) (FK_StudentProductPackage_StudentProduct)
        /// </summary>
        public virtual StudentProduct StudentProduct { get; set; } // FK_StudentProductPackage_StudentProduct

        public StudentProductPackage()
        {
            StudentProductPackageCourses = new List<StudentProductPackageCourse>();
        }
    }

}
// </auto-generated>