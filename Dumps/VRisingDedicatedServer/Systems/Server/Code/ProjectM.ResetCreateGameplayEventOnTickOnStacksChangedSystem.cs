using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.SetupInitialStatesGroup_Step1))]
[UpdateBefore(typeof(ProjectM.StackModifierSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class ResetCreateGameplayEventOnTickOnStacksChangedSystem : SystemBase
{
    EntityQuery _Query;
    EntityQuery __query_1123849424_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff_StacksIncreaseEvent>(),
            },
        });
        
        __query_1123849424_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff_StacksIncreaseEvent>(),
            },
        });
        
    }
    

}
