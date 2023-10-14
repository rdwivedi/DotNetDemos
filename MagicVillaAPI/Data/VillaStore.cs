using MagicVillaAPI.Models.Dto;

namespace MagicVillaAPI.Data
{
    public static class VillaStore
    {
        public static List<VillaDTO> villaList = new()
        {
            new() { Id=1, Name="Pool view"},
            new(){ Id=2, Name="Beach View"}
        };
    }
}
