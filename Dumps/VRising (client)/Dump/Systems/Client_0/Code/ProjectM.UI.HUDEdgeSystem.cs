using Unity.Entities;

namespace ProjectM.UI;


[UpdateInGroup(typeof(ProjectM.CharacterHUDGroup), OrderLast = true)]
public class HUDEdgeSystem : SystemBase
{
    EntityQuery __query_1956232776_0;
    EntityQuery __query_1956232776_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1956232776_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ScreenEdgeIcon>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
            },
        });
        
        __query_1956232776_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Terrain.TerrainChunkLookup>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
