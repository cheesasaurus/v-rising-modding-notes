using Unity.Entities;

namespace ProjectM.Gameplay;


[UpdateInGroup(typeof(ProjectM.BeforeSpawnGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class KnockbackEventSystem : SystemBase
{
    EntityQuery _Query;
    EntityQuery __query_991765342_0;
    EntityQuery __query_991765342_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.KnockbackEvent>(),
            },
        });
        
        __query_991765342_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.KnockbackEvent>(),
            },
        });
        
        __query_991765342_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.KnockbackAssetsSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
