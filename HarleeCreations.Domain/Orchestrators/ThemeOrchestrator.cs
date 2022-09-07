using HarleeCreations.Crosscutting.Dtos.Theme;
using HarleeCreations.Crosscutting.Models.Theme;
using HarleeCreations.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarleeCreations.Domain.Orchestrators
{
    public class ThemeOrchestrator
    {
        private ThemeRepository repository;
        
        public ThemeOrchestrator()
        {
            repository = new ThemeRepository();
        }
        public void AddColorScheme(ColorSchemeModel model)
        {
            ColorSchemeDto dto = new ColorSchemeDto()
            {
                UniqueName = model.UniqueName,
                V100 = model.V100,
                V200 = model.V200,
                V300 = model.V300,
                V400 = model.V400,
                V500 = model.V500,
                V600 = model.V600,
                V700 = model.V700,
                V800 = model.V800,
                V900 = model.V900,
            };

            repository.AddColorScheme(dto);

        }
    }
}
