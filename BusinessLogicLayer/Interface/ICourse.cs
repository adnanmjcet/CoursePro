using BusinessObjectLayer.CommonModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Interface
{
    public interface ICourse
    {
        List<CourseModel> CourseList();

        CourseModel GetCourse(CourseModel model);

        long Save(CourseModel model);

        CourseModel GetById(int id);

        CourseModel GetCourseSessions(int id);

    }
}
