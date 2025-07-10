using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToPersistenceLoadedGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct ValidateUnitCompositionSpawnerSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_707729589_0;
    EntityQuery __query_707729589_1;
    EntityQuery __query_707729589_2;
    EntityQuery __query_707729589_3;
    
    // unmanaged system, skipped generating example queries

}
