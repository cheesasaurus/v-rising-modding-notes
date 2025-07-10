using Unity.Entities;

namespace ProjectM.Sequencer;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class EntitySequenceSystem_Spawn : SystemBase
{
    EntityQuery __query_97767540_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_97767540_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.EntitySequence>(),
                ComponentType.ReadWrite<ProjectM.SpawnEntitySequence>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
    }
    

}
