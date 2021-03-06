using Movies.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Core.Service
{
    public interface IWorkingHoursService
    {
        public List<WorkingHours> GetWorkingHours();
        public bool InsertWorkingHours(WorkingHours WorkingHours);
        public bool UpdateWorkingHours(WorkingHours WorkingHours);
        public bool DeleteWorkingHours(int id);
    }
}
