using RPG.Jsons;
using RPG.Platform.DTOs;
using System;

namespace RPG.API.Mapping
{
    public class HeroWizard
    {
        public static object CreateHeroWizard(JsonHero jsonHero)
        {
            WizardDTO wizardDTO = new WizardDTO();
            wizardDTO.Name = jsonHero.Name;
            wizardDTO.HeroType = jsonHero.TypeHero;
            wizardDTO.CreationDate = DateTime.Now;
            wizardDTO.UpdateDate = DateTime.Now;

            return wizardDTO;
        }
    }
}