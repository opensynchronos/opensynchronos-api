using MessagePack;
using OpenSynchronos.API.Data;

namespace OpenSynchronos.API.Dto.User;

[MessagePackObject(keyAsPropertyName: true)]
public record UserDto(UserData User);