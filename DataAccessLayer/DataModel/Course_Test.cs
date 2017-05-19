namespace DataAccessLayer.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Course_Test
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Course_Test()
        {
            Course_Test_Answer = new HashSet<Course_Test_Answer>();
        }

        public long Id { get; set; }

        public long? CourseID { get; set; }

        [StringLength(550)]
        public string Question { get; set; }

        [StringLength(250)]
        public string Answer1 { get; set; }

        [StringLength(250)]
        public string Answer2 { get; set; }

        [StringLength(250)]
        public string Answer3 { get; set; }

        [StringLength(250)]
        public string Answer4 { get; set; }

        [StringLength(250)]
        public string CorrectAnswer { get; set; }

        [StringLength(50)]
        public string Mark { get; set; }

        [StringLength(650)]
        public string Reason { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CreatedOn { get; set; }

        public int? CreatedBy { get; set; }

        public virtual Course Course { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Course_Test_Answer> Course_Test_Answer { get; set; }
    }
}
