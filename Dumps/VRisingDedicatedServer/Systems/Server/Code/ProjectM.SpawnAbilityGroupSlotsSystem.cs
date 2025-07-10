using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class SpawnAbilityGroupSlotsSystem : SystemBase
{
    EntityQuery __query_1469148280_0;
    EntityQuery __query_1469148280_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1469148280_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.AbilityBarInitializationState>(),
                ComponentType.ReadWrite<ProjectM.AbilityGroupSlotBuffer>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
        __query_1469148280_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.AbilityGroupSlot>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
    }
    

}
