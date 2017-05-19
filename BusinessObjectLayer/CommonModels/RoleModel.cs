using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjectLayer.CommonModels
{
    public partial class RoleModel
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string CreatedDate { get; set; }

        public List<UserModel> UserModelList { get; set; }
    }
}
