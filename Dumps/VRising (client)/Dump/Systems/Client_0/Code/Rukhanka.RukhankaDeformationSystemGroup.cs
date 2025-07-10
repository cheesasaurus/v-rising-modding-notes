using Unity.Entities;

namespace Rukhanka;


[UpdateInGroup(typeof(PresentationSystemGroup))]
[UpdateBefore(typeof(Unity.Rendering.DeformationsInPresentation))]
[UpdateAfter(typeof(Unity.Rendering.RegisterMaterialsAndMeshesSystem))]
public class RukhankaDeformationSystemGroup : ComponentSystemGroup
{

}
