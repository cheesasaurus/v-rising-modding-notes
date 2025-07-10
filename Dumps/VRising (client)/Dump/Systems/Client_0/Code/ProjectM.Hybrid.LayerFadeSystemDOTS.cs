using Unity.Entities;

namespace ProjectM.Hybrid;


[UpdateInGroup(typeof(ProjectM.SetHybridDataGroup))]
[UpdateAfter(typeof(ProjectM.Hybrid.AnimatorLayerFadeSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public struct LayerFadeSystemDOTS : ISystem, ISystemCompilerGenerated
{

}
