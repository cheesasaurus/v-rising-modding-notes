using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
public class VivoxConnectionSystem : SystemBase
{
    EntityQuery __query_337126773_0;
    EntityQuery __query_337126773_1;
    EntityQuery __query_337126773_2;
    EntityQuery __query_337126773_3;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_337126773_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.CharacterVoiceActivity>(),
            },
        });
        
        __query_337126773_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.VivoxEvents.ClientStateEvent>(),
            },
        });
        
        __query_337126773_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.VivoxEvents.ClientStateEvent>(),
            },
        });
        
        __query_337126773_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.VivoxEvents.ClientEvent>(),
            },
        });
        
    }
    

}
