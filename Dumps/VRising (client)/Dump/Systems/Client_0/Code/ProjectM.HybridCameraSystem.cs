using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.CameraPresentationGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class HybridCameraSystem : SystemBase
{
    EntityQuery __query_1842227111_0;
    EntityQuery __query_1842227111_1;
    EntityQuery __query_1842227111_2;
    EntityQuery __query_1842227111_3;
    EntityQuery __query_1842227111_4;
    EntityQuery __query_1842227111_5;
    EntityQuery __query_1842227111_6;
    EntityQuery __query_1842227111_7;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1842227111_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ScreenShake>(),
                ComponentType.ReadOnly<ProjectM.Age>(),
                ComponentType.ReadOnly<ProjectM.LifeTime>(),
            },
        });
        
        __query_1842227111_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Transforms.Rotation>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
                ComponentType.ReadOnly<ProjectM.HybridCamera>(),
            },
        });
        
        __query_1842227111_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Transforms.Rotation>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
                ComponentType.ReadOnly<ProjectM.HybridCamera>(),
            },
        });
        
        __query_1842227111_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.HybridCameraData>(),
                ComponentType.ReadWrite<ProjectM.HybridCameraFrustumPlanes>(),
                ComponentType.ReadOnly<ProjectM.HybridCamera>(),
            },
        });
        
        __query_1842227111_4 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CameraTarget>(),
                ComponentType.ReadOnly<ProjectM.HybridCamera>(),
            },
        });
        
        __query_1842227111_5 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CameraTarget>(),
                ComponentType.ReadOnly<ProjectM.HybridCameraData>(),
            },
        });
        
        __query_1842227111_6 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.HybridCamera>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.HybridCameraInstancedTag>(),
            },
        });
        
        __query_1842227111_7 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.HybridCameraData>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
