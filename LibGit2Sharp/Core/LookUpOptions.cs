using System;

namespace LibGit2Sharp.Core
{
    [Flags]
    public enum LookUpOptions
    {
        None = 0,
        ThrowWhenNoGitObjectHasBeenFound = 1,
        DereferenceResultToCommit = 2,
        ThrowWhenCanNotBeDereferencedToACommit = 4,
    }
}
