/*
*  Copyright 2025 MASES s.r.l.
*
*  Licensed under the Apache License, Version 2.0 (the "License");
*  you may not use this file except in compliance with the License.
*  You may obtain a copy of the License at
*
*  http://www.apache.org/licenses/LICENSE-2.0
*
*  Unless required by applicable law or agreed to in writing, software
*  distributed under the License is distributed on an "AS IS" BASIS,
*  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
*  See the License for the specific language governing permissions and
*  limitations under the License.
*
*  Refer to LICENSE for more information.
*/

using MASES.CLIParser;
using MASES.JNet.Specific.CLI;
using MASES.Netdroid;
using System.Collections.Generic;
using System.IO;

namespace MASES.Netdroid.CLI
{
    /// <summary>
    /// Public entry point of <see cref="NetdroidCLICore{T}"/>
    /// </summary>
    public abstract class NetdroidCLICore<T> : NetdroidCore<T> where T : NetdroidCLICore<T>
    {
        #region Initialization
        /// <inheritdoc/>
        public override IEnumerable<IArgumentMetadata> CommandLineArguments => base.CommandLineArguments.SetCLICommandLineArguments();

        /// <summary>
        /// Public ctor
        /// </summary>
        public NetdroidCLICore()
        {
            this.InitCLI();
        }

        /// <inheritdoc/>
        protected override string[] ProcessCommandLine()
        {
            var result = base.ProcessCommandLine();
            return this.ProcessCLIParsedArgs(result, settingsCallback: (className) =>
            {
                switch (className)
                {
                    default:
                        ApplicationInitialHeapSize = ApplicationHeapSize = System.Environment.Is64BitOperatingSystem ? "1G" : "512M";
                        break;
                }
            });
        }

        /// <inheritdoc/>
        protected override IList<string> PathToParse => base.PathToParse.SetCLIPathToParse();
        #endregion

#if DEBUG
        public override bool EnableDebug => true;
#endif
    }
    /// <summary>
    /// Concrete implementation of <see cref="NetdroidCLICore{T}"/>
    /// </summary>
    internal class NetdroidCLICore : NetdroidCLICore<NetdroidCLICore>
    {
    }
}