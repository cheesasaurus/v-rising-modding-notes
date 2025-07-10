using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToPersistenceLoadedGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class TravelBuffCollectionPersistenceSystem : SystemBase
{
    EntityQuery __query_523689882_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_523689882_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.TravelBuff>(),
                ComponentType.ReadOnly<ProjectM.PersistenceV2.LoadedTag>(),
            },
        });
        
    }
    

}
