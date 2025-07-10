using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.MoveGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class JumpFromCliffsTravelSystem : SystemBase
{
    EntityQuery __query_1619853765_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1619853765_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadOnly<ProjectM.JumpFromCliffsTravelBuff>(),
                ComponentType.ReadOnly<ProjectM.JumpFromCliffsTravelBuffConstants>(),
                ComponentType.ReadOnly<ProjectM.Age>(),
                ComponentType.ReadOnly<ProjectM.LifeTime>(),
            },
        });
        
    }
    

}
