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
*  This file is generated by MASES.JNetReflector (ver. 2.5.1.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Os.Health
{
    #region PidHealthStats
    public partial class PidHealthStats
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/health/PidHealthStats.html#MEASUREMENT_WAKE_NESTING_COUNT"/>
        /// </summary>
        public static int MEASUREMENT_WAKE_NESTING_COUNT { get { if (!_MEASUREMENT_WAKE_NESTING_COUNTReady) { _MEASUREMENT_WAKE_NESTING_COUNTContent = SGetField<int>(LocalBridgeClazz, "MEASUREMENT_WAKE_NESTING_COUNT"); _MEASUREMENT_WAKE_NESTING_COUNTReady = true; } return _MEASUREMENT_WAKE_NESTING_COUNTContent; } }
        private static int _MEASUREMENT_WAKE_NESTING_COUNTContent = default;
        private static bool _MEASUREMENT_WAKE_NESTING_COUNTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/health/PidHealthStats.html#MEASUREMENT_WAKE_START_MS"/>
        /// </summary>
        public static int MEASUREMENT_WAKE_START_MS { get { if (!_MEASUREMENT_WAKE_START_MSReady) { _MEASUREMENT_WAKE_START_MSContent = SGetField<int>(LocalBridgeClazz, "MEASUREMENT_WAKE_START_MS"); _MEASUREMENT_WAKE_START_MSReady = true; } return _MEASUREMENT_WAKE_START_MSContent; } }
        private static int _MEASUREMENT_WAKE_START_MSContent = default;
        private static bool _MEASUREMENT_WAKE_START_MSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/health/PidHealthStats.html#MEASUREMENT_WAKE_SUM_MS"/>
        /// </summary>
        public static int MEASUREMENT_WAKE_SUM_MS { get { if (!_MEASUREMENT_WAKE_SUM_MSReady) { _MEASUREMENT_WAKE_SUM_MSContent = SGetField<int>(LocalBridgeClazz, "MEASUREMENT_WAKE_SUM_MS"); _MEASUREMENT_WAKE_SUM_MSReady = true; } return _MEASUREMENT_WAKE_SUM_MSContent; } }
        private static int _MEASUREMENT_WAKE_SUM_MSContent = default;
        private static bool _MEASUREMENT_WAKE_SUM_MSReady = false; // this is used because in case of generics 

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