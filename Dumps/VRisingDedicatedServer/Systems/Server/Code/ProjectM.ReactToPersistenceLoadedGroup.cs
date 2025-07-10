using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.LoadPersistenceGroup))]
public class ReactToPersistenceLoadedGroup : ComponentSystemGroup
{

}
