using System;

namespace LibGit2Sharp.Core.Handles
{
    public class NullRepositorySafeHandle : SafeHandleBase
    {
        public NullRepositorySafeHandle()
        {
            handle = IntPtr.Zero;
        }

        protected override bool ReleaseHandleImpl()
        {
            // Nothing to release
            return true;
        }
    }
}
