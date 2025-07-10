using Unity.Entities;

namespace ProjectM.CastleBuilding.Systems;


[UpdateInGroup(typeof(ProjectM.BeforeSerializeBarrierGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class AssetSwappingSystem : SystemBase
{
    EntityQuery __query_960380733_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_960380733_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.AssetSwapping.AssetSwapState>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeSpawnTag | EntityQueryOptions.IncludeAll,
        });
        
    }
    

}
