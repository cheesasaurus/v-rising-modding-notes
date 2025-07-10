using Unity.Entities;

namespace ProjectM.Hybrid;


[UpdateInGroup(typeof(ProjectM.SetHybridDataGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class GetAndSetHybridModelTransformSystem : SystemBase
{
    EntityQuery _HybridModelQuery;
    EntityQuery __query_2106995374_0;
    EntityQuery __query_2106995374_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _HybridModelQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Transforms.LocalToWorld>(),
                ComponentType.ReadOnly<ProjectM.Hybrid.HybridModelUser>(),
            },
        });
        
        __query_2106995374_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Hybrid.HybridModel>(),
                ComponentType.ReadWrite<ProjectM.Hybrid.HybridModelAnimData>(),
                ComponentType.ReadWrite<UnityEngine.Transform>(),
                ComponentType.ReadOnly<ProjectM.Hybrid.HybridModelPlayerTransformData>(),
            },
        });
        
        __query_2106995374_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Hybrid.HybridModelDOTSAnimator>(),
                ComponentType.ReadOnly<ProjectM.Hybrid.HybridModel>(),
                ComponentType.ReadWrite<ProjectM.Hybrid.HybridModelAnimData>(),
                ComponentType.ReadWrite<Unity.Transforms.Rotation>(),
                ComponentType.ReadWrite<Unity.Transforms.Translation>(),
                ComponentType.ReadOnly<ProjectM.Hybrid.HybridModelPlayerTransformData>(),
            },
        });
        
    }
    

}
