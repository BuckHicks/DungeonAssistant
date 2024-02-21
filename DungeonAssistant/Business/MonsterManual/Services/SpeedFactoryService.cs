using Autofac;
using DungeonAssistant.Business.MonsterManual.Interfaces;

namespace DungeonAssistant.Business.MonsterManual.Services;

public class SpeedFactoryService : ISpeedFactoryService
{
    private ILifetimeScope _scope;

    public SpeedFactoryService(ILifetimeScope scope)
    {
        _scope = scope;
    }

    public ISpeedModel GetSpeed()
    {
        return _scope.Resolve<ISpeedModel>();
    }
}
