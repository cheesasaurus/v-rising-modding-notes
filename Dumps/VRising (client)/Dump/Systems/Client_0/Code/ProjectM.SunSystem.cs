using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.NoStructuralChangesGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class SunSystem : SystemBase
{
    EntityQuery __query_1777838698_0;
    EntityQuery __query_1777838698_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1777838698_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Sun>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1777838698_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.DayNightCycle>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
