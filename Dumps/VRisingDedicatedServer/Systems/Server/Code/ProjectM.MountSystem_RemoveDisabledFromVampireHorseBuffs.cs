using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToPersistenceLoadedGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct MountSystem_RemoveDisabledFromVampireHorseBuffs : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_1228665815_0;
    
    // unmanaged system, skipped generating example queries

}
