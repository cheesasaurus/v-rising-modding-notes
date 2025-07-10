using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.AimPreviewGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class AimPreviewTravelBuffSystem : SystemBase
{
    EntityQuery __query_1371543947_0;
    EntityQuery __query_1371543947_1;
    EntityQuery __query_1371543947_2;
    EntityQuery __query_1371543947_3;
    EntityQuery __query_1371543947_4;
    EntityQuery __query_1371543947_5;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1371543947_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.AimPreview>(),
                ComponentType.ReadWrite<ProjectM.AimPreviewTravelBuff>(),
                ComponentType.ReadOnly<ProjectM.EntityOwner>(),
            },
        });
        
        __query_1371543947_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.AimPreviewTravelBuff>(),
            },
        });
        
        __query_1371543947_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.AimPreviewsDisabled>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1371543947_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Tiles.TileWorldSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1371543947_4 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Physics.PhysicsWorldSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1371543947_5 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Core.PrefabLookupMap>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
