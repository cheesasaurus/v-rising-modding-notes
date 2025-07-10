using Unity.Entities;

namespace ProjectM.Behaviours;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class RegisterEntityInBlackboardSystem : SystemBase
{
    EntityQuery _Query;
    EntityQuery __query_646695070_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Behaviours.RegisterEntityInBlackboard>(),
            },
        });
        
        __query_646695070_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Behaviours.RegisterEntityInBlackboard>(),
            },
        });
        
    }
    

}
