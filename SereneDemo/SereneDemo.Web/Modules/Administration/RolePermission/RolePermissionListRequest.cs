using Serenity.Services;

namespace SereneDemo.Administration
{
    public class RolePermissionListRequest : ServiceRequest
    {
        public int? RoleID { get; set; }
        public string Module { get; set; }
        public string Submodule { get; set; }
    }
}