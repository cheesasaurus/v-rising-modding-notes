using Unity.Entities;

namespace ProjectM.Hybrid;


[UpdateInGroup(typeof(PresentationSystemGroup))]
[UpdateAfter(typeof(ProjectM.Hybrid.HybridModelSystem))]
public class HybridModelAlignToWorldSystem : SystemBase
{
    EntityQuery __query_59777279_0;
    EntityQuery __query_59777279_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_59777279_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Hybrid.HybridModelAlignToWorldComponent>(),
            },
        });
        
        __query_59777279_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Tiles.TileWorldSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
