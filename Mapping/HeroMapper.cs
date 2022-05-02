using RPG.Platform.DTOs;
using RPG.Platform.Enums;
using RPG.Platform.Interfaces;
using System;

namespace RPG.API.Mapping
{
    public class HeroMapper
    {
        public static object CreateHero(TypeHero typeHero)
        {
            HeroDTO heroDTO = new HeroDTO();

            switch (typeHero)
            {
                //case TypeHero.Druid:
                //    heroDTO = new HeroDruid();
                //    break;
                //case TypeHero.Knight:
                //    heroDTO = new HeroKnight();
                //    break;
                //case TypeHero.Swordsman:
                //    heroDTO = new HeroSwordsman();
                //    break;
                //case TypeHero.Wizard:
                //    heroDTO = new HeroWizard();
                //    break;
            }

            return heroDTO;
        }

        public IHeroDTO RunTest(TypeHero typeHero)
        {
            throw new NotImplementedException();
        }
    }
}