using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToPersistenceLoadedGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class RepairTileModelEditingOnPersistenceLoad : SystemBase
{
    EntityQuery __query_112767786_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_112767786_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.EditableTileModel>(),
                ComponentType.ReadOnly<ProjectM.PersistenceV2.LoadedTag>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
    }
    

}
