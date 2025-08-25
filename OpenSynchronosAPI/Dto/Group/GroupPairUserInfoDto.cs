using MessagePack;
using OpenSynchronos.API.Data;
using OpenSynchronos.API.Data.Enum;

namespace OpenSynchronos.API.Dto.Group;

[MessagePackObject(keyAsPropertyName: true)]
public record GroupPairUserInfoDto(GroupData Group, UserData User, GroupPairUserInfo GroupUserInfo) : GroupPairDto(Group, User);