using Unity.Entities;

namespace ProjectM.Pathfinding;


[UpdateInGroup(typeof(ProjectM.AiSubGroup2))]
[RequireMatchingQueriesForUpdateAttribute]
public class PathfindingSystem : SystemBase
{
    EntityQuery __query_1460178784_0;
    EntityQuery __query_1460178784_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1460178784_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Pathfinding.PathRequest>(),
            },
        });
        
        __query_1460178784_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Tiles.TileWorldSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
