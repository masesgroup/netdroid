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
*  This file is generated by MASES.JNetReflector (ver. 2.5.5.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Nfc.Cardemulation
{
    #region PollingFrame
    public partial class PollingFrame
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/cardemulation/PollingFrame.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/cardemulation/PollingFrame.html#POLLING_LOOP_TYPE_A"/>
        /// </summary>
        public static int POLLING_LOOP_TYPE_A { get { if (!_POLLING_LOOP_TYPE_AReady) { _POLLING_LOOP_TYPE_AContent = SGetField<int>(LocalBridgeClazz, "POLLING_LOOP_TYPE_A"); _POLLING_LOOP_TYPE_AReady = true; } return _POLLING_LOOP_TYPE_AContent; } }
        private static int _POLLING_LOOP_TYPE_AContent = default;
        private static bool _POLLING_LOOP_TYPE_AReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/cardemulation/PollingFrame.html#POLLING_LOOP_TYPE_B"/>
        /// </summary>
        public static int POLLING_LOOP_TYPE_B { get { if (!_POLLING_LOOP_TYPE_BReady) { _POLLING_LOOP_TYPE_BContent = SGetField<int>(LocalBridgeClazz, "POLLING_LOOP_TYPE_B"); _POLLING_LOOP_TYPE_BReady = true; } return _POLLING_LOOP_TYPE_BContent; } }
        private static int _POLLING_LOOP_TYPE_BContent = default;
        private static bool _POLLING_LOOP_TYPE_BReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/cardemulation/PollingFrame.html#POLLING_LOOP_TYPE_F"/>
        /// </summary>
        public static int POLLING_LOOP_TYPE_F { get { if (!_POLLING_LOOP_TYPE_FReady) { _POLLING_LOOP_TYPE_FContent = SGetField<int>(LocalBridgeClazz, "POLLING_LOOP_TYPE_F"); _POLLING_LOOP_TYPE_FReady = true; } return _POLLING_LOOP_TYPE_FContent; } }
        private static int _POLLING_LOOP_TYPE_FContent = default;
        private static bool _POLLING_LOOP_TYPE_FReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/cardemulation/PollingFrame.html#POLLING_LOOP_TYPE_OFF"/>
        /// </summary>
        public static int POLLING_LOOP_TYPE_OFF { get { if (!_POLLING_LOOP_TYPE_OFFReady) { _POLLING_LOOP_TYPE_OFFContent = SGetField<int>(LocalBridgeClazz, "POLLING_LOOP_TYPE_OFF"); _POLLING_LOOP_TYPE_OFFReady = true; } return _POLLING_LOOP_TYPE_OFFContent; } }
        private static int _POLLING_LOOP_TYPE_OFFContent = default;
        private static bool _POLLING_LOOP_TYPE_OFFReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/cardemulation/PollingFrame.html#POLLING_LOOP_TYPE_ON"/>
        /// </summary>
        public static int POLLING_LOOP_TYPE_ON { get { if (!_POLLING_LOOP_TYPE_ONReady) { _POLLING_LOOP_TYPE_ONContent = SGetField<int>(LocalBridgeClazz, "POLLING_LOOP_TYPE_ON"); _POLLING_LOOP_TYPE_ONReady = true; } return _POLLING_LOOP_TYPE_ONContent; } }
        private static int _POLLING_LOOP_TYPE_ONContent = default;
        private static bool _POLLING_LOOP_TYPE_ONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/cardemulation/PollingFrame.html#POLLING_LOOP_TYPE_UNKNOWN"/>
        /// </summary>
        public static int POLLING_LOOP_TYPE_UNKNOWN { get { if (!_POLLING_LOOP_TYPE_UNKNOWNReady) { _POLLING_LOOP_TYPE_UNKNOWNContent = SGetField<int>(LocalBridgeClazz, "POLLING_LOOP_TYPE_UNKNOWN"); _POLLING_LOOP_TYPE_UNKNOWNReady = true; } return _POLLING_LOOP_TYPE_UNKNOWNContent; } }
        private static int _POLLING_LOOP_TYPE_UNKNOWNContent = default;
        private static bool _POLLING_LOOP_TYPE_UNKNOWNReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/cardemulation/PollingFrame.html#getTriggeredAutoTransact()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool GetTriggeredAutoTransact()
        {
            return IExecuteWithSignature<bool>("getTriggeredAutoTransact", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/cardemulation/PollingFrame.html#getData()"/>
        /// </summary>
        /// <returns><see cref="byte"/></returns>
        public byte[] GetData()
        {
            return IExecuteWithSignatureArray<byte>("getData", "()[B");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/cardemulation/PollingFrame.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/cardemulation/PollingFrame.html#getType()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetType()
        {
            return IExecuteWithSignature<int>("getType", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/cardemulation/PollingFrame.html#getVendorSpecificGain()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetVendorSpecificGain()
        {
            return IExecuteWithSignature<int>("getVendorSpecificGain", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/cardemulation/PollingFrame.html#getTimestamp()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetTimestamp()
        {
            return IExecuteWithSignature<long>("getTimestamp", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/cardemulation/PollingFrame.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecute("writeToParcel", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}