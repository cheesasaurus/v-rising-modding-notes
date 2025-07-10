using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct HideWeaponSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_25702554_0;
    EntityQuery __query_25702554_1;
    EntityQuery __query_25702554_2;
    
    // unmanaged system, skipped generating example queries

}
