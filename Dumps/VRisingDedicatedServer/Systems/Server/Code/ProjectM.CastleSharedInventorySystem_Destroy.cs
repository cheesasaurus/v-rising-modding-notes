using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToDestroyTagGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class CastleSharedInventorySystem_Destroy : SystemBase
{
    EntityQuery _Query;
    EntityQuery __query_1578914143_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.CastleHeartConnection>(),
                ComponentType.ReadOnly<ProjectM.CastleBuilding.CastleSharedInventory>(),
                ComponentType.ReadOnly<Unity.Entities.DestroyTag>(),
            },
        });
        
        __query_1578914143_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.CastleHeartConnection>(),
                ComponentType.ReadOnly<ProjectM.CastleBuilding.CastleSharedInventory>(),
                ComponentType.ReadOnly<Unity.Entities.DestroyTag>(),
            },
        });
        
    }
    

}
