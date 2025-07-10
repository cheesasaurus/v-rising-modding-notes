using Unity.Entities;

namespace Rukhanka;


[UpdateInGroup(typeof(Rukhanka.RukhankaDeformationSystemGroup))]
[UpdateAfter(typeof(Rukhanka.MeshDeformationSystem))]
public struct GPUAttachmentsUpdateSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_1737606538_0;
    EntityQuery __query_1737606538_1;
    
    // unmanaged system, skipped generating example queries

}
