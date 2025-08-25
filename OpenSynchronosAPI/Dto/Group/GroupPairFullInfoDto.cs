using MessagePack;
using OpenSynchronos.API.Data;
using OpenSynchronos.API.Data.Enum;

namespace OpenSynchronos.API.Dto.Group;

[MessagePackObject(keyAsPropertyName: true)]
public record GroupPairFullInfoDto(GroupData Group, UserData User, UserPermissions SelfToOtherPermissions, UserPermissions OtherToSelfPermissions) : GroupPairDto(Group, User);