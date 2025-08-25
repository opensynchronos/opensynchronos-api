using MessagePack;
using OpenSynchronos.API.Data;

namespace OpenSynchronos.API.Dto.User;

[MessagePackObject(keyAsPropertyName: true)]
public record OnlineUserCharaDataDto(UserData User, CharacterData CharaData) : UserDto(User);