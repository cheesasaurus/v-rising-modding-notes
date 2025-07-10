using Unity.Entities;

namespace ProjectM.Replays;


[UpdateInGroup(typeof(ProjectM.FinalizeGroup_Client))]
[RequireMatchingQueriesForUpdateAttribute]
public class ClientReplayRecorderSystem : SystemBase
{
    EntityQuery _ReplaySnapshotEvent;
    EntityQuery _HailMessageQuery;
    EntityQuery __query_42786501_0;
    EntityQuery __query_42786501_1;
    EntityQuery __query_42786501_2;
    EntityQuery __query_42786501_3;
    EntityQuery __query_42786501_4;
    EntityQuery __query_42786501_5;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _ReplaySnapshotEvent = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Replays.ReplayStoreSnapshotEvent>(),
                ComponentType.ReadWrite<ProjectM.Replays.ReplayStoreSnapshotEventBuffer>(),
                ComponentType.ReadWrite<ProjectM.Replays.ReplayScreenshotBuffer>(),
            },
        });
        
        _HailMessageQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.HailMessage>(),
                ComponentType.ReadOnly<ProjectM.Network.HailMessageBuffer>(),
            },
        });
        
        __query_42786501_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.HailMessage>(),
                ComponentType.ReadOnly<ProjectM.Network.HailMessageBuffer>(),
            },
        });
        
        __query_42786501_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Replays.ReplayStoreSnapshotEvent>(),
                ComponentType.ReadWrite<ProjectM.Replays.ReplayStoreSnapshotEventBuffer>(),
                ComponentType.ReadWrite<ProjectM.Replays.ReplayScreenshotBuffer>(),
            },
        });
        
        __query_42786501_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.LocalUser>(),
            },
        });
        
        __query_42786501_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.ReceivedPacket>(),
                ComponentType.ReadWrite<ProjectM.Network.ReceivedPacketBuffer>(),
            },
        });
        
        __query_42786501_4 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Replays.ClientReplayRecorderEnabled>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_42786501_5 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Replays.ClientReplayRecorderEnabled>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
