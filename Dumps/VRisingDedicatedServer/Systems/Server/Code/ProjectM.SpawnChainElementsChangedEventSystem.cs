using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class SpawnChainElementsChangedEventSystem : SystemBase
{
    EntityQuery _EventQuery;
    EntityQuery __query_1228365453_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _EventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.SpawnChainData.ActiveElementsChangedEvent>(),
            },
        });
        
        __query_1228365453_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.SpawnChainData.ActiveElementsChangedEvent>(),
            },
        });
        
    }
    

}
