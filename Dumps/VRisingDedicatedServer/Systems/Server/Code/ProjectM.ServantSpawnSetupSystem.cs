using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[UpdateAfter(typeof(ProjectM.ServantCoffinstationActionSystem))]
[UpdateAfter(typeof(ProjectM.ServantCoffinstationUpdateSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class ServantSpawnSetupSystem : SystemBase
{
    EntityQuery __query_1849383741_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1849383741_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.ServantConnectedCoffin>(),
                ComponentType.ReadOnly<ProjectM.ServantSpawnHandler>(),
                ComponentType.ReadOnly<ProjectM.NewUnitTag>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
    }
    

}
