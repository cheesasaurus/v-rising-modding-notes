using Unity.Entities;

namespace ProjectM.Network;


[UpdateInGroup(typeof(ProjectM.BeforeSerializeBarrierGroup), OrderFirst = true)]
public class UserActivityGridSystem : SystemBase
{
    EntityQuery __query_297698742_0;
    EntityQuery __query_297698742_1;
    EntityQuery __query_297698742_2;
    EntityQuery __query_297698742_3;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_297698742_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Controller>(),
                ComponentType.ReadOnly<ProjectM.Network.User>(),
                ComponentType.ReadOnly<ProjectM.Network.InputCommandDataProxy>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
                ComponentType.ReadOnly<ProjectM.Network.ConnectedUser>(),
            },
        });
        
        __query_297698742_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Controller>(),
                ComponentType.ReadOnly<ProjectM.Network.User>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
                ComponentType.ReadOnly<ProjectM.Network.LocalUser>(),
            },
        });
        
        __query_297698742_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Network.UserActivityGrid>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_297698742_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.UserActivityGrid>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
