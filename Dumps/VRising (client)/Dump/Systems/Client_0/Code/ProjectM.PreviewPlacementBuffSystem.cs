using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.BuildModeGroup), OrderLast = true)]
[RequireMatchingQueriesForUpdateAttribute]
public class PreviewPlacementBuffSystem : SystemBase
{
    EntityQuery _Query;
    EntityQuery __query_851069689_0;
    EntityQuery __query_851069689_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.PreviewPlacementBuff>(),
            },
        });
        
        __query_851069689_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.NetworkedSpawnChainChild>(),
                ComponentType.ReadOnly<Stunlock.Core.PrefabGUID>(),
            },
        });
        
        __query_851069689_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.BuildMode>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
