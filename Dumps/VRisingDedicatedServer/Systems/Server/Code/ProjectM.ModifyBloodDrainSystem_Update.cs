using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class ModifyBloodDrainSystem_Update : SystemBase
{
    EntityQuery __query_2080842966_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_2080842966_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.EntityOwner>(),
                ComponentType.ReadWrite<ProjectM.ModifyBloodDrainBuff>(),
            },
        });
        
    }
    

}
