using Unity.Entities;

namespace ProjectM.Presentation;


[UpdateInGroup(typeof(ProjectM.ScheduleBeforeUIGroup))]
public class OcclusionCullingSystem : SystemBase
{
    EntityQuery _ProxyLightOcclusionTestQuery;
    EntityQuery __query_456802355_0;
    EntityQuery __query_456802355_1;
    EntityQuery __query_456802355_2;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _ProxyLightOcclusionTestQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<Unity.Rendering.OcclusionCulling>(),
                ComponentType.ReadOnly<Unity.Transforms.LocalToWorld>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Rendering.DisableRendering>(),
            },
        });
        
        __query_456802355_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Entities.Graphics.Extension.OcclusionCullingUtility.DepthTextureData>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_456802355_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Presentation.OcclusionCullingSystemDependency>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_456802355_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Presentation.OcclusionCullingSystemDependency>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
