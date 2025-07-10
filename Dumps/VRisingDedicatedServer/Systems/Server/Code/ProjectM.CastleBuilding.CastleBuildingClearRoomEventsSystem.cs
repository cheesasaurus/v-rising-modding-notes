using Unity.Entities;

namespace ProjectM.CastleBuilding;


[UpdateInGroup(typeof(ProjectM.ReactToTileBoundsGroup))]
[UpdateBefore(typeof(ProjectM.CastleBuilding.CastleBuildingSearchRoomSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class CastleBuildingClearRoomEventsSystem : SystemBase
{
    EntityQuery _LastFrameEventsQuery;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _LastFrameEventsQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.CastleRoomEvent>(),
            },
        });
        
    }
    

}
