﻿using System;
using System.Collections.Generic;

namespace Orth.Windsor.Owinlifestyle
{
    internal interface IOwinRequestScopeContext
    {
        IDictionary<string, object> Items { get; }
        DateTime Timestamp { get; }
        void EndRequest();
    }
}
