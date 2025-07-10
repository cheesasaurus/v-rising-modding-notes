using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ScheduleGroup), OrderFirst = true)]
public struct MegaStaticManagerSystem_Client : ISystem, ISystemCompilerGenerated
{
    EntityQuery _Query;
    EntityQuery __query_287427096_0;
    EntityQuery __query_287427096_1;
    EntityQuery __query_287427096_2;
    EntityQuery __query_287427096_3;
    EntityQuery __query_287427096_4;
    EntityQuery __query_287427096_5;
    EntityQuery __query_287427096_6;
    
    // unmanaged system, skipped generating example queries

}
