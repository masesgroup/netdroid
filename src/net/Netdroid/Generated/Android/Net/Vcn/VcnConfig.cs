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
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Net.Vcn
{
    #region VcnConfig
    public partial class VcnConfig
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/vcn/VcnConfig.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/vcn/VcnConfig.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/vcn/VcnConfig.html#getGatewayConnectionConfigs()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Android.Net.Vcn.VcnGatewayConnectionConfig> GetGatewayConnectionConfigs()
        {
            return IExecuteWithSignature<Java.Util.Set<Android.Net.Vcn.VcnGatewayConnectionConfig>>("getGatewayConnectionConfigs", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/vcn/VcnConfig.html#getRestrictedUnderlyingNetworkTransports()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Java.Lang.Integer> GetRestrictedUnderlyingNetworkTransports()
        {
            return IExecuteWithSignature<Java.Util.Set<Java.Lang.Integer>>("getRestrictedUnderlyingNetworkTransports", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/vcn/VcnConfig.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecute("writeToParcel", arg0, arg1);
        }

        #endregion

        #region Nested classes
        #region Builder
        public partial class Builder
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/vcn/VcnConfig.Builder.html#%3Cinit%3E(android.content.Context)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Content.Context"/></param>
            public Builder(Android.Content.Context arg0)
                : base(arg0)
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
            /// <see href="https://developer.android.com/reference/android/net/vcn/VcnConfig.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Net.Vcn.VcnConfig"/></returns>
            public Android.Net.Vcn.VcnConfig Build()
            {
                return IExecuteWithSignature<Android.Net.Vcn.VcnConfig>("build", "()Landroid/net/vcn/VcnConfig;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/vcn/VcnConfig.Builder.html#addGatewayConnectionConfig(android.net.vcn.VcnGatewayConnectionConfig)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.Vcn.VcnGatewayConnectionConfig"/></param>
            /// <returns><see cref="Android.Net.Vcn.VcnConfig.Builder"/></returns>
            public Android.Net.Vcn.VcnConfig.Builder AddGatewayConnectionConfig(Android.Net.Vcn.VcnGatewayConnectionConfig arg0)
            {
                return IExecuteWithSignature<Android.Net.Vcn.VcnConfig.Builder>("addGatewayConnectionConfig", "(Landroid/net/vcn/VcnGatewayConnectionConfig;)Landroid/net/vcn/VcnConfig$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/vcn/VcnConfig.Builder.html#setRestrictedUnderlyingNetworkTransports(java.util.Set)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Set"/></param>
            /// <returns><see cref="Android.Net.Vcn.VcnConfig.Builder"/></returns>
            public Android.Net.Vcn.VcnConfig.Builder SetRestrictedUnderlyingNetworkTransports(Java.Util.Set<Java.Lang.Integer> arg0)
            {
                return IExecuteWithSignature<Android.Net.Vcn.VcnConfig.Builder>("setRestrictedUnderlyingNetworkTransports", "(Ljava/util/Set;)Landroid/net/vcn/VcnConfig$Builder;", arg0);
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