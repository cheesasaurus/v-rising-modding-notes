using Unity.Entities;

namespace ProjectM.CastleBuilding;


[UpdateInGroup(typeof(ProjectM.ReactToDestroyTagGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class CastleBuildingAttachmentCleanup : SystemBase
{
    EntityQuery __query_475332371_0;
    EntityQuery __query_475332371_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_475332371_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.CastleBuilding.CastleBuildingAttachToParentsBuffer>(),
                ComponentType.ReadOnly<Unity.Entities.DestroyTag>(),
            },
        });
        
        __query_475332371_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.CastleBuilding.CastleBuildingAttachedChildrenBuffer>(),
                ComponentType.ReadOnly<Unity.Entities.DestroyTag>(),
            },
        });
        
    }
    

}
