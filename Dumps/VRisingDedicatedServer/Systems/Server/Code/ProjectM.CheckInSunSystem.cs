using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ScheduleGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class CheckInSunSystem : SystemBase
{
    EntityQuery _DynamicCloudVolumeQuery;
    EntityQuery _RaycastJobQuery;
    EntityQuery __query_1202091801_0;
    EntityQuery __query_1202091801_1;
    EntityQuery __query_1202091801_2;
    EntityQuery __query_1202091801_3;
    EntityQuery __query_1202091801_4;
    EntityQuery __query_1202091801_5;
    EntityQuery __query_1202091801_6;
    EntityQuery __query_1202091801_7;
    EntityQuery __query_1202091801_8;
    EntityQuery __query_1202091801_9;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _DynamicCloudVolumeQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.DynamicCloudVolume>(),
                ComponentType.ReadOnly<Unity.Transforms.LocalToWorld>(),
            },
        });
        
        _RaycastJobQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.TakeDamageInSun>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Dead>(),
            },
        });
        
        __query_1202091801_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.TakeDamageInSun>(),
            },
        });
        
        __query_1202091801_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.TakeDamageInSun>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
                ComponentType.ReadOnly<ProjectM.BuffBuffer>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.IsConnected>(),
            },
        });
        
        __query_1202091801_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CloudCookie>(),
                ComponentType.ReadOnly<Unity.Transforms.LocalToWorld>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CloudLight>(),
            },
        });
        
        __query_1202091801_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CloudCookie>(),
                ComponentType.ReadOnly<Unity.Transforms.LocalToWorld>(),
                ComponentType.ReadOnly<ProjectM.CloudLight>(),
            },
        });
        
        __query_1202091801_4 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.TakeDamageInSun>(),
                ComponentType.ReadOnly<ProjectM.BuffableFlagState>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
            },
        });
        
        __query_1202091801_5 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.SunBlocker.SunBlockerRegion>(),
            },
        });
        
        __query_1202091801_6 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.DayNightCycle>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1202091801_7 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.CastleBlockCollection>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1202091801_8 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Sun>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1202091801_9 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Physics.PhysicsWorldSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
