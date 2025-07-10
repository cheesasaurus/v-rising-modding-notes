using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
public class UpdateMicroPOIManagerSystem : SystemBase
{
    EntityQuery _MainQuery;
    EntityQuery __query_1300366848_0;
    EntityQuery __query_1300366848_1;
    EntityQuery __query_1300366848_2;
    EntityQuery __query_1300366848_3;
    EntityQuery __query_1300366848_4;
    EntityQuery __query_1300366848_5;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _MainQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.MicroPOIManager>(),
                ComponentType.ReadOnly<ProjectM.MicroPOIManagerConfig>(),
                ComponentType.ReadOnly<Unity.Transforms.LocalToWorld>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Core.Authoring.WaitingForBaking>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
        __query_1300366848_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.MicroPOIManager>(),
                ComponentType.ReadOnly<ProjectM.MicroPOIManagerConfig>(),
                ComponentType.ReadOnly<Unity.Transforms.LocalToWorld>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Core.Authoring.WaitingForBaking>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
        __query_1300366848_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Core.PrefabLookupMap>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1300366848_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ServerTime>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1300366848_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.MapZoneCollection>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1300366848_4 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.UserActivityGrid>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1300366848_5 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.DestroyBarrier.Singleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
