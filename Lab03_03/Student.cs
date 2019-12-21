namespace Lab03_03
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Student")]
    public partial class Student
    {
        [Key]
        [Column("StudentID")]
        [StringLength(50)]
        public string StudentID { get; set; }

        [Column("StudentName")]
        [StringLength(50)]
        public string StudentName { get; set; }

        [Column("FacultyID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FacultyID { get; set; }

        [Column("AverageScore")]
        public double? AverageScore { get; set; }

        public virtual Faculty Faculty { get; set; }
    }
}
