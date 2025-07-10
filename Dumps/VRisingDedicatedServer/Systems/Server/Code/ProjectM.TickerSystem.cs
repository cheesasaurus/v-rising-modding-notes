using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[UpdateBefore(typeof(ProjectM.Scripting.TriggerSystem))]
[UpdateAfter(typeof(ProjectM.Scripting.ScriptUpdateServer))]
[RequireMatchingQueriesForUpdateAttribute]
public class TickerSystem : SystemBase
{
    EntityQuery __query_748284709_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_748284709_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Ticker>(),
                ComponentType.ReadOnly<Stunlock.Core.PrefabGUID>(),
            },
        });
        
    }
    

}
