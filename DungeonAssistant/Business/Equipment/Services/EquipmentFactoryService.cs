using Autofac;
using DungeonAssistant.Business.Commons.Models;
using DungeonAssistant.Business.Equipment.Interfaces;
using DungeonAssistant.Business.Equipment.Models;

namespace DungeonAssistant.Business.Equipment.Services;

public class EquipmentFactoryService : IEquipmentFactoryService
{
    private ILifetimeScope _scope;

    public EquipmentFactoryService(ILifetimeScope scope)
    {
        _scope = scope;
    }

    public IEquipmentModel GetEquipment()
    {
        //return _scope.Resolve<IEquipmentModel>();
        IEquipmentModel equipmentModel = new EquipmentModel();
        equipmentModel.Name = "Name";
        equipmentModel.Description.Add(new DescriptionModel("Description") );
        return equipmentModel;
    }
}
