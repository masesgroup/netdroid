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

namespace Android.Bluetooth
{
    #region BluetoothGattServerCallback
    public partial class BluetoothGattServerCallback
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
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattServerCallback.html#onCharacteristicReadRequest(android.bluetooth.BluetoothDevice,int,int,android.bluetooth.BluetoothGattCharacteristic)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Bluetooth.BluetoothDevice"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Android.Bluetooth.BluetoothGattCharacteristic"/></param>
        public void OnCharacteristicReadRequest(Android.Bluetooth.BluetoothDevice arg0, int arg1, int arg2, Android.Bluetooth.BluetoothGattCharacteristic arg3)
        {
            IExecute("onCharacteristicReadRequest", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattServerCallback.html#onCharacteristicWriteRequest(android.bluetooth.BluetoothDevice,int,android.bluetooth.BluetoothGattCharacteristic,boolean,boolean,int,byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Bluetooth.BluetoothDevice"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Android.Bluetooth.BluetoothGattCharacteristic"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        /// <param name="arg4"><see cref="bool"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="byte"/></param>
        public void OnCharacteristicWriteRequest(Android.Bluetooth.BluetoothDevice arg0, int arg1, Android.Bluetooth.BluetoothGattCharacteristic arg2, bool arg3, bool arg4, int arg5, byte[] arg6)
        {
            IExecute("onCharacteristicWriteRequest", arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattServerCallback.html#onConnectionStateChange(android.bluetooth.BluetoothDevice,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Bluetooth.BluetoothDevice"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public void OnConnectionStateChange(Android.Bluetooth.BluetoothDevice arg0, int arg1, int arg2)
        {
            IExecute("onConnectionStateChange", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattServerCallback.html#onDescriptorReadRequest(android.bluetooth.BluetoothDevice,int,int,android.bluetooth.BluetoothGattDescriptor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Bluetooth.BluetoothDevice"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Android.Bluetooth.BluetoothGattDescriptor"/></param>
        public void OnDescriptorReadRequest(Android.Bluetooth.BluetoothDevice arg0, int arg1, int arg2, Android.Bluetooth.BluetoothGattDescriptor arg3)
        {
            IExecute("onDescriptorReadRequest", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattServerCallback.html#onDescriptorWriteRequest(android.bluetooth.BluetoothDevice,int,android.bluetooth.BluetoothGattDescriptor,boolean,boolean,int,byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Bluetooth.BluetoothDevice"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Android.Bluetooth.BluetoothGattDescriptor"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        /// <param name="arg4"><see cref="bool"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="byte"/></param>
        public void OnDescriptorWriteRequest(Android.Bluetooth.BluetoothDevice arg0, int arg1, Android.Bluetooth.BluetoothGattDescriptor arg2, bool arg3, bool arg4, int arg5, byte[] arg6)
        {
            IExecute("onDescriptorWriteRequest", arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattServerCallback.html#onExecuteWrite(android.bluetooth.BluetoothDevice,int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Bluetooth.BluetoothDevice"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        public void OnExecuteWrite(Android.Bluetooth.BluetoothDevice arg0, int arg1, bool arg2)
        {
            IExecute("onExecuteWrite", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattServerCallback.html#onMtuChanged(android.bluetooth.BluetoothDevice,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Bluetooth.BluetoothDevice"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void OnMtuChanged(Android.Bluetooth.BluetoothDevice arg0, int arg1)
        {
            IExecute("onMtuChanged", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattServerCallback.html#onNotificationSent(android.bluetooth.BluetoothDevice,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Bluetooth.BluetoothDevice"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void OnNotificationSent(Android.Bluetooth.BluetoothDevice arg0, int arg1)
        {
            IExecute("onNotificationSent", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattServerCallback.html#onPhyRead(android.bluetooth.BluetoothDevice,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Bluetooth.BluetoothDevice"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public void OnPhyRead(Android.Bluetooth.BluetoothDevice arg0, int arg1, int arg2, int arg3)
        {
            IExecute("onPhyRead", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattServerCallback.html#onPhyUpdate(android.bluetooth.BluetoothDevice,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Bluetooth.BluetoothDevice"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public void OnPhyUpdate(Android.Bluetooth.BluetoothDevice arg0, int arg1, int arg2, int arg3)
        {
            IExecute("onPhyUpdate", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattServerCallback.html#onServiceAdded(int,android.bluetooth.BluetoothGattService)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.Bluetooth.BluetoothGattService"/></param>
        public void OnServiceAdded(int arg0, Android.Bluetooth.BluetoothGattService arg1)
        {
            IExecute("onServiceAdded", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}