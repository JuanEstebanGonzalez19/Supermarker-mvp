using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarker_mvp.Models
{
    internal interface IPayModeRepository
    {
        void Add(PayModeModel PayModeModel);
        void Edit(PayModeModel PayModeModel);
        void Delete(int id);
        IEnumerable<PayModeModel> GetAll();
        IEnumerable<PayModeModel> GetByValue(string value);
    }
}
