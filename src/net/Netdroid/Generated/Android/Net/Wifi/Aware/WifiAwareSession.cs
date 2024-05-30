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

namespace Android.Net.Wifi.Aware
{
    #region WifiAwareSession
    public partial class WifiAwareSession
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
        /// <see href="https://developer.android.com/reference/android/net/wifi/aware/WifiAwareSession.html#close()"/>
        /// </summary>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/aware/WifiAwareSession.html#publish(android.net.wifi.aware.PublishConfig,android.net.wifi.aware.DiscoverySessionCallback,android.os.Handler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Wifi.Aware.PublishConfig"/></param>
        /// <param name="arg1"><see cref="Android.Net.Wifi.Aware.DiscoverySessionCallback"/></param>
        /// <param name="arg2"><see cref="Android.Os.Handler"/></param>
        public void Publish(Android.Net.Wifi.Aware.PublishConfig arg0, Android.Net.Wifi.Aware.DiscoverySessionCallback arg1, Android.Os.Handler arg2)
        {
            IExecute("publish", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/aware/WifiAwareSession.html#subscribe(android.net.wifi.aware.SubscribeConfig,android.net.wifi.aware.DiscoverySessionCallback,android.os.Handler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Wifi.Aware.SubscribeConfig"/></param>
        /// <param name="arg1"><see cref="Android.Net.Wifi.Aware.DiscoverySessionCallback"/></param>
        /// <param name="arg2"><see cref="Android.Os.Handler"/></param>
        public void Subscribe(Android.Net.Wifi.Aware.SubscribeConfig arg0, Android.Net.Wifi.Aware.DiscoverySessionCallback arg1, Android.Os.Handler arg2)
        {
            IExecute("subscribe", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}