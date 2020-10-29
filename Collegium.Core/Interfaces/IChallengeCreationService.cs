﻿using TP3.Core.Data.ChallengeCreation;
using TP3.Core.Data.Datatable;

namespace TP3.Core.Interfaces
{
    public interface IChallengeCreationService
    {
        GridData<ChallengeCreationGridData> GetAll(DTParameters param, string user);
    }
}