namespace DataAccessLayer.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Course_Test_Answer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        public long? CourseID { get; set; }

        public long? CourseTestID { get; set; }

        [StringLength(50)]
        public string Answer { get; set; }

        public int? UserID { get; set; }

        public bool? IsCorrect { get; set; }

        public DateTime? CreatedOn { get; set; }

        public virtual Course Course { get; set; }

        public virtual Course_Test Course_Test { get; set; }

        public virtual User User { get; set; }
    }
}
