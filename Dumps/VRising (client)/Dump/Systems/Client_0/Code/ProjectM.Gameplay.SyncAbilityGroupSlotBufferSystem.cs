using Unity.Entities;

namespace ProjectM.Gameplay;


[UpdateInGroup(typeof(ProjectM.ReactToDeserializeGroup))]
public class SyncAbilityGroupSlotBufferSystem : SystemBase
{
    EntityQuery _Query;
    EntityQuery __query_1419277354_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.AbilityGroupSlot>(),
                ComponentType.ReadOnly<ProjectM.Network.ClientNetworkSnapshotState>(),
            },
            Options = EntityQueryOptions.IncludeSpawnTag | EntityQueryOptions.IncludeAll,
        });
        
        __query_1419277354_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.AbilityGroupSlot>(),
                ComponentType.ReadOnly<ProjectM.Network.ClientNetworkSnapshotState>(),
            },
            Options = EntityQueryOptions.IncludeSpawnTag | EntityQueryOptions.IncludeAll,
        });
        
    }
    

}
