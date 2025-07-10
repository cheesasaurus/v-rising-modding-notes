using Unity.Entities;

namespace ProjectM.Presentation;


[UpdateInGroup(typeof(PresentationSystemGroup))]
[UpdateBefore(typeof(ProjectM.Presentation.ProxyPrefabSystem))]
[UpdateBefore(typeof(ProjectM.UIGroup))]
[UpdateAfter(typeof(ProjectM.Presentation.AnimateFadeOutSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class CustomCullingSystem : SystemBase
{
    EntityQuery __query_1815674686_0;
    EntityQuery __query_1815674686_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1815674686_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Presentation.ShaderProperty_DitherAlpha>(),
                ComponentType.ReadWrite<Unity.Rendering.CustomCulling>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Rendering.DisableRendering>(),
            },
        });
        
        __query_1815674686_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<Unity.Rendering.CustomCulling>(),
                ComponentType.ReadOnly<Unity.Transforms.LocalToWorld>(),
                ComponentType.ReadOnly<ProjectM.ProxyPrefab>(),
                ComponentType.ReadOnly<ProjectM.Presentation.DistanceCulling>(),
            },
        });
        
    }
    

}
