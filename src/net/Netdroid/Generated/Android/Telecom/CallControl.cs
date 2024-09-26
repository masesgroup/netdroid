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
    #region CallControl declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/telecom/CallControl.html"/>
    /// </summary>
    public partial class CallControl : MASES.JCOBridge.C2JBridge.JVMBridgeBase<CallControl>
    {
        const string _bridgeClassName = "android.telecom.CallControl";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public CallControl() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public CallControl(params object[] args) : base(args) { }

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

    #region CallControl implementation
    public partial class CallControl
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/CallControl.html#getCallId()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.ParcelUuid"/></returns>
        public Android.Os.ParcelUuid GetCallId()
        {
            return IExecuteWithSignature<Android.Os.ParcelUuid>("getCallId", "()Landroid/os/ParcelUuid;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/CallControl.html#answer(int,java.util.concurrent.Executor,android.os.OutcomeReceiver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg2"><see cref="Android.Os.OutcomeReceiver"/></param>
        public void Answer(int arg0, Java.Util.Concurrent.Executor arg1, Android.Os.OutcomeReceiver<Java.Lang.Void, Android.Telecom.CallException> arg2)
        {
            IExecuteWithSignature("answer", "(ILjava/util/concurrent/Executor;Landroid/os/OutcomeReceiver;)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/CallControl.html#disconnect(android.telecom.DisconnectCause,java.util.concurrent.Executor,android.os.OutcomeReceiver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Telecom.DisconnectCause"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg2"><see cref="Android.Os.OutcomeReceiver"/></param>
        public void Disconnect(Android.Telecom.DisconnectCause arg0, Java.Util.Concurrent.Executor arg1, Android.Os.OutcomeReceiver<Java.Lang.Void, Android.Telecom.CallException> arg2)
        {
            IExecuteWithSignature("disconnect", "(Landroid/telecom/DisconnectCause;Ljava/util/concurrent/Executor;Landroid/os/OutcomeReceiver;)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/CallControl.html#requestCallEndpointChange(android.telecom.CallEndpoint,java.util.concurrent.Executor,android.os.OutcomeReceiver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Telecom.CallEndpoint"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg2"><see cref="Android.Os.OutcomeReceiver"/></param>
        public void RequestCallEndpointChange(Android.Telecom.CallEndpoint arg0, Java.Util.Concurrent.Executor arg1, Android.Os.OutcomeReceiver<Java.Lang.Void, Android.Telecom.CallException> arg2)
        {
            IExecuteWithSignature("requestCallEndpointChange", "(Landroid/telecom/CallEndpoint;Ljava/util/concurrent/Executor;Landroid/os/OutcomeReceiver;)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/CallControl.html#requestMuteState(boolean,java.util.concurrent.Executor,android.os.OutcomeReceiver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg2"><see cref="Android.Os.OutcomeReceiver"/></param>
        public void RequestMuteState(bool arg0, Java.Util.Concurrent.Executor arg1, Android.Os.OutcomeReceiver<Java.Lang.Void, Android.Telecom.CallException> arg2)
        {
            IExecuteWithSignature("requestMuteState", "(ZLjava/util/concurrent/Executor;Landroid/os/OutcomeReceiver;)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/CallControl.html#requestVideoState(int,java.util.concurrent.Executor,android.os.OutcomeReceiver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg2"><see cref="Android.Os.OutcomeReceiver"/></param>
        public void RequestVideoState(int arg0, Java.Util.Concurrent.Executor arg1, Android.Os.OutcomeReceiver<Java.Lang.Void, Android.Telecom.CallException> arg2)
        {
            IExecuteWithSignature("requestVideoState", "(ILjava/util/concurrent/Executor;Landroid/os/OutcomeReceiver;)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/CallControl.html#sendEvent(java.lang.String,android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Android.Os.Bundle"/></param>
        public void SendEvent(Java.Lang.String arg0, Android.Os.Bundle arg1)
        {
            IExecuteWithSignature("sendEvent", "(Ljava/lang/String;Landroid/os/Bundle;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/CallControl.html#setActive(java.util.concurrent.Executor,android.os.OutcomeReceiver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg1"><see cref="Android.Os.OutcomeReceiver"/></param>
        public void SetActive(Java.Util.Concurrent.Executor arg0, Android.Os.OutcomeReceiver<Java.Lang.Void, Android.Telecom.CallException> arg1)
        {
            IExecuteWithSignature("setActive", "(Ljava/util/concurrent/Executor;Landroid/os/OutcomeReceiver;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/CallControl.html#setInactive(java.util.concurrent.Executor,android.os.OutcomeReceiver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg1"><see cref="Android.Os.OutcomeReceiver"/></param>
        public void SetInactive(Java.Util.Concurrent.Executor arg0, Android.Os.OutcomeReceiver<Java.Lang.Void, Android.Telecom.CallException> arg1)
        {
            IExecuteWithSignature("setInactive", "(Ljava/util/concurrent/Executor;Landroid/os/OutcomeReceiver;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/CallControl.html#startCallStreaming(java.util.concurrent.Executor,android.os.OutcomeReceiver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg1"><see cref="Android.Os.OutcomeReceiver"/></param>
        public void StartCallStreaming(Java.Util.Concurrent.Executor arg0, Android.Os.OutcomeReceiver<Java.Lang.Void, Android.Telecom.CallException> arg1)
        {
            IExecuteWithSignature("startCallStreaming", "(Ljava/util/concurrent/Executor;Landroid/os/OutcomeReceiver;)V", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}