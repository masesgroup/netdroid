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

namespace Android.Bluetooth
{
    #region BluetoothGattService
    public partial class BluetoothGattService
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattService.html#%3Cinit%3E(java.util.UUID,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.UUID"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public BluetoothGattService(Java.Util.UUID arg0, int arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattService.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattService.html#SERVICE_TYPE_PRIMARY"/>
        /// </summary>
        public static int SERVICE_TYPE_PRIMARY { get { if (!_SERVICE_TYPE_PRIMARYReady) { _SERVICE_TYPE_PRIMARYContent = SGetField<int>(LocalBridgeClazz, "SERVICE_TYPE_PRIMARY"); _SERVICE_TYPE_PRIMARYReady = true; } return _SERVICE_TYPE_PRIMARYContent; } }
        private static int _SERVICE_TYPE_PRIMARYContent = default;
        private static bool _SERVICE_TYPE_PRIMARYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattService.html#SERVICE_TYPE_SECONDARY"/>
        /// </summary>
        public static int SERVICE_TYPE_SECONDARY { get { if (!_SERVICE_TYPE_SECONDARYReady) { _SERVICE_TYPE_SECONDARYContent = SGetField<int>(LocalBridgeClazz, "SERVICE_TYPE_SECONDARY"); _SERVICE_TYPE_SECONDARYReady = true; } return _SERVICE_TYPE_SECONDARYContent; } }
        private static int _SERVICE_TYPE_SECONDARYContent = default;
        private static bool _SERVICE_TYPE_SECONDARYReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattService.html#getCharacteristic(java.util.UUID)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.UUID"/></param>
        /// <returns><see cref="Android.Bluetooth.BluetoothGattCharacteristic"/></returns>
        public Android.Bluetooth.BluetoothGattCharacteristic GetCharacteristic(Java.Util.UUID arg0)
        {
            return IExecuteWithSignature<Android.Bluetooth.BluetoothGattCharacteristic>("getCharacteristic", "(Ljava/util/UUID;)Landroid/bluetooth/BluetoothGattCharacteristic;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattService.html#addCharacteristic(android.bluetooth.BluetoothGattCharacteristic)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Bluetooth.BluetoothGattCharacteristic"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool AddCharacteristic(Android.Bluetooth.BluetoothGattCharacteristic arg0)
        {
            return IExecuteWithSignature<bool>("addCharacteristic", "(Landroid/bluetooth/BluetoothGattCharacteristic;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattService.html#addService(android.bluetooth.BluetoothGattService)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Bluetooth.BluetoothGattService"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool AddService(Android.Bluetooth.BluetoothGattService arg0)
        {
            return IExecuteWithSignature<bool>("addService", "(Landroid/bluetooth/BluetoothGattService;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattService.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattService.html#getInstanceId()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetInstanceId()
        {
            return IExecuteWithSignature<int>("getInstanceId", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattService.html#getType()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetType()
        {
            return IExecuteWithSignature<int>("getType", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattService.html#getCharacteristics()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Bluetooth.BluetoothGattCharacteristic> GetCharacteristics()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Bluetooth.BluetoothGattCharacteristic>>("getCharacteristics", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattService.html#getIncludedServices()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Bluetooth.BluetoothGattService> GetIncludedServices()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Bluetooth.BluetoothGattService>>("getIncludedServices", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattService.html#getUuid()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.UUID"/></returns>
        public Java.Util.UUID GetUuid()
        {
            return IExecuteWithSignature<Java.Util.UUID>("getUuid", "()Ljava/util/UUID;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattService.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecute("writeToParcel", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}