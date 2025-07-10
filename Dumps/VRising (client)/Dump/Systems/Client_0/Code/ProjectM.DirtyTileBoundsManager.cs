using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToTilePositionGroup))]
public struct DirtyTileBoundsManager : ISystem, ISystemCompilerGenerated
{
    EntityQuery _NewCustomDirtyWorldBoundQuery;
    EntityQuery __query_631511019_0;
    
    // unmanaged system, skipped generating example queries

}
