using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup), OrderFirst = true)]
public class SetupInitialStatesGroup : ComponentSystemGroup
{

}
