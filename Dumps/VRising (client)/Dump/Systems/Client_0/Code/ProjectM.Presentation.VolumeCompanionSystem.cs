using Unity.Entities;

namespace ProjectM.Presentation;


[UpdateInGroup(typeof(PresentationSystemGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class VolumeCompanionSystem : SystemBase
{
    EntityQuery _CreatedQuery;
    EntityQuery _DestroyedQuery;
    EntityQuery _DisabledQuery;
    EntityQuery __query_935782126_0;
    EntityQuery __query_935782126_1;
    EntityQuery __query_935782126_2;
    EntityQuery __query_935782126_3;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _CreatedQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.VolumeCompanion>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.VolumeCompanionInstantiated>(),
            },
        });
        
        _DestroyedQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.VolumeCompanionInstantiated>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.VolumeCompanion>(),
            },
        });
        
        _DisabledQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.VolumeCompanion>(),
                ComponentType.ReadOnly<Unity.Entities.Disabled>(),
                ComponentType.ReadOnly<ProjectM.VolumeCompanionInstantiated>(),
            },
        });
        
        __query_935782126_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.VolumeCompanionBoxCollider>(),
                ComponentType.ReadOnly<Unity.Transforms.LocalToWorld>(),
                ComponentType.ReadOnly<ProjectM.VolumeCompanion>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.VolumeCompanionInstantiated>(),
            },
        });
        
        __query_935782126_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.VolumeCompanionSphereCollider>(),
                ComponentType.ReadOnly<Unity.Transforms.LocalToWorld>(),
                ComponentType.ReadOnly<ProjectM.VolumeCompanion>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.VolumeCompanionInstantiated>(),
            },
        });
        
        __query_935782126_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.VolumeCompanion>(),
                ComponentType.ReadOnly<Unity.Entities.Disabled>(),
                ComponentType.ReadOnly<ProjectM.VolumeCompanionInstantiated>(),
            },
        });
        
        __query_935782126_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.VolumeCompanionInstantiated>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.VolumeCompanion>(),
            },
        });
        
    }
    

}
