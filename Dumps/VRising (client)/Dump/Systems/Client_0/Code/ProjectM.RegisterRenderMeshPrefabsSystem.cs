using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.PrefabInitializationGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct RegisterRenderMeshPrefabsSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _Query;
    EntityQuery __query_512611721_0;
    
    // unmanaged system, skipped generating example queries

}
