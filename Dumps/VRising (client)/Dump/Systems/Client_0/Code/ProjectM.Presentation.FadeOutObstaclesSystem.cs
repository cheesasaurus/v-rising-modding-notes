using Unity.Entities;

namespace ProjectM.Presentation;


[UpdateInGroup(typeof(PresentationSystemGroup))]
[UpdateBefore(typeof(ProjectM.UIGroup))]
[UpdateAfter(typeof(ProjectM.Sequencer.GlobalParticleLifetimeSystem))]
[UpdateAfter(typeof(ProjectM.CheckOnScreenSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public struct FadeOutObstaclesSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _SphereCastQuery;
    EntityQuery __query_807115233_0;
    EntityQuery __query_807115233_1;
    EntityQuery __query_807115233_2;
    EntityQuery __query_807115233_3;
    EntityQuery __query_807115233_4;
    EntityQuery __query_807115233_5;
    EntityQuery __query_807115233_6;
    EntityQuery __query_807115233_7;
    EntityQuery __query_807115233_8;
    EntityQuery __query_807115233_9;
    EntityQuery __query_807115233_10;
    EntityQuery __query_807115233_11;
    
    // unmanaged system, skipped generating example queries

}
