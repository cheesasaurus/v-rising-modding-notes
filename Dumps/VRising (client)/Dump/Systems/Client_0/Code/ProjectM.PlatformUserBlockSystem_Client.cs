using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.StartSimulationGroup))]
[UpdateAfter(typeof(ProjectM.ClientBootstrapSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class PlatformUserBlockSystem_Client : SystemBase
{
    EntityQuery _Query;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.PlatformBlockedUserExistsEvent>(),
            },
        });
        
    }
    

}
