using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToDestroyTagGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class Destroy_BuffModificationsSystem_Server : SystemBase
{
    EntityQuery __query_1912026992_0;
    EntityQuery __query_1912026992_1;
    EntityQuery __query_1912026992_2;
    EntityQuery __query_1912026992_3;
    EntityQuery __query_1912026992_4;
    EntityQuery __query_1912026992_5;
    EntityQuery __query_1912026992_6;
    EntityQuery __query_1912026992_7;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1912026992_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadWrite<ProjectM.BuffModificationFlagData>(),
                ComponentType.ReadOnly<Unity.Entities.DestroyTag>(),
            },
        });
        
        __query_1912026992_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadOnly<ProjectM.LimitAbilityPriorityBuff>(),
                ComponentType.ReadOnly<ProjectM.LimitAbilityPriorityModifications>(),
                ComponentType.ReadOnly<Unity.Entities.DestroyTag>(),
            },
        });
        
        __query_1912026992_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadOnly<ProjectM.SetDynamicCollisionHardnessBuff>(),
                ComponentType.ReadOnly<ProjectM.SetDynamicCollisionHardnessModifications>(),
                ComponentType.ReadOnly<Unity.Entities.DestroyTag>(),
            },
        });
        
        __query_1912026992_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadOnly<ProjectM.FollowBuffOwnerModifications>(),
                ComponentType.ReadOnly<ProjectM.FollowBuffOwner>(),
                ComponentType.ReadOnly<Unity.Entities.DestroyTag>(),
            },
        });
        
        __query_1912026992_4 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadOnly<ProjectM.DisableAggroBuff>(),
                ComponentType.ReadOnly<ProjectM.DisableAggroBuffModifications>(),
                ComponentType.ReadOnly<Unity.Entities.DestroyTag>(),
            },
        });
        
        __query_1912026992_5 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadOnly<ProjectM.PreventDisableBuffModifications>(),
                ComponentType.ReadOnly<ProjectM.PreventDisableBuff>(),
                ComponentType.ReadOnly<Unity.Entities.DestroyTag>(),
            },
        });
        
        __query_1912026992_6 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadOnly<ProjectM.AdjustFlyHeightBuff>(),
                ComponentType.ReadOnly<ProjectM.AdjustFlyHeightBuffModifications>(),
                ComponentType.ReadOnly<Unity.Entities.DestroyTag>(),
            },
        });
        
        __query_1912026992_7 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadOnly<ProjectM.ModifyAggroRangesBuff>(),
                ComponentType.ReadOnly<ProjectM.ModifyAggroRangesBuffModifications>(),
                ComponentType.ReadOnly<Unity.Entities.DestroyTag>(),
            },
        });
        
    }
    

}
