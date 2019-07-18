using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SurveyQuestionaire.Startup))]
namespace SurveyQuestionaire
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
