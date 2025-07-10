using Unity.Entities;

namespace ProjectM.Hybrid;


[UpdateInGroup(typeof(PresentationSystemGroup))]
[UpdateAfter(typeof(ProjectM.Hybrid.HybridModelSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class HybridBoneRopeSystem : SystemBase
{
    EntityQuery __query_544736127_0;
    EntityQuery __query_544736127_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_544736127_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Hybrid.StunclothBoneRopeComponent>(),
            },
        });
        
        __query_544736127_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Tiles.TileWorldSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
