using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToPersistenceLoadedGroup))]
[UpdateAfter(typeof(ProjectM.AttachSystem_ReactToPersistenceLoad))]
[RequireMatchingQueriesForUpdateAttribute]
public class PostPersistenseLoadedUpdateUnlocksSystem : SystemBase
{
    EntityQuery __query_823418644_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_823418644_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.AchievementOwner>(),
                ComponentType.ReadOnly<ProjectM.Network.User>(),
                ComponentType.ReadOnly<ProjectM.PersistenceV2.LoadedTag>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
    }
    

}
