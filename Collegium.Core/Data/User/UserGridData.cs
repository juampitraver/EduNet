using TP3.Core.Data.BaseData;
using System.ComponentModel.DataAnnotations;

namespace TP3.Core.Data.User
{
    public class UserGridData: BaseGridData
    {
        public long Id { get; set; }
        [Display(Name = "Usuario")]
        public string UserName { get; set; }
    }
}
