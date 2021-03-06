﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjectLayer.CommonModels
{
    public partial class CourseTestAnswerModel
    {
        public long Id { get; set; }

        public long? CourseID { get; set; }
        public string CourseName { get; set; }


        public long? CourseTestID { get; set; }
        public string CourseTestName { get; set; }

        public string Answer { get; set; }

        public int? UserID { get; set; }
        public string UserName { get; set; }

        public bool? IsCorrect { get; set; }

        public DateTime? CreatedOn { get; set; }

        public List<CourseModel> CourseModelList { get; set; }

        public List<CourseTestModel> CourseTestModelList { get; set; }
        public List<CourseTestAnswerModel> CourseTestAnswerModelList { get; set; }

        public List<UserModel> UserModelList { get; set; }
    }
}
