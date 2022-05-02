using RPG.Jsons;
using RPG.Platform.DTOs;
using System;

namespace RPG.API.Mapping
{
    public class HeroDruid
    {
        public static object CreateHeroDruid(JsonHero jsonHero)
        {
            KnightDTO druidDTO = new KnightDTO();
            druidDTO.Name = jsonHero.Name;
            druidDTO.HeroType = jsonHero.TypeHero;
            druidDTO.CreationDate = DateTime.Now;
            druidDTO.UpdateDate = DateTime.Now;

            return druidDTO;
        }
    }
}