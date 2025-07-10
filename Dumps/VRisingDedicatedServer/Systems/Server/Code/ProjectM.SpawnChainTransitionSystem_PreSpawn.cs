using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.BeforeSpawnGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class SpawnChainTransitionSystem_PreSpawn : ProjectM.SpawnChainTransitionSystem
{
    EntityQuery _EventQuery;
    EntityQuery __query_1214202408_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _EventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.SpawnChainTransitionEvent>(),
            },
        });
        
        __query_1214202408_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.SpawnChainTransitionEvent>(),
            },
        });
        
    }
    

}
