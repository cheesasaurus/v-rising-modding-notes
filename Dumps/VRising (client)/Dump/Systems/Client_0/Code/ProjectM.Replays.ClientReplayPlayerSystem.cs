using Unity.Entities;

namespace ProjectM.Replays;


[UpdateInGroup(typeof(ProjectM.DeserializeGroup))]
[UpdateBefore(typeof(ProjectM.Network.ReceivePacketSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class ClientReplayPlayerSystem : SystemBase
{
    EntityQuery _ReplayJumpToSnapshotEvent;
    EntityQuery __query_248749947_0;
    EntityQuery __query_248749947_1;
    EntityQuery __query_248749947_2;
    EntityQuery __query_248749947_3;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _ReplayJumpToSnapshotEvent = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Replays.ReplayJumpToSnapshotEvent>(),
            },
        });
        
        __query_248749947_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Replays.ClientReplayPlayerEnabled>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_248749947_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Replays.ClientReplayPlayerEnabled>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_248749947_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.LocalUser>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_248749947_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.NetworkIdSystem.Singleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
