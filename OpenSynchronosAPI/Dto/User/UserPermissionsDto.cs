using MessagePack;
using OpenSynchronos.API.Data;
using OpenSynchronos.API.Data.Enum;

namespace OpenSynchronos.API.Dto.User;

[MessagePackObject(keyAsPropertyName: true)]
public record UserPermissionsDto(UserData User, UserPermissions Permissions) : UserDto(User);
