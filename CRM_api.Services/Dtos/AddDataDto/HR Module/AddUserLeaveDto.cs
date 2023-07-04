﻿using System.ComponentModel.DataAnnotations;

namespace CRM_api.Services.Dtos.AddDataDto.HR_Module
{
    public class AddUserLeaveDto
    {
        public int? LeaveTypeId { get; set; }
        public int? RequestedBy { get; set; }
        public int? PermittedBy { get; set; }
        [DataType(DataType.Date)]
        public DateTime? FromDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime? ToDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime? RequestedDate { get; set; } = DateTime.Now;
        public string? Reason { get; set; }
        public bool? IsPermitted { get; set; }
        public string? RejectedReason { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
