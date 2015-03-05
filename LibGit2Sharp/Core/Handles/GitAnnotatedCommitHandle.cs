using System.Runtime.InteropServices;

namespace LibGit2Sharp.Core.Handles
{
    public class GitAnnotatedCommitHandle : SafeHandleBase
    {
        protected override bool ReleaseHandleImpl()
        {
            Proxy.git_annotated_commit_free(handle);
            return true;
        }
    }
}
