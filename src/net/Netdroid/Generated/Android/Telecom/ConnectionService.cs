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
    #region ConnectionService
    public partial class ConnectionService
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/ConnectionService.html#SERVICE_INTERFACE"/>
        /// </summary>
        public static Java.Lang.String SERVICE_INTERFACE { get { if (!_SERVICE_INTERFACEReady) { _SERVICE_INTERFACEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SERVICE_INTERFACE"); _SERVICE_INTERFACEReady = true; } return _SERVICE_INTERFACEContent; } }
        private static Java.Lang.String _SERVICE_INTERFACEContent = default;
        private static bool _SERVICE_INTERFACEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/ConnectionService.html#onCreateIncomingConference(android.telecom.PhoneAccountHandle,android.telecom.ConnectionRequest)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Telecom.PhoneAccountHandle"/></param>
        /// <param name="arg1"><see cref="Android.Telecom.ConnectionRequest"/></param>
        /// <returns><see cref="Android.Telecom.Conference"/></returns>
        public Android.Telecom.Conference OnCreateIncomingConference(Android.Telecom.PhoneAccountHandle arg0, Android.Telecom.ConnectionRequest arg1)
        {
            return IExecute<Android.Telecom.Conference>("onCreateIncomingConference", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/ConnectionService.html#onCreateOutgoingConference(android.telecom.PhoneAccountHandle,android.telecom.ConnectionRequest)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Telecom.PhoneAccountHandle"/></param>
        /// <param name="arg1"><see cref="Android.Telecom.ConnectionRequest"/></param>
        /// <returns><see cref="Android.Telecom.Conference"/></returns>
        public Android.Telecom.Conference OnCreateOutgoingConference(Android.Telecom.PhoneAccountHandle arg0, Android.Telecom.ConnectionRequest arg1)
        {
            return IExecute<Android.Telecom.Conference>("onCreateOutgoingConference", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/ConnectionService.html#onCreateIncomingConnection(android.telecom.PhoneAccountHandle,android.telecom.ConnectionRequest)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Telecom.PhoneAccountHandle"/></param>
        /// <param name="arg1"><see cref="Android.Telecom.ConnectionRequest"/></param>
        /// <returns><see cref="Android.Telecom.Connection"/></returns>
        public Android.Telecom.Connection OnCreateIncomingConnection(Android.Telecom.PhoneAccountHandle arg0, Android.Telecom.ConnectionRequest arg1)
        {
            return IExecute<Android.Telecom.Connection>("onCreateIncomingConnection", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/ConnectionService.html#onCreateIncomingHandoverConnection(android.telecom.PhoneAccountHandle,android.telecom.ConnectionRequest)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Telecom.PhoneAccountHandle"/></param>
        /// <param name="arg1"><see cref="Android.Telecom.ConnectionRequest"/></param>
        /// <returns><see cref="Android.Telecom.Connection"/></returns>
        public Android.Telecom.Connection OnCreateIncomingHandoverConnection(Android.Telecom.PhoneAccountHandle arg0, Android.Telecom.ConnectionRequest arg1)
        {
            return IExecute<Android.Telecom.Connection>("onCreateIncomingHandoverConnection", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/ConnectionService.html#onCreateOutgoingConnection(android.telecom.PhoneAccountHandle,android.telecom.ConnectionRequest)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Telecom.PhoneAccountHandle"/></param>
        /// <param name="arg1"><see cref="Android.Telecom.ConnectionRequest"/></param>
        /// <returns><see cref="Android.Telecom.Connection"/></returns>
        public Android.Telecom.Connection OnCreateOutgoingConnection(Android.Telecom.PhoneAccountHandle arg0, Android.Telecom.ConnectionRequest arg1)
        {
            return IExecute<Android.Telecom.Connection>("onCreateOutgoingConnection", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/ConnectionService.html#onCreateOutgoingHandoverConnection(android.telecom.PhoneAccountHandle,android.telecom.ConnectionRequest)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Telecom.PhoneAccountHandle"/></param>
        /// <param name="arg1"><see cref="Android.Telecom.ConnectionRequest"/></param>
        /// <returns><see cref="Android.Telecom.Connection"/></returns>
        public Android.Telecom.Connection OnCreateOutgoingHandoverConnection(Android.Telecom.PhoneAccountHandle arg0, Android.Telecom.ConnectionRequest arg1)
        {
            return IExecute<Android.Telecom.Connection>("onCreateOutgoingHandoverConnection", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/ConnectionService.html#createRemoteIncomingConference(android.telecom.PhoneAccountHandle,android.telecom.ConnectionRequest)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Telecom.PhoneAccountHandle"/></param>
        /// <param name="arg1"><see cref="Android.Telecom.ConnectionRequest"/></param>
        /// <returns><see cref="Android.Telecom.RemoteConference"/></returns>
        public Android.Telecom.RemoteConference CreateRemoteIncomingConference(Android.Telecom.PhoneAccountHandle arg0, Android.Telecom.ConnectionRequest arg1)
        {
            return IExecute<Android.Telecom.RemoteConference>("createRemoteIncomingConference", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/ConnectionService.html#createRemoteOutgoingConference(android.telecom.PhoneAccountHandle,android.telecom.ConnectionRequest)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Telecom.PhoneAccountHandle"/></param>
        /// <param name="arg1"><see cref="Android.Telecom.ConnectionRequest"/></param>
        /// <returns><see cref="Android.Telecom.RemoteConference"/></returns>
        public Android.Telecom.RemoteConference CreateRemoteOutgoingConference(Android.Telecom.PhoneAccountHandle arg0, Android.Telecom.ConnectionRequest arg1)
        {
            return IExecute<Android.Telecom.RemoteConference>("createRemoteOutgoingConference", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/ConnectionService.html#createRemoteIncomingConnection(android.telecom.PhoneAccountHandle,android.telecom.ConnectionRequest)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Telecom.PhoneAccountHandle"/></param>
        /// <param name="arg1"><see cref="Android.Telecom.ConnectionRequest"/></param>
        /// <returns><see cref="Android.Telecom.RemoteConnection"/></returns>
        public Android.Telecom.RemoteConnection CreateRemoteIncomingConnection(Android.Telecom.PhoneAccountHandle arg0, Android.Telecom.ConnectionRequest arg1)
        {
            return IExecute<Android.Telecom.RemoteConnection>("createRemoteIncomingConnection", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/ConnectionService.html#createRemoteOutgoingConnection(android.telecom.PhoneAccountHandle,android.telecom.ConnectionRequest)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Telecom.PhoneAccountHandle"/></param>
        /// <param name="arg1"><see cref="Android.Telecom.ConnectionRequest"/></param>
        /// <returns><see cref="Android.Telecom.RemoteConnection"/></returns>
        public Android.Telecom.RemoteConnection CreateRemoteOutgoingConnection(Android.Telecom.PhoneAccountHandle arg0, Android.Telecom.ConnectionRequest arg1)
        {
            return IExecute<Android.Telecom.RemoteConnection>("createRemoteOutgoingConnection", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/ConnectionService.html#getAllConferences()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Collection"/></returns>
        public Java.Util.Collection<Android.Telecom.Conference> GetAllConferences()
        {
            return IExecuteWithSignature<Java.Util.Collection<Android.Telecom.Conference>>("getAllConferences", "()Ljava/util/Collection;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/ConnectionService.html#getAllConnections()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Collection"/></returns>
        public Java.Util.Collection<Android.Telecom.Connection> GetAllConnections()
        {
            return IExecuteWithSignature<Java.Util.Collection<Android.Telecom.Connection>>("getAllConnections", "()Ljava/util/Collection;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/ConnectionService.html#addConference(android.telecom.Conference)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Telecom.Conference"/></param>
        public void AddConference(Android.Telecom.Conference arg0)
        {
            IExecuteWithSignature("addConference", "(Landroid/telecom/Conference;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/ConnectionService.html#addExistingConnection(android.telecom.PhoneAccountHandle,android.telecom.Connection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Telecom.PhoneAccountHandle"/></param>
        /// <param name="arg1"><see cref="Android.Telecom.Connection"/></param>
        public void AddExistingConnection(Android.Telecom.PhoneAccountHandle arg0, Android.Telecom.Connection arg1)
        {
            IExecute("addExistingConnection", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/ConnectionService.html#conferenceRemoteConnections(android.telecom.RemoteConnection,android.telecom.RemoteConnection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Telecom.RemoteConnection"/></param>
        /// <param name="arg1"><see cref="Android.Telecom.RemoteConnection"/></param>
        public void ConferenceRemoteConnections(Android.Telecom.RemoteConnection arg0, Android.Telecom.RemoteConnection arg1)
        {
            IExecute("conferenceRemoteConnections", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/ConnectionService.html#connectionServiceFocusReleased()"/>
        /// </summary>
        public void ConnectionServiceFocusReleased()
        {
            IExecuteWithSignature("connectionServiceFocusReleased", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/ConnectionService.html#onConference(android.telecom.Connection,android.telecom.Connection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Telecom.Connection"/></param>
        /// <param name="arg1"><see cref="Android.Telecom.Connection"/></param>
        public void OnConference(Android.Telecom.Connection arg0, Android.Telecom.Connection arg1)
        {
            IExecute("onConference", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/ConnectionService.html#onConnectionServiceFocusGained()"/>
        /// </summary>
        public void OnConnectionServiceFocusGained()
        {
            IExecuteWithSignature("onConnectionServiceFocusGained", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/ConnectionService.html#onConnectionServiceFocusLost()"/>
        /// </summary>
        public void OnConnectionServiceFocusLost()
        {
            IExecuteWithSignature("onConnectionServiceFocusLost", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/ConnectionService.html#onCreateIncomingConferenceFailed(android.telecom.PhoneAccountHandle,android.telecom.ConnectionRequest)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Telecom.PhoneAccountHandle"/></param>
        /// <param name="arg1"><see cref="Android.Telecom.ConnectionRequest"/></param>
        public void OnCreateIncomingConferenceFailed(Android.Telecom.PhoneAccountHandle arg0, Android.Telecom.ConnectionRequest arg1)
        {
            IExecute("onCreateIncomingConferenceFailed", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/ConnectionService.html#onCreateIncomingConnectionFailed(android.telecom.PhoneAccountHandle,android.telecom.ConnectionRequest)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Telecom.PhoneAccountHandle"/></param>
        /// <param name="arg1"><see cref="Android.Telecom.ConnectionRequest"/></param>
        public void OnCreateIncomingConnectionFailed(Android.Telecom.PhoneAccountHandle arg0, Android.Telecom.ConnectionRequest arg1)
        {
            IExecute("onCreateIncomingConnectionFailed", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/ConnectionService.html#onCreateOutgoingConferenceFailed(android.telecom.PhoneAccountHandle,android.telecom.ConnectionRequest)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Telecom.PhoneAccountHandle"/></param>
        /// <param name="arg1"><see cref="Android.Telecom.ConnectionRequest"/></param>
        public void OnCreateOutgoingConferenceFailed(Android.Telecom.PhoneAccountHandle arg0, Android.Telecom.ConnectionRequest arg1)
        {
            IExecute("onCreateOutgoingConferenceFailed", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/ConnectionService.html#onCreateOutgoingConnectionFailed(android.telecom.PhoneAccountHandle,android.telecom.ConnectionRequest)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Telecom.PhoneAccountHandle"/></param>
        /// <param name="arg1"><see cref="Android.Telecom.ConnectionRequest"/></param>
        public void OnCreateOutgoingConnectionFailed(Android.Telecom.PhoneAccountHandle arg0, Android.Telecom.ConnectionRequest arg1)
        {
            IExecute("onCreateOutgoingConnectionFailed", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/ConnectionService.html#onHandoverFailed(android.telecom.ConnectionRequest,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Telecom.ConnectionRequest"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void OnHandoverFailed(Android.Telecom.ConnectionRequest arg0, int arg1)
        {
            IExecute("onHandoverFailed", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/ConnectionService.html#onRemoteConferenceAdded(android.telecom.RemoteConference)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Telecom.RemoteConference"/></param>
        public void OnRemoteConferenceAdded(Android.Telecom.RemoteConference arg0)
        {
            IExecuteWithSignature("onRemoteConferenceAdded", "(Landroid/telecom/RemoteConference;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/ConnectionService.html#onRemoteExistingConnectionAdded(android.telecom.RemoteConnection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Telecom.RemoteConnection"/></param>
        public void OnRemoteExistingConnectionAdded(Android.Telecom.RemoteConnection arg0)
        {
            IExecuteWithSignature("onRemoteExistingConnectionAdded", "(Landroid/telecom/RemoteConnection;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}