using Unity.Entities;

namespace ProjectM.Network;


[UpdateInGroup(typeof(ProjectM.DeserializeGroup))]
[UpdateBefore(typeof(ProjectM.AfterDeserializationGroup))]
[UpdateAfter(typeof(ProjectM.EndDeserializeBarrier))]
[RequireMatchingQueriesForUpdateAttribute]
public class NetworkInterpolationSystem_Client : SystemBase
{
    EntityQuery __query_1748990320_0;
    EntityQuery __query_1748990320_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1748990320_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.EntityInput>(),
                ComponentType.ReadOnly<ProjectM.Network.NetworkInterpolated_Shared>(),
                ComponentType.ReadWrite<ProjectM.Network.NetworkInterpolated_Client>(),
                ComponentType.ReadWrite<ProjectM.LastTranslation>(),
                ComponentType.ReadWrite<ProjectM.Velocity>(),
                ComponentType.ReadWrite<Unity.Transforms.Rotation>(),
                ComponentType.ReadWrite<Unity.Transforms.Translation>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.LocalControlled>(),
                ComponentType.ReadOnly<Unity.Entities.DestroyTag>(),
            },
            Options = EntityQueryOptions.IncludeSpawnTag | EntityQueryOptions.IncludeAll,
        });
        
        __query_1748990320_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.DisableNetworkInterpolation>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
