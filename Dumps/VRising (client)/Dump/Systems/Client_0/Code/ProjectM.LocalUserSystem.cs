using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.DeserializeGroup))]
[UpdateAfter(typeof(ProjectM.EndDeserializeBarrier))]
[RequireMatchingQueriesForUpdateAttribute]
public class LocalUserSystem : SystemBase
{
    EntityQuery _CameraRequest;
    EntityQuery _SetLocalUserEventQuery;
    EntityQuery _UserQuery;
    EntityQuery _RunSystemQuery;
    EntityQuery __query_19701141_0;
    EntityQuery __query_19701141_1;
    EntityQuery __query_19701141_2;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _CameraRequest = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.CameraRequest>(),
            },
        });
        
        _SetLocalUserEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Network.SetLocalUserIndexEvent>(),
            },
        });
        
        _UserQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.User>(),
            },
        });
        
        _RunSystemQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            Any = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CameraRequest>(),
                ComponentType.ReadOnly<ProjectM.Network.SetLocalUserIndexEvent>(),
            },
        });
        
        __query_19701141_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.ClientNetworkState>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_19701141_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CameraRequest>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_19701141_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.LocalUser>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
