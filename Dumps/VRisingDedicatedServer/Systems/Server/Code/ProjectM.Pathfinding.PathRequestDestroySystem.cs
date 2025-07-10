using Unity.Entities;

namespace ProjectM.Pathfinding;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class PathRequestDestroySystem : SystemBase
{
    EntityQuery __query_1460178995_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1460178995_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Pathfinding.PathRequest>(),
            },
        });
        
    }
    

}
