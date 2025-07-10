using Unity.Entities;

namespace ProjectM.CastleBuilding.Rebuilding;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
[UpdateAfter(typeof(ProjectM.Network.SetupNetworkIdSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class CastleRebuildRegistryOnSpawnSystem : SystemBase
{
    EntityQuery __query_1821520951_0;
    EntityQuery __query_1821520951_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1821520951_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.CastleHeartConnection>(),
                ComponentType.ReadOnly<Stunlock.Core.PrefabGUID>(),
                ComponentType.ReadOnly<ProjectM.CastleBuilding.Rebuilding.CastleRebuildCommonTag>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
        __query_1821520951_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.CastleHeartConnection>(),
                ComponentType.ReadOnly<ProjectM.Network.NetworkId>(),
                ComponentType.ReadOnly<Stunlock.Core.PrefabGUID>(),
                ComponentType.ReadOnly<ProjectM.CastleBuilding.Rebuilding.CastleRebuildUniqueTag>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
    }
    

}
