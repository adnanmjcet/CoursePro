using BusinessObjectLayer.CommonModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DataModel
{
    class PartialClass
    {
    }
    public partial class Course

    {
        public Course(CourseModel item)
        {
            Id = item.Id;
            Name = item.Name;
            Description = item.Description;
            Status = item.Status;
            IsDelete = item.IsDelete;
            CreatedOn = item.CreatedOn;
            UpdatedOn = item.UpdatedOn;
            CreatedBy = item.CreatedBy;
            UpdatedBy = item.UpdatedBy;
            
        }
    }
}
