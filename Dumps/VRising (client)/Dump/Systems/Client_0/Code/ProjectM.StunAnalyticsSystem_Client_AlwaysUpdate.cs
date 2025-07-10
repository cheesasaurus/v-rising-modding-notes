using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[UpdateAfter(typeof(ProjectM.StunAnalyticsSystem_Client_EventHandlers))]
[RequireMatchingQueriesForUpdateAttribute]
public class StunAnalyticsSystem_Client_AlwaysUpdate : SystemBase
{
    EntityQuery __query_1762304844_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1762304844_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CombatMusicListener_Shared>(),
                ComponentType.ReadOnly<ProjectM.Network.LocalCharacter>(),
            },
        });
        
    }
    

}
