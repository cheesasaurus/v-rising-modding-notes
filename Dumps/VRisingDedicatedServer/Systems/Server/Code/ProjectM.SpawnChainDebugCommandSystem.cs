using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ConsoleCommandGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class SpawnChainDebugCommandSystem : ProjectM.ConsoleCommandSystem
{
    EntityQuery __query_1780078534_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1780078534_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.SpawnChainDebugEnabled>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
