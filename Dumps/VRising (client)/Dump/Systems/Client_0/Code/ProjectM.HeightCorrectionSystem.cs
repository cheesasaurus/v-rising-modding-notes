using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[UpdateAfter(typeof(ProjectM.MapCollisionSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class HeightCorrectionSystem : SystemBase
{
    EntityQuery __query_496388984_0;
    EntityQuery __query_496388984_1;
    EntityQuery __query_496388984_2;
    EntityQuery __query_496388984_3;
    EntityQuery __query_496388984_4;
    EntityQuery __query_496388984_5;
    EntityQuery __query_496388984_6;
    EntityQuery __query_496388984_7;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_496388984_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Height>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.IsConnected>(),
            },
        });
        
        __query_496388984_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Height>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
                ComponentType.ReadOnly<ProjectM.Network.IsConnected>(),
            },
        });
        
        __query_496388984_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Height>(),
                ComponentType.ReadOnly<ProjectM.BuffableFlagState>(),
                ComponentType.ReadWrite<Unity.Transforms.Translation>(),
                ComponentType.ReadOnly<ProjectM.SnapToHeight>(),
            },
        });
        
        __query_496388984_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Height>(),
                ComponentType.ReadOnly<ProjectM.Velocity>(),
                ComponentType.ReadOnly<ProjectM.BuffableFlagState>(),
                ComponentType.ReadWrite<ProjectM.Shared.FallToHeight>(),
                ComponentType.ReadWrite<Unity.Transforms.Translation>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CanFly>(),
            },
        });
        
        __query_496388984_4 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Height>(),
                ComponentType.ReadOnly<ProjectM.Velocity>(),
                ComponentType.ReadOnly<ProjectM.BuffableFlagState>(),
                ComponentType.ReadWrite<ProjectM.CanFly>(),
                ComponentType.ReadWrite<ProjectM.Shared.FallToHeight>(),
                ComponentType.ReadWrite<Unity.Transforms.Translation>(),
            },
        });
        
        __query_496388984_5 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Physics.PhysicsWorldSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_496388984_6 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Tiles.TileWorldSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_496388984_7 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CurveCollection>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
