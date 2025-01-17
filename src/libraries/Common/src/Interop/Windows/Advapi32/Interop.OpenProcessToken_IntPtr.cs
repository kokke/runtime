// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.Win32.SafeHandles;
using System.Runtime.InteropServices;
using System;
using System.Security.Principal;

internal static partial class Interop
{
    internal static partial class Advapi32
    {
#if DLLIMPORTGENERATOR_ENABLED
        [GeneratedDllImport(Libraries.Advapi32, CharSet = CharSet.Unicode, SetLastError = true)]
        internal static partial bool OpenProcessToken(
#else
        [DllImport(Libraries.Advapi32, CharSet = CharSet.Unicode, SetLastError = true)]
        internal static extern bool OpenProcessToken(
#endif
            IntPtr ProcessToken,
            TokenAccessLevels DesiredAccess,
            out SafeTokenHandle TokenHandle);
    }
}
