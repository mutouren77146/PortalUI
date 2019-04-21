using Abp.Application.Services.Dto;

namespace COM.PortalUI.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

