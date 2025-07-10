using Unity.Entities;

namespace ProjectM.Behaviours;


[UpdateInGroup(typeof(ProjectM.AiSubGroup1))]
[RequireMatchingQueriesForUpdateAttribute]
public class EvaluateCastOptionsSystem : SystemBase
{
    EntityQuery _CleanupRequestQuery;
    EntityQuery _EvaluateRequestQuery;
    EntityQuery __query_1591503032_0;
    EntityQuery __query_1591503032_1;
    EntityQuery __query_1591503032_2;
    EntityQuery __query_1591503032_3;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _CleanupRequestQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Behaviours.EvaluateCastOptionsRequest>(),
            },
        });
        
        _EvaluateRequestQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Behaviours.EvaluateCastOptionsRequest>(),
            },
        });
        
        __query_1591503032_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Behaviours.EvaluateCastOptionsRequest>(),
            },
        });
        
        __query_1591503032_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Behaviours.EvaluateCastOptionsRequest>(),
            },
        });
        
        __query_1591503032_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CollisionDetectionSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1591503032_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Physics.PhysicsWorldSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
