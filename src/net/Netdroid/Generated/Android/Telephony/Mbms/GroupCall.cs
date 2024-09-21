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

namespace Android.Telephony.Mbms
{
    #region GroupCall declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/telephony/mbms/GroupCall.html"/>
    /// </summary>
    public partial class GroupCall : Java.Lang.AutoCloseable
    {
        const string _bridgeClassName = "android.telephony.mbms.GroupCall";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public GroupCall() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public GroupCall(params object[] args) : base(args) { }

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

    #region GroupCall implementation
    public partial class GroupCall
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/mbms/GroupCall.html#REASON_BY_USER_REQUEST"/>
        /// </summary>
        public static int REASON_BY_USER_REQUEST { get { if (!_REASON_BY_USER_REQUESTReady) { _REASON_BY_USER_REQUESTContent = SGetField<int>(LocalBridgeClazz, "REASON_BY_USER_REQUEST"); _REASON_BY_USER_REQUESTReady = true; } return _REASON_BY_USER_REQUESTContent; } }
        private static int _REASON_BY_USER_REQUESTContent = default;
        private static bool _REASON_BY_USER_REQUESTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/mbms/GroupCall.html#REASON_FREQUENCY_CONFLICT"/>
        /// </summary>
        public static int REASON_FREQUENCY_CONFLICT { get { if (!_REASON_FREQUENCY_CONFLICTReady) { _REASON_FREQUENCY_CONFLICTContent = SGetField<int>(LocalBridgeClazz, "REASON_FREQUENCY_CONFLICT"); _REASON_FREQUENCY_CONFLICTReady = true; } return _REASON_FREQUENCY_CONFLICTContent; } }
        private static int _REASON_FREQUENCY_CONFLICTContent = default;
        private static bool _REASON_FREQUENCY_CONFLICTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/mbms/GroupCall.html#REASON_LEFT_MBMS_BROADCAST_AREA"/>
        /// </summary>
        public static int REASON_LEFT_MBMS_BROADCAST_AREA { get { if (!_REASON_LEFT_MBMS_BROADCAST_AREAReady) { _REASON_LEFT_MBMS_BROADCAST_AREAContent = SGetField<int>(LocalBridgeClazz, "REASON_LEFT_MBMS_BROADCAST_AREA"); _REASON_LEFT_MBMS_BROADCAST_AREAReady = true; } return _REASON_LEFT_MBMS_BROADCAST_AREAContent; } }
        private static int _REASON_LEFT_MBMS_BROADCAST_AREAContent = default;
        private static bool _REASON_LEFT_MBMS_BROADCAST_AREAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/mbms/GroupCall.html#REASON_NONE"/>
        /// </summary>
        public static int REASON_NONE { get { if (!_REASON_NONEReady) { _REASON_NONEContent = SGetField<int>(LocalBridgeClazz, "REASON_NONE"); _REASON_NONEReady = true; } return _REASON_NONEContent; } }
        private static int _REASON_NONEContent = default;
        private static bool _REASON_NONEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/mbms/GroupCall.html#REASON_NOT_CONNECTED_TO_HOMECARRIER_LTE"/>
        /// </summary>
        public static int REASON_NOT_CONNECTED_TO_HOMECARRIER_LTE { get { if (!_REASON_NOT_CONNECTED_TO_HOMECARRIER_LTEReady) { _REASON_NOT_CONNECTED_TO_HOMECARRIER_LTEContent = SGetField<int>(LocalBridgeClazz, "REASON_NOT_CONNECTED_TO_HOMECARRIER_LTE"); _REASON_NOT_CONNECTED_TO_HOMECARRIER_LTEReady = true; } return _REASON_NOT_CONNECTED_TO_HOMECARRIER_LTEContent; } }
        private static int _REASON_NOT_CONNECTED_TO_HOMECARRIER_LTEContent = default;
        private static bool _REASON_NOT_CONNECTED_TO_HOMECARRIER_LTEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/mbms/GroupCall.html#REASON_OUT_OF_MEMORY"/>
        /// </summary>
        public static int REASON_OUT_OF_MEMORY { get { if (!_REASON_OUT_OF_MEMORYReady) { _REASON_OUT_OF_MEMORYContent = SGetField<int>(LocalBridgeClazz, "REASON_OUT_OF_MEMORY"); _REASON_OUT_OF_MEMORYReady = true; } return _REASON_OUT_OF_MEMORYContent; } }
        private static int _REASON_OUT_OF_MEMORYContent = default;
        private static bool _REASON_OUT_OF_MEMORYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/mbms/GroupCall.html#STATE_STALLED"/>
        /// </summary>
        public static int STATE_STALLED { get { if (!_STATE_STALLEDReady) { _STATE_STALLEDContent = SGetField<int>(LocalBridgeClazz, "STATE_STALLED"); _STATE_STALLEDReady = true; } return _STATE_STALLEDContent; } }
        private static int _STATE_STALLEDContent = default;
        private static bool _STATE_STALLEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/mbms/GroupCall.html#STATE_STARTED"/>
        /// </summary>
        public static int STATE_STARTED { get { if (!_STATE_STARTEDReady) { _STATE_STARTEDContent = SGetField<int>(LocalBridgeClazz, "STATE_STARTED"); _STATE_STARTEDReady = true; } return _STATE_STARTEDContent; } }
        private static int _STATE_STARTEDContent = default;
        private static bool _STATE_STARTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/mbms/GroupCall.html#STATE_STOPPED"/>
        /// </summary>
        public static int STATE_STOPPED { get { if (!_STATE_STOPPEDReady) { _STATE_STOPPEDContent = SGetField<int>(LocalBridgeClazz, "STATE_STOPPED"); _STATE_STOPPEDReady = true; } return _STATE_STOPPEDContent; } }
        private static int _STATE_STOPPEDContent = default;
        private static bool _STATE_STOPPEDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/mbms/GroupCall.html#getTmgi()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetTmgi()
        {
            return IExecuteWithSignature<long>("getTmgi", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/mbms/GroupCall.html#close()"/>
        /// </summary>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/mbms/GroupCall.html#updateGroupCall(java.util.List,java.util.List)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        /// <param name="arg1"><see cref="Java.Util.List"/></param>
        public void UpdateGroupCall(Java.Util.List<Java.Lang.Integer> arg0, Java.Util.List<Java.Lang.Integer> arg1)
        {
            IExecute("updateGroupCall", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}