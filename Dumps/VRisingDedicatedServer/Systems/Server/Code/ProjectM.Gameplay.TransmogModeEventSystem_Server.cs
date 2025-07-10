using Unity.Entities;

namespace ProjectM.Gameplay;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class TransmogModeEventSystem_Server : SystemBase
{
    EntityQuery _ChangeTransmogModeEntityQuery;
    EntityQuery __query_1329016525_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _ChangeTransmogModeEntityQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.Network.ChangeTransmogModeEvent>(),
            },
        });
        
        __query_1329016525_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.Network.ChangeTransmogModeEvent>(),
            },
        });
        
    }
    

}
