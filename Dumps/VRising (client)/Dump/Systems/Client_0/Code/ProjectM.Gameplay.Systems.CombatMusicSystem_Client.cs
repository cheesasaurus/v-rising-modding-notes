using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(PresentationSystemGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class CombatMusicSystem_Client : SystemBase
{
    EntityQuery __query_1806426322_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1806426322_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.CombatMusicListener_Client>(),
                ComponentType.ReadOnly<ProjectM.CombatMusicListener_Shared>(),
                ComponentType.ReadOnly<ProjectM.Network.LocalCharacter>(),
            },
        });
        
    }
    

}
