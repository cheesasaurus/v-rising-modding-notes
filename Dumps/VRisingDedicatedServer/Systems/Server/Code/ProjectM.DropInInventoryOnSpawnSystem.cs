using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class DropInInventoryOnSpawnSystem : SystemBase
{
    EntityQuery _Query;
    EntityQuery __query_956176632_0;
    EntityQuery __query_956176632_1;
    EntityQuery __query_956176632_2;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.DropInInventoryOnSpawn>(),
                ComponentType.ReadOnly<ProjectM.InventoryInstanceElement>(),
                ComponentType.ReadOnly<ProjectM.Shared.DropTableBuffer>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
        __query_956176632_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.DropInInventoryOnSpawn>(),
                ComponentType.ReadOnly<ProjectM.InventoryInstanceElement>(),
                ComponentType.ReadOnly<ProjectM.Shared.DropTableBuffer>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
        __query_956176632_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ServerGameBalanceSettings>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_956176632_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Shared.RelicDropped>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
