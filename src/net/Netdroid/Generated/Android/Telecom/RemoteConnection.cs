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

namespace Android.Telecom
{
    #region RemoteConnection
    public partial class RemoteConnection
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
        /// <see href="https://developer.android.com/reference/android/telecom/RemoteConnection.html#getAddress()"/>
        /// </summary>
        /// <returns><see cref="Android.Net.Uri"/></returns>
        public Android.Net.Uri GetAddress()
        {
            return IExecuteWithSignature<Android.Net.Uri>("getAddress", "()Landroid/net/Uri;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/RemoteConnection.html#getExtras()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.Bundle"/></returns>
        public Android.Os.Bundle GetExtras()
        {
            return IExecuteWithSignature<Android.Os.Bundle>("getExtras", "()Landroid/os/Bundle;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/RemoteConnection.html#getDisconnectCause()"/>
        /// </summary>
        /// <returns><see cref="Android.Telecom.DisconnectCause"/></returns>
        public Android.Telecom.DisconnectCause GetDisconnectCause()
        {
            return IExecuteWithSignature<Android.Telecom.DisconnectCause>("getDisconnectCause", "()Landroid/telecom/DisconnectCause;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/RemoteConnection.html#getConference()"/>
        /// </summary>
        /// <returns><see cref="Android.Telecom.RemoteConference"/></returns>
        public Android.Telecom.RemoteConference GetConference()
        {
            return IExecuteWithSignature<Android.Telecom.RemoteConference>("getConference", "()Landroid/telecom/RemoteConference;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/RemoteConnection.html#getVideoProvider()"/>
        /// </summary>
        /// <returns><see cref="Android.Telecom.RemoteConnection.VideoProvider"/></returns>
        public Android.Telecom.RemoteConnection.VideoProvider GetVideoProvider()
        {
            return IExecuteWithSignature<Android.Telecom.RemoteConnection.VideoProvider>("getVideoProvider", "()Landroid/telecom/RemoteConnection$VideoProvider;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/RemoteConnection.html#getStatusHints()"/>
        /// </summary>
        /// <returns><see cref="Android.Telecom.StatusHints"/></returns>
        public Android.Telecom.StatusHints GetStatusHints()
        {
            return IExecuteWithSignature<Android.Telecom.StatusHints>("getStatusHints", "()Landroid/telecom/StatusHints;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/RemoteConnection.html#isRingbackRequested()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsRingbackRequested()
        {
            return IExecuteWithSignature<bool>("isRingbackRequested", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/RemoteConnection.html#isVoipAudioMode()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsVoipAudioMode()
        {
            return IExecuteWithSignature<bool>("isVoipAudioMode", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/RemoteConnection.html#getAddressPresentation()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetAddressPresentation()
        {
            return IExecuteWithSignature<int>("getAddressPresentation", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/RemoteConnection.html#getCallerDisplayNamePresentation()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetCallerDisplayNamePresentation()
        {
            return IExecuteWithSignature<int>("getCallerDisplayNamePresentation", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/RemoteConnection.html#getConnectionCapabilities()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetConnectionCapabilities()
        {
            return IExecuteWithSignature<int>("getConnectionCapabilities", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/RemoteConnection.html#getConnectionProperties()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetConnectionProperties()
        {
            return IExecuteWithSignature<int>("getConnectionProperties", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/RemoteConnection.html#getState()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetState()
        {
            return IExecuteWithSignature<int>("getState", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/RemoteConnection.html#getVideoState()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetVideoState()
        {
            return IExecuteWithSignature<int>("getVideoState", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/RemoteConnection.html#getCallerDisplayName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence GetCallerDisplayName()
        {
            return IExecuteWithSignature<Java.Lang.CharSequence>("getCallerDisplayName", "()Ljava/lang/CharSequence;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/RemoteConnection.html#getConferenceableConnections()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Telecom.RemoteConnection> GetConferenceableConnections()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Telecom.RemoteConnection>>("getConferenceableConnections", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/RemoteConnection.html#abort()"/>
        /// </summary>
        public void Abort()
        {
            IExecuteWithSignature("abort", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/RemoteConnection.html#addConferenceParticipants(java.util.List)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        public void AddConferenceParticipants(Java.Util.List<Android.Net.Uri> arg0)
        {
            IExecuteWithSignature("addConferenceParticipants", "(Ljava/util/List;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/RemoteConnection.html#answer()"/>
        /// </summary>
        public void Answer()
        {
            IExecuteWithSignature("answer", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/RemoteConnection.html#disconnect()"/>
        /// </summary>
        public void Disconnect()
        {
            IExecuteWithSignature("disconnect", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/RemoteConnection.html#hold()"/>
        /// </summary>
        public void Hold()
        {
            IExecuteWithSignature("hold", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/RemoteConnection.html#playDtmfTone(char)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        public void PlayDtmfTone(char arg0)
        {
            IExecuteWithSignature("playDtmfTone", "(C)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/RemoteConnection.html#postDialContinue(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void PostDialContinue(bool arg0)
        {
            IExecuteWithSignature("postDialContinue", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/RemoteConnection.html#pullExternalCall()"/>
        /// </summary>
        public void PullExternalCall()
        {
            IExecuteWithSignature("pullExternalCall", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/RemoteConnection.html#registerCallback(android.telecom.RemoteConnection.Callback,android.os.Handler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Telecom.RemoteConnection.Callback"/></param>
        /// <param name="arg1"><see cref="Android.Os.Handler"/></param>
        public void RegisterCallback(Android.Telecom.RemoteConnection.Callback arg0, Android.Os.Handler arg1)
        {
            IExecute("registerCallback", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/RemoteConnection.html#registerCallback(android.telecom.RemoteConnection.Callback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Telecom.RemoteConnection.Callback"/></param>
        public void RegisterCallback(Android.Telecom.RemoteConnection.Callback arg0)
        {
            IExecuteWithSignature("registerCallback", "(Landroid/telecom/RemoteConnection$Callback;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/RemoteConnection.html#reject()"/>
        /// </summary>
        public void Reject()
        {
            IExecuteWithSignature("reject", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/RemoteConnection.html#setCallAudioState(android.telecom.CallAudioState)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Telecom.CallAudioState"/></param>
        public void SetCallAudioState(Android.Telecom.CallAudioState arg0)
        {
            IExecuteWithSignature("setCallAudioState", "(Landroid/telecom/CallAudioState;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/RemoteConnection.html#stopDtmfTone()"/>
        /// </summary>
        public void StopDtmfTone()
        {
            IExecuteWithSignature("stopDtmfTone", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/RemoteConnection.html#unhold()"/>
        /// </summary>
        public void Unhold()
        {
            IExecuteWithSignature("unhold", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/RemoteConnection.html#unregisterCallback(android.telecom.RemoteConnection.Callback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Telecom.RemoteConnection.Callback"/></param>
        public void UnregisterCallback(Android.Telecom.RemoteConnection.Callback arg0)
        {
            IExecuteWithSignature("unregisterCallback", "(Landroid/telecom/RemoteConnection$Callback;)V", arg0);
        }

        #endregion

        #region Nested classes
        #region Callback
        public partial class Callback
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
            /// <see href="https://developer.android.com/reference/android/telecom/RemoteConnection.Callback.html#onAddressChanged(android.telecom.RemoteConnection,android.net.Uri,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Telecom.RemoteConnection"/></param>
            /// <param name="arg1"><see cref="Android.Net.Uri"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            public void OnAddressChanged(Android.Telecom.RemoteConnection arg0, Android.Net.Uri arg1, int arg2)
            {
                IExecute("onAddressChanged", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telecom/RemoteConnection.Callback.html#onCallerDisplayNameChanged(android.telecom.RemoteConnection,java.lang.String,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Telecom.RemoteConnection"/></param>
            /// <param name="arg1"><see cref="Java.Lang.String"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            public void OnCallerDisplayNameChanged(Android.Telecom.RemoteConnection arg0, Java.Lang.String arg1, int arg2)
            {
                IExecute("onCallerDisplayNameChanged", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telecom/RemoteConnection.Callback.html#onConferenceableConnectionsChanged(android.telecom.RemoteConnection,java.util.List)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Telecom.RemoteConnection"/></param>
            /// <param name="arg1"><see cref="Java.Util.List"/></param>
            public void OnConferenceableConnectionsChanged(Android.Telecom.RemoteConnection arg0, Java.Util.List<Android.Telecom.RemoteConnection> arg1)
            {
                IExecute("onConferenceableConnectionsChanged", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telecom/RemoteConnection.Callback.html#onConferenceChanged(android.telecom.RemoteConnection,android.telecom.RemoteConference)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Telecom.RemoteConnection"/></param>
            /// <param name="arg1"><see cref="Android.Telecom.RemoteConference"/></param>
            public void OnConferenceChanged(Android.Telecom.RemoteConnection arg0, Android.Telecom.RemoteConference arg1)
            {
                IExecute("onConferenceChanged", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telecom/RemoteConnection.Callback.html#onConnectionCapabilitiesChanged(android.telecom.RemoteConnection,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Telecom.RemoteConnection"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            public void OnConnectionCapabilitiesChanged(Android.Telecom.RemoteConnection arg0, int arg1)
            {
                IExecute("onConnectionCapabilitiesChanged", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telecom/RemoteConnection.Callback.html#onConnectionEvent(android.telecom.RemoteConnection,java.lang.String,android.os.Bundle)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Telecom.RemoteConnection"/></param>
            /// <param name="arg1"><see cref="Java.Lang.String"/></param>
            /// <param name="arg2"><see cref="Android.Os.Bundle"/></param>
            public void OnConnectionEvent(Android.Telecom.RemoteConnection arg0, Java.Lang.String arg1, Android.Os.Bundle arg2)
            {
                IExecute("onConnectionEvent", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telecom/RemoteConnection.Callback.html#onConnectionPropertiesChanged(android.telecom.RemoteConnection,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Telecom.RemoteConnection"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            public void OnConnectionPropertiesChanged(Android.Telecom.RemoteConnection arg0, int arg1)
            {
                IExecute("onConnectionPropertiesChanged", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telecom/RemoteConnection.Callback.html#onDestroyed(android.telecom.RemoteConnection)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Telecom.RemoteConnection"/></param>
            public void OnDestroyed(Android.Telecom.RemoteConnection arg0)
            {
                IExecuteWithSignature("onDestroyed", "(Landroid/telecom/RemoteConnection;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telecom/RemoteConnection.Callback.html#onDisconnected(android.telecom.RemoteConnection,android.telecom.DisconnectCause)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Telecom.RemoteConnection"/></param>
            /// <param name="arg1"><see cref="Android.Telecom.DisconnectCause"/></param>
            public void OnDisconnected(Android.Telecom.RemoteConnection arg0, Android.Telecom.DisconnectCause arg1)
            {
                IExecute("onDisconnected", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telecom/RemoteConnection.Callback.html#onExtrasChanged(android.telecom.RemoteConnection,android.os.Bundle)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Telecom.RemoteConnection"/></param>
            /// <param name="arg1"><see cref="Android.Os.Bundle"/></param>
            public void OnExtrasChanged(Android.Telecom.RemoteConnection arg0, Android.Os.Bundle arg1)
            {
                IExecute("onExtrasChanged", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telecom/RemoteConnection.Callback.html#onPostDialChar(android.telecom.RemoteConnection,char)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Telecom.RemoteConnection"/></param>
            /// <param name="arg1"><see cref="char"/></param>
            public void OnPostDialChar(Android.Telecom.RemoteConnection arg0, char arg1)
            {
                IExecute("onPostDialChar", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telecom/RemoteConnection.Callback.html#onPostDialWait(android.telecom.RemoteConnection,java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Telecom.RemoteConnection"/></param>
            /// <param name="arg1"><see cref="Java.Lang.String"/></param>
            public void OnPostDialWait(Android.Telecom.RemoteConnection arg0, Java.Lang.String arg1)
            {
                IExecute("onPostDialWait", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telecom/RemoteConnection.Callback.html#onRingbackRequested(android.telecom.RemoteConnection,boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Telecom.RemoteConnection"/></param>
            /// <param name="arg1"><see cref="bool"/></param>
            public void OnRingbackRequested(Android.Telecom.RemoteConnection arg0, bool arg1)
            {
                IExecute("onRingbackRequested", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telecom/RemoteConnection.Callback.html#onStateChanged(android.telecom.RemoteConnection,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Telecom.RemoteConnection"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            public void OnStateChanged(Android.Telecom.RemoteConnection arg0, int arg1)
            {
                IExecute("onStateChanged", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telecom/RemoteConnection.Callback.html#onStatusHintsChanged(android.telecom.RemoteConnection,android.telecom.StatusHints)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Telecom.RemoteConnection"/></param>
            /// <param name="arg1"><see cref="Android.Telecom.StatusHints"/></param>
            public void OnStatusHintsChanged(Android.Telecom.RemoteConnection arg0, Android.Telecom.StatusHints arg1)
            {
                IExecute("onStatusHintsChanged", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telecom/RemoteConnection.Callback.html#onVideoProviderChanged(android.telecom.RemoteConnection,android.telecom.RemoteConnection.VideoProvider)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Telecom.RemoteConnection"/></param>
            /// <param name="arg1"><see cref="Android.Telecom.RemoteConnection.VideoProvider"/></param>
            public void OnVideoProviderChanged(Android.Telecom.RemoteConnection arg0, Android.Telecom.RemoteConnection.VideoProvider arg1)
            {
                IExecute("onVideoProviderChanged", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telecom/RemoteConnection.Callback.html#onVideoStateChanged(android.telecom.RemoteConnection,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Telecom.RemoteConnection"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            public void OnVideoStateChanged(Android.Telecom.RemoteConnection arg0, int arg1)
            {
                IExecute("onVideoStateChanged", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telecom/RemoteConnection.Callback.html#onVoipAudioChanged(android.telecom.RemoteConnection,boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Telecom.RemoteConnection"/></param>
            /// <param name="arg1"><see cref="bool"/></param>
            public void OnVoipAudioChanged(Android.Telecom.RemoteConnection arg0, bool arg1)
            {
                IExecute("onVoipAudioChanged", arg0, arg1);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region VideoProvider
        public partial class VideoProvider
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
            /// <see href="https://developer.android.com/reference/android/telecom/RemoteConnection.VideoProvider.html#registerCallback(android.telecom.RemoteConnection.VideoProvider.Callback)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Telecom.RemoteConnection.VideoProvider.Callback"/></param>
            public void RegisterCallback(Android.Telecom.RemoteConnection.VideoProvider.Callback arg0)
            {
                IExecuteWithSignature("registerCallback", "(Landroid/telecom/RemoteConnection$VideoProvider$Callback;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telecom/RemoteConnection.VideoProvider.html#requestCallDataUsage()"/>
            /// </summary>
            public void RequestCallDataUsage()
            {
                IExecuteWithSignature("requestCallDataUsage", "()V");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telecom/RemoteConnection.VideoProvider.html#requestCameraCapabilities()"/>
            /// </summary>
            public void RequestCameraCapabilities()
            {
                IExecuteWithSignature("requestCameraCapabilities", "()V");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telecom/RemoteConnection.VideoProvider.html#sendSessionModifyRequest(android.telecom.VideoProfile,android.telecom.VideoProfile)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Telecom.VideoProfile"/></param>
            /// <param name="arg1"><see cref="Android.Telecom.VideoProfile"/></param>
            public void SendSessionModifyRequest(Android.Telecom.VideoProfile arg0, Android.Telecom.VideoProfile arg1)
            {
                IExecute("sendSessionModifyRequest", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telecom/RemoteConnection.VideoProvider.html#sendSessionModifyResponse(android.telecom.VideoProfile)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Telecom.VideoProfile"/></param>
            public void SendSessionModifyResponse(Android.Telecom.VideoProfile arg0)
            {
                IExecuteWithSignature("sendSessionModifyResponse", "(Landroid/telecom/VideoProfile;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telecom/RemoteConnection.VideoProvider.html#setCamera(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            public void SetCamera(Java.Lang.String arg0)
            {
                IExecuteWithSignature("setCamera", "(Ljava/lang/String;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telecom/RemoteConnection.VideoProvider.html#setDeviceOrientation(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            public void SetDeviceOrientation(int arg0)
            {
                IExecuteWithSignature("setDeviceOrientation", "(I)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telecom/RemoteConnection.VideoProvider.html#setDisplaySurface(android.view.Surface)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.Surface"/></param>
            public void SetDisplaySurface(Android.View.Surface arg0)
            {
                IExecuteWithSignature("setDisplaySurface", "(Landroid/view/Surface;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telecom/RemoteConnection.VideoProvider.html#setPauseImage(android.net.Uri)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
            public void SetPauseImage(Android.Net.Uri arg0)
            {
                IExecuteWithSignature("setPauseImage", "(Landroid/net/Uri;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telecom/RemoteConnection.VideoProvider.html#setPreviewSurface(android.view.Surface)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.Surface"/></param>
            public void SetPreviewSurface(Android.View.Surface arg0)
            {
                IExecuteWithSignature("setPreviewSurface", "(Landroid/view/Surface;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telecom/RemoteConnection.VideoProvider.html#setZoom(float)"/>
            /// </summary>
            /// <param name="arg0"><see cref="float"/></param>
            public void SetZoom(float arg0)
            {
                IExecuteWithSignature("setZoom", "(F)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telecom/RemoteConnection.VideoProvider.html#unregisterCallback(android.telecom.RemoteConnection.VideoProvider.Callback)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Telecom.RemoteConnection.VideoProvider.Callback"/></param>
            public void UnregisterCallback(Android.Telecom.RemoteConnection.VideoProvider.Callback arg0)
            {
                IExecuteWithSignature("unregisterCallback", "(Landroid/telecom/RemoteConnection$VideoProvider$Callback;)V", arg0);
            }

            #endregion

            #region Nested classes
            #region Callback
            public partial class Callback
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
                /// <see href="https://developer.android.com/reference/android/telecom/RemoteConnection.VideoProvider.Callback.html#onCallDataUsageChanged(android.telecom.RemoteConnection.VideoProvider,long)"/>
                /// </summary>
                /// <param name="arg0"><see cref="Android.Telecom.RemoteConnection.VideoProvider"/></param>
                /// <param name="arg1"><see cref="long"/></param>
                public void OnCallDataUsageChanged(Android.Telecom.RemoteConnection.VideoProvider arg0, long arg1)
                {
                    IExecute("onCallDataUsageChanged", arg0, arg1);
                }
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/telecom/RemoteConnection.VideoProvider.Callback.html#onCallSessionEvent(android.telecom.RemoteConnection.VideoProvider,int)"/>
                /// </summary>
                /// <param name="arg0"><see cref="Android.Telecom.RemoteConnection.VideoProvider"/></param>
                /// <param name="arg1"><see cref="int"/></param>
                public void OnCallSessionEvent(Android.Telecom.RemoteConnection.VideoProvider arg0, int arg1)
                {
                    IExecute("onCallSessionEvent", arg0, arg1);
                }
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/telecom/RemoteConnection.VideoProvider.Callback.html#onCameraCapabilitiesChanged(android.telecom.RemoteConnection.VideoProvider,android.telecom.VideoProfile.CameraCapabilities)"/>
                /// </summary>
                /// <param name="arg0"><see cref="Android.Telecom.RemoteConnection.VideoProvider"/></param>
                /// <param name="arg1"><see cref="Android.Telecom.VideoProfile.CameraCapabilities"/></param>
                public void OnCameraCapabilitiesChanged(Android.Telecom.RemoteConnection.VideoProvider arg0, Android.Telecom.VideoProfile.CameraCapabilities arg1)
                {
                    IExecute("onCameraCapabilitiesChanged", arg0, arg1);
                }
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/telecom/RemoteConnection.VideoProvider.Callback.html#onPeerDimensionsChanged(android.telecom.RemoteConnection.VideoProvider,int,int)"/>
                /// </summary>
                /// <param name="arg0"><see cref="Android.Telecom.RemoteConnection.VideoProvider"/></param>
                /// <param name="arg1"><see cref="int"/></param>
                /// <param name="arg2"><see cref="int"/></param>
                public void OnPeerDimensionsChanged(Android.Telecom.RemoteConnection.VideoProvider arg0, int arg1, int arg2)
                {
                    IExecute("onPeerDimensionsChanged", arg0, arg1, arg2);
                }
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/telecom/RemoteConnection.VideoProvider.Callback.html#onSessionModifyRequestReceived(android.telecom.RemoteConnection.VideoProvider,android.telecom.VideoProfile)"/>
                /// </summary>
                /// <param name="arg0"><see cref="Android.Telecom.RemoteConnection.VideoProvider"/></param>
                /// <param name="arg1"><see cref="Android.Telecom.VideoProfile"/></param>
                public void OnSessionModifyRequestReceived(Android.Telecom.RemoteConnection.VideoProvider arg0, Android.Telecom.VideoProfile arg1)
                {
                    IExecute("onSessionModifyRequestReceived", arg0, arg1);
                }
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/telecom/RemoteConnection.VideoProvider.Callback.html#onSessionModifyResponseReceived(android.telecom.RemoteConnection.VideoProvider,int,android.telecom.VideoProfile,android.telecom.VideoProfile)"/>
                /// </summary>
                /// <param name="arg0"><see cref="Android.Telecom.RemoteConnection.VideoProvider"/></param>
                /// <param name="arg1"><see cref="int"/></param>
                /// <param name="arg2"><see cref="Android.Telecom.VideoProfile"/></param>
                /// <param name="arg3"><see cref="Android.Telecom.VideoProfile"/></param>
                public void OnSessionModifyResponseReceived(Android.Telecom.RemoteConnection.VideoProvider arg0, int arg1, Android.Telecom.VideoProfile arg2, Android.Telecom.VideoProfile arg3)
                {
                    IExecute("onSessionModifyResponseReceived", arg0, arg1, arg2, arg3);
                }
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/telecom/RemoteConnection.VideoProvider.Callback.html#onVideoQualityChanged(android.telecom.RemoteConnection.VideoProvider,int)"/>
                /// </summary>
                /// <param name="arg0"><see cref="Android.Telecom.RemoteConnection.VideoProvider"/></param>
                /// <param name="arg1"><see cref="int"/></param>
                public void OnVideoQualityChanged(Android.Telecom.RemoteConnection.VideoProvider arg0, int arg1)
                {
                    IExecute("onVideoQualityChanged", arg0, arg1);
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

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}