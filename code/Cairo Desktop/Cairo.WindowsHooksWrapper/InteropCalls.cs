namespace Cairo.WindowsHooksWrapper
{
    using System;
    using System.Runtime.InteropServices;


    internal class InteropCalls
    {
        [DllImport("Cairo.WindowsHooks.dll", CallingConvention = CallingConvention.StdCall)]
        internal static extern void SetSystrayCallback(Delegate theDelegate);

        [DllImport("Cairo.WindowsHooks.dll", CallingConvention = CallingConvention.StdCall)]
        internal static extern void SetTaskCallback(Delegate theDelegate);

        [DllImport("Cairo.WindowsHooks.dll", CallingConvention = CallingConvention.StdCall)]
        internal static extern void InitializeSystray();

        [DllImport("Cairo.WindowsHooks.dll", CallingConvention = CallingConvention.StdCall)]
        internal static extern void InitializeTask();

        [DllImport("Cairo.WindowsHooks.dll", CallingConvention = CallingConvention.StdCall)]
        internal static extern void Run();

        [DllImport("Cairo.WindowsHooks.dll", CallingConvention = CallingConvention.StdCall)]
        internal static extern void ShutdownAll();

        [DllImport("Cairo.WindowsHooks.dll", CallingConvention = CallingConvention.StdCall)]
        internal static extern void ShutdownTask();

        [DllImport("Cairo.WindowsHooks.dll", CallingConvention = CallingConvention.StdCall)]
        internal static extern void ShutdownSystray();
    }
}
