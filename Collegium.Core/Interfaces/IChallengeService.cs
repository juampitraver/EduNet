using TP3.Core.Data.BaseData;
using TP3.Core.Data.Challenge;
using TP3.Core.Data.ChallengeCreation;
using TP3.Core.Data.Datatable;

namespace TP3.Core.Interfaces
{
    public interface IChallengeService
    {
        ResponseData ValidByCode(string code);
        ChallengeQueryData GetByCode(string code);
        GridData<ChallengeCreationGridData> GetAll(DTParameters param, string user);
    }
}