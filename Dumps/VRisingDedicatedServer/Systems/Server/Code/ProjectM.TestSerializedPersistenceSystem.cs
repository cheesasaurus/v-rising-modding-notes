using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.PersistenceGroup), OrderLast = true)]
[UpdateAfter(typeof(ProjectM.SerializePersistenceSystemV2))]
[RequireMatchingQueriesForUpdateAttribute]
public class TestSerializedPersistenceSystem : SystemBase
{
    EntityQuery __query_667910941_0;
    EntityQuery __query_667910941_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_667910941_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.PersistenceDebuggingSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_667910941_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.TestPersistenceV2Save>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
