﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Runtime.InteropServices;

internal static partial class Interop
{
    internal static partial class Gdi32
    {
        [DllImport(Libraries.Gdi32, ExactSpelling = true)]
        private static extern BOOL DeleteObject(nint hObject);

        public static BOOL DeleteObject(HGDIOBJ hObject) => DeleteObject(hObject.Handle);
    }
}
