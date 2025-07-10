using Unity.Entities;

namespace ProjectM.Audio;


[UpdateInGroup(typeof(ProjectM.AudioGroup))]
[UpdateAfter(typeof(ProjectM.Audio.StudioEventSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class DebugSoundEventSystem : SystemBase
{
    EntityQuery __query_1047563170_0;
    EntityQuery __query_1047563170_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1047563170_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Transforms.LocalToWorld>(),
                ComponentType.ReadOnly<ProjectM.Audio.StudioEventInstance>(),
            },
        });
        
        __query_1047563170_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Audio.StudioListener>(),
                ComponentType.ReadOnly<Unity.Transforms.Rotation>(),
            },
        });
        
    }
    

}
