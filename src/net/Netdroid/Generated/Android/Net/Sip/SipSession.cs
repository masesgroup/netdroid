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

namespace Android.Net.Sip
{
    #region SipSession
    public partial class SipSession
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
        /// <see href="https://developer.android.com/reference/android/net/sip/SipSession.html#getLocalProfile()"/>
        /// </summary>
        /// <returns><see cref="Android.Net.Sip.SipProfile"/></returns>
        [global::System.Obsolete()]
        public Android.Net.Sip.SipProfile GetLocalProfile()
        {
            return IExecuteWithSignature<Android.Net.Sip.SipProfile>("getLocalProfile", "()Landroid/net/sip/SipProfile;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/sip/SipSession.html#getPeerProfile()"/>
        /// </summary>
        /// <returns><see cref="Android.Net.Sip.SipProfile"/></returns>
        [global::System.Obsolete()]
        public Android.Net.Sip.SipProfile GetPeerProfile()
        {
            return IExecuteWithSignature<Android.Net.Sip.SipProfile>("getPeerProfile", "()Landroid/net/sip/SipProfile;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/sip/SipSession.html#isInCall()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool IsInCall()
        {
            return IExecuteWithSignature<bool>("isInCall", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/sip/SipSession.html#getState()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int GetState()
        {
            return IExecuteWithSignature<int>("getState", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/sip/SipSession.html#getCallId()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        [global::System.Obsolete()]
        public Java.Lang.String GetCallId()
        {
            return IExecuteWithSignature<Java.Lang.String>("getCallId", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/sip/SipSession.html#getLocalIp()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        [global::System.Obsolete()]
        public Java.Lang.String GetLocalIp()
        {
            return IExecuteWithSignature<Java.Lang.String>("getLocalIp", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/sip/SipSession.html#answerCall(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        [global::System.Obsolete()]
        public void AnswerCall(Java.Lang.String arg0, int arg1)
        {
            IExecute("answerCall", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/sip/SipSession.html#changeCall(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        [global::System.Obsolete()]
        public void ChangeCall(Java.Lang.String arg0, int arg1)
        {
            IExecute("changeCall", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/sip/SipSession.html#endCall()"/>
        /// </summary>
        [global::System.Obsolete()]
        public void EndCall()
        {
            IExecuteWithSignature("endCall", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/sip/SipSession.html#makeCall(android.net.sip.SipProfile,java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Sip.SipProfile"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        [global::System.Obsolete()]
        public void MakeCall(Android.Net.Sip.SipProfile arg0, Java.Lang.String arg1, int arg2)
        {
            IExecute("makeCall", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/sip/SipSession.html#register(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        [global::System.Obsolete()]
        public void Register(int arg0)
        {
            IExecuteWithSignature("register", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/sip/SipSession.html#setListener(android.net.sip.SipSession.Listener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Sip.SipSession.Listener"/></param>
        [global::System.Obsolete()]
        public void SetListener(Android.Net.Sip.SipSession.Listener arg0)
        {
            IExecuteWithSignature("setListener", "(Landroid/net/sip/SipSession$Listener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/sip/SipSession.html#unregister()"/>
        /// </summary>
        [global::System.Obsolete()]
        public void Unregister()
        {
            IExecuteWithSignature("unregister", "()V");
        }

        #endregion

        #region Nested classes
        #region Listener
        public partial class Listener
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
            /// <see href="https://developer.android.com/reference/android/net/sip/SipSession.Listener.html#onCallBusy(android.net.sip.SipSession)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.Sip.SipSession"/></param>
            [global::System.Obsolete()]
            public void OnCallBusy(Android.Net.Sip.SipSession arg0)
            {
                IExecuteWithSignature("onCallBusy", "(Landroid/net/sip/SipSession;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/sip/SipSession.Listener.html#onCallChangeFailed(android.net.sip.SipSession,int,java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.Sip.SipSession"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="Java.Lang.String"/></param>
            [global::System.Obsolete()]
            public void OnCallChangeFailed(Android.Net.Sip.SipSession arg0, int arg1, Java.Lang.String arg2)
            {
                IExecute("onCallChangeFailed", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/sip/SipSession.Listener.html#onCallEnded(android.net.sip.SipSession)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.Sip.SipSession"/></param>
            [global::System.Obsolete()]
            public void OnCallEnded(Android.Net.Sip.SipSession arg0)
            {
                IExecuteWithSignature("onCallEnded", "(Landroid/net/sip/SipSession;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/sip/SipSession.Listener.html#onCallEstablished(android.net.sip.SipSession,java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.Sip.SipSession"/></param>
            /// <param name="arg1"><see cref="Java.Lang.String"/></param>
            [global::System.Obsolete()]
            public void OnCallEstablished(Android.Net.Sip.SipSession arg0, Java.Lang.String arg1)
            {
                IExecute("onCallEstablished", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/sip/SipSession.Listener.html#onCalling(android.net.sip.SipSession)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.Sip.SipSession"/></param>
            [global::System.Obsolete()]
            public void OnCalling(Android.Net.Sip.SipSession arg0)
            {
                IExecuteWithSignature("onCalling", "(Landroid/net/sip/SipSession;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/sip/SipSession.Listener.html#onError(android.net.sip.SipSession,int,java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.Sip.SipSession"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="Java.Lang.String"/></param>
            [global::System.Obsolete()]
            public void OnError(Android.Net.Sip.SipSession arg0, int arg1, Java.Lang.String arg2)
            {
                IExecute("onError", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/sip/SipSession.Listener.html#onRegistering(android.net.sip.SipSession)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.Sip.SipSession"/></param>
            [global::System.Obsolete()]
            public void OnRegistering(Android.Net.Sip.SipSession arg0)
            {
                IExecuteWithSignature("onRegistering", "(Landroid/net/sip/SipSession;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/sip/SipSession.Listener.html#onRegistrationDone(android.net.sip.SipSession,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.Sip.SipSession"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            [global::System.Obsolete()]
            public void OnRegistrationDone(Android.Net.Sip.SipSession arg0, int arg1)
            {
                IExecute("onRegistrationDone", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/sip/SipSession.Listener.html#onRegistrationFailed(android.net.sip.SipSession,int,java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.Sip.SipSession"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="Java.Lang.String"/></param>
            [global::System.Obsolete()]
            public void OnRegistrationFailed(Android.Net.Sip.SipSession arg0, int arg1, Java.Lang.String arg2)
            {
                IExecute("onRegistrationFailed", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/sip/SipSession.Listener.html#onRegistrationTimeout(android.net.sip.SipSession)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.Sip.SipSession"/></param>
            [global::System.Obsolete()]
            public void OnRegistrationTimeout(Android.Net.Sip.SipSession arg0)
            {
                IExecuteWithSignature("onRegistrationTimeout", "(Landroid/net/sip/SipSession;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/sip/SipSession.Listener.html#onRinging(android.net.sip.SipSession,android.net.sip.SipProfile,java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.Sip.SipSession"/></param>
            /// <param name="arg1"><see cref="Android.Net.Sip.SipProfile"/></param>
            /// <param name="arg2"><see cref="Java.Lang.String"/></param>
            [global::System.Obsolete()]
            public void OnRinging(Android.Net.Sip.SipSession arg0, Android.Net.Sip.SipProfile arg1, Java.Lang.String arg2)
            {
                IExecute("onRinging", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/sip/SipSession.Listener.html#onRingingBack(android.net.sip.SipSession)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.Sip.SipSession"/></param>
            [global::System.Obsolete()]
            public void OnRingingBack(Android.Net.Sip.SipSession arg0)
            {
                IExecuteWithSignature("onRingingBack", "(Landroid/net/sip/SipSession;)V", arg0);
            }

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
            /// <see href="https://developer.android.com/reference/android/net/sip/SipSession.State.html#DEREGISTERING"/>
            /// </summary>
            [global::System.Obsolete()]
            public static int DEREGISTERING { get { if (!_DEREGISTERINGReady) { _DEREGISTERINGContent = SGetField<int>(LocalBridgeClazz, "DEREGISTERING"); _DEREGISTERINGReady = true; } return _DEREGISTERINGContent; } }
            private static int _DEREGISTERINGContent = default;
            private static bool _DEREGISTERINGReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/sip/SipSession.State.html#IN_CALL"/>
            /// </summary>
            [global::System.Obsolete()]
            public static int IN_CALL { get { if (!_IN_CALLReady) { _IN_CALLContent = SGetField<int>(LocalBridgeClazz, "IN_CALL"); _IN_CALLReady = true; } return _IN_CALLContent; } }
            private static int _IN_CALLContent = default;
            private static bool _IN_CALLReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/sip/SipSession.State.html#INCOMING_CALL"/>
            /// </summary>
            [global::System.Obsolete()]
            public static int INCOMING_CALL { get { if (!_INCOMING_CALLReady) { _INCOMING_CALLContent = SGetField<int>(LocalBridgeClazz, "INCOMING_CALL"); _INCOMING_CALLReady = true; } return _INCOMING_CALLContent; } }
            private static int _INCOMING_CALLContent = default;
            private static bool _INCOMING_CALLReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/sip/SipSession.State.html#INCOMING_CALL_ANSWERING"/>
            /// </summary>
            [global::System.Obsolete()]
            public static int INCOMING_CALL_ANSWERING { get { if (!_INCOMING_CALL_ANSWERINGReady) { _INCOMING_CALL_ANSWERINGContent = SGetField<int>(LocalBridgeClazz, "INCOMING_CALL_ANSWERING"); _INCOMING_CALL_ANSWERINGReady = true; } return _INCOMING_CALL_ANSWERINGContent; } }
            private static int _INCOMING_CALL_ANSWERINGContent = default;
            private static bool _INCOMING_CALL_ANSWERINGReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/sip/SipSession.State.html#NOT_DEFINED"/>
            /// </summary>
            [global::System.Obsolete()]
            public static int NOT_DEFINED { get { if (!_NOT_DEFINEDReady) { _NOT_DEFINEDContent = SGetField<int>(LocalBridgeClazz, "NOT_DEFINED"); _NOT_DEFINEDReady = true; } return _NOT_DEFINEDContent; } }
            private static int _NOT_DEFINEDContent = default;
            private static bool _NOT_DEFINEDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/sip/SipSession.State.html#OUTGOING_CALL"/>
            /// </summary>
            [global::System.Obsolete()]
            public static int OUTGOING_CALL { get { if (!_OUTGOING_CALLReady) { _OUTGOING_CALLContent = SGetField<int>(LocalBridgeClazz, "OUTGOING_CALL"); _OUTGOING_CALLReady = true; } return _OUTGOING_CALLContent; } }
            private static int _OUTGOING_CALLContent = default;
            private static bool _OUTGOING_CALLReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/sip/SipSession.State.html#OUTGOING_CALL_CANCELING"/>
            /// </summary>
            [global::System.Obsolete()]
            public static int OUTGOING_CALL_CANCELING { get { if (!_OUTGOING_CALL_CANCELINGReady) { _OUTGOING_CALL_CANCELINGContent = SGetField<int>(LocalBridgeClazz, "OUTGOING_CALL_CANCELING"); _OUTGOING_CALL_CANCELINGReady = true; } return _OUTGOING_CALL_CANCELINGContent; } }
            private static int _OUTGOING_CALL_CANCELINGContent = default;
            private static bool _OUTGOING_CALL_CANCELINGReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/sip/SipSession.State.html#OUTGOING_CALL_RING_BACK"/>
            /// </summary>
            [global::System.Obsolete()]
            public static int OUTGOING_CALL_RING_BACK { get { if (!_OUTGOING_CALL_RING_BACKReady) { _OUTGOING_CALL_RING_BACKContent = SGetField<int>(LocalBridgeClazz, "OUTGOING_CALL_RING_BACK"); _OUTGOING_CALL_RING_BACKReady = true; } return _OUTGOING_CALL_RING_BACKContent; } }
            private static int _OUTGOING_CALL_RING_BACKContent = default;
            private static bool _OUTGOING_CALL_RING_BACKReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/sip/SipSession.State.html#PINGING"/>
            /// </summary>
            [global::System.Obsolete()]
            public static int PINGING { get { if (!_PINGINGReady) { _PINGINGContent = SGetField<int>(LocalBridgeClazz, "PINGING"); _PINGINGReady = true; } return _PINGINGContent; } }
            private static int _PINGINGContent = default;
            private static bool _PINGINGReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/sip/SipSession.State.html#READY_TO_CALL"/>
            /// </summary>
            [global::System.Obsolete()]
            public static int READY_TO_CALL { get { if (!_READY_TO_CALLReady) { _READY_TO_CALLContent = SGetField<int>(LocalBridgeClazz, "READY_TO_CALL"); _READY_TO_CALLReady = true; } return _READY_TO_CALLContent; } }
            private static int _READY_TO_CALLContent = default;
            private static bool _READY_TO_CALLReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/sip/SipSession.State.html#REGISTERING"/>
            /// </summary>
            [global::System.Obsolete()]
            public static int REGISTERING { get { if (!_REGISTERINGReady) { _REGISTERINGContent = SGetField<int>(LocalBridgeClazz, "REGISTERING"); _REGISTERINGReady = true; } return _REGISTERINGContent; } }
            private static int _REGISTERINGContent = default;
            private static bool _REGISTERINGReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/sip/SipSession.State.html#toString(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Java.Lang.String"/></returns>
            [global::System.Obsolete()]
            public static Java.Lang.String ToString(int arg0)
            {
                return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "toString", "(I)Ljava/lang/String;", arg0);
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