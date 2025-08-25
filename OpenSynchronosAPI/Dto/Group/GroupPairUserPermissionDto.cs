using MessagePack;
using OpenSynchronos.API.Data;
using OpenSynchronos.API.Data.Enum;

namespace OpenSynchronos.API.Dto.Group;

[MessagePackObject(keyAsPropertyName: true)]
public record GroupPairUserPermissionDto(GroupData Group, UserData User, GroupUserPreferredPermissions GroupPairPermissions) : GroupPairDto(Group, User);