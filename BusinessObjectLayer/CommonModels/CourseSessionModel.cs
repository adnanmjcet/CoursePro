﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjectLayer.CommonModels
{
    public partial class CourseSessionModel
    {
        public long Id { get; set; }

        public long? CourseID { get; set; }
        public string CourseName { get; set; }

        public string Topic { get; set; }

        public string Document1 { get; set; }

        public string Document2 { get; set; }

        public string AudioLink { get; set; }

        public string VideoLink { get; set; }

        public DateTime? CreatedOn { get; set; }

        public long? CreatedBy { get; set; }

        public DateTime? LastSendDate { get; set; }

        public List<CourseModel> CourseModelList { get; set; }
        public List<CourseSessionModel> CourseSessionModelList { get; set; }

    }
}
