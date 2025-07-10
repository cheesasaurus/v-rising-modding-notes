using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.SetupInitialStatesGroup_Step2))]
[RequireMatchingQueriesForUpdateAttribute]
public class Spawn_MoveSpeedBuffSystem : SystemBase
{
    EntityQuery __query_212240354_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_212240354_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadOnly<ProjectM.ModifyMovementSpeedBuff>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ModifyMovementSpeedBuffModification>(),
            },
        });
        
    }
    

}
