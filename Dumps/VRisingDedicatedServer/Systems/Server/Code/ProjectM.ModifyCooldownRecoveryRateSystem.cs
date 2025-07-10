using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.StatChangeGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class ModifyCooldownRecoveryRateSystem : SystemBase
{
    EntityQuery _Query;
    EntityQuery __query_166325041_0;
    EntityQuery __query_166325041_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.CooldownRecoveryRateChangedEvent>(),
            },
        });
        
        __query_166325041_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.CooldownRecoveryRateChangedEvent>(),
            },
        });
        
        __query_166325041_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ServerTime>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
