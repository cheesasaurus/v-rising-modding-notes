using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class EquipServantItemFromInventorySystem : SystemBase
{
    EntityQuery _Query;
    EntityQuery _EquipmentImpairedBuffs;
    EntityQuery __query_1850506269_0;
    EntityQuery __query_1850506269_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.Network.EquipServantItemFromInventoryEvent>(),
            },
        });
        
        _EquipmentImpairedBuffs = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadOnly<ProjectM.EquipmentImpairedBuff>(),
            },
        });
        
        __query_1850506269_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadWrite<ProjectM.Network.EquipServantItemFromInventoryEvent>(),
            },
        });
        
        __query_1850506269_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.NetworkIdSystem.Singleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
