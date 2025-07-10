using Unity.Entities;

namespace ProjectM.Presentation;


[UpdateInGroup(typeof(PresentationSystemGroup), OrderFirst = true)]
[UpdateBefore(typeof(ProjectM.FluffGroup))]
[UpdateAfter(typeof(ProjectM.Presentation.OccluderRasterizationSystem))]
public class OccluderRasterizationDebugSystem : SystemBase
{
    EntityQuery __query_839343228_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_839343228_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Entities.Graphics.Extension.OcclusionCullingUtility.DepthTextureData>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
