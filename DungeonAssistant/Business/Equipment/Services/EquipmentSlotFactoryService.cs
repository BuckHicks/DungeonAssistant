using Autofac;
using DungeonAssistant.Business.Equipment.Interfaces;
using DungeonAssistant.Business.Equipment.Models;

namespace DungeonAssistant.Business.Equipment.Services;

public class EquipmentSlotFactoryService : IEquipmentSlotFactoryService
{
    private ILifetimeScope _scope;
    private IEquipmentService _equipmentService;

    public EquipmentSlotFactoryService(ILifetimeScope scope, IEquipmentService equipmentService)
    {
        _scope = scope;
        _equipmentService = equipmentService;
    }

    public IEquipmentSlotModel GetEquipmentSlot()
    {
        return new EquipmentSlotModel(_equipmentService);
    }
}
