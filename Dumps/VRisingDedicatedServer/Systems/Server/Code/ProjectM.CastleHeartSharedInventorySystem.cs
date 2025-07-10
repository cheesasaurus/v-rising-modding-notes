using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class CastleHeartSharedInventorySystem : SystemBase
{
    EntityQuery _Query;
    EntityQuery __query_697535279_0;
    EntityQuery __query_697535279_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.SharedCastleInventoryManager>(),
                ComponentType.ReadWrite<ProjectM.Network.SyncToUserBuffer>(),
                ComponentType.ReadOnly<ProjectM.CastleBuilding.SharedCastleInventoryInstances>(),
            },
        });
        
        __query_697535279_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.SharedCastleInventoryManager>(),
                ComponentType.ReadWrite<ProjectM.Network.SyncToUserBuffer>(),
                ComponentType.ReadOnly<ProjectM.CastleBuilding.SharedCastleInventoryInstances>(),
            },
        });
        
        __query_697535279_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.MapZoneCollection>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
