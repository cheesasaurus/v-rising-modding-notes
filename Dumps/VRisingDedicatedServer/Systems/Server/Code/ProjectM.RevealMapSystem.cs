using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[UpdateAfter(typeof(ProjectM.SetCurrentMapZoneSystem_Server))]
[RequireMatchingQueriesForUpdateAttribute]
public class RevealMapSystem : SystemBase
{
    EntityQuery __query_1615387259_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1615387259_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.CurrentMapZone>(),
                ComponentType.ReadOnly<ProjectM.Network.User>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
                ComponentType.ReadOnly<ProjectM.Network.IsConnected>(),
            },
        });
        
    }
    

}
