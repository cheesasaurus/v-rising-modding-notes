using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class Debug_SpawnBuffs : SystemBase
{
    EntityQuery _DebugBuffsSpawned;
    EntityQuery __query_1620065016_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _DebugBuffsSpawned = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.DebugEventsSystem.Debug_ApplyBuffDelayed>(),
            },
        });
        
        __query_1620065016_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.DebugEventsSystem.Debug_ApplyBuffDelayed>(),
            },
        });
        
    }
    

}
