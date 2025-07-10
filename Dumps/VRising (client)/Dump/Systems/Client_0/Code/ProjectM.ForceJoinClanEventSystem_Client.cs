using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct ForceJoinClanEventSystem_Client : ISystem, ISystemCompilerGenerated
{
    EntityQuery _ErrorResponseQuery;
    EntityQuery _AdminForceJoinedYourClanQuery;
    EntityQuery __query_1636139949_0;
    EntityQuery __query_1636139949_1;
    EntityQuery __query_1636139949_2;
    EntityQuery __query_1636139949_3;
    
    // unmanaged system, skipped generating example queries

}
