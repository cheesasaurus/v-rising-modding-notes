using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.SetupInitialStatesGroup))]
[UpdateAfter(typeof(ProjectM.SetupInitialStatesGroup_Step1))]
public class SetupInitialStatesGroup_Step2 : ComponentSystemGroup
{

}
