using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.CameraPresentationGroup))]
[UpdateBefore(typeof(ProjectM.HybridCameraSystem))]
[UpdateAfter(typeof(ProjectM.Sequencer.ZoomModifierSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class FreeCameraSystem : SystemBase, ProjectM.IInputContext
{
    EntityQuery __query_1771408657_0;
    EntityQuery __query_1771408657_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1771408657_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.FreeCamera>(),
                ComponentType.ReadWrite<ProjectM.CameraTarget>(),
                ComponentType.ReadWrite<ProjectM.Audio.StudioListener>(),
                ComponentType.ReadWrite<ProjectM.FreeCameraState>(),
                ComponentType.ReadWrite<Unity.Transforms.Rotation>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
            },
        });
        
        __query_1771408657_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.FreeCamera>(),
                ComponentType.ReadWrite<ProjectM.CameraTarget>(),
                ComponentType.ReadOnly<ProjectM.FreeCameraState>(),
                ComponentType.ReadOnly<Unity.Transforms.Rotation>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
            },
        });
        
    }
    

}
