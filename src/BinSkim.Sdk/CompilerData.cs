﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.CodeAnalysis.IL.Sdk
{
    public struct CompilerData
    {
        public string Language { get; set; }
        public string BinaryType { get; set; }
        public string FileVersion { get; set; }
        public string CompilerName { get; set; }
        public string DebuggingFileName { get; set; }
        public string DebuggingFileGuid { get; set; }
        public string CompilerBackEndVersion { get; set; }
        public string CompilerFrontEndVersion { get; set; }

        public override string ToString()
        {
            return $"{CompilerName},{CompilerBackEndVersion},{CompilerFrontEndVersion},{FileVersion},{BinaryType},{Language},{DebuggingFileName},{DebuggingFileGuid}";
        }
    }
}
