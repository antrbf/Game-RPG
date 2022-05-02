using RPG.Jsons;
using RPG.Platform.DTOs;
using System;

namespace RPG.API.Mapping
{
    public class HeroKnight
    {
        public static object CreateHeroKnight(JsonHero jsonHero)
        {
            KnightDTO knightDTO = new KnightDTO();
            knightDTO.Name = jsonHero.Name;
            knightDTO.HeroType = jsonHero.TypeHero;
            knightDTO.CreationDate = DateTime.Now;
            knightDTO.UpdateDate = DateTime.Now;

            return knightDTO;
        }
    }
}