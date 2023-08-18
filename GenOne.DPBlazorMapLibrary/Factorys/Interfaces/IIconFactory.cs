using GenOne.DPBlazorMapLibrary.Models.Basics.Icons;

namespace GenOne.DPBlazorMapLibrary.Factorys.Interfaces
{
    public interface IIconFactory
    {
        Task<Icon> Create(IconOptions options);
        Task<Icon> CreateDefault();
        Task<Icon> CreateDivIcon(DivIconOptions options);
    }
}
