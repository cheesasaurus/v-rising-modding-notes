using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToDeadGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class DeathEventListenerSystem : SystemBase
{
    EntityQuery _DeathEventQuery;
    EntityQuery _GlobalDeathListenerQuery;
    EntityQuery _OnKillListenerQuery;
    EntityQuery _OnDeathListenerQuery;
    EntityQuery __query_1707184393_0;
    EntityQuery __query_1707184393_1;
    EntityQuery __query_1707184393_2;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _DeathEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.DeathEvent>(),
            },
        });
        
        _GlobalDeathListenerQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.GlobalDeathListener>(),
            },
        });
        
        _OnKillListenerQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.OnKillListener>(),
            },
        });
        
        _OnDeathListenerQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.OnDeathListener>(),
            },
        });
        
        __query_1707184393_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.GlobalDeathListener>(),
            },
        });
        
        __query_1707184393_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.OnKillListener>(),
            },
        });
        
        __query_1707184393_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.OnDeathListener>(),
            },
        });
        
    }
    

}
