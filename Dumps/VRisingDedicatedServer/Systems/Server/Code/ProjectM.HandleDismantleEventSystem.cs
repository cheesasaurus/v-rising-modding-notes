using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class HandleDismantleEventSystem : SystemBase
{
    EntityQuery _QueryDismantleEvent;
    EntityQuery __query_1312974960_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _QueryDismantleEvent = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.DismantleEvent>(),
            },
        });
        
        __query_1312974960_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ServerTime>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
