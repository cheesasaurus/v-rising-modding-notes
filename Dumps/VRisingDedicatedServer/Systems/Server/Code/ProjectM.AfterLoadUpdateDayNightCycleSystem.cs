using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToPersistenceLoadedGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class AfterLoadUpdateDayNightCycleSystem : SystemBase
{
    EntityQuery __query_1657221728_0;
    EntityQuery __query_1657221728_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1657221728_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.DayNightCycle>(),
                ComponentType.ReadOnly<ProjectM.PersistenceV2.LoadedTag>(),
            },
        });
        
        __query_1657221728_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ServerGameBalanceSettings>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
