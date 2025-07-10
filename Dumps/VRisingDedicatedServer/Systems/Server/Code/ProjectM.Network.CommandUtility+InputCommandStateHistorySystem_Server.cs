using Unity.Entities;

namespace ProjectM.Network;


[UpdateInGroup(typeof(ProjectM.ReactToTileBoundsGroup))]
[UpdateAfter(typeof(ProjectM.UpdateTileCellsSystem_Server))]
public class InputCommandStateHistorySystem_Server : ProjectM.Network.CommandUtility.InputCommandStateHistorySystem_Base
{
    EntityQuery __query_1019329073_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1019329073_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Controller>(),
                ComponentType.ReadWrite<ProjectM.Network.InputCommandStateHistoryBufferElement>(),
            },
            Any = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.LocalUser>(),
                ComponentType.ReadOnly<ProjectM.Network.IsConnected>(),
            },
        });
        
    }
    

}
