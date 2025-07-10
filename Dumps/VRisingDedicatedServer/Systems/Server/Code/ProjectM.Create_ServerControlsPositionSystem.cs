using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class Create_ServerControlsPositionSystem : SystemBase
{
    EntityQuery __query_1520208976_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1520208976_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
            Any = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ServerControlsMovementBuff>(),
                ComponentType.ReadOnly<ProjectM.ServerControlsRotationBuff>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ServerControlsPositionModifications>(),
            },
        });
        
    }
    

}
