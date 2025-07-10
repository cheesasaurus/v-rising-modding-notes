using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class Modify_BuffModificationsSystem_Server : SystemBase
{
    EntityQuery __query_1912026915_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1912026915_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadWrite<ProjectM.BuffModificationFlagData>(),
                ComponentType.ReadOnly<ProjectM.ConditionBuffModificationFlagData>(),
            },
        });
        
    }
    

}
