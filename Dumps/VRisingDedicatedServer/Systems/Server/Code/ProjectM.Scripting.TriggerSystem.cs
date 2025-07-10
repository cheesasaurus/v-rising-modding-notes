using Unity.Entities;

namespace ProjectM.Scripting;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[UpdateAfter(typeof(ProjectM.Scripting.ScriptUpdateServer))]
public class TriggerSystem : SystemBase
{
    EntityQuery __query_19728474_0;
    EntityQuery __query_19728474_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_19728474_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Scripting.Trigger>(),
                ComponentType.ReadOnly<ProjectM.Scripting.Trigger_OverlappingSphere>(),
            },
        });
        
        __query_19728474_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Physics.PhysicsWorldSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
