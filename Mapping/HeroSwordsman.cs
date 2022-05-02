using RPG.Jsons;
using RPG.Platform.DTOs;
using System;

namespace RPG.API.Mapping
{
    public class HeroSwordsman
    {
        public static object CreateHeroSwordsman(JsonHero jsonHero)
        {
            SwordsmanDTO swordsmanDTO = new SwordsmanDTO();
            swordsmanDTO.Name = jsonHero.Name;
            swordsmanDTO.HeroType = jsonHero.TypeHero;
            swordsmanDTO.CreationDate = DateTime.Now;
            swordsmanDTO.UpdateDate = DateTime.Now;

            return swordsmanDTO;
        }
    }
}