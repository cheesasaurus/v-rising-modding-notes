using Unity.Entities;

namespace ProjectM.Network;


[UpdateInGroup(typeof(ProjectM.SerializeGroup))]
[UpdateBefore(typeof(ProjectM.Network.PrioritizeSystem))]
[UpdateAfter(typeof(ProjectM.Network.SetupNetworkIdSystem_PreSerialize))]
[RequireMatchingQueriesForUpdateAttribute]
public class UpdateSnapshotsSystem : SystemBase
{
    EntityQuery _Query;
    EntityQuery __query_109787266_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.Networked>(),
                ComponentType.ReadWrite<ProjectM.Network.FrameChanged>(),
                ComponentType.ReadOnly<ProjectM.Network.NetworkId>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.DestroyedEntity>(),
            },
            Options = EntityQueryOptions.IncludeDestroyTag | EntityQueryOptions.IncludeAll,
        });
        
        __query_109787266_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.LogPrioritization>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
