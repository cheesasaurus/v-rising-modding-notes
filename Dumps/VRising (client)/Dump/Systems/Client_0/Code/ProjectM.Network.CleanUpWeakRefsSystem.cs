using Unity.Entities;

namespace ProjectM.Network;


[UpdateInGroup(typeof(ProjectM.ReactToDestroyTagGroup))]
[UpdateBefore(typeof(ProjectM.Network.ReturnNetworkIdSystem_Client))]
[RequireMatchingQueriesForUpdateAttribute]
public class CleanUpWeakRefsSystem : SystemBase
{
    EntityQuery __query_1220913519_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1220913519_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.NetworkSnapshot>(),
                ComponentType.ReadOnly<ProjectM.Network.NetworkId>(),
                ComponentType.ReadOnly<Unity.Entities.DestroyTag>(),
            },
        });
        
    }
    

}
