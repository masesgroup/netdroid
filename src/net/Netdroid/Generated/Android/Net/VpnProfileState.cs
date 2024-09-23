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

namespace Android.Net
{
    #region VpnProfileState declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/net/VpnProfileState.html"/>
    /// </summary>
    public partial class VpnProfileState : Android.Os.Parcelable
    {
        const string _bridgeClassName = "android.net.VpnProfileState";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public VpnProfileState() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public VpnProfileState(params object[] args) : base(args) { }
    
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

    #region VpnProfileState implementation
    public partial class VpnProfileState
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/VpnProfileState.html#%3Cinit%3E(int,java.lang.String,boolean,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        public VpnProfileState(int arg0, Java.Lang.String arg1, bool arg2, bool arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/VpnProfileState.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/VpnProfileState.html#STATE_CONNECTED"/>
        /// </summary>
        public static int STATE_CONNECTED { get { if (!_STATE_CONNECTEDReady) { _STATE_CONNECTEDContent = SGetField<int>(LocalBridgeClazz, "STATE_CONNECTED"); _STATE_CONNECTEDReady = true; } return _STATE_CONNECTEDContent; } }
        private static int _STATE_CONNECTEDContent = default;
        private static bool _STATE_CONNECTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/VpnProfileState.html#STATE_CONNECTING"/>
        /// </summary>
        public static int STATE_CONNECTING { get { if (!_STATE_CONNECTINGReady) { _STATE_CONNECTINGContent = SGetField<int>(LocalBridgeClazz, "STATE_CONNECTING"); _STATE_CONNECTINGReady = true; } return _STATE_CONNECTINGContent; } }
        private static int _STATE_CONNECTINGContent = default;
        private static bool _STATE_CONNECTINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/VpnProfileState.html#STATE_DISCONNECTED"/>
        /// </summary>
        public static int STATE_DISCONNECTED { get { if (!_STATE_DISCONNECTEDReady) { _STATE_DISCONNECTEDContent = SGetField<int>(LocalBridgeClazz, "STATE_DISCONNECTED"); _STATE_DISCONNECTEDReady = true; } return _STATE_DISCONNECTEDContent; } }
        private static int _STATE_DISCONNECTEDContent = default;
        private static bool _STATE_DISCONNECTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/VpnProfileState.html#STATE_FAILED"/>
        /// </summary>
        public static int STATE_FAILED { get { if (!_STATE_FAILEDReady) { _STATE_FAILEDContent = SGetField<int>(LocalBridgeClazz, "STATE_FAILED"); _STATE_FAILEDReady = true; } return _STATE_FAILEDContent; } }
        private static int _STATE_FAILEDContent = default;
        private static bool _STATE_FAILEDReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/VpnProfileState.html#isAlwaysOn()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsAlwaysOn()
        {
            return IExecuteWithSignature<bool>("isAlwaysOn", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/VpnProfileState.html#isLockdownEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsLockdownEnabled()
        {
            return IExecuteWithSignature<bool>("isLockdownEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/VpnProfileState.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/VpnProfileState.html#getState()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetState()
        {
            return IExecuteWithSignature<int>("getState", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/VpnProfileState.html#getSessionId()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetSessionId()
        {
            return IExecuteWithSignature<Java.Lang.String>("getSessionId", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/VpnProfileState.html#writeToParcel(android.os.Parcel,int)"/>
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