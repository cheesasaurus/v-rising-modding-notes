using Unity.Entities;

namespace ProjectM.Audio;


[UpdateInGroup(typeof(ProjectM.AudioGroup))]
[UpdateBefore(typeof(ProjectM.Audio.StudioManagerSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class StudioEventSystem : SystemBase
{
    EntityQuery _DestroyedAudioEventsQuery;
    EntityQuery _DisabledAudioEventsQuery;
    EntityQuery __query_1047562329_0;
    EntityQuery __query_1047562329_1;
    EntityQuery __query_1047562329_2;
    EntityQuery __query_1047562329_3;
    EntityQuery __query_1047562329_4;
    EntityQuery __query_1047562329_5;
    EntityQuery __query_1047562329_6;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _DestroyedAudioEventsQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Audio.StudioEventInstance>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Audio.StudioEvent>(),
            },
        });
        
        _DisabledAudioEventsQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Audio.StudioEventInstance>(),
                ComponentType.ReadOnly<Unity.Entities.Disabled>(),
            },
        });
        
        __query_1047562329_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Audio.StudioEventInstance>(),
            },
        });
        
        __query_1047562329_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Audio.StudioEventUpdatePosition>(),
                ComponentType.ReadOnly<ProjectM.Audio.StudioEvent>(),
                ComponentType.ReadWrite<Unity.Transforms.LocalToWorld>(),
            },
        });
        
        __query_1047562329_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Transforms.LocalToWorld>(),
                ComponentType.ReadOnly<ProjectM.Audio.StudioEventInstance>(),
            },
        });
        
        __query_1047562329_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Audio.StudioEventInstance>(),
                ComponentType.ReadWrite<ProjectM.Audio.StudioEventParameterBuffer>(),
            },
        });
        
        __query_1047562329_4 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Audio.StudioEvent>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Audio.StudioEventInstance>(),
                ComponentType.ReadOnly<ProjectM.Audio.StudioEventInstance_Finished>(),
                ComponentType.ReadOnly<Unity.Entities.Disabled>(),
            },
        });
        
        __query_1047562329_5 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Audio.StudioEventInstance>(),
                ComponentType.ReadOnly<Unity.Entities.Disabled>(),
            },
        });
        
        __query_1047562329_6 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Audio.StudioEventInstance>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Audio.StudioEvent>(),
            },
        });
        
    }
    

}
