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
*  This file is generated by MASES.JNetReflector (ver. 2.5.9.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Telecom
{
    #region CallEndpoint declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/telecom/CallEndpoint.html"/>
    /// </summary>
    public partial class CallEndpoint : Android.Os.Parcelable
    {
        const string _bridgeClassName = "android.telecom.CallEndpoint";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public CallEndpoint() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public CallEndpoint(params object[] args) : base(args) { }
    
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
    
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;
    
        // TODO: complete the class
    
    }
    #endregion

    #region CallEndpoint implementation
    public partial class CallEndpoint
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/CallEndpoint.html#%3Cinit%3E(java.lang.CharSequence,int,android.os.ParcelUuid)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Android.Os.ParcelUuid"/></param>
        public CallEndpoint(Java.Lang.CharSequence arg0, int arg1, Android.Os.ParcelUuid arg2)
            : base(arg0, arg1, arg2)
        {
        }
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/CallEndpoint.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/CallEndpoint.html#TYPE_BLUETOOTH"/>
        /// </summary>
        public static int TYPE_BLUETOOTH { get { if (!_TYPE_BLUETOOTHReady) { _TYPE_BLUETOOTHContent = SGetField<int>(LocalBridgeClazz, "TYPE_BLUETOOTH"); _TYPE_BLUETOOTHReady = true; } return _TYPE_BLUETOOTHContent; } }
        private static int _TYPE_BLUETOOTHContent = default;
        private static bool _TYPE_BLUETOOTHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/CallEndpoint.html#TYPE_EARPIECE"/>
        /// </summary>
        public static int TYPE_EARPIECE { get { if (!_TYPE_EARPIECEReady) { _TYPE_EARPIECEContent = SGetField<int>(LocalBridgeClazz, "TYPE_EARPIECE"); _TYPE_EARPIECEReady = true; } return _TYPE_EARPIECEContent; } }
        private static int _TYPE_EARPIECEContent = default;
        private static bool _TYPE_EARPIECEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/CallEndpoint.html#TYPE_SPEAKER"/>
        /// </summary>
        public static int TYPE_SPEAKER { get { if (!_TYPE_SPEAKERReady) { _TYPE_SPEAKERContent = SGetField<int>(LocalBridgeClazz, "TYPE_SPEAKER"); _TYPE_SPEAKERReady = true; } return _TYPE_SPEAKERContent; } }
        private static int _TYPE_SPEAKERContent = default;
        private static bool _TYPE_SPEAKERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/CallEndpoint.html#TYPE_STREAMING"/>
        /// </summary>
        public static int TYPE_STREAMING { get { if (!_TYPE_STREAMINGReady) { _TYPE_STREAMINGContent = SGetField<int>(LocalBridgeClazz, "TYPE_STREAMING"); _TYPE_STREAMINGReady = true; } return _TYPE_STREAMINGContent; } }
        private static int _TYPE_STREAMINGContent = default;
        private static bool _TYPE_STREAMINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/CallEndpoint.html#TYPE_UNKNOWN"/>
        /// </summary>
        public static int TYPE_UNKNOWN { get { if (!_TYPE_UNKNOWNReady) { _TYPE_UNKNOWNContent = SGetField<int>(LocalBridgeClazz, "TYPE_UNKNOWN"); _TYPE_UNKNOWNReady = true; } return _TYPE_UNKNOWNContent; } }
        private static int _TYPE_UNKNOWNContent = default;
        private static bool _TYPE_UNKNOWNReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/CallEndpoint.html#TYPE_WIRED_HEADSET"/>
        /// </summary>
        public static int TYPE_WIRED_HEADSET { get { if (!_TYPE_WIRED_HEADSETReady) { _TYPE_WIRED_HEADSETContent = SGetField<int>(LocalBridgeClazz, "TYPE_WIRED_HEADSET"); _TYPE_WIRED_HEADSETReady = true; } return _TYPE_WIRED_HEADSETContent; } }
        private static int _TYPE_WIRED_HEADSETContent = default;
        private static bool _TYPE_WIRED_HEADSETReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/CallEndpoint.html#getIdentifier()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.ParcelUuid"/></returns>
        public Android.Os.ParcelUuid GetIdentifier()
        {
            return IExecuteWithSignature<Android.Os.ParcelUuid>("getIdentifier", "()Landroid/os/ParcelUuid;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/CallEndpoint.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/CallEndpoint.html#getEndpointType()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetEndpointType()
        {
            return IExecuteWithSignature<int>("getEndpointType", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/CallEndpoint.html#getEndpointName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence GetEndpointName()
        {
            return IExecuteWithSignature<Java.Lang.CharSequence>("getEndpointName", "()Ljava/lang/CharSequence;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/CallEndpoint.html#writeToParcel(android.os.Parcel,int)"/>
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