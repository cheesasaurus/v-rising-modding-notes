using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
public class DeathMenuSystem : SystemBase
{
    EntityQuery __query_69065966_0;
    EntityQuery __query_69065966_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_69065966_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.LocalControlled>(),
            },
        });
        
        __query_69065966_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadOnly<ProjectM.SpawnSleepingBuff>(),
            },
        });
        
    }
    

}
