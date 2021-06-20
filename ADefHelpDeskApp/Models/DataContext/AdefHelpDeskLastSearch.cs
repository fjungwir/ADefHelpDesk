﻿using System;
using System.Collections.Generic;

namespace AdefHelpDeskBase.Models.DataContext
{
    public partial class AdefHelpDeskLastSearch
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int PortalId { get; set; }
        public string SearchText { get; set; }
        public string Status { get; set; }
        public string Priority { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? DueDate { get; set; }
        public int? AssignedRoleId { get; set; }
        public string Categories { get; set; }
        public int? CurrentPage { get; set; }
        public int? PageSize { get; set; }
    }
}
