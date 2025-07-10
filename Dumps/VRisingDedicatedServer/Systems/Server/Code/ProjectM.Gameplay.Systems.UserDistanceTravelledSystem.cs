using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class UserDistanceTravelledSystem : SystemBase
{
    EntityQuery __query_26425413_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_26425413_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Controller>(),
                ComponentType.ReadWrite<ProjectM.Network.UserStats>(),
                ComponentType.ReadOnly<ProjectM.Network.ConnectedUser>(),
            },
        });
        
    }
    

}
