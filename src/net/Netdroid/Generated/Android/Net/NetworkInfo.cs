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

namespace Android.Net
{
    #region NetworkInfo
    public partial class NetworkInfo
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/NetworkInfo.html#%3Cinit%3E(int,int,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        [System.Obsolete()]
        public NetworkInfo(int arg0, int arg1, Java.Lang.String arg2, Java.Lang.String arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/NetworkInfo.html#CREATOR"/>
        /// </summary>
        [System.Obsolete()]
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/NetworkInfo.html#getExtraInfo()"/> 
        /// </summary>
        [System.Obsolete()]
        public Java.Lang.String ExtraInfo
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getExtraInfo", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/NetworkInfo.html#getDetailedState()"/> 
        /// </summary>
        [System.Obsolete()]
        public Android.Net.NetworkInfo.DetailedState GetDetailedState
        {
            get { return IExecuteWithSignature<Android.Net.NetworkInfo.DetailedState>("getDetailedState", "()Landroid/net/NetworkInfo$DetailedState;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/NetworkInfo.html#getState()"/> 
        /// </summary>
        [System.Obsolete()]
        public Android.Net.NetworkInfo.State GetState
        {
            get { return IExecuteWithSignature<Android.Net.NetworkInfo.State>("getState", "()Landroid/net/NetworkInfo$State;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/NetworkInfo.html#getReason()"/> 
        /// </summary>
        [System.Obsolete()]
        public Java.Lang.String Reason
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getReason", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/NetworkInfo.html#getSubtype()"/> 
        /// </summary>
        [System.Obsolete()]
        public int Subtype
        {
            get { return IExecuteWithSignature<int>("getSubtype", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/NetworkInfo.html#getSubtypeName()"/> 
        /// </summary>
        [System.Obsolete()]
        public Java.Lang.String SubtypeName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getSubtypeName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/NetworkInfo.html#getType()"/> 
        /// </summary>
        [System.Obsolete()]
        public int Type
        {
            get { return IExecuteWithSignature<int>("getType", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/NetworkInfo.html#getTypeName()"/> 
        /// </summary>
        [System.Obsolete()]
        public Java.Lang.String TypeName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getTypeName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/NetworkInfo.html#isAvailable()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [System.Obsolete()]
        public bool IsAvailable()
        {
            return IExecuteWithSignature<bool>("isAvailable", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/NetworkInfo.html#isConnected()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [System.Obsolete()]
        public bool IsConnected()
        {
            return IExecuteWithSignature<bool>("isConnected", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/NetworkInfo.html#isConnectedOrConnecting()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [System.Obsolete()]
        public bool IsConnectedOrConnecting()
        {
            return IExecuteWithSignature<bool>("isConnectedOrConnecting", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/NetworkInfo.html#isFailover()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [System.Obsolete()]
        public bool IsFailover()
        {
            return IExecuteWithSignature<bool>("isFailover", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/NetworkInfo.html#isRoaming()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [System.Obsolete()]
        public bool IsRoaming()
        {
            return IExecuteWithSignature<bool>("isRoaming", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/NetworkInfo.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [System.Obsolete()]
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/NetworkInfo.html#setDetailedState(android.net.NetworkInfo.DetailedState,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.NetworkInfo.DetailedState"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        [System.Obsolete()]
        public void SetDetailedState(Android.Net.NetworkInfo.DetailedState arg0, Java.Lang.String arg1, Java.Lang.String arg2)
        {
            IExecute("setDetailedState", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/NetworkInfo.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        [System.Obsolete()]
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecute("writeToParcel", arg0, arg1);
        }

        #endregion

        #region Nested classes
        #region DetailedState
        public partial class DetailedState
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/NetworkInfo.DetailedState.html#AUTHENTICATING"/>
            /// </summary>
            [System.Obsolete()]
            public static Android.Net.NetworkInfo.DetailedState AUTHENTICATING { get { if (!_AUTHENTICATINGReady) { _AUTHENTICATINGContent = SGetField<Android.Net.NetworkInfo.DetailedState>(LocalBridgeClazz, "AUTHENTICATING"); _AUTHENTICATINGReady = true; } return _AUTHENTICATINGContent; } }
            private static Android.Net.NetworkInfo.DetailedState _AUTHENTICATINGContent = default;
            private static bool _AUTHENTICATINGReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/NetworkInfo.DetailedState.html#BLOCKED"/>
            /// </summary>
            [System.Obsolete()]
            public static Android.Net.NetworkInfo.DetailedState BLOCKED { get { if (!_BLOCKEDReady) { _BLOCKEDContent = SGetField<Android.Net.NetworkInfo.DetailedState>(LocalBridgeClazz, "BLOCKED"); _BLOCKEDReady = true; } return _BLOCKEDContent; } }
            private static Android.Net.NetworkInfo.DetailedState _BLOCKEDContent = default;
            private static bool _BLOCKEDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/NetworkInfo.DetailedState.html#CAPTIVE_PORTAL_CHECK"/>
            /// </summary>
            [System.Obsolete()]
            public static Android.Net.NetworkInfo.DetailedState CAPTIVE_PORTAL_CHECK { get { if (!_CAPTIVE_PORTAL_CHECKReady) { _CAPTIVE_PORTAL_CHECKContent = SGetField<Android.Net.NetworkInfo.DetailedState>(LocalBridgeClazz, "CAPTIVE_PORTAL_CHECK"); _CAPTIVE_PORTAL_CHECKReady = true; } return _CAPTIVE_PORTAL_CHECKContent; } }
            private static Android.Net.NetworkInfo.DetailedState _CAPTIVE_PORTAL_CHECKContent = default;
            private static bool _CAPTIVE_PORTAL_CHECKReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/NetworkInfo.DetailedState.html#CONNECTED"/>
            /// </summary>
            [System.Obsolete()]
            public static Android.Net.NetworkInfo.DetailedState CONNECTED { get { if (!_CONNECTEDReady) { _CONNECTEDContent = SGetField<Android.Net.NetworkInfo.DetailedState>(LocalBridgeClazz, "CONNECTED"); _CONNECTEDReady = true; } return _CONNECTEDContent; } }
            private static Android.Net.NetworkInfo.DetailedState _CONNECTEDContent = default;
            private static bool _CONNECTEDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/NetworkInfo.DetailedState.html#CONNECTING"/>
            /// </summary>
            [System.Obsolete()]
            public static Android.Net.NetworkInfo.DetailedState CONNECTING { get { if (!_CONNECTINGReady) { _CONNECTINGContent = SGetField<Android.Net.NetworkInfo.DetailedState>(LocalBridgeClazz, "CONNECTING"); _CONNECTINGReady = true; } return _CONNECTINGContent; } }
            private static Android.Net.NetworkInfo.DetailedState _CONNECTINGContent = default;
            private static bool _CONNECTINGReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/NetworkInfo.DetailedState.html#DISCONNECTED"/>
            /// </summary>
            [System.Obsolete()]
            public static Android.Net.NetworkInfo.DetailedState DISCONNECTED { get { if (!_DISCONNECTEDReady) { _DISCONNECTEDContent = SGetField<Android.Net.NetworkInfo.DetailedState>(LocalBridgeClazz, "DISCONNECTED"); _DISCONNECTEDReady = true; } return _DISCONNECTEDContent; } }
            private static Android.Net.NetworkInfo.DetailedState _DISCONNECTEDContent = default;
            private static bool _DISCONNECTEDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/NetworkInfo.DetailedState.html#DISCONNECTING"/>
            /// </summary>
            [System.Obsolete()]
            public static Android.Net.NetworkInfo.DetailedState DISCONNECTING { get { if (!_DISCONNECTINGReady) { _DISCONNECTINGContent = SGetField<Android.Net.NetworkInfo.DetailedState>(LocalBridgeClazz, "DISCONNECTING"); _DISCONNECTINGReady = true; } return _DISCONNECTINGContent; } }
            private static Android.Net.NetworkInfo.DetailedState _DISCONNECTINGContent = default;
            private static bool _DISCONNECTINGReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/NetworkInfo.DetailedState.html#FAILED"/>
            /// </summary>
            [System.Obsolete()]
            public static Android.Net.NetworkInfo.DetailedState FAILED { get { if (!_FAILEDReady) { _FAILEDContent = SGetField<Android.Net.NetworkInfo.DetailedState>(LocalBridgeClazz, "FAILED"); _FAILEDReady = true; } return _FAILEDContent; } }
            private static Android.Net.NetworkInfo.DetailedState _FAILEDContent = default;
            private static bool _FAILEDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/NetworkInfo.DetailedState.html#IDLE"/>
            /// </summary>
            [System.Obsolete()]
            public static Android.Net.NetworkInfo.DetailedState IDLE { get { if (!_IDLEReady) { _IDLEContent = SGetField<Android.Net.NetworkInfo.DetailedState>(LocalBridgeClazz, "IDLE"); _IDLEReady = true; } return _IDLEContent; } }
            private static Android.Net.NetworkInfo.DetailedState _IDLEContent = default;
            private static bool _IDLEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/NetworkInfo.DetailedState.html#OBTAINING_IPADDR"/>
            /// </summary>
            [System.Obsolete()]
            public static Android.Net.NetworkInfo.DetailedState OBTAINING_IPADDR { get { if (!_OBTAINING_IPADDRReady) { _OBTAINING_IPADDRContent = SGetField<Android.Net.NetworkInfo.DetailedState>(LocalBridgeClazz, "OBTAINING_IPADDR"); _OBTAINING_IPADDRReady = true; } return _OBTAINING_IPADDRContent; } }
            private static Android.Net.NetworkInfo.DetailedState _OBTAINING_IPADDRContent = default;
            private static bool _OBTAINING_IPADDRReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/NetworkInfo.DetailedState.html#SCANNING"/>
            /// </summary>
            [System.Obsolete()]
            public static Android.Net.NetworkInfo.DetailedState SCANNING { get { if (!_SCANNINGReady) { _SCANNINGContent = SGetField<Android.Net.NetworkInfo.DetailedState>(LocalBridgeClazz, "SCANNING"); _SCANNINGReady = true; } return _SCANNINGContent; } }
            private static Android.Net.NetworkInfo.DetailedState _SCANNINGContent = default;
            private static bool _SCANNINGReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/NetworkInfo.DetailedState.html#SUSPENDED"/>
            /// </summary>
            [System.Obsolete()]
            public static Android.Net.NetworkInfo.DetailedState SUSPENDED { get { if (!_SUSPENDEDReady) { _SUSPENDEDContent = SGetField<Android.Net.NetworkInfo.DetailedState>(LocalBridgeClazz, "SUSPENDED"); _SUSPENDEDReady = true; } return _SUSPENDEDContent; } }
            private static Android.Net.NetworkInfo.DetailedState _SUSPENDEDContent = default;
            private static bool _SUSPENDEDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/NetworkInfo.DetailedState.html#VERIFYING_POOR_LINK"/>
            /// </summary>
            [System.Obsolete()]
            public static Android.Net.NetworkInfo.DetailedState VERIFYING_POOR_LINK { get { if (!_VERIFYING_POOR_LINKReady) { _VERIFYING_POOR_LINKContent = SGetField<Android.Net.NetworkInfo.DetailedState>(LocalBridgeClazz, "VERIFYING_POOR_LINK"); _VERIFYING_POOR_LINKReady = true; } return _VERIFYING_POOR_LINKContent; } }
            private static Android.Net.NetworkInfo.DetailedState _VERIFYING_POOR_LINKContent = default;
            private static bool _VERIFYING_POOR_LINKReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/NetworkInfo.DetailedState.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Net.NetworkInfo.DetailedState"/></returns>
            public static Android.Net.NetworkInfo.DetailedState ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Android.Net.NetworkInfo.DetailedState>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Landroid/net/NetworkInfo$DetailedState;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/NetworkInfo.DetailedState.html#values()"/>
            /// </summary>
            /// <returns><see cref="Android.Net.NetworkInfo.DetailedState"/></returns>
            public static Android.Net.NetworkInfo.DetailedState[] Values()
            {
                return SExecuteWithSignatureArray<Android.Net.NetworkInfo.DetailedState>(LocalBridgeClazz, "values", "()[Landroid/net/NetworkInfo$DetailedState;");
            }

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region State
        public partial class State
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/NetworkInfo.State.html#CONNECTED"/>
            /// </summary>
            [System.Obsolete()]
            public static Android.Net.NetworkInfo.State CONNECTED { get { if (!_CONNECTEDReady) { _CONNECTEDContent = SGetField<Android.Net.NetworkInfo.State>(LocalBridgeClazz, "CONNECTED"); _CONNECTEDReady = true; } return _CONNECTEDContent; } }
            private static Android.Net.NetworkInfo.State _CONNECTEDContent = default;
            private static bool _CONNECTEDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/NetworkInfo.State.html#CONNECTING"/>
            /// </summary>
            [System.Obsolete()]
            public static Android.Net.NetworkInfo.State CONNECTING { get { if (!_CONNECTINGReady) { _CONNECTINGContent = SGetField<Android.Net.NetworkInfo.State>(LocalBridgeClazz, "CONNECTING"); _CONNECTINGReady = true; } return _CONNECTINGContent; } }
            private static Android.Net.NetworkInfo.State _CONNECTINGContent = default;
            private static bool _CONNECTINGReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/NetworkInfo.State.html#DISCONNECTED"/>
            /// </summary>
            [System.Obsolete()]
            public static Android.Net.NetworkInfo.State DISCONNECTED { get { if (!_DISCONNECTEDReady) { _DISCONNECTEDContent = SGetField<Android.Net.NetworkInfo.State>(LocalBridgeClazz, "DISCONNECTED"); _DISCONNECTEDReady = true; } return _DISCONNECTEDContent; } }
            private static Android.Net.NetworkInfo.State _DISCONNECTEDContent = default;
            private static bool _DISCONNECTEDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/NetworkInfo.State.html#DISCONNECTING"/>
            /// </summary>
            [System.Obsolete()]
            public static Android.Net.NetworkInfo.State DISCONNECTING { get { if (!_DISCONNECTINGReady) { _DISCONNECTINGContent = SGetField<Android.Net.NetworkInfo.State>(LocalBridgeClazz, "DISCONNECTING"); _DISCONNECTINGReady = true; } return _DISCONNECTINGContent; } }
            private static Android.Net.NetworkInfo.State _DISCONNECTINGContent = default;
            private static bool _DISCONNECTINGReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/NetworkInfo.State.html#SUSPENDED"/>
            /// </summary>
            [System.Obsolete()]
            public static Android.Net.NetworkInfo.State SUSPENDED { get { if (!_SUSPENDEDReady) { _SUSPENDEDContent = SGetField<Android.Net.NetworkInfo.State>(LocalBridgeClazz, "SUSPENDED"); _SUSPENDEDReady = true; } return _SUSPENDEDContent; } }
            private static Android.Net.NetworkInfo.State _SUSPENDEDContent = default;
            private static bool _SUSPENDEDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/NetworkInfo.State.html#UNKNOWN"/>
            /// </summary>
            [System.Obsolete()]
            public static Android.Net.NetworkInfo.State UNKNOWN { get { if (!_UNKNOWNReady) { _UNKNOWNContent = SGetField<Android.Net.NetworkInfo.State>(LocalBridgeClazz, "UNKNOWN"); _UNKNOWNReady = true; } return _UNKNOWNContent; } }
            private static Android.Net.NetworkInfo.State _UNKNOWNContent = default;
            private static bool _UNKNOWNReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/NetworkInfo.State.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Net.NetworkInfo.State"/></returns>
            public static Android.Net.NetworkInfo.State ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Android.Net.NetworkInfo.State>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Landroid/net/NetworkInfo$State;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/NetworkInfo.State.html#values()"/>
            /// </summary>
            /// <returns><see cref="Android.Net.NetworkInfo.State"/></returns>
            public static Android.Net.NetworkInfo.State[] Values()
            {
                return SExecuteWithSignatureArray<Android.Net.NetworkInfo.State>(LocalBridgeClazz, "values", "()[Landroid/net/NetworkInfo$State;");
            }

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}