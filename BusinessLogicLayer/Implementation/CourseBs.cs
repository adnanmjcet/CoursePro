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
                               Description = item.Description,
                               Status = item.Status,
                               IsDelete = item.IsDelete,
                               CreatedOn = item.CreatedOn,
                               UpdatedOn = item.UpdatedOn,
                               CreatedBy = item.CreatedBy,
                               UpdatedBy = item.UpdatedBy

                           }).OrderByDescending(x => x.Id).ToList();
            return _CourseList;
        }

        public List<CourseSessionModel> CourseSessionList()
        {
            GenericPattern<CourseSession> _tbl_CourseSession = new GenericPattern<CourseSession>();
            List<CourseSessionModel> _SessionList = new List<CourseSessionModel>();
            var CourseSessionData = _tbl_CourseSession.GetAll().ToList();
            _SessionList = (from item in CourseSessionData
                         select new CourseSessionModel
                         {
                             Id = item.Id,
                         }).OrderByDescending(x => x.Id).ToList();
            return _SessionList;
        }

        public List<CourseTestAnswerModel> CourseTestAnswerList()
        {
            GenericPattern<Course_Test_Answer> _tbl_CourseTestAnswer = new GenericPattern<Course_Test_Answer>();
            List<CourseTestAnswerModel> _CourseTestAnswerList = new List<CourseTestAnswerModel>();
            var CourseTestAnswerData = _tbl_CourseTestAnswer.GetAll().ToList();
            _CourseTestAnswerList = (from item in CourseTestAnswerData
                                     select new CourseTestAnswerModel
                                     {
                                Id = item.Id,
                            }).OrderByDescending(x => x.Id).ToList();
            return _CourseTestAnswerList;
        }

        public List<CourseTestModel> CourseTestList()
        {
            GenericPattern<Course_Test> _tbl_CourseTest = new GenericPattern<Course_Test>();
            List<CourseTestModel> _CourseTestList = new List<CourseTestModel>();
            var CourseTestData = _tbl_CourseTest.GetAll().ToList();
            _CourseTestList = (from item in CourseTestData
                                     select new CourseTestModel
                                     {
                                         Id = item.Id,
                                     }).OrderByDescending(x => x.Id).ToList();
            return _CourseTestList;
        }

        public CourseModel GetById(int id)
        {
            CourseModel _CourseList = new CourseModel();
            var item = _tbl_Course.GetById(id);
            item = item ?? new Course();
            _CourseList = new CourseModel
            {
                Id = item.Id,
                Name = item.Name,
                Description = item.Description,
                Status = item.Status,
                IsDelete = item.IsDelete,
                CreatedOn = item.CreatedOn,
                UpdatedOn = item.UpdatedOn,
                CreatedBy = item.CreatedBy,
                UpdatedBy = item.UpdatedBy
            };
            return _CourseList;
        }

        public CourseModel GetDetails(CourseModel model)
        {
            model = model ?? new CourseModel();
            if (model.Id != 0)
            {
                model.CourseModelList = CourseList();
                model.CourseSessionsModelList = CourseSessionList();
                model.CourseTestAnswerModelList = CourseTestAnswerList();
                model.CourseTestModelList = CourseTestList();
            }
            model.CourseModelList = CourseList();

            return model;
        }

        public int Save(CourseModel model)
        {
            Course _tblCourse = new Course(model);
            if (model.Id != null && model.Id != 0)
            {
                _tblCourse.CreatedOn = System.DateTime.Now;
                _tblCourse.CreatedBy = 1;
                _tbl_Course.Update(_tblCourse);

            }
            else
            {

                _tblCourse.CreatedOn = System.DateTime.Now;
                _tblCourse.CreatedBy = 1;

                _tblCourse = _tbl_Course.Insert(_tblCourse);
            }
            return (int)_tblCourse.Id;

        }
    }
}
