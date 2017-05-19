namespace DataAccessLayer.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            Course_Test_Answer = new HashSet<Course_Test_Answer>();
        }

        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Contact { get; set; }

        [StringLength(50)]
        public string Area { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        public int? RoleId { get; set; }

        public byte[] ProfilePic { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CreatedDate { get; set; }

        public string DeviceID { get; set; }

        public int? Platform { get; set; }

        [StringLength(50)]
        public string OTPPassword { get; set; }

        public DateTime? OTPGeneratedTime { get; set; }

        public bool? IsOTPCheck { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Course_Test_Answer> Course_Test_Answer { get; set; }

        public virtual Role Role { get; set; }
    }
}
