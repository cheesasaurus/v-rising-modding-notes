using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
public struct UpdateMapIconsSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _Query;
    
    // unmanaged system, skipped generating example queries

}
