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

namespace Android.Telephony.Data
{
    #region NetworkSliceInfo
    public partial class NetworkSliceInfo
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/data/NetworkSliceInfo.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/data/NetworkSliceInfo.html#SLICE_DIFFERENTIATOR_NO_SLICE"/>
        /// </summary>
        public static int SLICE_DIFFERENTIATOR_NO_SLICE { get { if (!_SLICE_DIFFERENTIATOR_NO_SLICEReady) { _SLICE_DIFFERENTIATOR_NO_SLICEContent = SGetField<int>(LocalBridgeClazz, "SLICE_DIFFERENTIATOR_NO_SLICE"); _SLICE_DIFFERENTIATOR_NO_SLICEReady = true; } return _SLICE_DIFFERENTIATOR_NO_SLICEContent; } }
        private static int _SLICE_DIFFERENTIATOR_NO_SLICEContent = default;
        private static bool _SLICE_DIFFERENTIATOR_NO_SLICEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/data/NetworkSliceInfo.html#SLICE_SERVICE_TYPE_EMBB"/>
        /// </summary>
        public static int SLICE_SERVICE_TYPE_EMBB { get { if (!_SLICE_SERVICE_TYPE_EMBBReady) { _SLICE_SERVICE_TYPE_EMBBContent = SGetField<int>(LocalBridgeClazz, "SLICE_SERVICE_TYPE_EMBB"); _SLICE_SERVICE_TYPE_EMBBReady = true; } return _SLICE_SERVICE_TYPE_EMBBContent; } }
        private static int _SLICE_SERVICE_TYPE_EMBBContent = default;
        private static bool _SLICE_SERVICE_TYPE_EMBBReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/data/NetworkSliceInfo.html#SLICE_SERVICE_TYPE_MIOT"/>
        /// </summary>
        public static int SLICE_SERVICE_TYPE_MIOT { get { if (!_SLICE_SERVICE_TYPE_MIOTReady) { _SLICE_SERVICE_TYPE_MIOTContent = SGetField<int>(LocalBridgeClazz, "SLICE_SERVICE_TYPE_MIOT"); _SLICE_SERVICE_TYPE_MIOTReady = true; } return _SLICE_SERVICE_TYPE_MIOTContent; } }
        private static int _SLICE_SERVICE_TYPE_MIOTContent = default;
        private static bool _SLICE_SERVICE_TYPE_MIOTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/data/NetworkSliceInfo.html#SLICE_SERVICE_TYPE_NONE"/>
        /// </summary>
        public static int SLICE_SERVICE_TYPE_NONE { get { if (!_SLICE_SERVICE_TYPE_NONEReady) { _SLICE_SERVICE_TYPE_NONEContent = SGetField<int>(LocalBridgeClazz, "SLICE_SERVICE_TYPE_NONE"); _SLICE_SERVICE_TYPE_NONEReady = true; } return _SLICE_SERVICE_TYPE_NONEContent; } }
        private static int _SLICE_SERVICE_TYPE_NONEContent = default;
        private static bool _SLICE_SERVICE_TYPE_NONEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/data/NetworkSliceInfo.html#SLICE_SERVICE_TYPE_URLLC"/>
        /// </summary>
        public static int SLICE_SERVICE_TYPE_URLLC { get { if (!_SLICE_SERVICE_TYPE_URLLCReady) { _SLICE_SERVICE_TYPE_URLLCContent = SGetField<int>(LocalBridgeClazz, "SLICE_SERVICE_TYPE_URLLC"); _SLICE_SERVICE_TYPE_URLLCReady = true; } return _SLICE_SERVICE_TYPE_URLLCContent; } }
        private static int _SLICE_SERVICE_TYPE_URLLCContent = default;
        private static bool _SLICE_SERVICE_TYPE_URLLCReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/data/NetworkSliceInfo.html#SLICE_STATUS_ALLOWED"/>
        /// </summary>
        public static int SLICE_STATUS_ALLOWED { get { if (!_SLICE_STATUS_ALLOWEDReady) { _SLICE_STATUS_ALLOWEDContent = SGetField<int>(LocalBridgeClazz, "SLICE_STATUS_ALLOWED"); _SLICE_STATUS_ALLOWEDReady = true; } return _SLICE_STATUS_ALLOWEDContent; } }
        private static int _SLICE_STATUS_ALLOWEDContent = default;
        private static bool _SLICE_STATUS_ALLOWEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/data/NetworkSliceInfo.html#SLICE_STATUS_CONFIGURED"/>
        /// </summary>
        public static int SLICE_STATUS_CONFIGURED { get { if (!_SLICE_STATUS_CONFIGUREDReady) { _SLICE_STATUS_CONFIGUREDContent = SGetField<int>(LocalBridgeClazz, "SLICE_STATUS_CONFIGURED"); _SLICE_STATUS_CONFIGUREDReady = true; } return _SLICE_STATUS_CONFIGUREDContent; } }
        private static int _SLICE_STATUS_CONFIGUREDContent = default;
        private static bool _SLICE_STATUS_CONFIGUREDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/data/NetworkSliceInfo.html#SLICE_STATUS_DEFAULT_CONFIGURED"/>
        /// </summary>
        public static int SLICE_STATUS_DEFAULT_CONFIGURED { get { if (!_SLICE_STATUS_DEFAULT_CONFIGUREDReady) { _SLICE_STATUS_DEFAULT_CONFIGUREDContent = SGetField<int>(LocalBridgeClazz, "SLICE_STATUS_DEFAULT_CONFIGURED"); _SLICE_STATUS_DEFAULT_CONFIGUREDReady = true; } return _SLICE_STATUS_DEFAULT_CONFIGUREDContent; } }
        private static int _SLICE_STATUS_DEFAULT_CONFIGUREDContent = default;
        private static bool _SLICE_STATUS_DEFAULT_CONFIGUREDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/data/NetworkSliceInfo.html#SLICE_STATUS_REJECTED_NOT_AVAILABLE_IN_PLMN"/>
        /// </summary>
        public static int SLICE_STATUS_REJECTED_NOT_AVAILABLE_IN_PLMN { get { if (!_SLICE_STATUS_REJECTED_NOT_AVAILABLE_IN_PLMNReady) { _SLICE_STATUS_REJECTED_NOT_AVAILABLE_IN_PLMNContent = SGetField<int>(LocalBridgeClazz, "SLICE_STATUS_REJECTED_NOT_AVAILABLE_IN_PLMN"); _SLICE_STATUS_REJECTED_NOT_AVAILABLE_IN_PLMNReady = true; } return _SLICE_STATUS_REJECTED_NOT_AVAILABLE_IN_PLMNContent; } }
        private static int _SLICE_STATUS_REJECTED_NOT_AVAILABLE_IN_PLMNContent = default;
        private static bool _SLICE_STATUS_REJECTED_NOT_AVAILABLE_IN_PLMNReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/data/NetworkSliceInfo.html#SLICE_STATUS_REJECTED_NOT_AVAILABLE_IN_REGISTERED_AREA"/>
        /// </summary>
        public static int SLICE_STATUS_REJECTED_NOT_AVAILABLE_IN_REGISTERED_AREA { get { if (!_SLICE_STATUS_REJECTED_NOT_AVAILABLE_IN_REGISTERED_AREAReady) { _SLICE_STATUS_REJECTED_NOT_AVAILABLE_IN_REGISTERED_AREAContent = SGetField<int>(LocalBridgeClazz, "SLICE_STATUS_REJECTED_NOT_AVAILABLE_IN_REGISTERED_AREA"); _SLICE_STATUS_REJECTED_NOT_AVAILABLE_IN_REGISTERED_AREAReady = true; } return _SLICE_STATUS_REJECTED_NOT_AVAILABLE_IN_REGISTERED_AREAContent; } }
        private static int _SLICE_STATUS_REJECTED_NOT_AVAILABLE_IN_REGISTERED_AREAContent = default;
        private static bool _SLICE_STATUS_REJECTED_NOT_AVAILABLE_IN_REGISTERED_AREAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/data/NetworkSliceInfo.html#SLICE_STATUS_UNKNOWN"/>
        /// </summary>
        public static int SLICE_STATUS_UNKNOWN { get { if (!_SLICE_STATUS_UNKNOWNReady) { _SLICE_STATUS_UNKNOWNContent = SGetField<int>(LocalBridgeClazz, "SLICE_STATUS_UNKNOWN"); _SLICE_STATUS_UNKNOWNReady = true; } return _SLICE_STATUS_UNKNOWNContent; } }
        private static int _SLICE_STATUS_UNKNOWNContent = default;
        private static bool _SLICE_STATUS_UNKNOWNReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/data/NetworkSliceInfo.html#getMappedHplmnSliceDifferentiator()"/> 
        /// </summary>
        public int MappedHplmnSliceDifferentiator
        {
            get { return IExecuteWithSignature<int>("getMappedHplmnSliceDifferentiator", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/data/NetworkSliceInfo.html#getMappedHplmnSliceServiceType()"/> 
        /// </summary>
        public int MappedHplmnSliceServiceType
        {
            get { return IExecuteWithSignature<int>("getMappedHplmnSliceServiceType", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/data/NetworkSliceInfo.html#getSliceDifferentiator()"/> 
        /// </summary>
        public int SliceDifferentiator
        {
            get { return IExecuteWithSignature<int>("getSliceDifferentiator", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/data/NetworkSliceInfo.html#getSliceServiceType()"/> 
        /// </summary>
        public int SliceServiceType
        {
            get { return IExecuteWithSignature<int>("getSliceServiceType", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/data/NetworkSliceInfo.html#getStatus()"/> 
        /// </summary>
        public int Status
        {
            get { return IExecuteWithSignature<int>("getStatus", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/data/NetworkSliceInfo.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/data/NetworkSliceInfo.html#writeToParcel(android.os.Parcel,int)"/>
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
            /// <see href="https://developer.android.com/reference/android/telephony/data/NetworkSliceInfo.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Telephony.Data.NetworkSliceInfo"/></returns>
            public Android.Telephony.Data.NetworkSliceInfo Build()
            {
                return IExecuteWithSignature<Android.Telephony.Data.NetworkSliceInfo>("build", "()Landroid/telephony/data/NetworkSliceInfo;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telephony/data/NetworkSliceInfo.Builder.html#setMappedHplmnSliceDifferentiator(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Telephony.Data.NetworkSliceInfo.Builder"/></returns>
            public Android.Telephony.Data.NetworkSliceInfo.Builder SetMappedHplmnSliceDifferentiator(int arg0)
            {
                return IExecuteWithSignature<Android.Telephony.Data.NetworkSliceInfo.Builder>("setMappedHplmnSliceDifferentiator", "(I)Landroid/telephony/data/NetworkSliceInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telephony/data/NetworkSliceInfo.Builder.html#setMappedHplmnSliceServiceType(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Telephony.Data.NetworkSliceInfo.Builder"/></returns>
            public Android.Telephony.Data.NetworkSliceInfo.Builder SetMappedHplmnSliceServiceType(int arg0)
            {
                return IExecuteWithSignature<Android.Telephony.Data.NetworkSliceInfo.Builder>("setMappedHplmnSliceServiceType", "(I)Landroid/telephony/data/NetworkSliceInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telephony/data/NetworkSliceInfo.Builder.html#setSliceDifferentiator(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Telephony.Data.NetworkSliceInfo.Builder"/></returns>
            public Android.Telephony.Data.NetworkSliceInfo.Builder SetSliceDifferentiator(int arg0)
            {
                return IExecuteWithSignature<Android.Telephony.Data.NetworkSliceInfo.Builder>("setSliceDifferentiator", "(I)Landroid/telephony/data/NetworkSliceInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telephony/data/NetworkSliceInfo.Builder.html#setSliceServiceType(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Telephony.Data.NetworkSliceInfo.Builder"/></returns>
            public Android.Telephony.Data.NetworkSliceInfo.Builder SetSliceServiceType(int arg0)
            {
                return IExecuteWithSignature<Android.Telephony.Data.NetworkSliceInfo.Builder>("setSliceServiceType", "(I)Landroid/telephony/data/NetworkSliceInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telephony/data/NetworkSliceInfo.Builder.html#setStatus(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Telephony.Data.NetworkSliceInfo.Builder"/></returns>
            public Android.Telephony.Data.NetworkSliceInfo.Builder SetStatus(int arg0)
            {
                return IExecuteWithSignature<Android.Telephony.Data.NetworkSliceInfo.Builder>("setStatus", "(I)Landroid/telephony/data/NetworkSliceInfo$Builder;", arg0);
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