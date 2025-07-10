using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
public class UIAssetSubSceneLoader_ClientWorld : ProjectM.AssetSubSceneStreamingHandler<ProjectM.UIAssetSubSceneLoader_ClientWorld.Singleton>
{

}
