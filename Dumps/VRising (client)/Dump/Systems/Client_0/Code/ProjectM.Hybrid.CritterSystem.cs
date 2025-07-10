using Unity.Entities;

namespace ProjectM.Hybrid;


[UpdateInGroup(typeof(PresentationSystemGroup))]
[UpdateAfter(typeof(ProjectM.Hybrid.HybridModelSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class CritterSystem : SystemBase
{
    EntityQuery _LocalPlayerQuery;
    EntityQuery _HybridCritterComponentQuery;
    EntityQuery _CritterDataQuery;
    EntityQuery __query_202659417_0;
    EntityQuery __query_202659417_1;
    EntityQuery __query_202659417_2;
    EntityQuery __query_202659417_3;
    EntityQuery __query_202659417_4;
    EntityQuery __query_202659417_5;
    EntityQuery __query_202659417_6;
    EntityQuery __query_202659417_7;
    EntityQuery __query_202659417_8;
    EntityQuery __query_202659417_9;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _LocalPlayerQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Controller>(),
                ComponentType.ReadWrite<ProjectM.Network.LocalUser>(),
            },
        });
        
        _HybridCritterComponentQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<HybridCritterComponent>(),
            },
        });
        
        _CritterDataQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CritterData>(),
            },
        });
        
        __query_202659417_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Hybrid.HybridModel>(),
                ComponentType.ReadWrite<HybridCritterComponent>(),
            },
        });
        
        __query_202659417_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Hybrid.HybridModelDOTSAnimator>(),
                ComponentType.ReadWrite<ProjectM.Hybrid.HybridModel>(),
                ComponentType.ReadOnly<HybridCritterTag>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<HybridCritterComponent>(),
            },
        });
        
        __query_202659417_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.CritterData>(),
                ComponentType.ReadWrite<Unity.Transforms.Rotation>(),
                ComponentType.ReadWrite<Unity.Transforms.Translation>(),
                ComponentType.ReadOnly<Unity.Transforms.LocalToWorld>(),
            },
        });
        
        __query_202659417_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CritterData>(),
            },
        });
        
        __query_202659417_4 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CritterData>(),
                ComponentType.ReadOnly<ProjectM.Height>(),
                ComponentType.ReadWrite<ProjectM.Shared.FallToHeight>(),
                ComponentType.ReadWrite<Unity.Transforms.Translation>(),
            },
        });
        
        __query_202659417_5 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<HybridCritterComponent>(),
            },
        });
        
        __query_202659417_6 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CritterData>(),
            },
        });
        
        __query_202659417_7 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Tiles.TileWorldSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_202659417_8 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Core.PrefabLookupMap>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_202659417_9 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Physics.PhysicsWorldSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
