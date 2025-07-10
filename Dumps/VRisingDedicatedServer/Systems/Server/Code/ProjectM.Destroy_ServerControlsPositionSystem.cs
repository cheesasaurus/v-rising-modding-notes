using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToDestroyTagGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class Destroy_ServerControlsPositionSystem : SystemBase
{
    EntityQuery __query_1520209017_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1520209017_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadOnly<ProjectM.ServerControlsPositionModifications>(),
                ComponentType.ReadOnly<ProjectM.ServerControlsMovementBuff>(),
                ComponentType.ReadOnly<Unity.Entities.DestroyTag>(),
            },
        });
        
    }
    

}
