using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToDestroyTagGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class ReplaceAbilityOnSlotWhenMountedBuffSystem_Destroy : SystemBase
{
    EntityQuery __query_1545567587_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1545567587_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadOnly<ProjectM.ReplaceAbilityOnSlotWhenMountedBuffElement>(),
                ComponentType.ReadWrite<ProjectM.ReplaceAbilityOnSlotWhenMountedBuffModificationElement>(),
                ComponentType.ReadOnly<Unity.Entities.DestroyTag>(),
            },
        });
        
    }
    

}
