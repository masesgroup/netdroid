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

namespace Android.Mtp
{
    #region MtpEvent
    public partial class MtpEvent
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/mtp/MtpEvent.html#EVENT_CANCEL_TRANSACTION"/>
        /// </summary>
        public static int EVENT_CANCEL_TRANSACTION { get { if (!_EVENT_CANCEL_TRANSACTIONReady) { _EVENT_CANCEL_TRANSACTIONContent = SGetField<int>(LocalBridgeClazz, "EVENT_CANCEL_TRANSACTION"); _EVENT_CANCEL_TRANSACTIONReady = true; } return _EVENT_CANCEL_TRANSACTIONContent; } }
        private static int _EVENT_CANCEL_TRANSACTIONContent = default;
        private static bool _EVENT_CANCEL_TRANSACTIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/mtp/MtpEvent.html#EVENT_CAPTURE_COMPLETE"/>
        /// </summary>
        public static int EVENT_CAPTURE_COMPLETE { get { if (!_EVENT_CAPTURE_COMPLETEReady) { _EVENT_CAPTURE_COMPLETEContent = SGetField<int>(LocalBridgeClazz, "EVENT_CAPTURE_COMPLETE"); _EVENT_CAPTURE_COMPLETEReady = true; } return _EVENT_CAPTURE_COMPLETEContent; } }
        private static int _EVENT_CAPTURE_COMPLETEContent = default;
        private static bool _EVENT_CAPTURE_COMPLETEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/mtp/MtpEvent.html#EVENT_DEVICE_INFO_CHANGED"/>
        /// </summary>
        public static int EVENT_DEVICE_INFO_CHANGED { get { if (!_EVENT_DEVICE_INFO_CHANGEDReady) { _EVENT_DEVICE_INFO_CHANGEDContent = SGetField<int>(LocalBridgeClazz, "EVENT_DEVICE_INFO_CHANGED"); _EVENT_DEVICE_INFO_CHANGEDReady = true; } return _EVENT_DEVICE_INFO_CHANGEDContent; } }
        private static int _EVENT_DEVICE_INFO_CHANGEDContent = default;
        private static bool _EVENT_DEVICE_INFO_CHANGEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/mtp/MtpEvent.html#EVENT_DEVICE_PROP_CHANGED"/>
        /// </summary>
        public static int EVENT_DEVICE_PROP_CHANGED { get { if (!_EVENT_DEVICE_PROP_CHANGEDReady) { _EVENT_DEVICE_PROP_CHANGEDContent = SGetField<int>(LocalBridgeClazz, "EVENT_DEVICE_PROP_CHANGED"); _EVENT_DEVICE_PROP_CHANGEDReady = true; } return _EVENT_DEVICE_PROP_CHANGEDContent; } }
        private static int _EVENT_DEVICE_PROP_CHANGEDContent = default;
        private static bool _EVENT_DEVICE_PROP_CHANGEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/mtp/MtpEvent.html#EVENT_DEVICE_RESET"/>
        /// </summary>
        public static int EVENT_DEVICE_RESET { get { if (!_EVENT_DEVICE_RESETReady) { _EVENT_DEVICE_RESETContent = SGetField<int>(LocalBridgeClazz, "EVENT_DEVICE_RESET"); _EVENT_DEVICE_RESETReady = true; } return _EVENT_DEVICE_RESETContent; } }
        private static int _EVENT_DEVICE_RESETContent = default;
        private static bool _EVENT_DEVICE_RESETReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/mtp/MtpEvent.html#EVENT_OBJECT_ADDED"/>
        /// </summary>
        public static int EVENT_OBJECT_ADDED { get { if (!_EVENT_OBJECT_ADDEDReady) { _EVENT_OBJECT_ADDEDContent = SGetField<int>(LocalBridgeClazz, "EVENT_OBJECT_ADDED"); _EVENT_OBJECT_ADDEDReady = true; } return _EVENT_OBJECT_ADDEDContent; } }
        private static int _EVENT_OBJECT_ADDEDContent = default;
        private static bool _EVENT_OBJECT_ADDEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/mtp/MtpEvent.html#EVENT_OBJECT_INFO_CHANGED"/>
        /// </summary>
        public static int EVENT_OBJECT_INFO_CHANGED { get { if (!_EVENT_OBJECT_INFO_CHANGEDReady) { _EVENT_OBJECT_INFO_CHANGEDContent = SGetField<int>(LocalBridgeClazz, "EVENT_OBJECT_INFO_CHANGED"); _EVENT_OBJECT_INFO_CHANGEDReady = true; } return _EVENT_OBJECT_INFO_CHANGEDContent; } }
        private static int _EVENT_OBJECT_INFO_CHANGEDContent = default;
        private static bool _EVENT_OBJECT_INFO_CHANGEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/mtp/MtpEvent.html#EVENT_OBJECT_PROP_CHANGED"/>
        /// </summary>
        public static int EVENT_OBJECT_PROP_CHANGED { get { if (!_EVENT_OBJECT_PROP_CHANGEDReady) { _EVENT_OBJECT_PROP_CHANGEDContent = SGetField<int>(LocalBridgeClazz, "EVENT_OBJECT_PROP_CHANGED"); _EVENT_OBJECT_PROP_CHANGEDReady = true; } return _EVENT_OBJECT_PROP_CHANGEDContent; } }
        private static int _EVENT_OBJECT_PROP_CHANGEDContent = default;
        private static bool _EVENT_OBJECT_PROP_CHANGEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/mtp/MtpEvent.html#EVENT_OBJECT_PROP_DESC_CHANGED"/>
        /// </summary>
        public static int EVENT_OBJECT_PROP_DESC_CHANGED { get { if (!_EVENT_OBJECT_PROP_DESC_CHANGEDReady) { _EVENT_OBJECT_PROP_DESC_CHANGEDContent = SGetField<int>(LocalBridgeClazz, "EVENT_OBJECT_PROP_DESC_CHANGED"); _EVENT_OBJECT_PROP_DESC_CHANGEDReady = true; } return _EVENT_OBJECT_PROP_DESC_CHANGEDContent; } }
        private static int _EVENT_OBJECT_PROP_DESC_CHANGEDContent = default;
        private static bool _EVENT_OBJECT_PROP_DESC_CHANGEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/mtp/MtpEvent.html#EVENT_OBJECT_REFERENCES_CHANGED"/>
        /// </summary>
        public static int EVENT_OBJECT_REFERENCES_CHANGED { get { if (!_EVENT_OBJECT_REFERENCES_CHANGEDReady) { _EVENT_OBJECT_REFERENCES_CHANGEDContent = SGetField<int>(LocalBridgeClazz, "EVENT_OBJECT_REFERENCES_CHANGED"); _EVENT_OBJECT_REFERENCES_CHANGEDReady = true; } return _EVENT_OBJECT_REFERENCES_CHANGEDContent; } }
        private static int _EVENT_OBJECT_REFERENCES_CHANGEDContent = default;
        private static bool _EVENT_OBJECT_REFERENCES_CHANGEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/mtp/MtpEvent.html#EVENT_OBJECT_REMOVED"/>
        /// </summary>
        public static int EVENT_OBJECT_REMOVED { get { if (!_EVENT_OBJECT_REMOVEDReady) { _EVENT_OBJECT_REMOVEDContent = SGetField<int>(LocalBridgeClazz, "EVENT_OBJECT_REMOVED"); _EVENT_OBJECT_REMOVEDReady = true; } return _EVENT_OBJECT_REMOVEDContent; } }
        private static int _EVENT_OBJECT_REMOVEDContent = default;
        private static bool _EVENT_OBJECT_REMOVEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/mtp/MtpEvent.html#EVENT_REQUEST_OBJECT_TRANSFER"/>
        /// </summary>
        public static int EVENT_REQUEST_OBJECT_TRANSFER { get { if (!_EVENT_REQUEST_OBJECT_TRANSFERReady) { _EVENT_REQUEST_OBJECT_TRANSFERContent = SGetField<int>(LocalBridgeClazz, "EVENT_REQUEST_OBJECT_TRANSFER"); _EVENT_REQUEST_OBJECT_TRANSFERReady = true; } return _EVENT_REQUEST_OBJECT_TRANSFERContent; } }
        private static int _EVENT_REQUEST_OBJECT_TRANSFERContent = default;
        private static bool _EVENT_REQUEST_OBJECT_TRANSFERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/mtp/MtpEvent.html#EVENT_STORAGE_INFO_CHANGED"/>
        /// </summary>
        public static int EVENT_STORAGE_INFO_CHANGED { get { if (!_EVENT_STORAGE_INFO_CHANGEDReady) { _EVENT_STORAGE_INFO_CHANGEDContent = SGetField<int>(LocalBridgeClazz, "EVENT_STORAGE_INFO_CHANGED"); _EVENT_STORAGE_INFO_CHANGEDReady = true; } return _EVENT_STORAGE_INFO_CHANGEDContent; } }
        private static int _EVENT_STORAGE_INFO_CHANGEDContent = default;
        private static bool _EVENT_STORAGE_INFO_CHANGEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/mtp/MtpEvent.html#EVENT_STORE_ADDED"/>
        /// </summary>
        public static int EVENT_STORE_ADDED { get { if (!_EVENT_STORE_ADDEDReady) { _EVENT_STORE_ADDEDContent = SGetField<int>(LocalBridgeClazz, "EVENT_STORE_ADDED"); _EVENT_STORE_ADDEDReady = true; } return _EVENT_STORE_ADDEDContent; } }
        private static int _EVENT_STORE_ADDEDContent = default;
        private static bool _EVENT_STORE_ADDEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/mtp/MtpEvent.html#EVENT_STORE_FULL"/>
        /// </summary>
        public static int EVENT_STORE_FULL { get { if (!_EVENT_STORE_FULLReady) { _EVENT_STORE_FULLContent = SGetField<int>(LocalBridgeClazz, "EVENT_STORE_FULL"); _EVENT_STORE_FULLReady = true; } return _EVENT_STORE_FULLContent; } }
        private static int _EVENT_STORE_FULLContent = default;
        private static bool _EVENT_STORE_FULLReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/mtp/MtpEvent.html#EVENT_STORE_REMOVED"/>
        /// </summary>
        public static int EVENT_STORE_REMOVED { get { if (!_EVENT_STORE_REMOVEDReady) { _EVENT_STORE_REMOVEDContent = SGetField<int>(LocalBridgeClazz, "EVENT_STORE_REMOVED"); _EVENT_STORE_REMOVEDReady = true; } return _EVENT_STORE_REMOVEDContent; } }
        private static int _EVENT_STORE_REMOVEDContent = default;
        private static bool _EVENT_STORE_REMOVEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/mtp/MtpEvent.html#EVENT_UNDEFINED"/>
        /// </summary>
        public static int EVENT_UNDEFINED { get { if (!_EVENT_UNDEFINEDReady) { _EVENT_UNDEFINEDContent = SGetField<int>(LocalBridgeClazz, "EVENT_UNDEFINED"); _EVENT_UNDEFINEDReady = true; } return _EVENT_UNDEFINEDContent; } }
        private static int _EVENT_UNDEFINEDContent = default;
        private static bool _EVENT_UNDEFINEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/mtp/MtpEvent.html#EVENT_UNREPORTED_STATUS"/>
        /// </summary>
        public static int EVENT_UNREPORTED_STATUS { get { if (!_EVENT_UNREPORTED_STATUSReady) { _EVENT_UNREPORTED_STATUSContent = SGetField<int>(LocalBridgeClazz, "EVENT_UNREPORTED_STATUS"); _EVENT_UNREPORTED_STATUSReady = true; } return _EVENT_UNREPORTED_STATUSContent; } }
        private static int _EVENT_UNREPORTED_STATUSContent = default;
        private static bool _EVENT_UNREPORTED_STATUSReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/mtp/MtpEvent.html#getDevicePropCode()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetDevicePropCode()
        {
            return IExecuteWithSignature<int>("getDevicePropCode", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/mtp/MtpEvent.html#getEventCode()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetEventCode()
        {
            return IExecuteWithSignature<int>("getEventCode", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/mtp/MtpEvent.html#getObjectFormatCode()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetObjectFormatCode()
        {
            return IExecuteWithSignature<int>("getObjectFormatCode", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/mtp/MtpEvent.html#getObjectHandle()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetObjectHandle()
        {
            return IExecuteWithSignature<int>("getObjectHandle", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/mtp/MtpEvent.html#getObjectPropCode()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetObjectPropCode()
        {
            return IExecuteWithSignature<int>("getObjectPropCode", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/mtp/MtpEvent.html#getParameter1()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetParameter1()
        {
            return IExecuteWithSignature<int>("getParameter1", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/mtp/MtpEvent.html#getParameter2()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetParameter2()
        {
            return IExecuteWithSignature<int>("getParameter2", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/mtp/MtpEvent.html#getParameter3()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetParameter3()
        {
            return IExecuteWithSignature<int>("getParameter3", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/mtp/MtpEvent.html#getStorageId()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetStorageId()
        {
            return IExecuteWithSignature<int>("getStorageId", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/mtp/MtpEvent.html#getTransactionId()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetTransactionId()
        {
            return IExecuteWithSignature<int>("getTransactionId", "()I");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}