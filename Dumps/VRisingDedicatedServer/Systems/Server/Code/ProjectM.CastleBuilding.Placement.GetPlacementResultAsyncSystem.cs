using Unity.Entities;

namespace ProjectM.CastleBuilding.Placement;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[UpdateAfter(typeof(ProjectM.Scripting.ScriptUpdateServer))]
[RequireMatchingQueriesForUpdateAttribute]
public class GetPlacementResultAsyncSystem : SystemBase
{
    EntityQuery _PlacementOperationRequests;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _PlacementOperationRequests = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.CastleBuilding.Placement.PlacementOperationRequest>(),
            },
        });
        
    }
    

}
