using Unity.Entities;

namespace ProjectM.Haptics;


[UpdateInGroup(typeof(ProjectM.Sequencer.SequencerPresentationGroup))]
[UpdateAfter(typeof(ProjectM.Sequencer.UpdatePresentationPostGraphSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class HapticVibrationSystem : SystemBase
{
    EntityQuery _HapticEventQuery;
    EntityQuery _InactiveEventsQuery;
    EntityQuery __query_347816200_0;
    EntityQuery __query_347816200_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _HapticEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Haptics.HapticEvent>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Haptics.HandledHapticEvent>(),
            },
        });
        
        _InactiveEventsQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Haptics.HandledHapticEvent>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Audio.StudioEvent>(),
            },
        });
        
        __query_347816200_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Haptics.HapticEvent>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Haptics.HandledHapticEvent>(),
            },
        });
        
        __query_347816200_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Haptics.HandledHapticEvent>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Audio.StudioEvent>(),
            },
        });
        
    }
    

}
