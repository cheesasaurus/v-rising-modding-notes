using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToPersistenceLoadedGroup), OrderLast = true)]
[RequireMatchingQueriesForUpdateAttribute]
public class RecalculateSharedInventorySystem_PersistenceLoaded : SystemBase
{
    EntityQuery __query_614111154_0;
    EntityQuery __query_614111154_1;
    EntityQuery __query_614111154_2;
    EntityQuery __query_614111154_3;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_614111154_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.SharedCastleInventoryConnection>(),
                ComponentType.ReadOnly<ProjectM.PersistenceV2.LoadedTag>(),
            },
        });
        
        __query_614111154_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.SharedCastleInventoryConnection>(),
                ComponentType.ReadOnly<ProjectM.PersistenceV2.LoadedTag>(),
            },
        });
        
        __query_614111154_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Core.PrefabLookupMap>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_614111154_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ItemKeyLookup>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
