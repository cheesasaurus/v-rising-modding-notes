using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class PlayerMapZonesDiscoverySystem : SystemBase
{
    EntityQuery __query_1877634278_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1877634278_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.User>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
                ComponentType.ReadOnly<ProjectM.Network.ConnectedUser>(),
            },
        });
        
    }
    

}
