using Core.Resources.Framework.Base;

namespace Core.Plugins.OnDemand;

public interface IOnDemandPlugin : IPlugin
{
    public void PreInitialize();
    public Task Initialize(BaseProfile Profile);
}
