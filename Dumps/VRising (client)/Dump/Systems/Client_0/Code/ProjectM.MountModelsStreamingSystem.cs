using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(PresentationSystemGroup))]
[UpdateAfter(typeof(ProjectM.Hybrid.HybridModelSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public struct MountModelsStreamingSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _MainQuery;
    EntityQuery __query_1925403165_0;
    EntityQuery __query_1925403165_1;
    EntityQuery __query_1925403165_2;
    
    // unmanaged system, skipped generating example queries

}
