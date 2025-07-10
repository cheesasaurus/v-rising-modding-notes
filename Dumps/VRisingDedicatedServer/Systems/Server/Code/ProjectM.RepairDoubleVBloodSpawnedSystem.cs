using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToPersistenceLoadedGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class RepairDoubleVBloodSpawnedSystem : SystemBase
{
    EntityQuery _SpawnSourceQuery;
    EntityQuery _Query;
    EntityQuery __query_707729731_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _SpawnSourceQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.VBloodUnitSpawnSource>(),
                ComponentType.ReadOnly<ProjectM.UnitCompositionActiveUnit>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.SpawnedBy>(),
                ComponentType.ReadOnly<ProjectM.VBloodUnit>(),
                ComponentType.ReadOnly<ProjectM.PersistenceV2.LoadedTag>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
        __query_707729731_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.SpawnedBy>(),
                ComponentType.ReadOnly<ProjectM.VBloodUnit>(),
                ComponentType.ReadOnly<ProjectM.PersistenceV2.LoadedTag>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
    }
    

}
