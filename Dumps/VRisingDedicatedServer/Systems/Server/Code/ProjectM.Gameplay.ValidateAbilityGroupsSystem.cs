using Unity.Entities;

namespace ProjectM.Gameplay;


[UpdateInGroup(typeof(ProjectM.AbilityInitializeGroup))]
[UpdateBefore(typeof(ProjectM.AbilityStartCastingSystem_Server))]
[RequireMatchingQueriesForUpdateAttribute]
public class ValidateAbilityGroupsSystem : SystemBase
{
    EntityQuery _Query;
    EntityQuery __query_1419277039_0;
    EntityQuery __query_1419277039_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.AbilityGroupSlot>(),
                ComponentType.ReadOnly<ProjectM.AbilityGroupSlot.DirtyTag>(),
            },
        });
        
        __query_1419277039_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.AbilityGroupSlot>(),
                ComponentType.ReadOnly<ProjectM.AbilityGroupSlot.DirtyTag>(),
            },
        });
        
        __query_1419277039_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ServerTime>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
