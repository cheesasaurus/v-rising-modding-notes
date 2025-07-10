using Unity.Entities;

namespace ProjectM.Audio;


[UpdateInGroup(typeof(ProjectM.AudioGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class UIAudioSystem : SystemBase
{
    EntityQuery _Query;
    EntityQuery __query_1701636167_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Audio.UISoundEvent>(),
            },
        });
        
        __query_1701636167_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Audio.UISoundEvent>(),
            },
        });
        
    }
    

}
