using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(InitializationSystemGroup))]
[UpdateAfter(typeof(Unity.Scenes.SceneSystemGroup))]
public class ReactToSceneLoadedGroup : ComponentSystemGroup
{

}
