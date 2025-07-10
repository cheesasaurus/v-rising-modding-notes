using Unity.Entities;

namespace ProjectM.CastleBuilding;


[UpdateInGroup(typeof(ProjectM.LateUpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class CastleBuildingAttachmentAddedEventsClearSystem : SystemBase
{
    EntityQuery _LastFrameEventsQuery;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _LastFrameEventsQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.CastleBuildingAttachmentAddedEvent>(),
            },
        });
        
    }
    

}
