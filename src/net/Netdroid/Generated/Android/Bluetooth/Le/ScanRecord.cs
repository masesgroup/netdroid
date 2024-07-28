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

namespace Android.Bluetooth.Le
{
    #region ScanRecord
    public partial class ScanRecord
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanRecord.html#DATA_TYPE_3D_INFORMATION_DATA"/>
        /// </summary>
        public static int DATA_TYPE_3D_INFORMATION_DATA { get { if (!_DATA_TYPE_3D_INFORMATION_DATAReady) { _DATA_TYPE_3D_INFORMATION_DATAContent = SGetField<int>(LocalBridgeClazz, "DATA_TYPE_3D_INFORMATION_DATA"); _DATA_TYPE_3D_INFORMATION_DATAReady = true; } return _DATA_TYPE_3D_INFORMATION_DATAContent; } }
        private static int _DATA_TYPE_3D_INFORMATION_DATAContent = default;
        private static bool _DATA_TYPE_3D_INFORMATION_DATAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanRecord.html#DATA_TYPE_ADVERTISING_INTERVAL"/>
        /// </summary>
        public static int DATA_TYPE_ADVERTISING_INTERVAL { get { if (!_DATA_TYPE_ADVERTISING_INTERVALReady) { _DATA_TYPE_ADVERTISING_INTERVALContent = SGetField<int>(LocalBridgeClazz, "DATA_TYPE_ADVERTISING_INTERVAL"); _DATA_TYPE_ADVERTISING_INTERVALReady = true; } return _DATA_TYPE_ADVERTISING_INTERVALContent; } }
        private static int _DATA_TYPE_ADVERTISING_INTERVALContent = default;
        private static bool _DATA_TYPE_ADVERTISING_INTERVALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanRecord.html#DATA_TYPE_ADVERTISING_INTERVAL_LONG"/>
        /// </summary>
        public static int DATA_TYPE_ADVERTISING_INTERVAL_LONG { get { if (!_DATA_TYPE_ADVERTISING_INTERVAL_LONGReady) { _DATA_TYPE_ADVERTISING_INTERVAL_LONGContent = SGetField<int>(LocalBridgeClazz, "DATA_TYPE_ADVERTISING_INTERVAL_LONG"); _DATA_TYPE_ADVERTISING_INTERVAL_LONGReady = true; } return _DATA_TYPE_ADVERTISING_INTERVAL_LONGContent; } }
        private static int _DATA_TYPE_ADVERTISING_INTERVAL_LONGContent = default;
        private static bool _DATA_TYPE_ADVERTISING_INTERVAL_LONGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanRecord.html#DATA_TYPE_APPEARANCE"/>
        /// </summary>
        public static int DATA_TYPE_APPEARANCE { get { if (!_DATA_TYPE_APPEARANCEReady) { _DATA_TYPE_APPEARANCEContent = SGetField<int>(LocalBridgeClazz, "DATA_TYPE_APPEARANCE"); _DATA_TYPE_APPEARANCEReady = true; } return _DATA_TYPE_APPEARANCEContent; } }
        private static int _DATA_TYPE_APPEARANCEContent = default;
        private static bool _DATA_TYPE_APPEARANCEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanRecord.html#DATA_TYPE_BIG_INFO"/>
        /// </summary>
        public static int DATA_TYPE_BIG_INFO { get { if (!_DATA_TYPE_BIG_INFOReady) { _DATA_TYPE_BIG_INFOContent = SGetField<int>(LocalBridgeClazz, "DATA_TYPE_BIG_INFO"); _DATA_TYPE_BIG_INFOReady = true; } return _DATA_TYPE_BIG_INFOContent; } }
        private static int _DATA_TYPE_BIG_INFOContent = default;
        private static bool _DATA_TYPE_BIG_INFOReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanRecord.html#DATA_TYPE_BROADCAST_CODE"/>
        /// </summary>
        public static int DATA_TYPE_BROADCAST_CODE { get { if (!_DATA_TYPE_BROADCAST_CODEReady) { _DATA_TYPE_BROADCAST_CODEContent = SGetField<int>(LocalBridgeClazz, "DATA_TYPE_BROADCAST_CODE"); _DATA_TYPE_BROADCAST_CODEReady = true; } return _DATA_TYPE_BROADCAST_CODEContent; } }
        private static int _DATA_TYPE_BROADCAST_CODEContent = default;
        private static bool _DATA_TYPE_BROADCAST_CODEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanRecord.html#DATA_TYPE_CHANNEL_MAP_UPDATE_INDICATION"/>
        /// </summary>
        public static int DATA_TYPE_CHANNEL_MAP_UPDATE_INDICATION { get { if (!_DATA_TYPE_CHANNEL_MAP_UPDATE_INDICATIONReady) { _DATA_TYPE_CHANNEL_MAP_UPDATE_INDICATIONContent = SGetField<int>(LocalBridgeClazz, "DATA_TYPE_CHANNEL_MAP_UPDATE_INDICATION"); _DATA_TYPE_CHANNEL_MAP_UPDATE_INDICATIONReady = true; } return _DATA_TYPE_CHANNEL_MAP_UPDATE_INDICATIONContent; } }
        private static int _DATA_TYPE_CHANNEL_MAP_UPDATE_INDICATIONContent = default;
        private static bool _DATA_TYPE_CHANNEL_MAP_UPDATE_INDICATIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanRecord.html#DATA_TYPE_CLASS_OF_DEVICE"/>
        /// </summary>
        public static int DATA_TYPE_CLASS_OF_DEVICE { get { if (!_DATA_TYPE_CLASS_OF_DEVICEReady) { _DATA_TYPE_CLASS_OF_DEVICEContent = SGetField<int>(LocalBridgeClazz, "DATA_TYPE_CLASS_OF_DEVICE"); _DATA_TYPE_CLASS_OF_DEVICEReady = true; } return _DATA_TYPE_CLASS_OF_DEVICEContent; } }
        private static int _DATA_TYPE_CLASS_OF_DEVICEContent = default;
        private static bool _DATA_TYPE_CLASS_OF_DEVICEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanRecord.html#DATA_TYPE_DEVICE_ID"/>
        /// </summary>
        public static int DATA_TYPE_DEVICE_ID { get { if (!_DATA_TYPE_DEVICE_IDReady) { _DATA_TYPE_DEVICE_IDContent = SGetField<int>(LocalBridgeClazz, "DATA_TYPE_DEVICE_ID"); _DATA_TYPE_DEVICE_IDReady = true; } return _DATA_TYPE_DEVICE_IDContent; } }
        private static int _DATA_TYPE_DEVICE_IDContent = default;
        private static bool _DATA_TYPE_DEVICE_IDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanRecord.html#DATA_TYPE_FLAGS"/>
        /// </summary>
        public static int DATA_TYPE_FLAGS { get { if (!_DATA_TYPE_FLAGSReady) { _DATA_TYPE_FLAGSContent = SGetField<int>(LocalBridgeClazz, "DATA_TYPE_FLAGS"); _DATA_TYPE_FLAGSReady = true; } return _DATA_TYPE_FLAGSContent; } }
        private static int _DATA_TYPE_FLAGSContent = default;
        private static bool _DATA_TYPE_FLAGSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanRecord.html#DATA_TYPE_INDOOR_POSITIONING"/>
        /// </summary>
        public static int DATA_TYPE_INDOOR_POSITIONING { get { if (!_DATA_TYPE_INDOOR_POSITIONINGReady) { _DATA_TYPE_INDOOR_POSITIONINGContent = SGetField<int>(LocalBridgeClazz, "DATA_TYPE_INDOOR_POSITIONING"); _DATA_TYPE_INDOOR_POSITIONINGReady = true; } return _DATA_TYPE_INDOOR_POSITIONINGContent; } }
        private static int _DATA_TYPE_INDOOR_POSITIONINGContent = default;
        private static bool _DATA_TYPE_INDOOR_POSITIONINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanRecord.html#DATA_TYPE_LE_BLUETOOTH_DEVICE_ADDRESS"/>
        /// </summary>
        public static int DATA_TYPE_LE_BLUETOOTH_DEVICE_ADDRESS { get { if (!_DATA_TYPE_LE_BLUETOOTH_DEVICE_ADDRESSReady) { _DATA_TYPE_LE_BLUETOOTH_DEVICE_ADDRESSContent = SGetField<int>(LocalBridgeClazz, "DATA_TYPE_LE_BLUETOOTH_DEVICE_ADDRESS"); _DATA_TYPE_LE_BLUETOOTH_DEVICE_ADDRESSReady = true; } return _DATA_TYPE_LE_BLUETOOTH_DEVICE_ADDRESSContent; } }
        private static int _DATA_TYPE_LE_BLUETOOTH_DEVICE_ADDRESSContent = default;
        private static bool _DATA_TYPE_LE_BLUETOOTH_DEVICE_ADDRESSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanRecord.html#DATA_TYPE_LE_ROLE"/>
        /// </summary>
        public static int DATA_TYPE_LE_ROLE { get { if (!_DATA_TYPE_LE_ROLEReady) { _DATA_TYPE_LE_ROLEContent = SGetField<int>(LocalBridgeClazz, "DATA_TYPE_LE_ROLE"); _DATA_TYPE_LE_ROLEReady = true; } return _DATA_TYPE_LE_ROLEContent; } }
        private static int _DATA_TYPE_LE_ROLEContent = default;
        private static bool _DATA_TYPE_LE_ROLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanRecord.html#DATA_TYPE_LE_SECURE_CONNECTIONS_CONFIRMATION_VALUE"/>
        /// </summary>
        public static int DATA_TYPE_LE_SECURE_CONNECTIONS_CONFIRMATION_VALUE { get { if (!_DATA_TYPE_LE_SECURE_CONNECTIONS_CONFIRMATION_VALUEReady) { _DATA_TYPE_LE_SECURE_CONNECTIONS_CONFIRMATION_VALUEContent = SGetField<int>(LocalBridgeClazz, "DATA_TYPE_LE_SECURE_CONNECTIONS_CONFIRMATION_VALUE"); _DATA_TYPE_LE_SECURE_CONNECTIONS_CONFIRMATION_VALUEReady = true; } return _DATA_TYPE_LE_SECURE_CONNECTIONS_CONFIRMATION_VALUEContent; } }
        private static int _DATA_TYPE_LE_SECURE_CONNECTIONS_CONFIRMATION_VALUEContent = default;
        private static bool _DATA_TYPE_LE_SECURE_CONNECTIONS_CONFIRMATION_VALUEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanRecord.html#DATA_TYPE_LE_SECURE_CONNECTIONS_RANDOM_VALUE"/>
        /// </summary>
        public static int DATA_TYPE_LE_SECURE_CONNECTIONS_RANDOM_VALUE { get { if (!_DATA_TYPE_LE_SECURE_CONNECTIONS_RANDOM_VALUEReady) { _DATA_TYPE_LE_SECURE_CONNECTIONS_RANDOM_VALUEContent = SGetField<int>(LocalBridgeClazz, "DATA_TYPE_LE_SECURE_CONNECTIONS_RANDOM_VALUE"); _DATA_TYPE_LE_SECURE_CONNECTIONS_RANDOM_VALUEReady = true; } return _DATA_TYPE_LE_SECURE_CONNECTIONS_RANDOM_VALUEContent; } }
        private static int _DATA_TYPE_LE_SECURE_CONNECTIONS_RANDOM_VALUEContent = default;
        private static bool _DATA_TYPE_LE_SECURE_CONNECTIONS_RANDOM_VALUEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanRecord.html#DATA_TYPE_LE_SUPPORTED_FEATURES"/>
        /// </summary>
        public static int DATA_TYPE_LE_SUPPORTED_FEATURES { get { if (!_DATA_TYPE_LE_SUPPORTED_FEATURESReady) { _DATA_TYPE_LE_SUPPORTED_FEATURESContent = SGetField<int>(LocalBridgeClazz, "DATA_TYPE_LE_SUPPORTED_FEATURES"); _DATA_TYPE_LE_SUPPORTED_FEATURESReady = true; } return _DATA_TYPE_LE_SUPPORTED_FEATURESContent; } }
        private static int _DATA_TYPE_LE_SUPPORTED_FEATURESContent = default;
        private static bool _DATA_TYPE_LE_SUPPORTED_FEATURESReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanRecord.html#DATA_TYPE_LOCAL_NAME_COMPLETE"/>
        /// </summary>
        public static int DATA_TYPE_LOCAL_NAME_COMPLETE { get { if (!_DATA_TYPE_LOCAL_NAME_COMPLETEReady) { _DATA_TYPE_LOCAL_NAME_COMPLETEContent = SGetField<int>(LocalBridgeClazz, "DATA_TYPE_LOCAL_NAME_COMPLETE"); _DATA_TYPE_LOCAL_NAME_COMPLETEReady = true; } return _DATA_TYPE_LOCAL_NAME_COMPLETEContent; } }
        private static int _DATA_TYPE_LOCAL_NAME_COMPLETEContent = default;
        private static bool _DATA_TYPE_LOCAL_NAME_COMPLETEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanRecord.html#DATA_TYPE_LOCAL_NAME_SHORT"/>
        /// </summary>
        public static int DATA_TYPE_LOCAL_NAME_SHORT { get { if (!_DATA_TYPE_LOCAL_NAME_SHORTReady) { _DATA_TYPE_LOCAL_NAME_SHORTContent = SGetField<int>(LocalBridgeClazz, "DATA_TYPE_LOCAL_NAME_SHORT"); _DATA_TYPE_LOCAL_NAME_SHORTReady = true; } return _DATA_TYPE_LOCAL_NAME_SHORTContent; } }
        private static int _DATA_TYPE_LOCAL_NAME_SHORTContent = default;
        private static bool _DATA_TYPE_LOCAL_NAME_SHORTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanRecord.html#DATA_TYPE_MANUFACTURER_SPECIFIC_DATA"/>
        /// </summary>
        public static int DATA_TYPE_MANUFACTURER_SPECIFIC_DATA { get { if (!_DATA_TYPE_MANUFACTURER_SPECIFIC_DATAReady) { _DATA_TYPE_MANUFACTURER_SPECIFIC_DATAContent = SGetField<int>(LocalBridgeClazz, "DATA_TYPE_MANUFACTURER_SPECIFIC_DATA"); _DATA_TYPE_MANUFACTURER_SPECIFIC_DATAReady = true; } return _DATA_TYPE_MANUFACTURER_SPECIFIC_DATAContent; } }
        private static int _DATA_TYPE_MANUFACTURER_SPECIFIC_DATAContent = default;
        private static bool _DATA_TYPE_MANUFACTURER_SPECIFIC_DATAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanRecord.html#DATA_TYPE_MESH_BEACON"/>
        /// </summary>
        public static int DATA_TYPE_MESH_BEACON { get { if (!_DATA_TYPE_MESH_BEACONReady) { _DATA_TYPE_MESH_BEACONContent = SGetField<int>(LocalBridgeClazz, "DATA_TYPE_MESH_BEACON"); _DATA_TYPE_MESH_BEACONReady = true; } return _DATA_TYPE_MESH_BEACONContent; } }
        private static int _DATA_TYPE_MESH_BEACONContent = default;
        private static bool _DATA_TYPE_MESH_BEACONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanRecord.html#DATA_TYPE_MESH_MESSAGE"/>
        /// </summary>
        public static int DATA_TYPE_MESH_MESSAGE { get { if (!_DATA_TYPE_MESH_MESSAGEReady) { _DATA_TYPE_MESH_MESSAGEContent = SGetField<int>(LocalBridgeClazz, "DATA_TYPE_MESH_MESSAGE"); _DATA_TYPE_MESH_MESSAGEReady = true; } return _DATA_TYPE_MESH_MESSAGEContent; } }
        private static int _DATA_TYPE_MESH_MESSAGEContent = default;
        private static bool _DATA_TYPE_MESH_MESSAGEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanRecord.html#DATA_TYPE_NONE"/>
        /// </summary>
        public static int DATA_TYPE_NONE { get { if (!_DATA_TYPE_NONEReady) { _DATA_TYPE_NONEContent = SGetField<int>(LocalBridgeClazz, "DATA_TYPE_NONE"); _DATA_TYPE_NONEReady = true; } return _DATA_TYPE_NONEContent; } }
        private static int _DATA_TYPE_NONEContent = default;
        private static bool _DATA_TYPE_NONEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanRecord.html#DATA_TYPE_PB_ADV"/>
        /// </summary>
        public static int DATA_TYPE_PB_ADV { get { if (!_DATA_TYPE_PB_ADVReady) { _DATA_TYPE_PB_ADVContent = SGetField<int>(LocalBridgeClazz, "DATA_TYPE_PB_ADV"); _DATA_TYPE_PB_ADVReady = true; } return _DATA_TYPE_PB_ADVContent; } }
        private static int _DATA_TYPE_PB_ADVContent = default;
        private static bool _DATA_TYPE_PB_ADVReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanRecord.html#DATA_TYPE_PUBLIC_TARGET_ADDRESS"/>
        /// </summary>
        public static int DATA_TYPE_PUBLIC_TARGET_ADDRESS { get { if (!_DATA_TYPE_PUBLIC_TARGET_ADDRESSReady) { _DATA_TYPE_PUBLIC_TARGET_ADDRESSContent = SGetField<int>(LocalBridgeClazz, "DATA_TYPE_PUBLIC_TARGET_ADDRESS"); _DATA_TYPE_PUBLIC_TARGET_ADDRESSReady = true; } return _DATA_TYPE_PUBLIC_TARGET_ADDRESSContent; } }
        private static int _DATA_TYPE_PUBLIC_TARGET_ADDRESSContent = default;
        private static bool _DATA_TYPE_PUBLIC_TARGET_ADDRESSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanRecord.html#DATA_TYPE_RANDOM_TARGET_ADDRESS"/>
        /// </summary>
        public static int DATA_TYPE_RANDOM_TARGET_ADDRESS { get { if (!_DATA_TYPE_RANDOM_TARGET_ADDRESSReady) { _DATA_TYPE_RANDOM_TARGET_ADDRESSContent = SGetField<int>(LocalBridgeClazz, "DATA_TYPE_RANDOM_TARGET_ADDRESS"); _DATA_TYPE_RANDOM_TARGET_ADDRESSReady = true; } return _DATA_TYPE_RANDOM_TARGET_ADDRESSContent; } }
        private static int _DATA_TYPE_RANDOM_TARGET_ADDRESSContent = default;
        private static bool _DATA_TYPE_RANDOM_TARGET_ADDRESSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanRecord.html#DATA_TYPE_RESOLVABLE_SET_IDENTIFIER"/>
        /// </summary>
        public static int DATA_TYPE_RESOLVABLE_SET_IDENTIFIER { get { if (!_DATA_TYPE_RESOLVABLE_SET_IDENTIFIERReady) { _DATA_TYPE_RESOLVABLE_SET_IDENTIFIERContent = SGetField<int>(LocalBridgeClazz, "DATA_TYPE_RESOLVABLE_SET_IDENTIFIER"); _DATA_TYPE_RESOLVABLE_SET_IDENTIFIERReady = true; } return _DATA_TYPE_RESOLVABLE_SET_IDENTIFIERContent; } }
        private static int _DATA_TYPE_RESOLVABLE_SET_IDENTIFIERContent = default;
        private static bool _DATA_TYPE_RESOLVABLE_SET_IDENTIFIERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanRecord.html#DATA_TYPE_SECURITY_MANAGER_OUT_OF_BAND_FLAGS"/>
        /// </summary>
        public static int DATA_TYPE_SECURITY_MANAGER_OUT_OF_BAND_FLAGS { get { if (!_DATA_TYPE_SECURITY_MANAGER_OUT_OF_BAND_FLAGSReady) { _DATA_TYPE_SECURITY_MANAGER_OUT_OF_BAND_FLAGSContent = SGetField<int>(LocalBridgeClazz, "DATA_TYPE_SECURITY_MANAGER_OUT_OF_BAND_FLAGS"); _DATA_TYPE_SECURITY_MANAGER_OUT_OF_BAND_FLAGSReady = true; } return _DATA_TYPE_SECURITY_MANAGER_OUT_OF_BAND_FLAGSContent; } }
        private static int _DATA_TYPE_SECURITY_MANAGER_OUT_OF_BAND_FLAGSContent = default;
        private static bool _DATA_TYPE_SECURITY_MANAGER_OUT_OF_BAND_FLAGSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanRecord.html#DATA_TYPE_SERVICE_DATA_128_BIT"/>
        /// </summary>
        public static int DATA_TYPE_SERVICE_DATA_128_BIT { get { if (!_DATA_TYPE_SERVICE_DATA_128_BITReady) { _DATA_TYPE_SERVICE_DATA_128_BITContent = SGetField<int>(LocalBridgeClazz, "DATA_TYPE_SERVICE_DATA_128_BIT"); _DATA_TYPE_SERVICE_DATA_128_BITReady = true; } return _DATA_TYPE_SERVICE_DATA_128_BITContent; } }
        private static int _DATA_TYPE_SERVICE_DATA_128_BITContent = default;
        private static bool _DATA_TYPE_SERVICE_DATA_128_BITReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanRecord.html#DATA_TYPE_SERVICE_DATA_16_BIT"/>
        /// </summary>
        public static int DATA_TYPE_SERVICE_DATA_16_BIT { get { if (!_DATA_TYPE_SERVICE_DATA_16_BITReady) { _DATA_TYPE_SERVICE_DATA_16_BITContent = SGetField<int>(LocalBridgeClazz, "DATA_TYPE_SERVICE_DATA_16_BIT"); _DATA_TYPE_SERVICE_DATA_16_BITReady = true; } return _DATA_TYPE_SERVICE_DATA_16_BITContent; } }
        private static int _DATA_TYPE_SERVICE_DATA_16_BITContent = default;
        private static bool _DATA_TYPE_SERVICE_DATA_16_BITReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanRecord.html#DATA_TYPE_SERVICE_DATA_32_BIT"/>
        /// </summary>
        public static int DATA_TYPE_SERVICE_DATA_32_BIT { get { if (!_DATA_TYPE_SERVICE_DATA_32_BITReady) { _DATA_TYPE_SERVICE_DATA_32_BITContent = SGetField<int>(LocalBridgeClazz, "DATA_TYPE_SERVICE_DATA_32_BIT"); _DATA_TYPE_SERVICE_DATA_32_BITReady = true; } return _DATA_TYPE_SERVICE_DATA_32_BITContent; } }
        private static int _DATA_TYPE_SERVICE_DATA_32_BITContent = default;
        private static bool _DATA_TYPE_SERVICE_DATA_32_BITReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanRecord.html#DATA_TYPE_SERVICE_SOLICITATION_UUIDS_128_BIT"/>
        /// </summary>
        public static int DATA_TYPE_SERVICE_SOLICITATION_UUIDS_128_BIT { get { if (!_DATA_TYPE_SERVICE_SOLICITATION_UUIDS_128_BITReady) { _DATA_TYPE_SERVICE_SOLICITATION_UUIDS_128_BITContent = SGetField<int>(LocalBridgeClazz, "DATA_TYPE_SERVICE_SOLICITATION_UUIDS_128_BIT"); _DATA_TYPE_SERVICE_SOLICITATION_UUIDS_128_BITReady = true; } return _DATA_TYPE_SERVICE_SOLICITATION_UUIDS_128_BITContent; } }
        private static int _DATA_TYPE_SERVICE_SOLICITATION_UUIDS_128_BITContent = default;
        private static bool _DATA_TYPE_SERVICE_SOLICITATION_UUIDS_128_BITReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanRecord.html#DATA_TYPE_SERVICE_SOLICITATION_UUIDS_16_BIT"/>
        /// </summary>
        public static int DATA_TYPE_SERVICE_SOLICITATION_UUIDS_16_BIT { get { if (!_DATA_TYPE_SERVICE_SOLICITATION_UUIDS_16_BITReady) { _DATA_TYPE_SERVICE_SOLICITATION_UUIDS_16_BITContent = SGetField<int>(LocalBridgeClazz, "DATA_TYPE_SERVICE_SOLICITATION_UUIDS_16_BIT"); _DATA_TYPE_SERVICE_SOLICITATION_UUIDS_16_BITReady = true; } return _DATA_TYPE_SERVICE_SOLICITATION_UUIDS_16_BITContent; } }
        private static int _DATA_TYPE_SERVICE_SOLICITATION_UUIDS_16_BITContent = default;
        private static bool _DATA_TYPE_SERVICE_SOLICITATION_UUIDS_16_BITReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanRecord.html#DATA_TYPE_SERVICE_SOLICITATION_UUIDS_32_BIT"/>
        /// </summary>
        public static int DATA_TYPE_SERVICE_SOLICITATION_UUIDS_32_BIT { get { if (!_DATA_TYPE_SERVICE_SOLICITATION_UUIDS_32_BITReady) { _DATA_TYPE_SERVICE_SOLICITATION_UUIDS_32_BITContent = SGetField<int>(LocalBridgeClazz, "DATA_TYPE_SERVICE_SOLICITATION_UUIDS_32_BIT"); _DATA_TYPE_SERVICE_SOLICITATION_UUIDS_32_BITReady = true; } return _DATA_TYPE_SERVICE_SOLICITATION_UUIDS_32_BITContent; } }
        private static int _DATA_TYPE_SERVICE_SOLICITATION_UUIDS_32_BITContent = default;
        private static bool _DATA_TYPE_SERVICE_SOLICITATION_UUIDS_32_BITReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanRecord.html#DATA_TYPE_SERVICE_UUIDS_128_BIT_COMPLETE"/>
        /// </summary>
        public static int DATA_TYPE_SERVICE_UUIDS_128_BIT_COMPLETE { get { if (!_DATA_TYPE_SERVICE_UUIDS_128_BIT_COMPLETEReady) { _DATA_TYPE_SERVICE_UUIDS_128_BIT_COMPLETEContent = SGetField<int>(LocalBridgeClazz, "DATA_TYPE_SERVICE_UUIDS_128_BIT_COMPLETE"); _DATA_TYPE_SERVICE_UUIDS_128_BIT_COMPLETEReady = true; } return _DATA_TYPE_SERVICE_UUIDS_128_BIT_COMPLETEContent; } }
        private static int _DATA_TYPE_SERVICE_UUIDS_128_BIT_COMPLETEContent = default;
        private static bool _DATA_TYPE_SERVICE_UUIDS_128_BIT_COMPLETEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanRecord.html#DATA_TYPE_SERVICE_UUIDS_128_BIT_PARTIAL"/>
        /// </summary>
        public static int DATA_TYPE_SERVICE_UUIDS_128_BIT_PARTIAL { get { if (!_DATA_TYPE_SERVICE_UUIDS_128_BIT_PARTIALReady) { _DATA_TYPE_SERVICE_UUIDS_128_BIT_PARTIALContent = SGetField<int>(LocalBridgeClazz, "DATA_TYPE_SERVICE_UUIDS_128_BIT_PARTIAL"); _DATA_TYPE_SERVICE_UUIDS_128_BIT_PARTIALReady = true; } return _DATA_TYPE_SERVICE_UUIDS_128_BIT_PARTIALContent; } }
        private static int _DATA_TYPE_SERVICE_UUIDS_128_BIT_PARTIALContent = default;
        private static bool _DATA_TYPE_SERVICE_UUIDS_128_BIT_PARTIALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanRecord.html#DATA_TYPE_SERVICE_UUIDS_16_BIT_COMPLETE"/>
        /// </summary>
        public static int DATA_TYPE_SERVICE_UUIDS_16_BIT_COMPLETE { get { if (!_DATA_TYPE_SERVICE_UUIDS_16_BIT_COMPLETEReady) { _DATA_TYPE_SERVICE_UUIDS_16_BIT_COMPLETEContent = SGetField<int>(LocalBridgeClazz, "DATA_TYPE_SERVICE_UUIDS_16_BIT_COMPLETE"); _DATA_TYPE_SERVICE_UUIDS_16_BIT_COMPLETEReady = true; } return _DATA_TYPE_SERVICE_UUIDS_16_BIT_COMPLETEContent; } }
        private static int _DATA_TYPE_SERVICE_UUIDS_16_BIT_COMPLETEContent = default;
        private static bool _DATA_TYPE_SERVICE_UUIDS_16_BIT_COMPLETEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanRecord.html#DATA_TYPE_SERVICE_UUIDS_16_BIT_PARTIAL"/>
        /// </summary>
        public static int DATA_TYPE_SERVICE_UUIDS_16_BIT_PARTIAL { get { if (!_DATA_TYPE_SERVICE_UUIDS_16_BIT_PARTIALReady) { _DATA_TYPE_SERVICE_UUIDS_16_BIT_PARTIALContent = SGetField<int>(LocalBridgeClazz, "DATA_TYPE_SERVICE_UUIDS_16_BIT_PARTIAL"); _DATA_TYPE_SERVICE_UUIDS_16_BIT_PARTIALReady = true; } return _DATA_TYPE_SERVICE_UUIDS_16_BIT_PARTIALContent; } }
        private static int _DATA_TYPE_SERVICE_UUIDS_16_BIT_PARTIALContent = default;
        private static bool _DATA_TYPE_SERVICE_UUIDS_16_BIT_PARTIALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanRecord.html#DATA_TYPE_SERVICE_UUIDS_32_BIT_COMPLETE"/>
        /// </summary>
        public static int DATA_TYPE_SERVICE_UUIDS_32_BIT_COMPLETE { get { if (!_DATA_TYPE_SERVICE_UUIDS_32_BIT_COMPLETEReady) { _DATA_TYPE_SERVICE_UUIDS_32_BIT_COMPLETEContent = SGetField<int>(LocalBridgeClazz, "DATA_TYPE_SERVICE_UUIDS_32_BIT_COMPLETE"); _DATA_TYPE_SERVICE_UUIDS_32_BIT_COMPLETEReady = true; } return _DATA_TYPE_SERVICE_UUIDS_32_BIT_COMPLETEContent; } }
        private static int _DATA_TYPE_SERVICE_UUIDS_32_BIT_COMPLETEContent = default;
        private static bool _DATA_TYPE_SERVICE_UUIDS_32_BIT_COMPLETEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanRecord.html#DATA_TYPE_SERVICE_UUIDS_32_BIT_PARTIAL"/>
        /// </summary>
        public static int DATA_TYPE_SERVICE_UUIDS_32_BIT_PARTIAL { get { if (!_DATA_TYPE_SERVICE_UUIDS_32_BIT_PARTIALReady) { _DATA_TYPE_SERVICE_UUIDS_32_BIT_PARTIALContent = SGetField<int>(LocalBridgeClazz, "DATA_TYPE_SERVICE_UUIDS_32_BIT_PARTIAL"); _DATA_TYPE_SERVICE_UUIDS_32_BIT_PARTIALReady = true; } return _DATA_TYPE_SERVICE_UUIDS_32_BIT_PARTIALContent; } }
        private static int _DATA_TYPE_SERVICE_UUIDS_32_BIT_PARTIALContent = default;
        private static bool _DATA_TYPE_SERVICE_UUIDS_32_BIT_PARTIALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanRecord.html#DATA_TYPE_SIMPLE_PAIRING_HASH_C"/>
        /// </summary>
        public static int DATA_TYPE_SIMPLE_PAIRING_HASH_C { get { if (!_DATA_TYPE_SIMPLE_PAIRING_HASH_CReady) { _DATA_TYPE_SIMPLE_PAIRING_HASH_CContent = SGetField<int>(LocalBridgeClazz, "DATA_TYPE_SIMPLE_PAIRING_HASH_C"); _DATA_TYPE_SIMPLE_PAIRING_HASH_CReady = true; } return _DATA_TYPE_SIMPLE_PAIRING_HASH_CContent; } }
        private static int _DATA_TYPE_SIMPLE_PAIRING_HASH_CContent = default;
        private static bool _DATA_TYPE_SIMPLE_PAIRING_HASH_CReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanRecord.html#DATA_TYPE_SIMPLE_PAIRING_HASH_C_256"/>
        /// </summary>
        public static int DATA_TYPE_SIMPLE_PAIRING_HASH_C_256 { get { if (!_DATA_TYPE_SIMPLE_PAIRING_HASH_C_256Ready) { _DATA_TYPE_SIMPLE_PAIRING_HASH_C_256Content = SGetField<int>(LocalBridgeClazz, "DATA_TYPE_SIMPLE_PAIRING_HASH_C_256"); _DATA_TYPE_SIMPLE_PAIRING_HASH_C_256Ready = true; } return _DATA_TYPE_SIMPLE_PAIRING_HASH_C_256Content; } }
        private static int _DATA_TYPE_SIMPLE_PAIRING_HASH_C_256Content = default;
        private static bool _DATA_TYPE_SIMPLE_PAIRING_HASH_C_256Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanRecord.html#DATA_TYPE_SIMPLE_PAIRING_RANDOMIZER_R"/>
        /// </summary>
        public static int DATA_TYPE_SIMPLE_PAIRING_RANDOMIZER_R { get { if (!_DATA_TYPE_SIMPLE_PAIRING_RANDOMIZER_RReady) { _DATA_TYPE_SIMPLE_PAIRING_RANDOMIZER_RContent = SGetField<int>(LocalBridgeClazz, "DATA_TYPE_SIMPLE_PAIRING_RANDOMIZER_R"); _DATA_TYPE_SIMPLE_PAIRING_RANDOMIZER_RReady = true; } return _DATA_TYPE_SIMPLE_PAIRING_RANDOMIZER_RContent; } }
        private static int _DATA_TYPE_SIMPLE_PAIRING_RANDOMIZER_RContent = default;
        private static bool _DATA_TYPE_SIMPLE_PAIRING_RANDOMIZER_RReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanRecord.html#DATA_TYPE_SIMPLE_PAIRING_RANDOMIZER_R_256"/>
        /// </summary>
        public static int DATA_TYPE_SIMPLE_PAIRING_RANDOMIZER_R_256 { get { if (!_DATA_TYPE_SIMPLE_PAIRING_RANDOMIZER_R_256Ready) { _DATA_TYPE_SIMPLE_PAIRING_RANDOMIZER_R_256Content = SGetField<int>(LocalBridgeClazz, "DATA_TYPE_SIMPLE_PAIRING_RANDOMIZER_R_256"); _DATA_TYPE_SIMPLE_PAIRING_RANDOMIZER_R_256Ready = true; } return _DATA_TYPE_SIMPLE_PAIRING_RANDOMIZER_R_256Content; } }
        private static int _DATA_TYPE_SIMPLE_PAIRING_RANDOMIZER_R_256Content = default;
        private static bool _DATA_TYPE_SIMPLE_PAIRING_RANDOMIZER_R_256Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanRecord.html#DATA_TYPE_SLAVE_CONNECTION_INTERVAL_RANGE"/>
        /// </summary>
        public static int DATA_TYPE_SLAVE_CONNECTION_INTERVAL_RANGE { get { if (!_DATA_TYPE_SLAVE_CONNECTION_INTERVAL_RANGEReady) { _DATA_TYPE_SLAVE_CONNECTION_INTERVAL_RANGEContent = SGetField<int>(LocalBridgeClazz, "DATA_TYPE_SLAVE_CONNECTION_INTERVAL_RANGE"); _DATA_TYPE_SLAVE_CONNECTION_INTERVAL_RANGEReady = true; } return _DATA_TYPE_SLAVE_CONNECTION_INTERVAL_RANGEContent; } }
        private static int _DATA_TYPE_SLAVE_CONNECTION_INTERVAL_RANGEContent = default;
        private static bool _DATA_TYPE_SLAVE_CONNECTION_INTERVAL_RANGEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanRecord.html#DATA_TYPE_TRANSPORT_DISCOVERY_DATA"/>
        /// </summary>
        public static int DATA_TYPE_TRANSPORT_DISCOVERY_DATA { get { if (!_DATA_TYPE_TRANSPORT_DISCOVERY_DATAReady) { _DATA_TYPE_TRANSPORT_DISCOVERY_DATAContent = SGetField<int>(LocalBridgeClazz, "DATA_TYPE_TRANSPORT_DISCOVERY_DATA"); _DATA_TYPE_TRANSPORT_DISCOVERY_DATAReady = true; } return _DATA_TYPE_TRANSPORT_DISCOVERY_DATAContent; } }
        private static int _DATA_TYPE_TRANSPORT_DISCOVERY_DATAContent = default;
        private static bool _DATA_TYPE_TRANSPORT_DISCOVERY_DATAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanRecord.html#DATA_TYPE_TX_POWER_LEVEL"/>
        /// </summary>
        public static int DATA_TYPE_TX_POWER_LEVEL { get { if (!_DATA_TYPE_TX_POWER_LEVELReady) { _DATA_TYPE_TX_POWER_LEVELContent = SGetField<int>(LocalBridgeClazz, "DATA_TYPE_TX_POWER_LEVEL"); _DATA_TYPE_TX_POWER_LEVELReady = true; } return _DATA_TYPE_TX_POWER_LEVELContent; } }
        private static int _DATA_TYPE_TX_POWER_LEVELContent = default;
        private static bool _DATA_TYPE_TX_POWER_LEVELReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanRecord.html#DATA_TYPE_URI"/>
        /// </summary>
        public static int DATA_TYPE_URI { get { if (!_DATA_TYPE_URIReady) { _DATA_TYPE_URIContent = SGetField<int>(LocalBridgeClazz, "DATA_TYPE_URI"); _DATA_TYPE_URIReady = true; } return _DATA_TYPE_URIContent; } }
        private static int _DATA_TYPE_URIContent = default;
        private static bool _DATA_TYPE_URIReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanRecord.html#getManufacturerSpecificData()"/>
        /// </summary>
        /// <returns><see cref="Android.Util.SparseArray"/></returns>
        public Android.Util.SparseArray<byte[]> GetManufacturerSpecificData()
        {
            return IExecuteWithSignature<Android.Util.SparseArray<byte[]>>("getManufacturerSpecificData", "()Landroid/util/SparseArray;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanRecord.html#getBytes()"/>
        /// </summary>
        /// <returns><see cref="byte"/></returns>
        public byte[] GetBytes()
        {
            return IExecuteWithSignatureArray<byte>("getBytes", "()[B");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanRecord.html#getManufacturerSpecificData(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="byte"/></returns>
        public byte[] GetManufacturerSpecificData(int arg0)
        {
            return IExecuteWithSignatureArray<byte>("getManufacturerSpecificData", "(I)[B", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanRecord.html#getServiceData(android.os.ParcelUuid)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.ParcelUuid"/></param>
        /// <returns><see cref="byte"/></returns>
        public byte[] GetServiceData(Android.Os.ParcelUuid arg0)
        {
            return IExecuteWithSignatureArray<byte>("getServiceData", "(Landroid/os/ParcelUuid;)[B", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanRecord.html#getAdvertiseFlags()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetAdvertiseFlags()
        {
            return IExecuteWithSignature<int>("getAdvertiseFlags", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanRecord.html#getTxPowerLevel()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetTxPowerLevel()
        {
            return IExecuteWithSignature<int>("getTxPowerLevel", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanRecord.html#getDeviceName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetDeviceName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getDeviceName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanRecord.html#getServiceSolicitationUuids()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Os.ParcelUuid> GetServiceSolicitationUuids()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Os.ParcelUuid>>("getServiceSolicitationUuids", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanRecord.html#getServiceUuids()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Os.ParcelUuid> GetServiceUuids()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Os.ParcelUuid>>("getServiceUuids", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanRecord.html#getServiceData()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<Android.Os.ParcelUuid, byte[]> GetServiceData()
        {
            return IExecuteWithSignature<Java.Util.Map<Android.Os.ParcelUuid, byte[]>>("getServiceData", "()Ljava/util/Map;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanRecord.html#getAdvertisingDataMap()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<Java.Lang.Integer, byte[]> GetAdvertisingDataMap()
        {
            return IExecuteWithSignature<Java.Util.Map<Java.Lang.Integer, byte[]>>("getAdvertisingDataMap", "()Ljava/util/Map;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}