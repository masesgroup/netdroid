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
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Telephony
{
    #region CellSignalStrength
    public partial class CellSignalStrength
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/CellSignalStrength.html#SIGNAL_STRENGTH_GOOD"/>
        /// </summary>
        public static int SIGNAL_STRENGTH_GOOD { get { if (!_SIGNAL_STRENGTH_GOODReady) { _SIGNAL_STRENGTH_GOODContent = SGetField<int>(LocalBridgeClazz, "SIGNAL_STRENGTH_GOOD"); _SIGNAL_STRENGTH_GOODReady = true; } return _SIGNAL_STRENGTH_GOODContent; } }
        private static int _SIGNAL_STRENGTH_GOODContent = default;
        private static bool _SIGNAL_STRENGTH_GOODReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/CellSignalStrength.html#SIGNAL_STRENGTH_GREAT"/>
        /// </summary>
        public static int SIGNAL_STRENGTH_GREAT { get { if (!_SIGNAL_STRENGTH_GREATReady) { _SIGNAL_STRENGTH_GREATContent = SGetField<int>(LocalBridgeClazz, "SIGNAL_STRENGTH_GREAT"); _SIGNAL_STRENGTH_GREATReady = true; } return _SIGNAL_STRENGTH_GREATContent; } }
        private static int _SIGNAL_STRENGTH_GREATContent = default;
        private static bool _SIGNAL_STRENGTH_GREATReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/CellSignalStrength.html#SIGNAL_STRENGTH_MODERATE"/>
        /// </summary>
        public static int SIGNAL_STRENGTH_MODERATE { get { if (!_SIGNAL_STRENGTH_MODERATEReady) { _SIGNAL_STRENGTH_MODERATEContent = SGetField<int>(LocalBridgeClazz, "SIGNAL_STRENGTH_MODERATE"); _SIGNAL_STRENGTH_MODERATEReady = true; } return _SIGNAL_STRENGTH_MODERATEContent; } }
        private static int _SIGNAL_STRENGTH_MODERATEContent = default;
        private static bool _SIGNAL_STRENGTH_MODERATEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/CellSignalStrength.html#SIGNAL_STRENGTH_NONE_OR_UNKNOWN"/>
        /// </summary>
        public static int SIGNAL_STRENGTH_NONE_OR_UNKNOWN { get { if (!_SIGNAL_STRENGTH_NONE_OR_UNKNOWNReady) { _SIGNAL_STRENGTH_NONE_OR_UNKNOWNContent = SGetField<int>(LocalBridgeClazz, "SIGNAL_STRENGTH_NONE_OR_UNKNOWN"); _SIGNAL_STRENGTH_NONE_OR_UNKNOWNReady = true; } return _SIGNAL_STRENGTH_NONE_OR_UNKNOWNContent; } }
        private static int _SIGNAL_STRENGTH_NONE_OR_UNKNOWNContent = default;
        private static bool _SIGNAL_STRENGTH_NONE_OR_UNKNOWNReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/CellSignalStrength.html#SIGNAL_STRENGTH_POOR"/>
        /// </summary>
        public static int SIGNAL_STRENGTH_POOR { get { if (!_SIGNAL_STRENGTH_POORReady) { _SIGNAL_STRENGTH_POORContent = SGetField<int>(LocalBridgeClazz, "SIGNAL_STRENGTH_POOR"); _SIGNAL_STRENGTH_POORReady = true; } return _SIGNAL_STRENGTH_POORContent; } }
        private static int _SIGNAL_STRENGTH_POORContent = default;
        private static bool _SIGNAL_STRENGTH_POORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/CellSignalStrength.html#getAsuLevel()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetAsuLevel()
        {
            return IExecuteWithSignature<int>("getAsuLevel", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/CellSignalStrength.html#getDbm()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetDbm()
        {
            return IExecuteWithSignature<int>("getDbm", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/CellSignalStrength.html#getLevel()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetLevel()
        {
            return IExecuteWithSignature<int>("getLevel", "()I");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}