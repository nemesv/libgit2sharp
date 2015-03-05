﻿namespace LibGit2Sharp.Core.Handles
{
    public class BranchIteratorSafeHandle : SafeHandleBase
    {
        protected override bool ReleaseHandleImpl()
        {
            Proxy.git_branch_iterator_free(handle);
            return true;
        }
    }
}
