using Unity.Entities;

namespace ProjectM.CastleBuilding;


[UpdateInGroup(typeof(ProjectM.ReactToDeadGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class CastleBuildingDeadCleanup : SystemBase
{
    EntityQuery __query_416420527_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_416420527_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.DeathEvent>(),
            },
        });
        
    }
    

}
