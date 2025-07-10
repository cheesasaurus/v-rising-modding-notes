using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.AbilityGroup))]
[UpdateAfter(typeof(ProjectM.AbilityInitializeGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class Update_ReplaceAbilityOnSlotSystem : SystemBase
{
    EntityQuery _UpdateAddQuery;
    EntityQuery _UpdateRemoveQuery;
    EntityQuery __query_1482480706_0;
    EntityQuery __query_1482480706_1;
    EntityQuery __query_1482480706_2;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _UpdateAddQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.AbilityGroupSlotModificationBuffer>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ReplaceAbilityOnSlotBuff_WithCondition>(),
                ComponentType.ReadOnly<ProjectM.ReplaceAbilityOnSlotBuff_AllInitialized>(),
            },
        });
        
        _UpdateRemoveQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.AbilityGroupSlotModificationBuffer>(),
                ComponentType.ReadOnly<ProjectM.AbilityGroupSlotModificationDestroy>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ReplaceAbilityOnSlotBuff_WithCondition>(),
            },
        });
        
        __query_1482480706_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.AbilityGroupSlotModificationBuffer>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ReplaceAbilityOnSlotBuff_WithCondition>(),
                ComponentType.ReadOnly<ProjectM.ReplaceAbilityOnSlotBuff_AllInitialized>(),
            },
        });
        
        __query_1482480706_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.AbilityGroupSlotModificationBuffer>(),
                ComponentType.ReadOnly<ProjectM.ReplaceAbilityOnSlotBuff_WithCondition>(),
            },
        });
        
        __query_1482480706_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.AbilityGroupSlotModificationBuffer>(),
                ComponentType.ReadOnly<ProjectM.AbilityGroupSlotModificationDestroy>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ReplaceAbilityOnSlotBuff_WithCondition>(),
            },
        });
        
    }
    

}
