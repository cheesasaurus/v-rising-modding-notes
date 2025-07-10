using Unity.Entities;

namespace ProjectM.CastleBuilding.Rebuilding;


[UpdateInGroup(typeof(ProjectM.ReactToDestroyTagGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class CastleRebuildRegistryOnDestroySystem : SystemBase
{
    EntityQuery _HeartQuery;
    EntityQuery _CommonQuery;
    EntityQuery _UniqueQuery;
    EntityQuery __query_1821521061_0;
    EntityQuery __query_1821521061_1;
    EntityQuery __query_1821521061_2;
    EntityQuery __query_1821521061_3;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _HeartQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.CastleHeart>(),
                ComponentType.ReadOnly<Unity.Entities.DestroyTag>(),
            },
        });
        
        _CommonQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.CastleHeartConnection>(),
                ComponentType.ReadOnly<Stunlock.Core.PrefabGUID>(),
                ComponentType.ReadOnly<ProjectM.CastleBuilding.Rebuilding.CastleRebuildCommonTag>(),
                ComponentType.ReadOnly<Unity.Entities.DestroyTag>(),
            },
        });
        
        _UniqueQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.CastleHeartConnection>(),
                ComponentType.ReadOnly<ProjectM.CastleBuilding.Rebuilding.CastleRebuildUniqueKey>(),
                ComponentType.ReadOnly<ProjectM.CastleBuilding.Rebuilding.CastleRebuildUniqueTag>(),
                ComponentType.ReadOnly<Unity.Entities.DestroyTag>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.Rebuilding.CastleRebuildRegistryOnDestroySystem.CastleRebuildUniqueSourceRemoved>(),
            },
        });
        
        __query_1821521061_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.CastleHeart>(),
                ComponentType.ReadOnly<Unity.Entities.DestroyTag>(),
            },
        });
        
        __query_1821521061_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.CastleHeartConnection>(),
                ComponentType.ReadOnly<Stunlock.Core.PrefabGUID>(),
                ComponentType.ReadOnly<ProjectM.CastleBuilding.Rebuilding.CastleRebuildCommonTag>(),
                ComponentType.ReadOnly<Unity.Entities.DestroyTag>(),
            },
        });
        
        __query_1821521061_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.CastleHeartConnection>(),
                ComponentType.ReadOnly<ProjectM.CastleBuilding.Rebuilding.CastleRebuildUniqueKey>(),
                ComponentType.ReadOnly<ProjectM.CastleBuilding.Rebuilding.CastleRebuildUniqueTag>(),
                ComponentType.ReadOnly<Unity.Entities.DestroyTag>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.Rebuilding.CastleRebuildRegistryOnDestroySystem.CastleRebuildUniqueSourceRemoved>(),
            },
        });
        
        __query_1821521061_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.CastleHeartConnection>(),
                ComponentType.ReadOnly<ProjectM.CastleBuilding.Rebuilding.CastleRebuildUniqueKey>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Entities.DestroyTag>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
    }
    

}
