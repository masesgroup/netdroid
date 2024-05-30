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

namespace Android.Telecom
{
    #region DisconnectCause
    public partial class DisconnectCause
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/DisconnectCause.html#%3Cinit%3E(int,java.lang.CharSequence,java.lang.CharSequence,java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg2"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        public DisconnectCause(int arg0, Java.Lang.CharSequence arg1, Java.Lang.CharSequence arg2, Java.Lang.String arg3, int arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/DisconnectCause.html#%3Cinit%3E(int,java.lang.CharSequence,java.lang.CharSequence,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg2"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        public DisconnectCause(int arg0, Java.Lang.CharSequence arg1, Java.Lang.CharSequence arg2, Java.Lang.String arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/DisconnectCause.html#%3Cinit%3E(int,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public DisconnectCause(int arg0, Java.Lang.String arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/DisconnectCause.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public DisconnectCause(int arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/DisconnectCause.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/DisconnectCause.html#ANSWERED_ELSEWHERE"/>
        /// </summary>
        public static int ANSWERED_ELSEWHERE { get { if (!_ANSWERED_ELSEWHEREReady) { _ANSWERED_ELSEWHEREContent = SGetField<int>(LocalBridgeClazz, "ANSWERED_ELSEWHERE"); _ANSWERED_ELSEWHEREReady = true; } return _ANSWERED_ELSEWHEREContent; } }
        private static int _ANSWERED_ELSEWHEREContent = default;
        private static bool _ANSWERED_ELSEWHEREReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/DisconnectCause.html#BUSY"/>
        /// </summary>
        public static int BUSY { get { if (!_BUSYReady) { _BUSYContent = SGetField<int>(LocalBridgeClazz, "BUSY"); _BUSYReady = true; } return _BUSYContent; } }
        private static int _BUSYContent = default;
        private static bool _BUSYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/DisconnectCause.html#CALL_PULLED"/>
        /// </summary>
        public static int CALL_PULLED { get { if (!_CALL_PULLEDReady) { _CALL_PULLEDContent = SGetField<int>(LocalBridgeClazz, "CALL_PULLED"); _CALL_PULLEDReady = true; } return _CALL_PULLEDContent; } }
        private static int _CALL_PULLEDContent = default;
        private static bool _CALL_PULLEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/DisconnectCause.html#CANCELED"/>
        /// </summary>
        public static int CANCELED { get { if (!_CANCELEDReady) { _CANCELEDContent = SGetField<int>(LocalBridgeClazz, "CANCELED"); _CANCELEDReady = true; } return _CANCELEDContent; } }
        private static int _CANCELEDContent = default;
        private static bool _CANCELEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/DisconnectCause.html#CONNECTION_MANAGER_NOT_SUPPORTED"/>
        /// </summary>
        public static int CONNECTION_MANAGER_NOT_SUPPORTED { get { if (!_CONNECTION_MANAGER_NOT_SUPPORTEDReady) { _CONNECTION_MANAGER_NOT_SUPPORTEDContent = SGetField<int>(LocalBridgeClazz, "CONNECTION_MANAGER_NOT_SUPPORTED"); _CONNECTION_MANAGER_NOT_SUPPORTEDReady = true; } return _CONNECTION_MANAGER_NOT_SUPPORTEDContent; } }
        private static int _CONNECTION_MANAGER_NOT_SUPPORTEDContent = default;
        private static bool _CONNECTION_MANAGER_NOT_SUPPORTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/DisconnectCause.html#ERROR"/>
        /// </summary>
        public static int ERROR { get { if (!_ERRORReady) { _ERRORContent = SGetField<int>(LocalBridgeClazz, "ERROR"); _ERRORReady = true; } return _ERRORContent; } }
        private static int _ERRORContent = default;
        private static bool _ERRORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/DisconnectCause.html#LOCAL"/>
        /// </summary>
        public static int LOCAL { get { if (!_LOCALReady) { _LOCALContent = SGetField<int>(LocalBridgeClazz, "LOCAL"); _LOCALReady = true; } return _LOCALContent; } }
        private static int _LOCALContent = default;
        private static bool _LOCALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/DisconnectCause.html#MISSED"/>
        /// </summary>
        public static int MISSED { get { if (!_MISSEDReady) { _MISSEDContent = SGetField<int>(LocalBridgeClazz, "MISSED"); _MISSEDReady = true; } return _MISSEDContent; } }
        private static int _MISSEDContent = default;
        private static bool _MISSEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/DisconnectCause.html#OTHER"/>
        /// </summary>
        public static int OTHER { get { if (!_OTHERReady) { _OTHERContent = SGetField<int>(LocalBridgeClazz, "OTHER"); _OTHERReady = true; } return _OTHERContent; } }
        private static int _OTHERContent = default;
        private static bool _OTHERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/DisconnectCause.html#REJECTED"/>
        /// </summary>
        public static int REJECTED { get { if (!_REJECTEDReady) { _REJECTEDContent = SGetField<int>(LocalBridgeClazz, "REJECTED"); _REJECTEDReady = true; } return _REJECTEDContent; } }
        private static int _REJECTEDContent = default;
        private static bool _REJECTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/DisconnectCause.html#REMOTE"/>
        /// </summary>
        public static int REMOTE { get { if (!_REMOTEReady) { _REMOTEContent = SGetField<int>(LocalBridgeClazz, "REMOTE"); _REMOTEReady = true; } return _REMOTEContent; } }
        private static int _REMOTEContent = default;
        private static bool _REMOTEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/DisconnectCause.html#RESTRICTED"/>
        /// </summary>
        public static int RESTRICTED { get { if (!_RESTRICTEDReady) { _RESTRICTEDContent = SGetField<int>(LocalBridgeClazz, "RESTRICTED"); _RESTRICTEDReady = true; } return _RESTRICTEDContent; } }
        private static int _RESTRICTEDContent = default;
        private static bool _RESTRICTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/DisconnectCause.html#UNKNOWN"/>
        /// </summary>
        public static int UNKNOWN { get { if (!_UNKNOWNReady) { _UNKNOWNContent = SGetField<int>(LocalBridgeClazz, "UNKNOWN"); _UNKNOWNReady = true; } return _UNKNOWNContent; } }
        private static int _UNKNOWNContent = default;
        private static bool _UNKNOWNReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/DisconnectCause.html#REASON_EMERGENCY_CALL_PLACED"/>
        /// </summary>
        public static Java.Lang.String REASON_EMERGENCY_CALL_PLACED { get { if (!_REASON_EMERGENCY_CALL_PLACEDReady) { _REASON_EMERGENCY_CALL_PLACEDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "REASON_EMERGENCY_CALL_PLACED"); _REASON_EMERGENCY_CALL_PLACEDReady = true; } return _REASON_EMERGENCY_CALL_PLACEDContent; } }
        private static Java.Lang.String _REASON_EMERGENCY_CALL_PLACEDContent = default;
        private static bool _REASON_EMERGENCY_CALL_PLACEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/DisconnectCause.html#REASON_EMULATING_SINGLE_CALL"/>
        /// </summary>
        public static Java.Lang.String REASON_EMULATING_SINGLE_CALL { get { if (!_REASON_EMULATING_SINGLE_CALLReady) { _REASON_EMULATING_SINGLE_CALLContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "REASON_EMULATING_SINGLE_CALL"); _REASON_EMULATING_SINGLE_CALLReady = true; } return _REASON_EMULATING_SINGLE_CALLContent; } }
        private static Java.Lang.String _REASON_EMULATING_SINGLE_CALLContent = default;
        private static bool _REASON_EMULATING_SINGLE_CALLReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/DisconnectCause.html#REASON_IMS_ACCESS_BLOCKED"/>
        /// </summary>
        public static Java.Lang.String REASON_IMS_ACCESS_BLOCKED { get { if (!_REASON_IMS_ACCESS_BLOCKEDReady) { _REASON_IMS_ACCESS_BLOCKEDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "REASON_IMS_ACCESS_BLOCKED"); _REASON_IMS_ACCESS_BLOCKEDReady = true; } return _REASON_IMS_ACCESS_BLOCKEDContent; } }
        private static Java.Lang.String _REASON_IMS_ACCESS_BLOCKEDContent = default;
        private static bool _REASON_IMS_ACCESS_BLOCKEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/DisconnectCause.html#REASON_WIFI_ON_BUT_WFC_OFF"/>
        /// </summary>
        public static Java.Lang.String REASON_WIFI_ON_BUT_WFC_OFF { get { if (!_REASON_WIFI_ON_BUT_WFC_OFFReady) { _REASON_WIFI_ON_BUT_WFC_OFFContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "REASON_WIFI_ON_BUT_WFC_OFF"); _REASON_WIFI_ON_BUT_WFC_OFFReady = true; } return _REASON_WIFI_ON_BUT_WFC_OFFContent; } }
        private static Java.Lang.String _REASON_WIFI_ON_BUT_WFC_OFFContent = default;
        private static bool _REASON_WIFI_ON_BUT_WFC_OFFReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/DisconnectCause.html#getCode()"/> 
        /// </summary>
        public int Code
        {
            get { return IExecuteWithSignature<int>("getCode", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/DisconnectCause.html#getDescription()"/> 
        /// </summary>
        public Java.Lang.CharSequence Description
        {
            get { return IExecuteWithSignature<Java.Lang.CharSequence>("getDescription", "()Ljava/lang/CharSequence;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/DisconnectCause.html#getLabel()"/> 
        /// </summary>
        public Java.Lang.CharSequence Label
        {
            get { return IExecuteWithSignature<Java.Lang.CharSequence>("getLabel", "()Ljava/lang/CharSequence;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/DisconnectCause.html#getReason()"/> 
        /// </summary>
        public Java.Lang.String Reason
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getReason", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/DisconnectCause.html#getTone()"/> 
        /// </summary>
        public int Tone
        {
            get { return IExecuteWithSignature<int>("getTone", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/DisconnectCause.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/DisconnectCause.html#writeToParcel(android.os.Parcel,int)"/>
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