using Unity.Entities;

namespace Unity.Rendering;


[UpdateInGroup(typeof(PresentationSystemGroup))]
[UpdateAfter(typeof(Unity.Rendering.StructuralChangePresentationSystemGroup))]
public class UpdatePresentationSystemGroup : ComponentSystemGroup
{

}
