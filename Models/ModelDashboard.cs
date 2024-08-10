using DirectComplaintRegister.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Web;
using System.Web.Services.Description;

namespace ComplaintTracker.Models
{
    public class ModelDashboard
    {
        public string TodayComplaints { get; set; }
        public string TodayPendingComplaints { get; set; }
        public string PreviousPendingComplaints { get; set; }
        public string TotalPendingComplaints { get; set; }

        public string TotalPlannedShutdown { get; set; }
        public string TodayESDShutdown { get; set; }

        public List<SourceWiseComplaint> ListSourceWiseComplaintData { get; set; }
        public List<CategoryWiseComplaint> ListCategoryWiseComplaintData { get; set; }


    }

    public class SourceWiseComplaint
    {
        public string ComplaintSource { get; set; }
        public string Today { get; set; }

        public string TodayPending { get; set; }
        public string PreviousPending { get; set; }

        public string TotalPending { get; set; }

    }

    public class CategoryWiseComplaint
    {
        public string ComplaintCategory { get; set; }
        public string Today { get; set; }

        public string TodayPending { get; set; }
        public string PreviousPending { get; set; }

        public string TotalPending { get; set; }

    }

}
