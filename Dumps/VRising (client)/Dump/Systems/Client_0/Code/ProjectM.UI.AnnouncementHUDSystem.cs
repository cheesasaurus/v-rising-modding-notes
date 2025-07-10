using Unity.Entities;

namespace ProjectM.UI;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class AnnouncementHUDSystem : SystemBase
{
    EntityQuery __query_249625573_0;
    EntityQuery __query_249625573_1;
    EntityQuery __query_249625573_2;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_249625573_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.UI.UICanvasBase>(),
            },
        });
        
        __query_249625573_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Terrain.TerrainChunkLookup>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_249625573_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.LocalControlled>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
