using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.SetupInitialStatesGroup_Step2))]
[RequireMatchingQueriesForUpdateAttribute]
public struct RemoveUnitLevelChangedTagsSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _MainQuery;
    EntityQuery __query_1076210094_0;
    
    // unmanaged system, skipped generating example queries

}
