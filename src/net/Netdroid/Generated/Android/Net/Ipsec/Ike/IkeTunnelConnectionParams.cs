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

namespace Android.Net.Ipsec.Ike
{
    #region IkeTunnelConnectionParams
    public partial class IkeTunnelConnectionParams
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeTunnelConnectionParams.html#%3Cinit%3E(android.net.ipsec.ike.IkeSessionParams,android.net.ipsec.ike.TunnelModeChildSessionParams)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Ipsec.Ike.IkeSessionParams"/></param>
        /// <param name="arg1"><see cref="Android.Net.Ipsec.Ike.TunnelModeChildSessionParams"/></param>
        public IkeTunnelConnectionParams(Android.Net.Ipsec.Ike.IkeSessionParams arg0, Android.Net.Ipsec.Ike.TunnelModeChildSessionParams arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeTunnelConnectionParams.html#getIkeSessionParams()"/>
        /// </summary>
        /// <returns><see cref="Android.Net.Ipsec.Ike.IkeSessionParams"/></returns>
        public Android.Net.Ipsec.Ike.IkeSessionParams GetIkeSessionParams()
        {
            return IExecuteWithSignature<Android.Net.Ipsec.Ike.IkeSessionParams>("getIkeSessionParams", "()Landroid/net/ipsec/ike/IkeSessionParams;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeTunnelConnectionParams.html#getTunnelModeChildSessionParams()"/>
        /// </summary>
        /// <returns><see cref="Android.Net.Ipsec.Ike.TunnelModeChildSessionParams"/></returns>
        public Android.Net.Ipsec.Ike.TunnelModeChildSessionParams GetTunnelModeChildSessionParams()
        {
            return IExecuteWithSignature<Android.Net.Ipsec.Ike.TunnelModeChildSessionParams>("getTunnelModeChildSessionParams", "()Landroid/net/ipsec/ike/TunnelModeChildSessionParams;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}