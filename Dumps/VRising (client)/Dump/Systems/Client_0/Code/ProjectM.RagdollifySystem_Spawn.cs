using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.AfterDeserializationGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class RagdollifySystem_Spawn : SystemBase
{
    EntityQuery _Query;
    EntityQuery __query_545320517_0;
    EntityQuery __query_545320517_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.RagdollDriven>(),
            },
        });
        
        __query_545320517_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.RagdollDriven>(),
            },
        });
        
        __query_545320517_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Core.PrefabLookupMap>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
