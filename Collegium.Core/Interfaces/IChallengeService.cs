using TP3.Core.Data.BaseData;
using TP3.Core.Data.Challenge;

namespace TP3.Core.Interfaces
{
    public interface IChallengeService
    {
        ResponseData ValidByCode(string code);
        ChallengeQueryData GetByCode(string code);
    }
}