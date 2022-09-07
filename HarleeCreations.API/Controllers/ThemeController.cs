using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HarleeCreations.Crosscutting.Models.Theme;
using Microsoft.AspNetCore.Cors;
using HarleeCreations.Domain.Orchestrators;

namespace HarleeCreations.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors]
    public class ThemeController : ControllerBase
    {
        private ThemeOrchestrator orchestrator;

        public ThemeController()
        {
            orchestrator = new ThemeOrchestrator();
        }

        [HttpPost]
        public void AddColorScheme(ColorSchemeModel model)
        {
            orchestrator.AddColorScheme(model);
        }
    }
}
