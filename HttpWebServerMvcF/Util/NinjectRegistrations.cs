using HttpWebServerMvcF.BL;
using HttpWebServerMvcF.DAL;
using HttpWebServerMvcF.Infrastructure;
using Ninject.Modules;

namespace HttpWebServerMvcF.Util
{
    public class NinjectRegistrations : NinjectModule
    {
        public override void Load()
        {
            Bind<ILogger>().To<Logger>();
            Bind<IParticipantRepository>().To<ParticipantRepository>();
            Bind<IParticipantsService>().To<ParticipantsService>();
            Bind<IPartiesRepository>().To<PartiesRepository>();
            Bind<IPartiesService>().To<PartiesService>();
        }
    }
}