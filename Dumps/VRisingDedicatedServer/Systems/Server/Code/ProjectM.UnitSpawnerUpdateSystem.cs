using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class UnitSpawnerUpdateSystem : SystemBase
{
    EntityQuery _Query;
    EntityQuery __query_2099431916_0;
    EntityQuery __query_2099431916_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.UnitSpawnerstation>(),
                ComponentType.ReadOnly<ProjectM.EditableTileModel>(),
                ComponentType.ReadOnly<ProjectM.CastleWorkstation>(),
                ComponentType.ReadOnly<ProjectM.InventoryOwner>(),
                ComponentType.ReadOnly<ProjectM.StationBonusBuffer>(),
                ComponentType.ReadOnly<ProjectM.RefinementstationRecipesBuffer>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
        __query_2099431916_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.UnitSpawnerstation>(),
                ComponentType.ReadOnly<ProjectM.EditableTileModel>(),
                ComponentType.ReadOnly<ProjectM.CastleWorkstation>(),
                ComponentType.ReadOnly<ProjectM.InventoryOwner>(),
                ComponentType.ReadOnly<ProjectM.StationBonusBuffer>(),
                ComponentType.ReadOnly<ProjectM.RefinementstationRecipesBuffer>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
        __query_2099431916_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Core.PrefabLookupMap>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
