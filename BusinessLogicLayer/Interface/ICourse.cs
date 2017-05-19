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
        List<CourseSessionModel> CourseSessionList();
        List<CourseTestModel> CourseTestList();
        List<CourseTestAnswerModel> CourseTestAnswerList();

        CourseModel GetDetails(CourseModel model);

        int Save(CourseModel model);

        CourseModel GetById(int id);


    }
}
