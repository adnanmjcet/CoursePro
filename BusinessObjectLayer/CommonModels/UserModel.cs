using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjectLayer.CommonModels
{
    public partial class UserModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Contact { get; set; }

        public string Area { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public int? RoleId { get; set; }

        public byte[] ProfilePic { get; set; }

        public DateTime? CreatedDate { get; set; }

        public string DeviceID { get; set; }

        public int? Platform { get; set; }

        public string OTPPassword { get; set; }

        public DateTime? OTPGeneratedTime { get; set; }

        public bool? IsOTPCheck { get; set; }

        public List<CourseTestAnswerModel> CourseTestAnswerModelList { get; set; }

        public List<RoleModel> RoleModelList { get; set; }
        public List<UserModel> UserModelList { get; set; }

    }
}
