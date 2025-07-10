using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.InputGroup))]
[UpdateAfter(typeof(ProjectM.SetInputGroup))]
public class MenuInputSystem : SystemBase, ProjectM.IInputContext
{

}
