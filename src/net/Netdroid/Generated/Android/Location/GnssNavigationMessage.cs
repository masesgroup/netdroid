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

namespace Android.Location
{
    #region GnssNavigationMessage
    public partial class GnssNavigationMessage
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssNavigationMessage.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssNavigationMessage.html#STATUS_PARITY_PASSED"/>
        /// </summary>
        public static int STATUS_PARITY_PASSED { get { if (!_STATUS_PARITY_PASSEDReady) { _STATUS_PARITY_PASSEDContent = SGetField<int>(LocalBridgeClazz, "STATUS_PARITY_PASSED"); _STATUS_PARITY_PASSEDReady = true; } return _STATUS_PARITY_PASSEDContent; } }
        private static int _STATUS_PARITY_PASSEDContent = default;
        private static bool _STATUS_PARITY_PASSEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssNavigationMessage.html#STATUS_PARITY_REBUILT"/>
        /// </summary>
        public static int STATUS_PARITY_REBUILT { get { if (!_STATUS_PARITY_REBUILTReady) { _STATUS_PARITY_REBUILTContent = SGetField<int>(LocalBridgeClazz, "STATUS_PARITY_REBUILT"); _STATUS_PARITY_REBUILTReady = true; } return _STATUS_PARITY_REBUILTContent; } }
        private static int _STATUS_PARITY_REBUILTContent = default;
        private static bool _STATUS_PARITY_REBUILTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssNavigationMessage.html#STATUS_UNKNOWN"/>
        /// </summary>
        public static int STATUS_UNKNOWN { get { if (!_STATUS_UNKNOWNReady) { _STATUS_UNKNOWNContent = SGetField<int>(LocalBridgeClazz, "STATUS_UNKNOWN"); _STATUS_UNKNOWNReady = true; } return _STATUS_UNKNOWNContent; } }
        private static int _STATUS_UNKNOWNContent = default;
        private static bool _STATUS_UNKNOWNReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssNavigationMessage.html#TYPE_BDS_CNAV1"/>
        /// </summary>
        public static int TYPE_BDS_CNAV1 { get { if (!_TYPE_BDS_CNAV1Ready) { _TYPE_BDS_CNAV1Content = SGetField<int>(LocalBridgeClazz, "TYPE_BDS_CNAV1"); _TYPE_BDS_CNAV1Ready = true; } return _TYPE_BDS_CNAV1Content; } }
        private static int _TYPE_BDS_CNAV1Content = default;
        private static bool _TYPE_BDS_CNAV1Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssNavigationMessage.html#TYPE_BDS_CNAV2"/>
        /// </summary>
        public static int TYPE_BDS_CNAV2 { get { if (!_TYPE_BDS_CNAV2Ready) { _TYPE_BDS_CNAV2Content = SGetField<int>(LocalBridgeClazz, "TYPE_BDS_CNAV2"); _TYPE_BDS_CNAV2Ready = true; } return _TYPE_BDS_CNAV2Content; } }
        private static int _TYPE_BDS_CNAV2Content = default;
        private static bool _TYPE_BDS_CNAV2Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssNavigationMessage.html#TYPE_BDS_D1"/>
        /// </summary>
        public static int TYPE_BDS_D1 { get { if (!_TYPE_BDS_D1Ready) { _TYPE_BDS_D1Content = SGetField<int>(LocalBridgeClazz, "TYPE_BDS_D1"); _TYPE_BDS_D1Ready = true; } return _TYPE_BDS_D1Content; } }
        private static int _TYPE_BDS_D1Content = default;
        private static bool _TYPE_BDS_D1Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssNavigationMessage.html#TYPE_BDS_D2"/>
        /// </summary>
        public static int TYPE_BDS_D2 { get { if (!_TYPE_BDS_D2Ready) { _TYPE_BDS_D2Content = SGetField<int>(LocalBridgeClazz, "TYPE_BDS_D2"); _TYPE_BDS_D2Ready = true; } return _TYPE_BDS_D2Content; } }
        private static int _TYPE_BDS_D2Content = default;
        private static bool _TYPE_BDS_D2Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssNavigationMessage.html#TYPE_GAL_F"/>
        /// </summary>
        public static int TYPE_GAL_F { get { if (!_TYPE_GAL_FReady) { _TYPE_GAL_FContent = SGetField<int>(LocalBridgeClazz, "TYPE_GAL_F"); _TYPE_GAL_FReady = true; } return _TYPE_GAL_FContent; } }
        private static int _TYPE_GAL_FContent = default;
        private static bool _TYPE_GAL_FReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssNavigationMessage.html#TYPE_GAL_I"/>
        /// </summary>
        public static int TYPE_GAL_I { get { if (!_TYPE_GAL_IReady) { _TYPE_GAL_IContent = SGetField<int>(LocalBridgeClazz, "TYPE_GAL_I"); _TYPE_GAL_IReady = true; } return _TYPE_GAL_IContent; } }
        private static int _TYPE_GAL_IContent = default;
        private static bool _TYPE_GAL_IReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssNavigationMessage.html#TYPE_GLO_L1CA"/>
        /// </summary>
        public static int TYPE_GLO_L1CA { get { if (!_TYPE_GLO_L1CAReady) { _TYPE_GLO_L1CAContent = SGetField<int>(LocalBridgeClazz, "TYPE_GLO_L1CA"); _TYPE_GLO_L1CAReady = true; } return _TYPE_GLO_L1CAContent; } }
        private static int _TYPE_GLO_L1CAContent = default;
        private static bool _TYPE_GLO_L1CAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssNavigationMessage.html#TYPE_GPS_CNAV2"/>
        /// </summary>
        public static int TYPE_GPS_CNAV2 { get { if (!_TYPE_GPS_CNAV2Ready) { _TYPE_GPS_CNAV2Content = SGetField<int>(LocalBridgeClazz, "TYPE_GPS_CNAV2"); _TYPE_GPS_CNAV2Ready = true; } return _TYPE_GPS_CNAV2Content; } }
        private static int _TYPE_GPS_CNAV2Content = default;
        private static bool _TYPE_GPS_CNAV2Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssNavigationMessage.html#TYPE_GPS_L1CA"/>
        /// </summary>
        public static int TYPE_GPS_L1CA { get { if (!_TYPE_GPS_L1CAReady) { _TYPE_GPS_L1CAContent = SGetField<int>(LocalBridgeClazz, "TYPE_GPS_L1CA"); _TYPE_GPS_L1CAReady = true; } return _TYPE_GPS_L1CAContent; } }
        private static int _TYPE_GPS_L1CAContent = default;
        private static bool _TYPE_GPS_L1CAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssNavigationMessage.html#TYPE_GPS_L2CNAV"/>
        /// </summary>
        public static int TYPE_GPS_L2CNAV { get { if (!_TYPE_GPS_L2CNAVReady) { _TYPE_GPS_L2CNAVContent = SGetField<int>(LocalBridgeClazz, "TYPE_GPS_L2CNAV"); _TYPE_GPS_L2CNAVReady = true; } return _TYPE_GPS_L2CNAVContent; } }
        private static int _TYPE_GPS_L2CNAVContent = default;
        private static bool _TYPE_GPS_L2CNAVReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssNavigationMessage.html#TYPE_GPS_L5CNAV"/>
        /// </summary>
        public static int TYPE_GPS_L5CNAV { get { if (!_TYPE_GPS_L5CNAVReady) { _TYPE_GPS_L5CNAVContent = SGetField<int>(LocalBridgeClazz, "TYPE_GPS_L5CNAV"); _TYPE_GPS_L5CNAVReady = true; } return _TYPE_GPS_L5CNAVContent; } }
        private static int _TYPE_GPS_L5CNAVContent = default;
        private static bool _TYPE_GPS_L5CNAVReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssNavigationMessage.html#TYPE_IRN_L5CA"/>
        /// </summary>
        public static int TYPE_IRN_L5CA { get { if (!_TYPE_IRN_L5CAReady) { _TYPE_IRN_L5CAContent = SGetField<int>(LocalBridgeClazz, "TYPE_IRN_L5CA"); _TYPE_IRN_L5CAReady = true; } return _TYPE_IRN_L5CAContent; } }
        private static int _TYPE_IRN_L5CAContent = default;
        private static bool _TYPE_IRN_L5CAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssNavigationMessage.html#TYPE_QZS_L1CA"/>
        /// </summary>
        public static int TYPE_QZS_L1CA { get { if (!_TYPE_QZS_L1CAReady) { _TYPE_QZS_L1CAContent = SGetField<int>(LocalBridgeClazz, "TYPE_QZS_L1CA"); _TYPE_QZS_L1CAReady = true; } return _TYPE_QZS_L1CAContent; } }
        private static int _TYPE_QZS_L1CAContent = default;
        private static bool _TYPE_QZS_L1CAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssNavigationMessage.html#TYPE_SBS"/>
        /// </summary>
        public static int TYPE_SBS { get { if (!_TYPE_SBSReady) { _TYPE_SBSContent = SGetField<int>(LocalBridgeClazz, "TYPE_SBS"); _TYPE_SBSReady = true; } return _TYPE_SBSContent; } }
        private static int _TYPE_SBSContent = default;
        private static bool _TYPE_SBSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssNavigationMessage.html#TYPE_UNKNOWN"/>
        /// </summary>
        public static int TYPE_UNKNOWN { get { if (!_TYPE_UNKNOWNReady) { _TYPE_UNKNOWNContent = SGetField<int>(LocalBridgeClazz, "TYPE_UNKNOWN"); _TYPE_UNKNOWNReady = true; } return _TYPE_UNKNOWNContent; } }
        private static int _TYPE_UNKNOWNContent = default;
        private static bool _TYPE_UNKNOWNReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssNavigationMessage.html#getData()"/>
        /// </summary>
        /// <returns><see cref="byte"/></returns>
        public byte[] GetData()
        {
            return IExecuteWithSignatureArray<byte>("getData", "()[B");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssNavigationMessage.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssNavigationMessage.html#getMessageId()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetMessageId()
        {
            return IExecuteWithSignature<int>("getMessageId", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssNavigationMessage.html#getStatus()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetStatus()
        {
            return IExecuteWithSignature<int>("getStatus", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssNavigationMessage.html#getSubmessageId()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetSubmessageId()
        {
            return IExecuteWithSignature<int>("getSubmessageId", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssNavigationMessage.html#getSvid()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetSvid()
        {
            return IExecuteWithSignature<int>("getSvid", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssNavigationMessage.html#getType()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetType()
        {
            return IExecuteWithSignature<int>("getType", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssNavigationMessage.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecute("writeToParcel", arg0, arg1);
        }

        #endregion

        #region Nested classes
        #region Callback
        public partial class Callback
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/location/GnssNavigationMessage.Callback.html#STATUS_LOCATION_DISABLED"/>
            /// </summary>
            [global::System.Obsolete()]
            public static int STATUS_LOCATION_DISABLED { get { if (!_STATUS_LOCATION_DISABLEDReady) { _STATUS_LOCATION_DISABLEDContent = SGetField<int>(LocalBridgeClazz, "STATUS_LOCATION_DISABLED"); _STATUS_LOCATION_DISABLEDReady = true; } return _STATUS_LOCATION_DISABLEDContent; } }
            private static int _STATUS_LOCATION_DISABLEDContent = default;
            private static bool _STATUS_LOCATION_DISABLEDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/location/GnssNavigationMessage.Callback.html#STATUS_NOT_SUPPORTED"/>
            /// </summary>
            [global::System.Obsolete()]
            public static int STATUS_NOT_SUPPORTED { get { if (!_STATUS_NOT_SUPPORTEDReady) { _STATUS_NOT_SUPPORTEDContent = SGetField<int>(LocalBridgeClazz, "STATUS_NOT_SUPPORTED"); _STATUS_NOT_SUPPORTEDReady = true; } return _STATUS_NOT_SUPPORTEDContent; } }
            private static int _STATUS_NOT_SUPPORTEDContent = default;
            private static bool _STATUS_NOT_SUPPORTEDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/location/GnssNavigationMessage.Callback.html#STATUS_READY"/>
            /// </summary>
            [global::System.Obsolete()]
            public static int STATUS_READY { get { if (!_STATUS_READYReady) { _STATUS_READYContent = SGetField<int>(LocalBridgeClazz, "STATUS_READY"); _STATUS_READYReady = true; } return _STATUS_READYContent; } }
            private static int _STATUS_READYContent = default;
            private static bool _STATUS_READYReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/location/GnssNavigationMessage.Callback.html#onGnssNavigationMessageReceived(android.location.GnssNavigationMessage)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Location.GnssNavigationMessage"/></param>
            public void OnGnssNavigationMessageReceived(Android.Location.GnssNavigationMessage arg0)
            {
                IExecuteWithSignature("onGnssNavigationMessageReceived", "(Landroid/location/GnssNavigationMessage;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/location/GnssNavigationMessage.Callback.html#onStatusChanged(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            [global::System.Obsolete()]
            public void OnStatusChanged(int arg0)
            {
                IExecuteWithSignature("onStatusChanged", "(I)V", arg0);
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