using Unity.Entities;

namespace ProjectM.Network;


[UpdateInGroup(typeof(ProjectM.FinalizeGroup_Server))]
public class ClearInputCommands : SystemBase
{
    EntityQuery __query_1019329049_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1019329049_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Network.InputCommandBufferElement>(),
            },
        });
        
    }
    

}
