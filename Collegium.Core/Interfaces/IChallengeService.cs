﻿using TP3.Core.Data.BaseData;
using TP3.Core.Data.Challenge;
using TP3.Core.Data.Datatable;

namespace TP3.Core.Interfaces
{
    public interface IChallengeService
    {
        ResponseData ValidByCode(string code);
        ChallengeQueryData GetByCode(string code);
        GridData<ChallengeGridData> GetAll(DTParameters param, string user);
        ResponseData Create(ChallengeData data, string userName);
        void AddElement(ChallengeData data);
        void AddCommand(ChallengeData data);
        void AddCable(ChallengeData data);
    }
}