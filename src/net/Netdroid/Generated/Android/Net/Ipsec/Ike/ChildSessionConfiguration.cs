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

namespace Android.Net.Ipsec.Ike
{
    #region ChildSessionConfiguration
    public partial class ChildSessionConfiguration
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
        /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/ChildSessionConfiguration.html#getInboundTrafficSelectors()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Net.Ipsec.Ike.IkeTrafficSelector> GetInboundTrafficSelectors()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Net.Ipsec.Ike.IkeTrafficSelector>>("getInboundTrafficSelectors", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/ChildSessionConfiguration.html#getOutboundTrafficSelectors()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Net.Ipsec.Ike.IkeTrafficSelector> GetOutboundTrafficSelectors()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Net.Ipsec.Ike.IkeTrafficSelector>>("getOutboundTrafficSelectors", "()Ljava/util/List;");
        }

        #endregion

        #region Nested classes
        #region Builder
        public partial class Builder
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/ChildSessionConfiguration.Builder.html#%3Cinit%3E(java.util.List,java.util.List)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.List"/></param>
            /// <param name="arg1"><see cref="Java.Util.List"/></param>
            public Builder(Java.Util.List<Android.Net.Ipsec.Ike.IkeTrafficSelector> arg0, Java.Util.List<Android.Net.Ipsec.Ike.IkeTrafficSelector> arg1)
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
            /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/ChildSessionConfiguration.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Net.Ipsec.Ike.ChildSessionConfiguration"/></returns>
            public Android.Net.Ipsec.Ike.ChildSessionConfiguration Build()
            {
                return IExecuteWithSignature<Android.Net.Ipsec.Ike.ChildSessionConfiguration>("build", "()Landroid/net/ipsec/ike/ChildSessionConfiguration;");
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