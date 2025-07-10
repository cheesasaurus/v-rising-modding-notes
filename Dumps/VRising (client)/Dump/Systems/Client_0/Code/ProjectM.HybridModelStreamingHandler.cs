using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
public class HybridModelStreamingHandler : ProjectM.AssetSubSceneStreamingHandler<ProjectM.HybridModelStreamingHandler.Singleton>
{

}
