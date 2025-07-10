using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.StartSimulationNetworkGroup))]
[UpdateAfter(typeof(ProjectM.ServerBootstrapSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class PlatformUserBlockSystem_Server : SystemBase
{
    EntityQuery _Query;
    EntityQuery __query_1455263670_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.Network.PlatformUserBlockCheckEvent>(),
            },
        });
        
        __query_1455263670_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.User>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeSpawnTag | EntityQueryOptions.IncludeAll,
        });
        
    }
    

}
