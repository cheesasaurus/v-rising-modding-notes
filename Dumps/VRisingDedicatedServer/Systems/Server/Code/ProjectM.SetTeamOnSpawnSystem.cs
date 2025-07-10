using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup), OrderLast = true)]
[RequireMatchingQueriesForUpdateAttribute]
public class SetTeamOnSpawnSystem : SystemBase
{
    EntityQuery __query_57018132_0;
    EntityQuery __query_57018132_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_57018132_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Team>(),
                ComponentType.ReadWrite<ProjectM.TeamReference>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
        __query_57018132_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.FactionReference>(),
                ComponentType.ReadWrite<ProjectM.Team>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
    }
    

}
