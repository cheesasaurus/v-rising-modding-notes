using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(InitializationSystemGroup))]
public class ConsoleSystem : SystemBase, ProjectM.IInputContext
{

}
