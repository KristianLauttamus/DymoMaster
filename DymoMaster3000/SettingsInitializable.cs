using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DymoMaster3000
{
    interface SettingsInitializable
    {
        void loadFromSettings();
        Dictionary<String, String> getForSettings();
    }
}
