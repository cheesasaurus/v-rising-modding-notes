using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.CameraPresentationGroup))]
[UpdateBefore(typeof(ProjectM.HybridCameraSystem))]
[UpdateAfter(typeof(ProjectM.Sequencer.ZoomModifierSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class OrbitCameraSystem : SystemBase, ProjectM.IInputContext
{
    EntityQuery __query_825924359_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_825924359_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CameraTarget>(),
                ComponentType.ReadOnly<ProjectM.OrbitCamera>(),
                ComponentType.ReadWrite<ProjectM.OrbitCameraState>(),
                ComponentType.ReadWrite<ProjectM.Audio.StudioListener>(),
                ComponentType.ReadWrite<Unity.Transforms.Rotation>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
            },
        });
        
    }
    

}
