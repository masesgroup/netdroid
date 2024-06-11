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

/*
*  This file is generated by MASES.JNetReflector (ver. 2.5.2.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Os.Health
{
    #region PackageHealthStats
    public partial class PackageHealthStats
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/health/PackageHealthStats.html#MEASUREMENTS_WAKEUP_ALARMS_COUNT"/>
        /// </summary>
        public static int MEASUREMENTS_WAKEUP_ALARMS_COUNT { get { if (!_MEASUREMENTS_WAKEUP_ALARMS_COUNTReady) { _MEASUREMENTS_WAKEUP_ALARMS_COUNTContent = SGetField<int>(LocalBridgeClazz, "MEASUREMENTS_WAKEUP_ALARMS_COUNT"); _MEASUREMENTS_WAKEUP_ALARMS_COUNTReady = true; } return _MEASUREMENTS_WAKEUP_ALARMS_COUNTContent; } }
        private static int _MEASUREMENTS_WAKEUP_ALARMS_COUNTContent = default;
        private static bool _MEASUREMENTS_WAKEUP_ALARMS_COUNTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/health/PackageHealthStats.html#STATS_SERVICES"/>
        /// </summary>
        public static int STATS_SERVICES { get { if (!_STATS_SERVICESReady) { _STATS_SERVICESContent = SGetField<int>(LocalBridgeClazz, "STATS_SERVICES"); _STATS_SERVICESReady = true; } return _STATS_SERVICESContent; } }
        private static int _STATS_SERVICESContent = default;
        private static bool _STATS_SERVICESReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}