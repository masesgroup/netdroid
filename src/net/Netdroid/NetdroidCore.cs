/*
*  Copyright 2024 MASES s.r.l.
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

using System;
using System.Collections.Generic;
using System.Runtime;

namespace MASES.Netdroid
{
    /// <summary>
    /// Public entry point of <see cref="NetdroidCore{T}"/>
    /// </summary>
    public abstract class NetdroidCore<T> : NetdroidCoreBase<T> where T : NetdroidCore<T>
    {
        #region Initialization
        /// <summary>
        /// Public ctor
        /// </summary>
        public NetdroidCore()
        {
            JCOBridge.C2JBridge.JCOBridge.RegisterExceptions(typeof(NetdroidCore<>).Assembly);
        }

        /// <summary>
        /// Default performance options used in initialization
        /// </summary>
        protected virtual IList<string> PerformanceOptions => new List<string>();
        /// <summary>
        /// Adds options to the JVM
        /// </summary>
        protected override IDictionary<string, string> Options
        {
            get
            {
                IDictionary<string, string> opt = new Dictionary<string, string>();
                if (PerformanceOptions != null)
                {
                    foreach (var item in PerformanceOptions)
                    {
                        opt.Add(item, null);
                    }
                }
                return opt;
            }
        }

        /// <summary>
        /// A list of paths to be used in initialization of JVM ClassPath
        /// </summary>
        protected override IList<string> PathToParse
        {
            get
            {
                var lst = base.PathToParse;

                var assembly = typeof(NetdroidCore<>).Assembly;
                var version = assembly.GetName().Version.ToString();
                // 1. check first full version
                var netdroidFile = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(assembly.Location), JARsSubFolder, $"netdroid-{version}.jar");
                if (!System.IO.File.Exists(netdroidFile) && version.EndsWith(".0"))
                {
                    // 2. if not exist remove last part of version
                    version = version.Substring(0, version.LastIndexOf(".0"));
                    netdroidFile = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(assembly.Location), JARsSubFolder, $"netdroid-{version}.jar");
                }
                lst.Add(netdroidFile);
#if !NETDROID_DOCKER_BUILD_ACTIONS
                var androidHome = Environment.GetEnvironmentVariable("ANDROID_HOME");
                var androidSDKVersion = Environment.GetEnvironmentVariable("NETDROID_DOCKER_SDK_VERSION");
                var androidJarPath = System.IO.Path(androidHome, "platforms", $"android-{androidSDKVersion}", "android.jar");
                lst.Add(androidJarPath);
#endif
                return lst;
            }
        }
#endregion
    }
}