using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class MoveSpeedBuffSystem : SystemBase
{
    EntityQuery __query_212240405_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_212240405_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ModifyMovementSpeedBuffModification>(),
                ComponentType.ReadOnly<ProjectM.ModifyMovementSpeedBuff>(),
                ComponentType.ReadOnly<ProjectM.Age>(),
                ComponentType.ReadOnly<ProjectM.LifeTime>(),
            },
        });
        
    }
    

}
