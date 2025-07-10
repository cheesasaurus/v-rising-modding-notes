using Unity.Entities;

namespace ProjectM.Presentation;


[UpdateInGroup(typeof(PresentationSystemGroup), OrderFirst = true)]
[UpdateBefore(typeof(ProjectM.FluffGroup))]
[UpdateAfter(typeof(ProjectM.CameraPresentationGroup))]
public struct OccluderRasterizationSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _LoadTrianglesQuery;
    EntityQuery __query_615419569_0;
    EntityQuery __query_615419569_1;
    EntityQuery __query_615419569_2;
    EntityQuery __query_615419569_3;
    EntityQuery __query_615419569_4;
    EntityQuery __query_615419569_5;
    EntityQuery __query_615419569_6;
    EntityQuery __query_615419569_7;
    
    // unmanaged system, skipped generating example queries

}
