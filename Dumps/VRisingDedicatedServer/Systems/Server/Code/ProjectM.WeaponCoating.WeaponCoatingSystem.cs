using Unity.Entities;

namespace ProjectM.WeaponCoating;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct WeaponCoatingSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _ActiveCoatingQuery;
    EntityQuery __query_1145599454_0;
    EntityQuery __query_1145599454_1;
    EntityQuery __query_1145599454_2;
    
    // unmanaged system, skipped generating example queries

}
