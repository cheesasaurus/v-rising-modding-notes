using Unity.Entities;

namespace ProjectM.UI;


[UpdateInGroup(typeof(ProjectM.UIGroup))]
public class ClanClientSystem : SystemBase, ProjectM.IInputContext
{
    EntityQuery __query_1794488533_0;
    EntityQuery __query_1794488533_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1794488533_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ClanInviteRequest_Shared>(),
                ComponentType.ReadOnly<ProjectM.Age>(),
            },
        });
        
        __query_1794488533_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ServerGameBalanceSettings>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
