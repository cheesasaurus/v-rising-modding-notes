using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.StatChangeGroup))]
[UpdateBefore(typeof(ProjectM.Gameplay.Systems.StatChangeSystem))]
[UpdateAfter(typeof(ProjectM.Gameplay.Systems.StatChangeMutationSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class DestroyBuffOnDamageTakenSystem : SystemBase
{
    EntityQuery _HealthChangeEventQuery;
    EntityQuery __query_96720993_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _HealthChangeEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.StatChangeEvent>(),
            },
        });
        
        __query_96720993_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadOnly<ProjectM.DestroyBuffOnDamageTaken>(),
            },
        });
        
    }
    

}
