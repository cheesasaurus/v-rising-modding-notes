using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToDestroyTagGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class Destroy_BuffModificationsSystem_Client : SystemBase
{
    EntityQuery __query_1912026964_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1912026964_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadOnly<ProjectM.ModifyObstacleFadeoutModifications>(),
                ComponentType.ReadOnly<ProjectM.ModifyObstacleFadeoutBuff>(),
                ComponentType.ReadOnly<Unity.Entities.DestroyTag>(),
            },
        });
        
    }
    

}
