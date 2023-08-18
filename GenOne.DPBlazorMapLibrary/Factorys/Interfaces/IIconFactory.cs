namespace DPBlazorMapLibrary
{
    public interface IIconFactory
    {
        Task<Icon> Create(IconOptions options);
        Task<Icon> CreateDefault();
        Task<Icon> CreateDivIcon(DivIconOptions options);
    }
}
