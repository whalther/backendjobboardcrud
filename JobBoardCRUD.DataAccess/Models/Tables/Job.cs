using System;
using System.Collections.Generic;
using System.Text;

namespace JobBoardCRUD.DataAccess.Models.Tables
{
    public partial class Job
    {
        public int Id { get; set; }
        public string JobTitle { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? ExpiresAt { get; set; }
        public bool JobStatus { get; set; }
    }
}
