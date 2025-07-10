using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
public class HybridEquipmentStreamingHandler : ProjectM.AssetSubSceneStreamingHandler<ProjectM.HybridEquipmentStreamingHandler.Singleton>
{

}
