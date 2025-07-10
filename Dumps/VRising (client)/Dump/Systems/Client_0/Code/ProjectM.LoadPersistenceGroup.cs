using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(InitializationSystemGroup))]
[UpdateAfter(typeof(ProjectM.PrefabInitializationGroup))]
public class LoadPersistenceGroup : ComponentSystemGroup
{

}
