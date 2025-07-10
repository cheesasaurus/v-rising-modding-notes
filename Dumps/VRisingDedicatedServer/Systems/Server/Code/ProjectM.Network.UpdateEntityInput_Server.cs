using Unity.Entities;

namespace ProjectM.Network;


[UpdateInGroup(typeof(ProjectM.DeserializeGroup))]
[UpdateAfter(typeof(ProjectM.Network.DeserializeUserInputSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class UpdateEntityInput_Server : SystemBase
{
    EntityQuery __query_1019327416_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1019327416_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.EntityInput>(),
                ComponentType.ReadOnly<ProjectM.Controller>(),
                ComponentType.ReadOnly<ProjectM.Network.InputCommandBufferElement>(),
                ComponentType.ReadOnly<ProjectM.Network.IsConnected>(),
            },
        });
        
    }
    

}
