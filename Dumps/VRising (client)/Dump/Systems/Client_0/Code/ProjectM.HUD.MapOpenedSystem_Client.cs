using Unity.Entities;

namespace ProjectM.HUD;


[UpdateInGroup(typeof(InitializationSystemGroup))]
[UpdateBefore(typeof(ProjectM.UI.OpenHUDMenuSystem))]
public class MapOpenedSystem_Client : SystemBase
{

}
