using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class EquipItemSystem : SystemBase
{
    EntityQuery _EventQuery;
    EntityQuery _EquipmentImpairedBuffs;
    EntityQuery __query_1850505309_0;
    EntityQuery __query_1850505309_1;
    EntityQuery __query_1850505309_2;
    EntityQuery __query_1850505309_3;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _EventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.Network.EquipItemEvent>(),
            },
        });
        
        _EquipmentImpairedBuffs = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadOnly<ProjectM.EquipmentImpairedBuff>(),
            },
        });
        
        __query_1850505309_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.Network.EquipItemEvent>(),
            },
        });
        
        __query_1850505309_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CreateGameplayEventOnItemEquipped>(),
            },
        });
        
        __query_1850505309_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ServerRootPrefabCollection>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1850505309_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ServerGameBalanceSettings>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
