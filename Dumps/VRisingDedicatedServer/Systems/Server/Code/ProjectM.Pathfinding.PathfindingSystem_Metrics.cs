using Unity.Entities;

namespace ProjectM.Pathfinding;


[UpdateInGroup(typeof(ProjectM.AiSubGroup2))]
[UpdateBefore(typeof(ProjectM.Pathfinding.PathfindingSystem))]
public class PathfindingSystem_Metrics : SystemBase
{
    EntityQuery __query_1460178926_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1460178926_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Pathfinding.PathRequest>(),
            },
        });
        
    }
    

}
