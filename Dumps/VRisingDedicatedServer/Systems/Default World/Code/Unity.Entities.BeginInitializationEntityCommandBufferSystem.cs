
namespace Unity.Entities;


[UpdateInGroup(typeof(InitializationSystemGroup), OrderFirst = true)]
public class BeginInitializationEntityCommandBufferSystem : EntityCommandBufferSystem
{

}
