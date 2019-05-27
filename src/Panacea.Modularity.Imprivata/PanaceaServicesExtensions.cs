using Panacea.Core;
using System.Linq;

namespace Panacea.Modularity.Imprivata
{
    public static class PanaceaServicesExtensions
    {
        public static IImprivataPlugin GetImprivata(this PanaceaServices core)
        {
            return core.PluginLoader.GetPlugin<IImprivataPlugin>();
        }

        public static bool TryGetImprivata(this PanaceaServices core, out IImprivataPlugin plugin)
        {
            plugin = null;
            var imprivata = core.PluginLoader.GetPlugins<IImprivataPlugin>().FirstOrDefault();
            if (imprivata == null)
            {
                return false;
            }
            plugin = imprivata;
            return true;
        }
    }
}
