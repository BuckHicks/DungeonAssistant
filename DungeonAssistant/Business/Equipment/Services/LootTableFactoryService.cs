using Autofac;
using DungeonAssistant.Business.Equipment.Interfaces;
using DungeonAssistant.Business.Equipment.Models;

namespace DungeonAssistant.Business.Equipment.Services;

public class LootTableFactoryService : ILootTableFactoryService
{
    private ILifetimeScope _scope;
    private IEquipmentService _equipmentService;

    public LootTableFactoryService(ILifetimeScope scope, IEquipmentService equipmentService)
    {
        _scope = scope;
        _equipmentService = equipmentService;
    }

    public ILootTableModel GetLootTable()
    {
        IEquipmentSlotModel equipmentSlotModel = new EquipmentSlotModel(_equipmentService);

        ILootTableModel lootTableModel = new LootTableModel();
        lootTableModel.EquipmentSlots = new List<IEquipmentSlotModel>();
        lootTableModel.Name = "Name";
        lootTableModel.Description = "Description";
        return lootTableModel;
    }
}
