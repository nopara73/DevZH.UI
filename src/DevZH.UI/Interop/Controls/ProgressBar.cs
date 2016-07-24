﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace DevZH.UI.Interop
{
    internal partial class NativeMethods
    {
        [DllImport(LibUI, CallingConvention = CallingConvention.Cdecl, EntryPoint = "uiProgressBarValue")]
        public static extern int ProgressBarValue(ControlHandle progressBar);

        [DllImport(LibUI, CallingConvention = CallingConvention.Cdecl, EntryPoint = "uiProgressBarSetValue")]
        public static extern void ProgressBarSetValue(ControlHandle progressBar, int number);

        [DllImport(LibUI, CallingConvention = CallingConvention.Cdecl, EntryPoint = "uiNewProgressBar")]
        public static extern ControlHandle NewProgressBar();
    }
}