using Unity.Entities;

namespace ProjectM.Haptics;


[UpdateInGroup(typeof(ProjectM.PrefabInitializationGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct HapticDamageFeedbackSingletonSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_368764041_0;
    
    // unmanaged system, skipped generating example queries

}
