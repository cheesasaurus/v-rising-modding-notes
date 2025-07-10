using Unity.Entities;

namespace ProjectM.Network;


[UpdateInGroup(typeof(ProjectM.AfterDeserializationGroup))]
public class RemoveOldInputCommands : SystemBase
{
    EntityQuery __query_1019328999_0;
    EntityQuery __query_1019328999_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1019328999_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.InputCommandDataProxy>(),
                ComponentType.ReadWrite<ProjectM.Network.InputCommandBufferElement>(),
                ComponentType.ReadOnly<ProjectM.Network.LocalUser>(),
            },
        });
        
        __query_1019328999_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.ClientNetworkState>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
