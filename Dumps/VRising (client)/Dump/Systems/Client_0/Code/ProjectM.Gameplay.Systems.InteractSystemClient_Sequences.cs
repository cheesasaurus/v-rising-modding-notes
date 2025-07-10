using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class InteractSystemClient_Sequences : SystemBase
{
    EntityQuery _GetActiveInteractableQuery;
    EntityQuery __query_195794759_0;
    EntityQuery __query_195794759_1;
    EntityQuery __query_195794759_2;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _GetActiveInteractableQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Interactable>(),
                ComponentType.ReadWrite<ProjectM.InteractableActive>(),
            },
        });
        
        __query_195794759_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.InteractableSequence>(),
                ComponentType.ReadOnly<ProjectM.InteractableActive>(),
            },
        });
        
        __query_195794759_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.InteractableSequence>(),
                ComponentType.ReadOnly<ProjectM.InteractableWasActive>(),
            },
        });
        
        __query_195794759_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.SpellTarget>(),
            },
        });
        
    }
    

}
