using System;
using System.Runtime.CompilerServices;

namespace Phantom.Core.Builtins
{
    [CompilerGlobalScope]
    public class QuickReferences
    {
        public static string MachineName { get { return Environment.MachineName; } }
    }
}
