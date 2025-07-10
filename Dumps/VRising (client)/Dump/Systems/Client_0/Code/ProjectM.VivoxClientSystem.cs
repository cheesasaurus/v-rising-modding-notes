using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
public class VivoxClientSystem : SystemBase, ProjectM.IInputContext
{
    EntityQuery _CameraUserQuery;
    EntityQuery __query_1655155604_0;
    EntityQuery __query_1655155604_1;
    EntityQuery __query_1655155604_2;
    EntityQuery __query_1655155604_3;
    EntityQuery __query_1655155604_4;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _CameraUserQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CameraUser>(),
            },
        });
        
        __query_1655155604_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.VivoxEvents.ServerRejectEvent>(),
            },
        });
        
        __query_1655155604_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.VivoxEvents.ServerLoginEvent>(),
            },
        });
        
        __query_1655155604_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.VivoxEvents.ServerChannelEvent>(),
            },
        });
        
        __query_1655155604_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.PlayerCharacter>(),
                ComponentType.ReadOnly<ProjectM.CharacterVoiceActivity>(),
            },
        });
        
        __query_1655155604_4 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.UserInfoBufferSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
