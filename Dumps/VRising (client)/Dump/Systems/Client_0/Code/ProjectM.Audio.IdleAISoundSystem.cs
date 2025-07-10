using Unity.Entities;

namespace ProjectM.Audio;


[UpdateInGroup(typeof(ProjectM.AudioGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class IdleAISoundSystem : SystemBase
{
    EntityQuery __query_203074992_0;
    EntityQuery __query_203074992_1;
    EntityQuery __query_203074992_2;
    EntityQuery __query_203074992_3;
    EntityQuery __query_203074992_4;
    EntityQuery __query_203074992_5;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_203074992_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Audio.IdleAISound>(),
                ComponentType.ReadOnly<Unity.Transforms.LocalToWorld>(),
                ComponentType.ReadOnly<ProjectM.Audio.IdleAISoundBuffer>(),
            },
        });
        
        __query_203074992_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.MoveVelocity>(),
                ComponentType.ReadOnly<ProjectM.Audio.IdleAISound>(),
                ComponentType.ReadOnly<ProjectM.Audio.IdleAISoundBuffer>(),
                ComponentType.ReadOnly<ProjectM.Audio.UpdateStudioParametersTag>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Shared.Script_CarriageData>(),
            },
        });
        
        __query_203074992_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Shared.Script_CarriageData>(),
                ComponentType.ReadOnly<ProjectM.Audio.IdleAISound>(),
                ComponentType.ReadOnly<ProjectM.Audio.IdleAISoundBuffer>(),
                ComponentType.ReadOnly<ProjectM.Audio.UpdateStudioParametersTag>(),
            },
        });
        
        __query_203074992_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Audio.IdleAISound>(),
            },
        });
        
        __query_203074992_4 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.AggroConsumer>(),
                ComponentType.ReadOnly<ProjectM.Audio.IdleAISound>(),
                ComponentType.ReadOnly<ProjectM.Audio.IdleAISoundBuffer>(),
            },
        });
        
        __query_203074992_5 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.AggroConsumer>(),
                ComponentType.ReadOnly<ProjectM.Dead>(),
                ComponentType.ReadOnly<ProjectM.Audio.IdleAISound>(),
                ComponentType.ReadOnly<ProjectM.Audio.IdleAISoundBuffer>(),
            },
        });
        
    }
    

}
