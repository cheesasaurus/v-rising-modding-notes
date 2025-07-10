using Unity.Entities;

namespace ProjectM.Sequencer;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class BuffSequenceSystem_WaitingForCondition : SystemBase
{
    EntityQuery _Query;
    EntityQuery __query_313887832_0;
    EntityQuery __query_313887832_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadWrite<ProjectM.BuffSequence>(),
                ComponentType.ReadOnly<ProjectM.Sequencer.BuffSequence_WaitingForCondition>(),
            },
        });
        
        __query_313887832_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadWrite<ProjectM.BuffSequence>(),
                ComponentType.ReadOnly<ProjectM.Sequencer.BuffSequence_WaitingForCondition>(),
            },
        });
        
        __query_313887832_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ServerTime>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
