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

namespace Android.Telephony
{
    #region MbmsStreamingSession
    public partial class MbmsStreamingSession
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/MbmsStreamingSession.html#create(android.content.Context,java.util.concurrent.Executor,android.telephony.mbms.MbmsStreamingSessionCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg2"><see cref="Android.Telephony.Mbms.MbmsStreamingSessionCallback"/></param>
        /// <returns><see cref="Android.Telephony.MbmsStreamingSession"/></returns>
        public static Android.Telephony.MbmsStreamingSession Create(Android.Content.Context arg0, Java.Util.Concurrent.Executor arg1, Android.Telephony.Mbms.MbmsStreamingSessionCallback arg2)
        {
            return SExecute<Android.Telephony.MbmsStreamingSession>(LocalBridgeClazz, "create", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/MbmsStreamingSession.html#create(android.content.Context,java.util.concurrent.Executor,int,android.telephony.mbms.MbmsStreamingSessionCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Android.Telephony.Mbms.MbmsStreamingSessionCallback"/></param>
        /// <returns><see cref="Android.Telephony.MbmsStreamingSession"/></returns>
        public static Android.Telephony.MbmsStreamingSession Create(Android.Content.Context arg0, Java.Util.Concurrent.Executor arg1, int arg2, Android.Telephony.Mbms.MbmsStreamingSessionCallback arg3)
        {
            return SExecute<Android.Telephony.MbmsStreamingSession>(LocalBridgeClazz, "create", arg0, arg1, arg2, arg3);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/MbmsStreamingSession.html#startStreaming(android.telephony.mbms.StreamingServiceInfo,java.util.concurrent.Executor,android.telephony.mbms.StreamingServiceCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Telephony.Mbms.StreamingServiceInfo"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg2"><see cref="Android.Telephony.Mbms.StreamingServiceCallback"/></param>
        /// <returns><see cref="Android.Telephony.Mbms.StreamingService"/></returns>
        public Android.Telephony.Mbms.StreamingService StartStreaming(Android.Telephony.Mbms.StreamingServiceInfo arg0, Java.Util.Concurrent.Executor arg1, Android.Telephony.Mbms.StreamingServiceCallback arg2)
        {
            return IExecute<Android.Telephony.Mbms.StreamingService>("startStreaming", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/MbmsStreamingSession.html#close()"/>
        /// </summary>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/MbmsStreamingSession.html#requestUpdateStreamingServices(java.util.List)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        public void RequestUpdateStreamingServices(Java.Util.List<Java.Lang.String> arg0)
        {
            IExecuteWithSignature("requestUpdateStreamingServices", "(Ljava/util/List;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}