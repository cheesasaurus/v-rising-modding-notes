using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class GetOwnerPrimaryAggroTargetOnSpawnSystem : SystemBase
{
    EntityQuery __query_392415901_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_392415901_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.EntityOwner>(),
                ComponentType.ReadWrite<ProjectM.GetOwnerPrimaryAggroTargetOnSpawn>(),
                ComponentType.ReadOnly<ProjectM.AggroBuffer>(),
                ComponentType.ReadOnly<ProjectM.AggroDamageHistoryBufferElement>(),
            },
        });
        
    }
    

}
