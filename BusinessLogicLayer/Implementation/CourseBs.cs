using BusinessLogicLayer.Interface;
using BusinessObjectLayer.CommonModels;
using DataAccessLayer.DataModel;
using DataAccessLayer.GenericPattern.Implementation;
using DataAccessLayer.GenericPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Implementation
{
    public class CourseBs : ICourse
    {
        private readonly IGenericPattern<Course> _tbl_Course;
        private readonly CourseModel _CourseModel;
        private readonly CourseTestAnswerModel _CourseTestAnswerModel;
        private readonly CourseTestModel _CourseTestModel;
        private readonly CourseSessionModel _CourseSessionModel;

        public CourseBs()
        {
            _tbl_Course = new GenericPattern<Course>();
            _CourseModel = new CourseModel();
            _CourseTestAnswerModel = new CourseTestAnswerModel();
            _CourseTestModel = new CourseTestModel();
            _CourseSessionModel = new CourseSessionModel();
        }

        public List<CourseModel> CourseList()
        {
            List<CourseModel> _CourseList = new List<CourseModel>();
            var CourseData = _tbl_Course.GetAll().ToList();
            _CourseList = (from item in CourseData
                            select new CourseModel
                            {
                                Id = item.Id,
                                Name = item.Name,
                                UserName = (item.User != null) ? item.User.UserName : string.Empty,
                                ZoneName = (item.Zone != null) ? item.Zone.Name : string.Empty,
                                CreatedBy = item.CreatedBy,

                            }).OrderByDescending(x => x.Id).ToList();
            return _CourseList;
        }

        public List<CourseSessionModel> CourseSessionList()
        {
            throw new NotImplementedException();
        }

        public List<CourseTestAnswerModel> CourseTestAnswerList()
        {
            throw new NotImplementedException();
        }

        public List<CourseTestModel> CourseTestList()
        {
            throw new NotImplementedException();
        }

        public CourseModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public CourseModel GetDetails(CourseModel model)
        {
            throw new NotImplementedException();
        }

        public int Save(CourseModel model)
        {
            throw new NotImplementedException();
        }
    }
}
