using Abp.Application.Services.Dto;
using System.Collections.Generic;

namespace GWebsite.AbpZeroTemplate.Application.Share.MenuClients.Dto
{
    public class GetMenuClientOutput
    {
        public MenuClientDto MenuClient { get; set; }
        public List<ComboboxItemDto> MenuClients { get; set; }

        public GetMenuClientOutput()
        {
            MenuClients = new List<ComboboxItemDto>();
        }
    }
}
