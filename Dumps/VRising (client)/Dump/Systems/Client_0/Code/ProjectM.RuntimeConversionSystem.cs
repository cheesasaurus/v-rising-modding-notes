using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(InitializationSystemGroup))]
[UpdateBefore(typeof(ProjectM.PrefabInitializationGroup))]
[UpdateBefore(typeof(Unity.Scenes.SceneSystemGroup))]
public class RuntimeConversionSystem : SystemBase
{

}
