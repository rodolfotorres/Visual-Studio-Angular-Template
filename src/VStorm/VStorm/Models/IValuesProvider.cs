using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VStorm.Models
{
    public interface IValuesProvider
    {
        IEnumerable<string> GetValues();
    }

    public class ValuesProvider : IValuesProvider
    {
        public IEnumerable<string> GetValues()
        {
            return new string[] { "value1", "value2" };
        }
    }
}
