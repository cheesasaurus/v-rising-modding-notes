using Unity.Entities;

namespace ProjectM.CastleBuilding;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class CastleBuildingAttachmentBuffSystem : SystemBase
{
    EntityQuery __query_1274212879_0;
    EntityQuery __query_1274212879_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1274212879_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.CastleBuildingAttachmentAddedEvent>(),
            },
        });
        
        __query_1274212879_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.CastleBuildingAttachmentRemovedEvent>(),
            },
        });
        
    }
    

}
