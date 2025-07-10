using Unity.Entities;

namespace ProjectM.Sequencer;


[UpdateInGroup(typeof(ProjectM.GetHybridDataGroup))]
public class AnimatorParameterSystem : SystemBase
{
    EntityQuery __query_1230400940_0;
    EntityQuery __query_1230400940_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1230400940_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Sequencer.AnimatorParameterSystem.SystemData>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1230400940_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Sequencer.AnimatorParameterSystem.SystemData>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
