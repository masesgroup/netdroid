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

namespace Android.Net.Vcn
{
    #region VcnUnderlyingNetworkTemplate
    public partial class VcnUnderlyingNetworkTemplate
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/vcn/VcnUnderlyingNetworkTemplate.html#MATCH_ANY"/>
        /// </summary>
        public static int MATCH_ANY { get { if (!_MATCH_ANYReady) { _MATCH_ANYContent = SGetField<int>(LocalBridgeClazz, "MATCH_ANY"); _MATCH_ANYReady = true; } return _MATCH_ANYContent; } }
        private static int _MATCH_ANYContent = default;
        private static bool _MATCH_ANYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/vcn/VcnUnderlyingNetworkTemplate.html#MATCH_FORBIDDEN"/>
        /// </summary>
        public static int MATCH_FORBIDDEN { get { if (!_MATCH_FORBIDDENReady) { _MATCH_FORBIDDENContent = SGetField<int>(LocalBridgeClazz, "MATCH_FORBIDDEN"); _MATCH_FORBIDDENReady = true; } return _MATCH_FORBIDDENContent; } }
        private static int _MATCH_FORBIDDENContent = default;
        private static bool _MATCH_FORBIDDENReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/vcn/VcnUnderlyingNetworkTemplate.html#MATCH_REQUIRED"/>
        /// </summary>
        public static int MATCH_REQUIRED { get { if (!_MATCH_REQUIREDReady) { _MATCH_REQUIREDContent = SGetField<int>(LocalBridgeClazz, "MATCH_REQUIRED"); _MATCH_REQUIREDReady = true; } return _MATCH_REQUIREDContent; } }
        private static int _MATCH_REQUIREDContent = default;
        private static bool _MATCH_REQUIREDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/vcn/VcnUnderlyingNetworkTemplate.html#getMetered()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetMetered()
        {
            return IExecuteWithSignature<int>("getMetered", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/vcn/VcnUnderlyingNetworkTemplate.html#getMinEntryDownstreamBandwidthKbps()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetMinEntryDownstreamBandwidthKbps()
        {
            return IExecuteWithSignature<int>("getMinEntryDownstreamBandwidthKbps", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/vcn/VcnUnderlyingNetworkTemplate.html#getMinEntryUpstreamBandwidthKbps()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetMinEntryUpstreamBandwidthKbps()
        {
            return IExecuteWithSignature<int>("getMinEntryUpstreamBandwidthKbps", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/vcn/VcnUnderlyingNetworkTemplate.html#getMinExitDownstreamBandwidthKbps()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetMinExitDownstreamBandwidthKbps()
        {
            return IExecuteWithSignature<int>("getMinExitDownstreamBandwidthKbps", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/vcn/VcnUnderlyingNetworkTemplate.html#getMinExitUpstreamBandwidthKbps()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetMinExitUpstreamBandwidthKbps()
        {
            return IExecuteWithSignature<int>("getMinExitUpstreamBandwidthKbps", "()I");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}