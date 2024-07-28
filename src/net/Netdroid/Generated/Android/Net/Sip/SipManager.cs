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

namespace Android.Net.Sip
{
    #region SipManager
    public partial class SipManager
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/sip/SipManager.html#INCOMING_CALL_RESULT_CODE"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int INCOMING_CALL_RESULT_CODE { get { if (!_INCOMING_CALL_RESULT_CODEReady) { _INCOMING_CALL_RESULT_CODEContent = SGetField<int>(LocalBridgeClazz, "INCOMING_CALL_RESULT_CODE"); _INCOMING_CALL_RESULT_CODEReady = true; } return _INCOMING_CALL_RESULT_CODEContent; } }
        private static int _INCOMING_CALL_RESULT_CODEContent = default;
        private static bool _INCOMING_CALL_RESULT_CODEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/sip/SipManager.html#EXTRA_CALL_ID"/>
        /// </summary>
        [global::System.Obsolete()]
        public static Java.Lang.String EXTRA_CALL_ID { get { if (!_EXTRA_CALL_IDReady) { _EXTRA_CALL_IDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_CALL_ID"); _EXTRA_CALL_IDReady = true; } return _EXTRA_CALL_IDContent; } }
        private static Java.Lang.String _EXTRA_CALL_IDContent = default;
        private static bool _EXTRA_CALL_IDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/sip/SipManager.html#EXTRA_OFFER_SD"/>
        /// </summary>
        [global::System.Obsolete()]
        public static Java.Lang.String EXTRA_OFFER_SD { get { if (!_EXTRA_OFFER_SDReady) { _EXTRA_OFFER_SDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_OFFER_SD"); _EXTRA_OFFER_SDReady = true; } return _EXTRA_OFFER_SDContent; } }
        private static Java.Lang.String _EXTRA_OFFER_SDContent = default;
        private static bool _EXTRA_OFFER_SDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/sip/SipManager.html#newInstance(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <returns><see cref="Android.Net.Sip.SipManager"/></returns>
        [global::System.Obsolete()]
        public static Android.Net.Sip.SipManager NewInstance(Android.Content.Context arg0)
        {
            return SExecuteWithSignature<Android.Net.Sip.SipManager>(LocalBridgeClazz, "newInstance", "(Landroid/content/Context;)Landroid/net/sip/SipManager;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/sip/SipManager.html#isApiSupported(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public static bool IsApiSupported(Android.Content.Context arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isApiSupported", "(Landroid/content/Context;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/sip/SipManager.html#isIncomingCallIntent(android.content.Intent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Intent"/></param>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public static bool IsIncomingCallIntent(Android.Content.Intent arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isIncomingCallIntent", "(Landroid/content/Intent;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/sip/SipManager.html#isSipWifiOnly(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public static bool IsSipWifiOnly(Android.Content.Context arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isSipWifiOnly", "(Landroid/content/Context;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/sip/SipManager.html#isVoipSupported(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public static bool IsVoipSupported(Android.Content.Context arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isVoipSupported", "(Landroid/content/Context;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/sip/SipManager.html#getCallId(android.content.Intent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Intent"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        [global::System.Obsolete()]
        public static Java.Lang.String GetCallId(Android.Content.Intent arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "getCallId", "(Landroid/content/Intent;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/sip/SipManager.html#getOfferSessionDescription(android.content.Intent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Intent"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        [global::System.Obsolete()]
        public static Java.Lang.String GetOfferSessionDescription(Android.Content.Intent arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "getOfferSessionDescription", "(Landroid/content/Intent;)Ljava/lang/String;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/sip/SipManager.html#makeAudioCall(android.net.sip.SipProfile,android.net.sip.SipProfile,android.net.sip.SipAudioCall.Listener,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Sip.SipProfile"/></param>
        /// <param name="arg1"><see cref="Android.Net.Sip.SipProfile"/></param>
        /// <param name="arg2"><see cref="Android.Net.Sip.SipAudioCall.Listener"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="Android.Net.Sip.SipAudioCall"/></returns>
        /// <exception cref="Android.Net.Sip.SipException"/>
        [global::System.Obsolete()]
        public Android.Net.Sip.SipAudioCall MakeAudioCall(Android.Net.Sip.SipProfile arg0, Android.Net.Sip.SipProfile arg1, Android.Net.Sip.SipAudioCall.Listener arg2, int arg3)
        {
            return IExecute<Android.Net.Sip.SipAudioCall>("makeAudioCall", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/sip/SipManager.html#makeAudioCall(java.lang.String,java.lang.String,android.net.sip.SipAudioCall.Listener,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Android.Net.Sip.SipAudioCall.Listener"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="Android.Net.Sip.SipAudioCall"/></returns>
        /// <exception cref="Android.Net.Sip.SipException"/>
        [global::System.Obsolete()]
        public Android.Net.Sip.SipAudioCall MakeAudioCall(Java.Lang.String arg0, Java.Lang.String arg1, Android.Net.Sip.SipAudioCall.Listener arg2, int arg3)
        {
            return IExecute<Android.Net.Sip.SipAudioCall>("makeAudioCall", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/sip/SipManager.html#takeAudioCall(android.content.Intent,android.net.sip.SipAudioCall.Listener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Intent"/></param>
        /// <param name="arg1"><see cref="Android.Net.Sip.SipAudioCall.Listener"/></param>
        /// <returns><see cref="Android.Net.Sip.SipAudioCall"/></returns>
        /// <exception cref="Android.Net.Sip.SipException"/>
        [global::System.Obsolete()]
        public Android.Net.Sip.SipAudioCall TakeAudioCall(Android.Content.Intent arg0, Android.Net.Sip.SipAudioCall.Listener arg1)
        {
            return IExecute<Android.Net.Sip.SipAudioCall>("takeAudioCall", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/sip/SipManager.html#createSipSession(android.net.sip.SipProfile,android.net.sip.SipSession.Listener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Sip.SipProfile"/></param>
        /// <param name="arg1"><see cref="Android.Net.Sip.SipSession.Listener"/></param>
        /// <returns><see cref="Android.Net.Sip.SipSession"/></returns>
        /// <exception cref="Android.Net.Sip.SipException"/>
        [global::System.Obsolete()]
        public Android.Net.Sip.SipSession CreateSipSession(Android.Net.Sip.SipProfile arg0, Android.Net.Sip.SipSession.Listener arg1)
        {
            return IExecute<Android.Net.Sip.SipSession>("createSipSession", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/sip/SipManager.html#getSessionFor(android.content.Intent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Intent"/></param>
        /// <returns><see cref="Android.Net.Sip.SipSession"/></returns>
        /// <exception cref="Android.Net.Sip.SipException"/>
        [global::System.Obsolete()]
        public Android.Net.Sip.SipSession GetSessionFor(Android.Content.Intent arg0)
        {
            return IExecuteWithSignature<Android.Net.Sip.SipSession>("getSessionFor", "(Landroid/content/Intent;)Landroid/net/sip/SipSession;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/sip/SipManager.html#isOpened(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Android.Net.Sip.SipException"/>
        [global::System.Obsolete()]
        public bool IsOpened(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<bool>("isOpened", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/sip/SipManager.html#isRegistered(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Android.Net.Sip.SipException"/>
        [global::System.Obsolete()]
        public bool IsRegistered(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<bool>("isRegistered", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/sip/SipManager.html#close(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Android.Net.Sip.SipException"/>
        [global::System.Obsolete()]
        public void Close(Java.Lang.String arg0)
        {
            IExecuteWithSignature("close", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/sip/SipManager.html#open(android.net.sip.SipProfile,android.app.PendingIntent,android.net.sip.SipRegistrationListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Sip.SipProfile"/></param>
        /// <param name="arg1"><see cref="Android.App.PendingIntent"/></param>
        /// <param name="arg2"><see cref="Android.Net.Sip.SipRegistrationListener"/></param>
        /// <exception cref="Android.Net.Sip.SipException"/>
        [global::System.Obsolete()]
        public void Open(Android.Net.Sip.SipProfile arg0, Android.App.PendingIntent arg1, Android.Net.Sip.SipRegistrationListener arg2)
        {
            IExecute("open", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/sip/SipManager.html#open(android.net.sip.SipProfile)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Sip.SipProfile"/></param>
        /// <exception cref="Android.Net.Sip.SipException"/>
        [global::System.Obsolete()]
        public void Open(Android.Net.Sip.SipProfile arg0)
        {
            IExecuteWithSignature("open", "(Landroid/net/sip/SipProfile;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/sip/SipManager.html#register(android.net.sip.SipProfile,int,android.net.sip.SipRegistrationListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Sip.SipProfile"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Android.Net.Sip.SipRegistrationListener"/></param>
        /// <exception cref="Android.Net.Sip.SipException"/>
        [global::System.Obsolete()]
        public void Register(Android.Net.Sip.SipProfile arg0, int arg1, Android.Net.Sip.SipRegistrationListener arg2)
        {
            IExecute("register", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/sip/SipManager.html#setRegistrationListener(java.lang.String,android.net.sip.SipRegistrationListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Android.Net.Sip.SipRegistrationListener"/></param>
        /// <exception cref="Android.Net.Sip.SipException"/>
        [global::System.Obsolete()]
        public void SetRegistrationListener(Java.Lang.String arg0, Android.Net.Sip.SipRegistrationListener arg1)
        {
            IExecute("setRegistrationListener", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/sip/SipManager.html#unregister(android.net.sip.SipProfile,android.net.sip.SipRegistrationListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Sip.SipProfile"/></param>
        /// <param name="arg1"><see cref="Android.Net.Sip.SipRegistrationListener"/></param>
        /// <exception cref="Android.Net.Sip.SipException"/>
        [global::System.Obsolete()]
        public void Unregister(Android.Net.Sip.SipProfile arg0, Android.Net.Sip.SipRegistrationListener arg1)
        {
            IExecute("unregister", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}