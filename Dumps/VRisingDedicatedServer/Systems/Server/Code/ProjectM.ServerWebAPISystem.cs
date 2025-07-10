using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.StartSimulationNetworkGroup))]
[UpdateAfter(typeof(ProjectM.ServerBootstrapSystem))]
public class ServerWebAPISystem : SystemBase
{

}
