using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToPersistenceLoadedGroup))]
public struct AbilityIgnoreSettingsPrefabPatchingSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _LoadedAbilitiesWithoutIgnoreSettings;
    EntityQuery __query_1309191991_0;
    EntityQuery __query_1309191991_1;
    
    // unmanaged system, skipped generating example queries

}
