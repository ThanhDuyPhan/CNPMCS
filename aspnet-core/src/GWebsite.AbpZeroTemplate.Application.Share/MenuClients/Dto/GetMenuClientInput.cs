using Abp.Runtime.Validation;
using GSoft.AbpZeroTemplate.Dto;

namespace GWebsite.AbpZeroTemplate.Application.Share.MenuClients.Dto
{
    public class GetMenuClientInput : PagedAndSortedInputDto, IShouldNormalize
    {
        //[Range(1, int.MaxValue)]
        //public int Id { get; set; }

        public string Name { get; set; }

        public void Normalize()
        {
            if (string.IsNullOrEmpty(Sorting))
            {
                Sorting = "Name";
            }
        }
    }
}
