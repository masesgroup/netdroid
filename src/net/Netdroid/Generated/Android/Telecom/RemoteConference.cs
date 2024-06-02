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
    #region RemoteConference
    public partial class RemoteConference
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
        /// <see href="https://developer.android.com/reference/android/telecom/RemoteConference.html#getExtras()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.Bundle"/></returns>
        public Android.Os.Bundle GetExtras()
        {
            return IExecuteWithSignature<Android.Os.Bundle>("getExtras", "()Landroid/os/Bundle;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/RemoteConference.html#getDisconnectCause()"/>
        /// </summary>
        /// <returns><see cref="Android.Telecom.DisconnectCause"/></returns>
        public Android.Telecom.DisconnectCause GetDisconnectCause()
        {
            return IExecuteWithSignature<Android.Telecom.DisconnectCause>("getDisconnectCause", "()Landroid/telecom/DisconnectCause;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/RemoteConference.html#getConnectionCapabilities()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetConnectionCapabilities()
        {
            return IExecuteWithSignature<int>("getConnectionCapabilities", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/RemoteConference.html#getConnectionProperties()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetConnectionProperties()
        {
            return IExecuteWithSignature<int>("getConnectionProperties", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/RemoteConference.html#getState()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetState()
        {
            return IExecuteWithSignature<int>("getState", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/RemoteConference.html#getConferenceableConnections()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Telecom.RemoteConnection> GetConferenceableConnections()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Telecom.RemoteConnection>>("getConferenceableConnections", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/RemoteConference.html#getConnections()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Telecom.RemoteConnection> GetConnections()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Telecom.RemoteConnection>>("getConnections", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/RemoteConference.html#disconnect()"/>
        /// </summary>
        public void Disconnect()
        {
            IExecuteWithSignature("disconnect", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/RemoteConference.html#hold()"/>
        /// </summary>
        public void Hold()
        {
            IExecuteWithSignature("hold", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/RemoteConference.html#merge()"/>
        /// </summary>
        public void Merge()
        {
            IExecuteWithSignature("merge", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/RemoteConference.html#playDtmfTone(char)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        public void PlayDtmfTone(char arg0)
        {
            IExecuteWithSignature("playDtmfTone", "(C)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/RemoteConference.html#registerCallback(android.telecom.RemoteConference.Callback,android.os.Handler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Telecom.RemoteConference.Callback"/></param>
        /// <param name="arg1"><see cref="Android.Os.Handler"/></param>
        public void RegisterCallback(Android.Telecom.RemoteConference.Callback arg0, Android.Os.Handler arg1)
        {
            IExecute("registerCallback", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/RemoteConference.html#registerCallback(android.telecom.RemoteConference.Callback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Telecom.RemoteConference.Callback"/></param>
        public void RegisterCallback(Android.Telecom.RemoteConference.Callback arg0)
        {
            IExecuteWithSignature("registerCallback", "(Landroid/telecom/RemoteConference$Callback;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/RemoteConference.html#separate(android.telecom.RemoteConnection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Telecom.RemoteConnection"/></param>
        public void Separate(Android.Telecom.RemoteConnection arg0)
        {
            IExecuteWithSignature("separate", "(Landroid/telecom/RemoteConnection;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/RemoteConference.html#setCallAudioState(android.telecom.CallAudioState)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Telecom.CallAudioState"/></param>
        public void SetCallAudioState(Android.Telecom.CallAudioState arg0)
        {
            IExecuteWithSignature("setCallAudioState", "(Landroid/telecom/CallAudioState;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/RemoteConference.html#stopDtmfTone()"/>
        /// </summary>
        public void StopDtmfTone()
        {
            IExecuteWithSignature("stopDtmfTone", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/RemoteConference.html#swap()"/>
        /// </summary>
        public void Swap()
        {
            IExecuteWithSignature("swap", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/RemoteConference.html#unhold()"/>
        /// </summary>
        public void Unhold()
        {
            IExecuteWithSignature("unhold", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/RemoteConference.html#unregisterCallback(android.telecom.RemoteConference.Callback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Telecom.RemoteConference.Callback"/></param>
        public void UnregisterCallback(Android.Telecom.RemoteConference.Callback arg0)
        {
            IExecuteWithSignature("unregisterCallback", "(Landroid/telecom/RemoteConference$Callback;)V", arg0);
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
            /// <see href="https://developer.android.com/reference/android/telecom/RemoteConference.Callback.html#onConferenceableConnectionsChanged(android.telecom.RemoteConference,java.util.List)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Telecom.RemoteConference"/></param>
            /// <param name="arg1"><see cref="Java.Util.List"/></param>
            public void OnConferenceableConnectionsChanged(Android.Telecom.RemoteConference arg0, Java.Util.List<Android.Telecom.RemoteConnection> arg1)
            {
                IExecute("onConferenceableConnectionsChanged", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telecom/RemoteConference.Callback.html#onConnectionAdded(android.telecom.RemoteConference,android.telecom.RemoteConnection)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Telecom.RemoteConference"/></param>
            /// <param name="arg1"><see cref="Android.Telecom.RemoteConnection"/></param>
            public void OnConnectionAdded(Android.Telecom.RemoteConference arg0, Android.Telecom.RemoteConnection arg1)
            {
                IExecute("onConnectionAdded", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telecom/RemoteConference.Callback.html#onConnectionCapabilitiesChanged(android.telecom.RemoteConference,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Telecom.RemoteConference"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            public void OnConnectionCapabilitiesChanged(Android.Telecom.RemoteConference arg0, int arg1)
            {
                IExecute("onConnectionCapabilitiesChanged", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telecom/RemoteConference.Callback.html#onConnectionPropertiesChanged(android.telecom.RemoteConference,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Telecom.RemoteConference"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            public void OnConnectionPropertiesChanged(Android.Telecom.RemoteConference arg0, int arg1)
            {
                IExecute("onConnectionPropertiesChanged", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telecom/RemoteConference.Callback.html#onConnectionRemoved(android.telecom.RemoteConference,android.telecom.RemoteConnection)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Telecom.RemoteConference"/></param>
            /// <param name="arg1"><see cref="Android.Telecom.RemoteConnection"/></param>
            public void OnConnectionRemoved(Android.Telecom.RemoteConference arg0, Android.Telecom.RemoteConnection arg1)
            {
                IExecute("onConnectionRemoved", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telecom/RemoteConference.Callback.html#onDestroyed(android.telecom.RemoteConference)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Telecom.RemoteConference"/></param>
            public void OnDestroyed(Android.Telecom.RemoteConference arg0)
            {
                IExecuteWithSignature("onDestroyed", "(Landroid/telecom/RemoteConference;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telecom/RemoteConference.Callback.html#onDisconnected(android.telecom.RemoteConference,android.telecom.DisconnectCause)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Telecom.RemoteConference"/></param>
            /// <param name="arg1"><see cref="Android.Telecom.DisconnectCause"/></param>
            public void OnDisconnected(Android.Telecom.RemoteConference arg0, Android.Telecom.DisconnectCause arg1)
            {
                IExecute("onDisconnected", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telecom/RemoteConference.Callback.html#onExtrasChanged(android.telecom.RemoteConference,android.os.Bundle)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Telecom.RemoteConference"/></param>
            /// <param name="arg1"><see cref="Android.Os.Bundle"/></param>
            public void OnExtrasChanged(Android.Telecom.RemoteConference arg0, Android.Os.Bundle arg1)
            {
                IExecute("onExtrasChanged", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telecom/RemoteConference.Callback.html#onStateChanged(android.telecom.RemoteConference,int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Telecom.RemoteConference"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            public void OnStateChanged(Android.Telecom.RemoteConference arg0, int arg1, int arg2)
            {
                IExecute("onStateChanged", arg0, arg1, arg2);
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