using Unity.Entities;

namespace Rukhanka;


[UpdateInGroup(typeof(InitializationSystemGroup), OrderLast = true)]
public struct BlobDatabaseUpdateSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery newBlobAssetsQuery;
    EntityQuery removedBlobAssetsQuery;
    EntityQuery __query_1017308855_0;
    EntityQuery __query_1017308855_1;
    EntityQuery __query_1017308855_2;
    EntityQuery __query_1017308855_3;
    
    // unmanaged system, skipped generating example queries

}
