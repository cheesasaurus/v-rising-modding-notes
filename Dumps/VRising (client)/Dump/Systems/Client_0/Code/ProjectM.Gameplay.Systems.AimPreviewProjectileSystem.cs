using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.AimPreviewGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class AimPreviewProjectileSystem : SystemBase
{
    EntityQuery _AimPreviewProjectileQuery;
    EntityQuery __query_367403051_0;
    EntityQuery __query_367403051_1;
    EntityQuery __query_367403051_2;
    EntityQuery __query_367403051_3;
    EntityQuery __query_367403051_4;
    EntityQuery __query_367403051_5;
    EntityQuery __query_367403051_6;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _AimPreviewProjectileQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.AimPreview>(),
                ComponentType.ReadWrite<ProjectM.AimPreviewProjectile>(),
                ComponentType.ReadOnly<ProjectM.EntityOwner>(),
            },
        });
        
        __query_367403051_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.AimPreview>(),
                ComponentType.ReadWrite<ProjectM.AimPreviewProjectile>(),
                ComponentType.ReadOnly<ProjectM.EntityOwner>(),
            },
        });
        
        __query_367403051_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.AimPreviewsDisabled>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_367403051_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Shared.SpellModCollectionData>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_367403051_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CurveCollection>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_367403051_4 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Physics.PhysicsWorldSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_367403051_5 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ServerTime>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_367403051_6 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Tiles.TileWorldSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
