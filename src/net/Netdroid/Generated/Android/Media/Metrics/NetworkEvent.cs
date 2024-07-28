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

namespace Android.Media.Metrics
{
    #region NetworkEvent
    public partial class NetworkEvent
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Android.Media.Metrics.NetworkEvent"/> to <see cref="Android.Os.Parcelable"/>
        /// </summary>
        public static implicit operator Android.Os.Parcelable(Android.Media.Metrics.NetworkEvent t) => t.Cast<Android.Os.Parcelable>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/NetworkEvent.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/NetworkEvent.html#NETWORK_TYPE_2G"/>
        /// </summary>
        public static int NETWORK_TYPE_2G { get { if (!_NETWORK_TYPE_2GReady) { _NETWORK_TYPE_2GContent = SGetField<int>(LocalBridgeClazz, "NETWORK_TYPE_2G"); _NETWORK_TYPE_2GReady = true; } return _NETWORK_TYPE_2GContent; } }
        private static int _NETWORK_TYPE_2GContent = default;
        private static bool _NETWORK_TYPE_2GReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/NetworkEvent.html#NETWORK_TYPE_3G"/>
        /// </summary>
        public static int NETWORK_TYPE_3G { get { if (!_NETWORK_TYPE_3GReady) { _NETWORK_TYPE_3GContent = SGetField<int>(LocalBridgeClazz, "NETWORK_TYPE_3G"); _NETWORK_TYPE_3GReady = true; } return _NETWORK_TYPE_3GContent; } }
        private static int _NETWORK_TYPE_3GContent = default;
        private static bool _NETWORK_TYPE_3GReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/NetworkEvent.html#NETWORK_TYPE_4G"/>
        /// </summary>
        public static int NETWORK_TYPE_4G { get { if (!_NETWORK_TYPE_4GReady) { _NETWORK_TYPE_4GContent = SGetField<int>(LocalBridgeClazz, "NETWORK_TYPE_4G"); _NETWORK_TYPE_4GReady = true; } return _NETWORK_TYPE_4GContent; } }
        private static int _NETWORK_TYPE_4GContent = default;
        private static bool _NETWORK_TYPE_4GReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/NetworkEvent.html#NETWORK_TYPE_5G_NSA"/>
        /// </summary>
        public static int NETWORK_TYPE_5G_NSA { get { if (!_NETWORK_TYPE_5G_NSAReady) { _NETWORK_TYPE_5G_NSAContent = SGetField<int>(LocalBridgeClazz, "NETWORK_TYPE_5G_NSA"); _NETWORK_TYPE_5G_NSAReady = true; } return _NETWORK_TYPE_5G_NSAContent; } }
        private static int _NETWORK_TYPE_5G_NSAContent = default;
        private static bool _NETWORK_TYPE_5G_NSAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/NetworkEvent.html#NETWORK_TYPE_5G_SA"/>
        /// </summary>
        public static int NETWORK_TYPE_5G_SA { get { if (!_NETWORK_TYPE_5G_SAReady) { _NETWORK_TYPE_5G_SAContent = SGetField<int>(LocalBridgeClazz, "NETWORK_TYPE_5G_SA"); _NETWORK_TYPE_5G_SAReady = true; } return _NETWORK_TYPE_5G_SAContent; } }
        private static int _NETWORK_TYPE_5G_SAContent = default;
        private static bool _NETWORK_TYPE_5G_SAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/NetworkEvent.html#NETWORK_TYPE_ETHERNET"/>
        /// </summary>
        public static int NETWORK_TYPE_ETHERNET { get { if (!_NETWORK_TYPE_ETHERNETReady) { _NETWORK_TYPE_ETHERNETContent = SGetField<int>(LocalBridgeClazz, "NETWORK_TYPE_ETHERNET"); _NETWORK_TYPE_ETHERNETReady = true; } return _NETWORK_TYPE_ETHERNETContent; } }
        private static int _NETWORK_TYPE_ETHERNETContent = default;
        private static bool _NETWORK_TYPE_ETHERNETReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/NetworkEvent.html#NETWORK_TYPE_OFFLINE"/>
        /// </summary>
        public static int NETWORK_TYPE_OFFLINE { get { if (!_NETWORK_TYPE_OFFLINEReady) { _NETWORK_TYPE_OFFLINEContent = SGetField<int>(LocalBridgeClazz, "NETWORK_TYPE_OFFLINE"); _NETWORK_TYPE_OFFLINEReady = true; } return _NETWORK_TYPE_OFFLINEContent; } }
        private static int _NETWORK_TYPE_OFFLINEContent = default;
        private static bool _NETWORK_TYPE_OFFLINEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/NetworkEvent.html#NETWORK_TYPE_OTHER"/>
        /// </summary>
        public static int NETWORK_TYPE_OTHER { get { if (!_NETWORK_TYPE_OTHERReady) { _NETWORK_TYPE_OTHERContent = SGetField<int>(LocalBridgeClazz, "NETWORK_TYPE_OTHER"); _NETWORK_TYPE_OTHERReady = true; } return _NETWORK_TYPE_OTHERContent; } }
        private static int _NETWORK_TYPE_OTHERContent = default;
        private static bool _NETWORK_TYPE_OTHERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/NetworkEvent.html#NETWORK_TYPE_UNKNOWN"/>
        /// </summary>
        public static int NETWORK_TYPE_UNKNOWN { get { if (!_NETWORK_TYPE_UNKNOWNReady) { _NETWORK_TYPE_UNKNOWNContent = SGetField<int>(LocalBridgeClazz, "NETWORK_TYPE_UNKNOWN"); _NETWORK_TYPE_UNKNOWNReady = true; } return _NETWORK_TYPE_UNKNOWNContent; } }
        private static int _NETWORK_TYPE_UNKNOWNContent = default;
        private static bool _NETWORK_TYPE_UNKNOWNReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/NetworkEvent.html#NETWORK_TYPE_WIFI"/>
        /// </summary>
        public static int NETWORK_TYPE_WIFI { get { if (!_NETWORK_TYPE_WIFIReady) { _NETWORK_TYPE_WIFIContent = SGetField<int>(LocalBridgeClazz, "NETWORK_TYPE_WIFI"); _NETWORK_TYPE_WIFIReady = true; } return _NETWORK_TYPE_WIFIContent; } }
        private static int _NETWORK_TYPE_WIFIContent = default;
        private static bool _NETWORK_TYPE_WIFIReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/NetworkEvent.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/NetworkEvent.html#getNetworkType()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetNetworkType()
        {
            return IExecuteWithSignature<int>("getNetworkType", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/NetworkEvent.html#writeToParcel(android.os.Parcel,int)"/>
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

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/metrics/NetworkEvent.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Media.Metrics.NetworkEvent"/></returns>
            public Android.Media.Metrics.NetworkEvent Build()
            {
                return IExecuteWithSignature<Android.Media.Metrics.NetworkEvent>("build", "()Landroid/media/metrics/NetworkEvent;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/metrics/NetworkEvent.Builder.html#setMetricsBundle(android.os.Bundle)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
            /// <returns><see cref="Android.Media.Metrics.NetworkEvent.Builder"/></returns>
            public Android.Media.Metrics.NetworkEvent.Builder SetMetricsBundle(Android.Os.Bundle arg0)
            {
                return IExecuteWithSignature<Android.Media.Metrics.NetworkEvent.Builder>("setMetricsBundle", "(Landroid/os/Bundle;)Landroid/media/metrics/NetworkEvent$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/metrics/NetworkEvent.Builder.html#setNetworkType(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Media.Metrics.NetworkEvent.Builder"/></returns>
            public Android.Media.Metrics.NetworkEvent.Builder SetNetworkType(int arg0)
            {
                return IExecuteWithSignature<Android.Media.Metrics.NetworkEvent.Builder>("setNetworkType", "(I)Landroid/media/metrics/NetworkEvent$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/metrics/NetworkEvent.Builder.html#setTimeSinceCreatedMillis(long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="long"/></param>
            /// <returns><see cref="Android.Media.Metrics.NetworkEvent.Builder"/></returns>
            public Android.Media.Metrics.NetworkEvent.Builder SetTimeSinceCreatedMillis(long arg0)
            {
                return IExecuteWithSignature<Android.Media.Metrics.NetworkEvent.Builder>("setTimeSinceCreatedMillis", "(J)Landroid/media/metrics/NetworkEvent$Builder;", arg0);
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