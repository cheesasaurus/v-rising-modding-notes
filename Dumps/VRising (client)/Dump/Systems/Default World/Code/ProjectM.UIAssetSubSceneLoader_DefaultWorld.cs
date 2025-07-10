using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(PresentationSystemGroup))]
public class UIAssetSubSceneLoader_DefaultWorld : ProjectM.AssetSubSceneStreamingHandler<ProjectM.UIAssetSubSceneLoader_DefaultWorld.Singleton>
{

}
