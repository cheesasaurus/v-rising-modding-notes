using Unity.Entities;

namespace ProjectM.UI;


[UpdateInGroup(typeof(ProjectM.BuildModeGroup), OrderFirst = true)]
[RequireMatchingQueriesForUpdateAttribute]
public class BuildMenuMapper : SystemBase, ProjectM.IInputContext
{

}
