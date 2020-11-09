using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using TP3.Core.Data.BaseData;
using TP3.Core.Data.Challenge;
using TP3.Core.Helpers;
using TP3.Core.Interfaces;
using TP3.Domain.Entities;

namespace TP3.Core.Implementations
{
    public class EnumService : IEnumService
    {
        public List<CableData> GetAllCableSelectable()
        {
            return Enum.GetValues(typeof(eCableColor)).Cast<eCableColor>().Select(s => new CableData
            {
                Id = (int)s,
                IsSelected = false,
                Order = (int)s
            }).ToList();

        }

        public List<SelectableData> GetNetTypes()
        {
            return Enum.GetValues(typeof(eNetType)).Cast<eNetType>().Select(s => new SelectableData
            {
                Id = (int)s,
                Name = s.GetAttribute<DescriptionAttribute>().Description
            }).ToList();

        }

        public List<SelectableData> GetConnectionTypes()
        {
            return Enum.GetValues(typeof(eConectionType)).Cast<eConectionType>().Select(s => new SelectableData
            {
                Id = (int)s,
                Name = s.GetAttribute<DescriptionAttribute>().Description
            }).ToList();

        }

        public List<SelectableData> GetElements()
        {
            return Enum.GetValues(typeof(eElement)).Cast<eElement>().Select(s => new SelectableData
            {
                Id = (int)s,
                Name = s.GetAttribute<DescriptionAttribute>().Description
            }).ToList();

        }

        public List<SelectableData> GetCables()
        {
            return Enum.GetValues(typeof(eCableColor)).Cast<eCableColor>().Select(s => new SelectableData
            {
                Id = (int)s,
                Name = s.GetAttribute<DescriptionAttribute>().Description
            }).ToList();

        }

        public List<SelectableData> GetCommands()
        {
            return Enum.GetValues(typeof(eCommand)).Cast<eCommand>().Select(s => new SelectableData
            {
                Id = (int)s,
                Name = s.GetAttribute<DescriptionAttribute>().Description
            }).ToList();

        }

    }
}
