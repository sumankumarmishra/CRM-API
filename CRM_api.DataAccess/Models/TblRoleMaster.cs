﻿namespace CRM_api.DataAccess.Models
{
    public partial class TblRoleMaster
    {
        public int RoleId { get; set; }
        public string? RoleName { get; set; }

        public TblRoleMaster()
        {

        }

        public TblRoleMaster(string? roleName)
        {
            RoleName = roleName;
        }
    }
}
