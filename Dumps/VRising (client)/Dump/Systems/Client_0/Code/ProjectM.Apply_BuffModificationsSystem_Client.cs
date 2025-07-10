using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class Apply_BuffModificationsSystem_Client : SystemBase
{
    EntityQuery __query_1912026642_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1912026642_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadOnly<ProjectM.ModifyObstacleFadeoutBuff>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ModifyObstacleFadeoutModifications>(),
            },
        });
        
    }
    

}
