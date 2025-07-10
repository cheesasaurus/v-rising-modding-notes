using Unity.Entities;

namespace ProjectM.UI;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class ReviveCancelEventSystem : SystemBase
{
    EntityQuery __query_1443162900_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1443162900_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.Network.GiveUpReviveEvent>(),
            },
        });
        
    }
    

}
