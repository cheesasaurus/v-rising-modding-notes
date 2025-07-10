using Unity.Entities;

namespace ProjectM.Haptics;


[UpdateInGroup(typeof(ProjectM.AfterDeserializationGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class HapticFeedbackOnDamageSystem : SystemBase
{
    EntityQuery _OnDamagedEventQuery;
    EntityQuery __query_368764069_0;
    EntityQuery __query_368764069_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _OnDamagedEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Haptics.OnDamagedHapticEvent>(),
            },
        });
        
        __query_368764069_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Haptics.OnDamagedHapticEvent>(),
            },
        });
        
        __query_368764069_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Haptics.HapticDamageFeedback>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
