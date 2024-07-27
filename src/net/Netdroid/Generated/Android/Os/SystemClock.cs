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
*  This file is generated by MASES.JNetReflector (ver. 2.5.4.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Os
{
    #region SystemClock
    public partial class SystemClock
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/SystemClock.html#setCurrentTimeMillis(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool SetCurrentTimeMillis(long arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "setCurrentTimeMillis", "(J)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/SystemClock.html#currentGnssTimeClock()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Clock"/></returns>
        public static Java.Time.Clock CurrentGnssTimeClock()
        {
            return SExecuteWithSignature<Java.Time.Clock>(LocalBridgeClazz, "currentGnssTimeClock", "()Ljava/time/Clock;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/SystemClock.html#currentNetworkTimeClock()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Clock"/></returns>
        public static Java.Time.Clock CurrentNetworkTimeClock()
        {
            return SExecuteWithSignature<Java.Time.Clock>(LocalBridgeClazz, "currentNetworkTimeClock", "()Ljava/time/Clock;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/SystemClock.html#currentThreadTimeMillis()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public static long CurrentThreadTimeMillis()
        {
            return SExecuteWithSignature<long>(LocalBridgeClazz, "currentThreadTimeMillis", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/SystemClock.html#elapsedRealtime()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public static long ElapsedRealtime()
        {
            return SExecuteWithSignature<long>(LocalBridgeClazz, "elapsedRealtime", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/SystemClock.html#elapsedRealtimeNanos()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public static long ElapsedRealtimeNanos()
        {
            return SExecuteWithSignature<long>(LocalBridgeClazz, "elapsedRealtimeNanos", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/SystemClock.html#uptimeMillis()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public static long UptimeMillis()
        {
            return SExecuteWithSignature<long>(LocalBridgeClazz, "uptimeMillis", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/SystemClock.html#uptimeNanos()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public static long UptimeNanos()
        {
            return SExecuteWithSignature<long>(LocalBridgeClazz, "uptimeNanos", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/SystemClock.html#sleep(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public static void Sleep(long arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "sleep", "(J)V", arg0);
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}