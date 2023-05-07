using Microsoft.AspNetCore.Mvc.Rendering;

namespace Parcial3_Diego_Alexander_Valencia_Calderon.Helpers
{
    public interface IDropDownListsHelper
    {
        Task<IEnumerable<SelectListItem>> GetDDLServices();
    }
}