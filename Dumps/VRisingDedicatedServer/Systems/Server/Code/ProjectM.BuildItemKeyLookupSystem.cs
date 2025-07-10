using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.PrefabInitializationGroup))]
[UpdateAfter(typeof(ProjectM.SetupServerSettings))]
[RequireMatchingQueriesForUpdateAttribute]
public struct BuildItemKeyLookupSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _Query;
    EntityQuery __query_773907852_0;
    EntityQuery __query_773907852_1;
    EntityQuery __query_773907852_2;
    EntityQuery __query_773907852_3;
    
    // unmanaged system, skipped generating example queries

}
