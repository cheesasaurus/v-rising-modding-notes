using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct ModifyDropTableBuffsSystems_Spawn : ISystem, ISystemCompilerGenerated
{
    EntityQuery _MainQuery;
    EntityQuery __query_749055415_0;
    
    // unmanaged system, skipped generating example queries

}
