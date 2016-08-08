﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using DevZH.UI.Interface;
using DevZH.UI.Interop;

namespace DevZH.UI.Drawing
{
    public class DrawContext : IControlHandle
    {
        public DrawContext(IntPtr ptr)
        {
            ControlHandle = new ControlHandle(ptr);
        }

        public void Fill(Path path, Brush brush)
        {
            var tmp = brush.Internal;
            NativeMethods.DrawFill(ControlHandle, path.ControlHandle, ref tmp);
        }

        public void Stroke(Path path, Brush brush, StrokeParams param)
        {
            var b = brush.Internal;
            var p = param.Internal;
            NativeMethods.DrawStroke(ControlHandle, path.ControlHandle, ref b, ref p);
        }

        public void Clip(Path path)
        {
            NativeMethods.DrawClip(ControlHandle, path.ControlHandle);
        }

        public void Save()
        {
            NativeMethods.DrawSave(ControlHandle);
        }

        public void ReStore()
        {
            NativeMethods.DrawRestore(ControlHandle);
        }

        public void Transform(Matrix matrix)
        {
            NativeMethods.DrawTransform(ControlHandle, matrix);
        }

        public void DrawText(double x, double y, TextLayout layout)
        {
            NativeMethods.DrawText(ControlHandle, x, y, layout.ControlHandle);
        }

        public ControlHandle ControlHandle { get; }
    }
}