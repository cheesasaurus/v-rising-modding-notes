using Unity.Entities;

namespace ProjectM.Presentation;


[UpdateInGroup(typeof(PresentationSystemGroup))]
[UpdateAfter(typeof(ProjectM.CameraPresentationGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class CloudCookieSystem : SystemBase
{
    EntityQuery _CloudVolumeQuery;
    EntityQuery __query_103585662_0;
    EntityQuery __query_103585662_1;
    EntityQuery __query_103585662_2;
    EntityQuery __query_103585662_3;
    EntityQuery __query_103585662_4;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _CloudVolumeQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.DynamicCloudVolume>(),
                ComponentType.ReadOnly<Unity.Transforms.LocalToWorld>(),
            },
        });
        
        __query_103585662_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Presentation.MoodManagerComponent>(),
            },
        });
        
        __query_103585662_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CloudCookie>(),
                ComponentType.ReadOnly<Unity.Transforms.LocalToWorld>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CloudLight>(),
            },
        });
        
        __query_103585662_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CloudCookie>(),
                ComponentType.ReadOnly<Unity.Transforms.LocalToWorld>(),
                ComponentType.ReadOnly<ProjectM.CloudLight>(),
            },
        });
        
        __query_103585662_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.DynamicCloudVolume>(),
                ComponentType.ReadOnly<Unity.Transforms.LocalToWorld>(),
            },
        });
        
        __query_103585662_4 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.DayNightCycle>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
