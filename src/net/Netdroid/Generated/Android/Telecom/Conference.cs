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
        /// <see href="https://developer.android.com/reference/android/telecom/Conference.html#getConferenceableConnections()"/> <see href="https://developer.android.com/reference/android/telecom/Conference.html#setConferenceableConnections(java.util.List)"/>
        /// </summary>
        public Java.Util.List<Android.Telecom.Connection> ConferenceableConnections
        {
            get { return IExecuteWithSignature<Java.Util.List<Android.Telecom.Connection>>("getConferenceableConnections", "()Ljava/util/List;"); } set { IExecuteWithSignature("setConferenceableConnections", "(Ljava/util/List;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/Conference.html#getConnectionCapabilities()"/> <see href="https://developer.android.com/reference/android/telecom/Conference.html#setConnectionCapabilities(int)"/>
        /// </summary>
        public int ConnectionCapabilities
        {
            get { return IExecuteWithSignature<int>("getConnectionCapabilities", "()I"); } set { IExecuteWithSignature("setConnectionCapabilities", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/Conference.html#getConnectionProperties()"/> <see href="https://developer.android.com/reference/android/telecom/Conference.html#setConnectionProperties(int)"/>
        /// </summary>
        public int ConnectionProperties
        {
            get { return IExecuteWithSignature<int>("getConnectionProperties", "()I"); } set { IExecuteWithSignature("setConnectionProperties", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/Conference.html#getConnections()"/> 
        /// </summary>
        public Java.Util.List<Android.Telecom.Connection> Connections
        {
            get { return IExecuteWithSignature<Java.Util.List<Android.Telecom.Connection>>("getConnections", "()Ljava/util/List;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/Conference.html#getConnectionStartElapsedRealtimeMillis()"/> <see href="https://developer.android.com/reference/android/telecom/Conference.html#setConnectionStartElapsedRealtimeMillis(long)"/>
        /// </summary>
        public long ConnectionStartElapsedRealtimeMillis
        {
            get { return IExecuteWithSignature<long>("getConnectionStartElapsedRealtimeMillis", "()J"); } set { IExecuteWithSignature("setConnectionStartElapsedRealtimeMillis", "(J)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/Conference.html#getConnectionTime()"/> <see href="https://developer.android.com/reference/android/telecom/Conference.html#setConnectionTime(long)"/>
        /// </summary>
        public long ConnectionTime
        {
            get { return IExecuteWithSignature<long>("getConnectionTime", "()J"); } set { IExecuteWithSignature("setConnectionTime", "(J)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/Conference.html#getCurrentCallEndpoint()"/> 
        /// </summary>
        public Android.Telecom.CallEndpoint CurrentCallEndpoint
        {
            get { return IExecuteWithSignature<Android.Telecom.CallEndpoint>("getCurrentCallEndpoint", "()Landroid/telecom/CallEndpoint;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/Conference.html#getDisconnectCause()"/> 
        /// </summary>
        public Android.Telecom.DisconnectCause DisconnectCause
        {
            get { return IExecuteWithSignature<Android.Telecom.DisconnectCause>("getDisconnectCause", "()Landroid/telecom/DisconnectCause;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/Conference.html#getExtras()"/> <see href="https://developer.android.com/reference/android/telecom/Conference.html#setExtras(android.os.Bundle)"/>
        /// </summary>
        public Android.Os.Bundle Extras
        {
            get { return IExecuteWithSignature<Android.Os.Bundle>("getExtras", "()Landroid/os/Bundle;"); } set { IExecuteWithSignature("setExtras", "(Landroid/os/Bundle;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/Conference.html#getPhoneAccountHandle()"/> 
        /// </summary>
        public Android.Telecom.PhoneAccountHandle PhoneAccountHandle
        {
            get { return IExecuteWithSignature<Android.Telecom.PhoneAccountHandle>("getPhoneAccountHandle", "()Landroid/telecom/PhoneAccountHandle;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/Conference.html#getState()"/> 
        /// </summary>
        public int State
        {
            get { return IExecuteWithSignature<int>("getState", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/Conference.html#getStatusHints()"/> <see href="https://developer.android.com/reference/android/telecom/Conference.html#setStatusHints(android.telecom.StatusHints)"/>
        /// </summary>
        public Android.Telecom.StatusHints StatusHints
        {
            get { return IExecuteWithSignature<Android.Telecom.StatusHints>("getStatusHints", "()Landroid/telecom/StatusHints;"); } set { IExecuteWithSignature("setStatusHints", "(Landroid/telecom/StatusHints;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/Conference.html#getVideoProvider()"/> 
        /// </summary>
        public Android.Telecom.Connection.VideoProvider VideoProvider
        {
            get { return IExecuteWithSignature<Android.Telecom.Connection.VideoProvider>("getVideoProvider", "()Landroid/telecom/Connection$VideoProvider;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/Conference.html#getVideoState()"/> 
        /// </summary>
        public int VideoState
        {
            get { return IExecuteWithSignature<int>("getVideoState", "()I"); }
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