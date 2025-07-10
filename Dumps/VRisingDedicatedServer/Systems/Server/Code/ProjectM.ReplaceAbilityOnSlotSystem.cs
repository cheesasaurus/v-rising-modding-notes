using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class ReplaceAbilityOnSlotSystem : SystemBase
{
    EntityQuery __query_1482480545_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1482480545_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.EntityOwner>(),
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadOnly<ProjectM.ReplaceAbilityOnSlotData>(),
                ComponentType.ReadOnly<ProjectM.ReplaceAbilityOnSlotBuff>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
    }
    

}
