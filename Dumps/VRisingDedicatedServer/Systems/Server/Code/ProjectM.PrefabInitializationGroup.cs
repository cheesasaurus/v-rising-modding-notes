using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(InitializationSystemGroup))]
[UpdateAfter(typeof(ProjectM.ReactToSceneLoadedGroup))]
public class PrefabInitializationGroup : ComponentSystemGroup
{

}
