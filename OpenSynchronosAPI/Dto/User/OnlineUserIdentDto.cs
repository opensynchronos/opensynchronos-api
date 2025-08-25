using MessagePack;
using OpenSynchronos.API.Data;

namespace OpenSynchronos.API.Dto.User;

[MessagePackObject(keyAsPropertyName: true)]
public record OnlineUserIdentDto(UserData User, string Ident) : UserDto(User);