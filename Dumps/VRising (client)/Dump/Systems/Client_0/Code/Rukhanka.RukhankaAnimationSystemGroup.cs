using Unity.Entities;

namespace Rukhanka;


[UpdateBefore(typeof(Unity.Transforms.TransformSystemGroup))]
public class RukhankaAnimationSystemGroup : ComponentSystemGroup
{

}
