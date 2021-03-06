﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panacea.Modularity.Imprivata
{
    public interface IImprivataPlugin : IPlugin
    {
        Task<AuthenticationResult> AuthenticateCardAsync(string code, List<string> imprivataServers);
    }
}
