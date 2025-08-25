using MessagePack;
using OpenSynchronos.API.Data;
using OpenSynchronos.API.Data.Enum;

namespace OpenSynchronos.API.Dto.Group;

[MessagePackObject(keyAsPropertyName: true)]
public record GroupPermissionDto(GroupData Group, GroupPermissions Permissions) : GroupDto(Group);