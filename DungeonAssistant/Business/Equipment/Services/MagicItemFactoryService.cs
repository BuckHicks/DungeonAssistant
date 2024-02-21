using Autofac;
using DungeonAssistant.Business.Equipment.Interfaces;

namespace DungeonAssistant.Business.Equipment.Services;

public class MagicItemFactoryService : IMagicItemFactoryService
{
    private ILifetimeScope _scope;

    public MagicItemFactoryService(ILifetimeScope scope)
    {
        _scope = scope;
    }

    public IMagicItemModel GetMagicItem()
    {
        return _scope.Resolve<IMagicItemModel>();
    }
}
