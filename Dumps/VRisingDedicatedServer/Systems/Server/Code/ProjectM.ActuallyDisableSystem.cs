using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.EarlyUpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class ActuallyDisableSystem : SystemBase
{
    EntityQuery _Query;
    EntityQuery __query_1329488492_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ToggleDisabledEvent>(),
            },
        });
        
        __query_1329488492_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ToggleDisabledEvent>(),
            },
        });
        
    }
    

}
