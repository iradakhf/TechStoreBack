using TechStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechStore.Interfaces
{
   public interface ILayoutService
    {
      Task<IDictionary<string, string>> GetSettings();
    }
}
