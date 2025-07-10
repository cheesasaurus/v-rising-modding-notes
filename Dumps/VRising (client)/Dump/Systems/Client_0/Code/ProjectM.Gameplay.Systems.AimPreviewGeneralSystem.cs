using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.AimPreviewGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class AimPreviewGeneralSystem : SystemBase
{
    EntityQuery _MainQuery;
    EntityQuery __query_673162304_0;
    EntityQuery __query_673162304_1;
    EntityQuery __query_673162304_2;
    EntityQuery __query_673162304_3;
    EntityQuery __query_673162304_4;
    EntityQuery __query_673162304_5;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _MainQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.AimPreview>(),
                ComponentType.ReadWrite<ProjectM.AimPreviewGeneral>(),
                ComponentType.ReadOnly<ProjectM.EntityOwner>(),
            },
        });
        
        __query_673162304_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.AimPreviewGeneral>(),
            },
        });
        
        __query_673162304_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.AimPreview>(),
                ComponentType.ReadWrite<ProjectM.AimPreviewGeneral>(),
                ComponentType.ReadOnly<ProjectM.EntityOwner>(),
            },
        });
        
        __query_673162304_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.AimPreviewsDisabled>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_673162304_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Tiles.TileWorldSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_673162304_4 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Physics.PhysicsWorldSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_673162304_5 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Core.PrefabLookupMap>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
