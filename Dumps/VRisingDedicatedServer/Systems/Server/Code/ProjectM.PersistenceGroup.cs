using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.AfterDestroyGroup_Server))]
public class PersistenceGroup : ComponentSystemGroup
{

}
