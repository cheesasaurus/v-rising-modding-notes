using Unity.Entities;

namespace ProjectM.Hybrid;


[UpdateInGroup(typeof(PresentationSystemGroup))]
[UpdateBefore(typeof(ProjectM.Hybrid.HybridModelSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public struct DetectGenderChangeSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_735696323_0;
    
    // unmanaged system, skipped generating example queries

}
