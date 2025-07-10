using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToPersistenceLoadedGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class ModifiablePatchingSystem : SystemBase
{
    EntityQuery __query_1313386287_0;
    EntityQuery __query_1313386287_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1313386287_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Core.PrefabLookupMap>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1313386287_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ModificationsRegistry>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
