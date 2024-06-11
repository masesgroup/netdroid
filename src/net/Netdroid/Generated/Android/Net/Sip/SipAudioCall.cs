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
*  This file is generated by MASES.JNetReflector (ver. 2.5.2.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Net.Sip
{
    #region SipAudioCall
    public partial class SipAudioCall
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/sip/SipAudioCall.html#%3Cinit%3E(android.content.Context,android.net.sip.SipProfile)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Net.Sip.SipProfile"/></param>
        [global::System.Obsolete()]
        public SipAudioCall(Android.Content.Context arg0, Android.Net.Sip.SipProfile arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/sip/SipAudioCall.html#getLocalProfile()"/>
        /// </summary>
        /// <returns><see cref="Android.Net.Sip.SipProfile"/></returns>
        [global::System.Obsolete()]
        public Android.Net.Sip.SipProfile GetLocalProfile()
        {
            return IExecuteWithSignature<Android.Net.Sip.SipProfile>("getLocalProfile", "()Landroid/net/sip/SipProfile;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/sip/SipAudioCall.html#getPeerProfile()"/>
        /// </summary>
        /// <returns><see cref="Android.Net.Sip.SipProfile"/></returns>
        [global::System.Obsolete()]
        public Android.Net.Sip.SipProfile GetPeerProfile()
        {
            return IExecuteWithSignature<Android.Net.Sip.SipProfile>("getPeerProfile", "()Landroid/net/sip/SipProfile;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/sip/SipAudioCall.html#isInCall()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool IsInCall()
        {
            return IExecuteWithSignature<bool>("isInCall", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/sip/SipAudioCall.html#isMuted()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool IsMuted()
        {
            return IExecuteWithSignature<bool>("isMuted", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/sip/SipAudioCall.html#isOnHold()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool IsOnHold()
        {
            return IExecuteWithSignature<bool>("isOnHold", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/sip/SipAudioCall.html#getState()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int GetState()
        {
            return IExecuteWithSignature<int>("getState", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/sip/SipAudioCall.html#answerCall(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <exception cref="Android.Net.Sip.SipException"/>
        [global::System.Obsolete()]
        public void AnswerCall(int arg0)
        {
            IExecuteWithSignature("answerCall", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/sip/SipAudioCall.html#attachCall(android.net.sip.SipSession,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Sip.SipSession"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Android.Net.Sip.SipException"/>
        [global::System.Obsolete()]
        public void AttachCall(Android.Net.Sip.SipSession arg0, Java.Lang.String arg1)
        {
            IExecute("attachCall", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/sip/SipAudioCall.html#close()"/>
        /// </summary>
        [global::System.Obsolete()]
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/sip/SipAudioCall.html#continueCall(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <exception cref="Android.Net.Sip.SipException"/>
        [global::System.Obsolete()]
        public void ContinueCall(int arg0)
        {
            IExecuteWithSignature("continueCall", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/sip/SipAudioCall.html#endCall()"/>
        /// </summary>
        /// <exception cref="Android.Net.Sip.SipException"/>
        [global::System.Obsolete()]
        public void EndCall()
        {
            IExecuteWithSignature("endCall", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/sip/SipAudioCall.html#holdCall(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <exception cref="Android.Net.Sip.SipException"/>
        [global::System.Obsolete()]
        public void HoldCall(int arg0)
        {
            IExecuteWithSignature("holdCall", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/sip/SipAudioCall.html#makeCall(android.net.sip.SipProfile,android.net.sip.SipSession,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Sip.SipProfile"/></param>
        /// <param name="arg1"><see cref="Android.Net.Sip.SipSession"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Android.Net.Sip.SipException"/>
        [global::System.Obsolete()]
        public void MakeCall(Android.Net.Sip.SipProfile arg0, Android.Net.Sip.SipSession arg1, int arg2)
        {
            IExecute("makeCall", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/sip/SipAudioCall.html#sendDtmf(int,android.os.Message)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.Os.Message"/></param>
        [global::System.Obsolete()]
        public void SendDtmf(int arg0, Android.Os.Message arg1)
        {
            IExecute("sendDtmf", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/sip/SipAudioCall.html#sendDtmf(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        [global::System.Obsolete()]
        public void SendDtmf(int arg0)
        {
            IExecuteWithSignature("sendDtmf", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/sip/SipAudioCall.html#setListener(android.net.sip.SipAudioCall.Listener,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Sip.SipAudioCall.Listener"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        [global::System.Obsolete()]
        public void SetListener(Android.Net.Sip.SipAudioCall.Listener arg0, bool arg1)
        {
            IExecute("setListener", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/sip/SipAudioCall.html#setListener(android.net.sip.SipAudioCall.Listener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Sip.SipAudioCall.Listener"/></param>
        [global::System.Obsolete()]
        public void SetListener(Android.Net.Sip.SipAudioCall.Listener arg0)
        {
            IExecuteWithSignature("setListener", "(Landroid/net/sip/SipAudioCall$Listener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/sip/SipAudioCall.html#setSpeakerMode(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        [global::System.Obsolete()]
        public void SetSpeakerMode(bool arg0)
        {
            IExecuteWithSignature("setSpeakerMode", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/sip/SipAudioCall.html#startAudio()"/>
        /// </summary>
        [global::System.Obsolete()]
        public void StartAudio()
        {
            IExecuteWithSignature("startAudio", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/sip/SipAudioCall.html#toggleMute()"/>
        /// </summary>
        [global::System.Obsolete()]
        public void ToggleMute()
        {
            IExecuteWithSignature("toggleMute", "()V");
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
            /// <see href="https://developer.android.com/reference/android/net/sip/SipAudioCall.Listener.html#onCallBusy(android.net.sip.SipAudioCall)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.Sip.SipAudioCall"/></param>
            [global::System.Obsolete()]
            public void OnCallBusy(Android.Net.Sip.SipAudioCall arg0)
            {
                IExecuteWithSignature("onCallBusy", "(Landroid/net/sip/SipAudioCall;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/sip/SipAudioCall.Listener.html#onCallEnded(android.net.sip.SipAudioCall)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.Sip.SipAudioCall"/></param>
            [global::System.Obsolete()]
            public void OnCallEnded(Android.Net.Sip.SipAudioCall arg0)
            {
                IExecuteWithSignature("onCallEnded", "(Landroid/net/sip/SipAudioCall;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/sip/SipAudioCall.Listener.html#onCallEstablished(android.net.sip.SipAudioCall)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.Sip.SipAudioCall"/></param>
            [global::System.Obsolete()]
            public void OnCallEstablished(Android.Net.Sip.SipAudioCall arg0)
            {
                IExecuteWithSignature("onCallEstablished", "(Landroid/net/sip/SipAudioCall;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/sip/SipAudioCall.Listener.html#onCallHeld(android.net.sip.SipAudioCall)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.Sip.SipAudioCall"/></param>
            [global::System.Obsolete()]
            public void OnCallHeld(Android.Net.Sip.SipAudioCall arg0)
            {
                IExecuteWithSignature("onCallHeld", "(Landroid/net/sip/SipAudioCall;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/sip/SipAudioCall.Listener.html#onCalling(android.net.sip.SipAudioCall)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.Sip.SipAudioCall"/></param>
            [global::System.Obsolete()]
            public void OnCalling(Android.Net.Sip.SipAudioCall arg0)
            {
                IExecuteWithSignature("onCalling", "(Landroid/net/sip/SipAudioCall;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/sip/SipAudioCall.Listener.html#onChanged(android.net.sip.SipAudioCall)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.Sip.SipAudioCall"/></param>
            [global::System.Obsolete()]
            public void OnChanged(Android.Net.Sip.SipAudioCall arg0)
            {
                IExecuteWithSignature("onChanged", "(Landroid/net/sip/SipAudioCall;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/sip/SipAudioCall.Listener.html#onError(android.net.sip.SipAudioCall,int,java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.Sip.SipAudioCall"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="Java.Lang.String"/></param>
            [global::System.Obsolete()]
            public void OnError(Android.Net.Sip.SipAudioCall arg0, int arg1, Java.Lang.String arg2)
            {
                IExecute("onError", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/sip/SipAudioCall.Listener.html#onReadyToCall(android.net.sip.SipAudioCall)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.Sip.SipAudioCall"/></param>
            [global::System.Obsolete()]
            public void OnReadyToCall(Android.Net.Sip.SipAudioCall arg0)
            {
                IExecuteWithSignature("onReadyToCall", "(Landroid/net/sip/SipAudioCall;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/sip/SipAudioCall.Listener.html#onRinging(android.net.sip.SipAudioCall,android.net.sip.SipProfile)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.Sip.SipAudioCall"/></param>
            /// <param name="arg1"><see cref="Android.Net.Sip.SipProfile"/></param>
            [global::System.Obsolete()]
            public void OnRinging(Android.Net.Sip.SipAudioCall arg0, Android.Net.Sip.SipProfile arg1)
            {
                IExecute("onRinging", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/sip/SipAudioCall.Listener.html#onRingingBack(android.net.sip.SipAudioCall)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.Sip.SipAudioCall"/></param>
            [global::System.Obsolete()]
            public void OnRingingBack(Android.Net.Sip.SipAudioCall arg0)
            {
                IExecuteWithSignature("onRingingBack", "(Landroid/net/sip/SipAudioCall;)V", arg0);
            }

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