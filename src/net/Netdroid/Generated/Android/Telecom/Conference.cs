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

namespace Android.Telecom
{
    #region Conference
    public partial class Conference
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/Conference.html#%3Cinit%3E(android.telecom.PhoneAccountHandle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Telecom.PhoneAccountHandle"/></param>
        public Conference(Android.Telecom.PhoneAccountHandle arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/Conference.html#CONNECT_TIME_NOT_SPECIFIED"/>
        /// </summary>
        public static long CONNECT_TIME_NOT_SPECIFIED { get { if (!_CONNECT_TIME_NOT_SPECIFIEDReady) { _CONNECT_TIME_NOT_SPECIFIEDContent = SGetField<long>(LocalBridgeClazz, "CONNECT_TIME_NOT_SPECIFIED"); _CONNECT_TIME_NOT_SPECIFIEDReady = true; } return _CONNECT_TIME_NOT_SPECIFIEDContent; } }
        private static long _CONNECT_TIME_NOT_SPECIFIEDContent = default;
        private static bool _CONNECT_TIME_NOT_SPECIFIEDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/Conference.html#createFailedConference(android.telecom.DisconnectCause,android.telecom.PhoneAccountHandle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Telecom.DisconnectCause"/></param>
        /// <param name="arg1"><see cref="Android.Telecom.PhoneAccountHandle"/></param>
        /// <returns><see cref="Android.Telecom.Conference"/></returns>
        public static Android.Telecom.Conference CreateFailedConference(Android.Telecom.DisconnectCause arg0, Android.Telecom.PhoneAccountHandle arg1)
        {
            return SExecute<Android.Telecom.Conference>(LocalBridgeClazz, "createFailedConference", arg0, arg1);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/Conference.html#getVideoProvider()"/>
        /// </summary>
        /// <returns><see cref="Android.Telecom.Connection.VideoProvider"/></returns>
        public Android.Telecom.Connection.VideoProvider GetVideoProvider()
        {
            return IExecuteWithSignature<Android.Telecom.Connection.VideoProvider>("getVideoProvider", "()Landroid/telecom/Connection$VideoProvider;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/Conference.html#getExtras()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.Bundle"/></returns>
        public Android.Os.Bundle GetExtras()
        {
            return IExecuteWithSignature<Android.Os.Bundle>("getExtras", "()Landroid/os/Bundle;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/Conference.html#getCallAudioState()"/>
        /// </summary>
        /// <returns><see cref="Android.Telecom.CallAudioState"/></returns>
        [global::System.Obsolete()]
        public Android.Telecom.CallAudioState GetCallAudioState()
        {
            return IExecuteWithSignature<Android.Telecom.CallAudioState>("getCallAudioState", "()Landroid/telecom/CallAudioState;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/Conference.html#getCurrentCallEndpoint()"/>
        /// </summary>
        /// <returns><see cref="Android.Telecom.CallEndpoint"/></returns>
        public Android.Telecom.CallEndpoint GetCurrentCallEndpoint()
        {
            return IExecuteWithSignature<Android.Telecom.CallEndpoint>("getCurrentCallEndpoint", "()Landroid/telecom/CallEndpoint;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/Conference.html#getDisconnectCause()"/>
        /// </summary>
        /// <returns><see cref="Android.Telecom.DisconnectCause"/></returns>
        public Android.Telecom.DisconnectCause GetDisconnectCause()
        {
            return IExecuteWithSignature<Android.Telecom.DisconnectCause>("getDisconnectCause", "()Landroid/telecom/DisconnectCause;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/Conference.html#getPhoneAccountHandle()"/>
        /// </summary>
        /// <returns><see cref="Android.Telecom.PhoneAccountHandle"/></returns>
        public Android.Telecom.PhoneAccountHandle GetPhoneAccountHandle()
        {
            return IExecuteWithSignature<Android.Telecom.PhoneAccountHandle>("getPhoneAccountHandle", "()Landroid/telecom/PhoneAccountHandle;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/Conference.html#getStatusHints()"/>
        /// </summary>
        /// <returns><see cref="Android.Telecom.StatusHints"/></returns>
        public Android.Telecom.StatusHints GetStatusHints()
        {
            return IExecuteWithSignature<Android.Telecom.StatusHints>("getStatusHints", "()Landroid/telecom/StatusHints;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/Conference.html#addConnection(android.telecom.Connection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Telecom.Connection"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool AddConnection(Android.Telecom.Connection arg0)
        {
            return IExecuteWithSignature<bool>("addConnection", "(Landroid/telecom/Connection;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/Conference.html#isRingbackRequested()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsRingbackRequested()
        {
            return IExecuteWithSignature<bool>("isRingbackRequested", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/Conference.html#getConnectionCapabilities()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetConnectionCapabilities()
        {
            return IExecuteWithSignature<int>("getConnectionCapabilities", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/Conference.html#getConnectionProperties()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetConnectionProperties()
        {
            return IExecuteWithSignature<int>("getConnectionProperties", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/Conference.html#getState()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetState()
        {
            return IExecuteWithSignature<int>("getState", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/Conference.html#getConferenceableConnections()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Telecom.Connection> GetConferenceableConnections()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Telecom.Connection>>("getConferenceableConnections", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/Conference.html#getConnections()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Telecom.Connection> GetConnections()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Telecom.Connection>>("getConnections", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/Conference.html#getConnectionStartElapsedRealtimeMillis()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetConnectionStartElapsedRealtimeMillis()
        {
            return IExecuteWithSignature<long>("getConnectionStartElapsedRealtimeMillis", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/Conference.html#getConnectionTime()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetConnectionTime()
        {
            return IExecuteWithSignature<long>("getConnectionTime", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/Conference.html#destroy()"/>
        /// </summary>
        public void Destroy()
        {
            IExecuteWithSignature("destroy", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/Conference.html#putExtras(android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
        public void PutExtras(Android.Os.Bundle arg0)
        {
            IExecuteWithSignature("putExtras", "(Landroid/os/Bundle;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/Conference.html#removeConnection(android.telecom.Connection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Telecom.Connection"/></param>
        public void RemoveConnection(Android.Telecom.Connection arg0)
        {
            IExecuteWithSignature("removeConnection", "(Landroid/telecom/Connection;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/Conference.html#removeExtras(java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void RemoveExtras(params Java.Lang.String[] arg0)
        {
            if (arg0.Length == 0) IExecuteWithSignature("removeExtras", "([Ljava/lang/String;)V"); else IExecuteWithSignature("removeExtras", "([Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/Conference.html#removeExtras(java.util.List)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        public void RemoveExtras(Java.Util.List<Java.Lang.String> arg0)
        {
            IExecuteWithSignature("removeExtras", "(Ljava/util/List;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/Conference.html#setActive()"/>
        /// </summary>
        public void SetActive()
        {
            IExecuteWithSignature("setActive", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/Conference.html#setConferenceableConnections(java.util.List)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        public void SetConferenceableConnections(Java.Util.List<Android.Telecom.Connection> arg0)
        {
            IExecuteWithSignature("setConferenceableConnections", "(Ljava/util/List;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/Conference.html#setConnectionCapabilities(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetConnectionCapabilities(int arg0)
        {
            IExecuteWithSignature("setConnectionCapabilities", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/Conference.html#setConnectionProperties(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetConnectionProperties(int arg0)
        {
            IExecuteWithSignature("setConnectionProperties", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/Conference.html#setConnectionStartElapsedRealTime(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        [global::System.Obsolete()]
        public void SetConnectionStartElapsedRealTime(long arg0)
        {
            IExecuteWithSignature("setConnectionStartElapsedRealTime", "(J)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/Conference.html#setConnectionStartElapsedRealtimeMillis(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public void SetConnectionStartElapsedRealtimeMillis(long arg0)
        {
            IExecuteWithSignature("setConnectionStartElapsedRealtimeMillis", "(J)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/Conference.html#setConnectionTime(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public void SetConnectionTime(long arg0)
        {
            IExecuteWithSignature("setConnectionTime", "(J)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/Conference.html#setDialing()"/>
        /// </summary>
        public void SetDialing()
        {
            IExecuteWithSignature("setDialing", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/Conference.html#setDisconnected(android.telecom.DisconnectCause)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Telecom.DisconnectCause"/></param>
        public void SetDisconnected(Android.Telecom.DisconnectCause arg0)
        {
            IExecuteWithSignature("setDisconnected", "(Landroid/telecom/DisconnectCause;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/Conference.html#setExtras(android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
        public void SetExtras(Android.Os.Bundle arg0)
        {
            IExecuteWithSignature("setExtras", "(Landroid/os/Bundle;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/Conference.html#setOnHold()"/>
        /// </summary>
        public void SetOnHold()
        {
            IExecuteWithSignature("setOnHold", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/Conference.html#setRingbackRequested(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetRingbackRequested(bool arg0)
        {
            IExecuteWithSignature("setRingbackRequested", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/Conference.html#setRinging()"/>
        /// </summary>
        public void SetRinging()
        {
            IExecuteWithSignature("setRinging", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/Conference.html#setStatusHints(android.telecom.StatusHints)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Telecom.StatusHints"/></param>
        public void SetStatusHints(Android.Telecom.StatusHints arg0)
        {
            IExecuteWithSignature("setStatusHints", "(Landroid/telecom/StatusHints;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/Conference.html#setVideoProvider(android.telecom.Connection,android.telecom.Connection.VideoProvider)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Telecom.Connection"/></param>
        /// <param name="arg1"><see cref="Android.Telecom.Connection.VideoProvider"/></param>
        public void SetVideoProvider(Android.Telecom.Connection arg0, Android.Telecom.Connection.VideoProvider arg1)
        {
            IExecute("setVideoProvider", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/Conference.html#setVideoState(android.telecom.Connection,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Telecom.Connection"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void SetVideoState(Android.Telecom.Connection arg0, int arg1)
        {
            IExecute("setVideoState", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/Conference.html#getVideoState()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetVideoState()
        {
            return IExecuteWithSignature<int>("getVideoState", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/Conference.html#onAddConferenceParticipants(java.util.List)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        public void OnAddConferenceParticipants(Java.Util.List<Android.Net.Uri> arg0)
        {
            IExecuteWithSignature("onAddConferenceParticipants", "(Ljava/util/List;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/Conference.html#onAnswer(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void OnAnswer(int arg0)
        {
            IExecuteWithSignature("onAnswer", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/Conference.html#onAvailableCallEndpointsChanged(java.util.List)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        public void OnAvailableCallEndpointsChanged(Java.Util.List<Android.Telecom.CallEndpoint> arg0)
        {
            IExecuteWithSignature("onAvailableCallEndpointsChanged", "(Ljava/util/List;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/Conference.html#onCallAudioStateChanged(android.telecom.CallAudioState)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Telecom.CallAudioState"/></param>
        [global::System.Obsolete()]
        public void OnCallAudioStateChanged(Android.Telecom.CallAudioState arg0)
        {
            IExecuteWithSignature("onCallAudioStateChanged", "(Landroid/telecom/CallAudioState;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/Conference.html#onCallEndpointChanged(android.telecom.CallEndpoint)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Telecom.CallEndpoint"/></param>
        public void OnCallEndpointChanged(Android.Telecom.CallEndpoint arg0)
        {
            IExecuteWithSignature("onCallEndpointChanged", "(Landroid/telecom/CallEndpoint;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/Conference.html#onConnectionAdded(android.telecom.Connection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Telecom.Connection"/></param>
        public void OnConnectionAdded(Android.Telecom.Connection arg0)
        {
            IExecuteWithSignature("onConnectionAdded", "(Landroid/telecom/Connection;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/Conference.html#onDisconnect()"/>
        /// </summary>
        public void OnDisconnect()
        {
            IExecuteWithSignature("onDisconnect", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/Conference.html#onExtrasChanged(android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
        public void OnExtrasChanged(Android.Os.Bundle arg0)
        {
            IExecuteWithSignature("onExtrasChanged", "(Landroid/os/Bundle;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/Conference.html#onHold()"/>
        /// </summary>
        public void OnHold()
        {
            IExecuteWithSignature("onHold", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/Conference.html#onMerge()"/>
        /// </summary>
        public void OnMerge()
        {
            IExecuteWithSignature("onMerge", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/Conference.html#onMerge(android.telecom.Connection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Telecom.Connection"/></param>
        public void OnMerge(Android.Telecom.Connection arg0)
        {
            IExecuteWithSignature("onMerge", "(Landroid/telecom/Connection;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/Conference.html#onMuteStateChanged(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void OnMuteStateChanged(bool arg0)
        {
            IExecuteWithSignature("onMuteStateChanged", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/Conference.html#onPlayDtmfTone(char)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        public void OnPlayDtmfTone(char arg0)
        {
            IExecuteWithSignature("onPlayDtmfTone", "(C)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/Conference.html#onReject()"/>
        /// </summary>
        public void OnReject()
        {
            IExecuteWithSignature("onReject", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/Conference.html#onSeparate(android.telecom.Connection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Telecom.Connection"/></param>
        public void OnSeparate(Android.Telecom.Connection arg0)
        {
            IExecuteWithSignature("onSeparate", "(Landroid/telecom/Connection;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/Conference.html#onStopDtmfTone()"/>
        /// </summary>
        public void OnStopDtmfTone()
        {
            IExecuteWithSignature("onStopDtmfTone", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/Conference.html#onSwap()"/>
        /// </summary>
        public void OnSwap()
        {
            IExecuteWithSignature("onSwap", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/Conference.html#onUnhold()"/>
        /// </summary>
        public void OnUnhold()
        {
            IExecuteWithSignature("onUnhold", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/Conference.html#sendConferenceEvent(java.lang.String,android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Android.Os.Bundle"/></param>
        public void SendConferenceEvent(Java.Lang.String arg0, Android.Os.Bundle arg1)
        {
            IExecute("sendConferenceEvent", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}