using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class AiMoveSystem_Client_Spawn : SystemBase
{
    EntityQuery __query_1334111533_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1334111533_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Movement>(),
                ComponentType.ReadWrite<ProjectM.AiMove_Client>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
    }
    

}
