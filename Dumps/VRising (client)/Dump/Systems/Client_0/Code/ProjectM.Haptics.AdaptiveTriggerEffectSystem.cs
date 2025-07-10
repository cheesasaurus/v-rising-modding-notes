using Unity.Entities;

namespace ProjectM.Haptics;


[UpdateInGroup(typeof(ProjectM.AfterDeserializationGroup))]
public class AdaptiveTriggerEffectSystem : SystemBase
{
    EntityQuery _InactiveEventsQuery;
    EntityQuery _TriggerEventQuery;
    EntityQuery __query_1558351936_0;
    EntityQuery __query_1558351936_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _InactiveEventsQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Haptics.HandledAdaptiveTriggerEvent>(),
            },
        });
        
        _TriggerEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Haptics.AdaptiveTriggerEvent>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Haptics.HandledAdaptiveTriggerEvent>(),
            },
        });
        
        __query_1558351936_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Haptics.HandledAdaptiveTriggerEvent>(),
            },
        });
        
        __query_1558351936_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Haptics.AdaptiveTriggerEvent>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Haptics.HandledAdaptiveTriggerEvent>(),
            },
        });
        
    }
    

}
