using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToPersistenceLoadedGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct RepairModifyRotationDuringCastSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _LoadedModifyRotationDuringCast;
    EntityQuery __query_2009872893_0;
    EntityQuery __query_2009872893_1;
    
    // unmanaged system, skipped generating example queries

}
