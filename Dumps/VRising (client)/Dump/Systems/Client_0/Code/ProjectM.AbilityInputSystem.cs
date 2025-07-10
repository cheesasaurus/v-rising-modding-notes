using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.SetInputGroup), OrderFirst = true)]
[UpdateBefore(typeof(ProjectM.GameplayInputSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class AbilityInputSystem : SystemBase, ProjectM.IInputContext
{
    EntityQuery _AbilityInputQuery;
    EntityQuery __query_789576139_0;
    EntityQuery __query_789576139_1;
    EntityQuery __query_789576139_2;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _AbilityInputQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.EntityAbilityInput>(),
                ComponentType.ReadOnly<ProjectM.Controller>(),
            },
        });
        
        __query_789576139_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.EntityAbilityInput>(),
                ComponentType.ReadOnly<ProjectM.Controller>(),
            },
        });
        
        __query_789576139_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.AbilityInputState>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_789576139_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.AbilityInputState>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
