using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class SpawnTeamSystem : SystemBase
{
    EntityQuery _Query;
    EntityQuery __query_57017908_0;
    EntityQuery __query_57017908_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.TeamData>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
        __query_57017908_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.TeamData>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
        __query_57017908_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Team>(),
                ComponentType.ReadOnly<ProjectM.TeamReference>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
    }
    

}
