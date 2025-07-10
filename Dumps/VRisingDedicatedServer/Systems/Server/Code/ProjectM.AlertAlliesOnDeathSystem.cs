using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToDeadGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class AlertAlliesOnDeathSystem : SystemBase
{
    EntityQuery _Query;
    EntityQuery __query_934001705_0;
    EntityQuery __query_934001705_1;
    EntityQuery __query_934001705_2;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.DeathEvent>(),
            },
        });
        
        __query_934001705_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.DeathEvent>(),
            },
        });
        
        __query_934001705_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CollisionDetectionSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_934001705_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Tiles.TileWorldSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
