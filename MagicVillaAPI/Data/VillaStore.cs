using MagicVillaAPI.Models.Dto;

namespace MagicVillaAPI.Data
{
    public static class VillaStore
    {
        public static List<VillaDTO> villaList = new()
        {
            new() { Id=1, Name="Pool view", area=350, occupency=4},
            new(){ Id=2, Name="Beach View",area=350, occupency=4},
            new(){ Id=3, Name="Beach View",area=500, occupency=6}
        };
    }
}
