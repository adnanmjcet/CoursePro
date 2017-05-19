using BusinessObjectLayer.CommonModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Interface
{
    public interface ICourseTestAnswer
    {
        List<CourseTestAnswerModel> CourseTestAnswerList();

        CourseTestAnswerModel GetCourseTestAnswer(CourseTestAnswerModel model);

        long Save(CourseTestAnswerModel model);

        CourseTestAnswerModel GetById(long id);

        List<CourseTestAnswerModel> GetCourseTestAnswerList(long courseId);

        void UpdateCourseTestAnswer(List<CourseTestAnswerModel> lstmodel);
    }
}
