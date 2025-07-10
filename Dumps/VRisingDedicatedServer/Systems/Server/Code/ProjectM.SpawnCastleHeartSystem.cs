using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class SpawnCastleHeartSystem : SystemBase
{
    EntityQuery _Query;
    EntityQuery __query_839224270_0;
    EntityQuery __query_839224270_1;
    EntityQuery __query_839224270_2;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.CastleHeart>(),
                ComponentType.ReadOnly<ProjectM.CastleBuilding.SharedCastleInventoryConnection>(),
                ComponentType.ReadWrite<ProjectM.Network.SyncBoundingBox>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
        __query_839224270_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.CastleHeart>(),
                ComponentType.ReadOnly<ProjectM.CastleBuilding.SharedCastleInventoryConnection>(),
                ComponentType.ReadWrite<ProjectM.Network.SyncBoundingBox>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
        __query_839224270_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Core.PrefabLookupMap>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_839224270_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ItemKeyLookup>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
