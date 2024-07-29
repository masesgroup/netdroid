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
*  This file is generated by MASES.JNetReflector (ver. 2.5.6.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Net.Ipsec.Ike
{
    #region ChildSessionParams
    public partial class ChildSessionParams
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
        /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/ChildSessionParams.html#getHardLifetimeSeconds()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetHardLifetimeSeconds()
        {
            return IExecuteWithSignature<int>("getHardLifetimeSeconds", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/ChildSessionParams.html#getSoftLifetimeSeconds()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetSoftLifetimeSeconds()
        {
            return IExecuteWithSignature<int>("getSoftLifetimeSeconds", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/ChildSessionParams.html#getChildSaProposals()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Net.Ipsec.Ike.ChildSaProposal> GetChildSaProposals()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Net.Ipsec.Ike.ChildSaProposal>>("getChildSaProposals", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/ChildSessionParams.html#getInboundTrafficSelectors()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Net.Ipsec.Ike.IkeTrafficSelector> GetInboundTrafficSelectors()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Net.Ipsec.Ike.IkeTrafficSelector>>("getInboundTrafficSelectors", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/ChildSessionParams.html#getOutboundTrafficSelectors()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Net.Ipsec.Ike.IkeTrafficSelector> GetOutboundTrafficSelectors()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Net.Ipsec.Ike.IkeTrafficSelector>>("getOutboundTrafficSelectors", "()Ljava/util/List;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}