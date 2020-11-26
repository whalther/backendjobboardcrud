using System;
using System.Collections.Generic;
using System.Text;

namespace JobBoardCRUD.Models.Entities
{
    public class JobInfo
    {
        public int JobNumber { get; set; }
        public string JobTitlePosition { get; set; }
        public string JobDescription { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? ExpiresAt { get; set; }
    }
}
