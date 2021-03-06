﻿//
// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
//

namespace Microsoft.Azure.Functions.PowerShellWorker.DependencyManagement
{
    using Microsoft.Azure.Functions.PowerShellWorker.Utility;

    internal interface IDependencySnapshotComparer
    {
        bool AreEquivalent(string snapshotPathA, string snapshotPathB, ILogger logger);
    }
}
