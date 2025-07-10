using Unity.Entities;

namespace ProjectM.Sequencer;


[UpdateInGroup(typeof(SimulationSystemGroup))]
[UpdateBefore(typeof(ProjectM.Sequencer.CreateSequenceSystem))]
[UpdateAfter(typeof(ProjectM.RecursiveGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class SpawnSequenceForEntitySystem : SystemBase
{
    EntityQuery __query_998741749_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_998741749_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Sequencer.SpawnSequenceForEntity>(),
                ComponentType.ReadOnly<Unity.Transforms.Rotation>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Sequencer.SuccessfullySpawnedSequence>(),
            },
        });
        
    }
    

}
