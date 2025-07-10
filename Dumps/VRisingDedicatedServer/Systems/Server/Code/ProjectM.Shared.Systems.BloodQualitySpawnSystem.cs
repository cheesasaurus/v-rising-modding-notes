using Unity.Entities;

namespace ProjectM.Shared.Systems;


[UpdateInGroup(typeof(ProjectM.SetupInitialStatesGroup_Step1))]
[RequireMatchingQueriesForUpdateAttribute]
public struct BloodQualitySpawnSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _MainQuery;
    EntityQuery __query_1995313219_0;
    EntityQuery __query_1995313219_1;
    EntityQuery __query_1995313219_2;
    EntityQuery __query_1995313219_3;
    
    // unmanaged system, skipped generating example queries

}
