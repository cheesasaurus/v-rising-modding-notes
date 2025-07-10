using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.PrefabInitializationGroup))]
[UpdateAfter(typeof(ProjectM.RegisterRenderMeshPrefabsSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class HideOutsideVisionKeywordSystem : SystemBase
{
    EntityQuery _Query;
    EntityQuery __query_583691388_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<Unity.Rendering.MaterialMeshInfo>(),
                ComponentType.ReadOnly<ProjectM.HideRendererOutsideVision>(),
                ComponentType.ReadOnly<Unity.Entities.Prefab>(),
            },
        });
        
        __query_583691388_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<Unity.Rendering.MaterialMeshInfo>(),
                ComponentType.ReadOnly<ProjectM.HideRendererOutsideVision>(),
                ComponentType.ReadOnly<Unity.Entities.Prefab>(),
            },
        });
        
    }
    

}
