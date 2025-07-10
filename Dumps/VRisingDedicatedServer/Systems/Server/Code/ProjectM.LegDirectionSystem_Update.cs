using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct LegDirectionSystem_Update : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_1821474746_0;
    EntityQuery __query_1821474746_1;
    
    // unmanaged system, skipped generating example queries

}
