using Unity.Entities;

namespace ProjectM.Sequencer;


[UpdateInGroup(typeof(ProjectM.ReactToDestroyTagGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class BuffSequenceSystem_Destroy : SystemBase
{
    EntityQuery __query_313887935_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_313887935_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Sequencer.BuffSequenceSpawned>(),
                ComponentType.ReadOnly<Unity.Entities.DestroyTag>(),
            },
        });
        
    }
    

}
