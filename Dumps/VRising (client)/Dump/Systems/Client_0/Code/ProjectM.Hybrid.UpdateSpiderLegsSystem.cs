using Unity.Entities;

namespace ProjectM.Hybrid;


[UpdateInGroup(typeof(ProjectM.GetHybridDataGroup))]
[UpdateAfter(typeof(ProjectM.Hybrid.GetSpiderLegsSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class UpdateSpiderLegsSystem : SystemBase
{
    EntityQuery __query_2132794233_0;
    EntityQuery __query_2132794233_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_2132794233_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Hybrid.HybridModel>(),
                ComponentType.ReadWrite<ProjectM.Hybrid.SpiderLegsDriver>(),
                ComponentType.ReadWrite<ProjectM.Hybrid.SpiderLeg>(),
                ComponentType.ReadOnly<ProjectM.Hybrid.HybridIKSpiderLegs>(),
            },
        });
        
        __query_2132794233_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Tiles.TileWorldSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
