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
    #region BluetoothGattServer
    public partial class BluetoothGattServer
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
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattServer.html#getService(java.util.UUID)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.UUID"/></param>
        /// <returns><see cref="Android.Bluetooth.BluetoothGattService"/></returns>
        public Android.Bluetooth.BluetoothGattService GetService(Java.Util.UUID arg0)
        {
            return IExecuteWithSignature<Android.Bluetooth.BluetoothGattService>("getService", "(Ljava/util/UUID;)Landroid/bluetooth/BluetoothGattService;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattServer.html#addService(android.bluetooth.BluetoothGattService)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Bluetooth.BluetoothGattService"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool AddService(Android.Bluetooth.BluetoothGattService arg0)
        {
            return IExecuteWithSignature<bool>("addService", "(Landroid/bluetooth/BluetoothGattService;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattServer.html#connect(android.bluetooth.BluetoothDevice,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Bluetooth.BluetoothDevice"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Connect(Android.Bluetooth.BluetoothDevice arg0, bool arg1)
        {
            return IExecute<bool>("connect", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattServer.html#notifyCharacteristicChanged(android.bluetooth.BluetoothDevice,android.bluetooth.BluetoothGattCharacteristic,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Bluetooth.BluetoothDevice"/></param>
        /// <param name="arg1"><see cref="Android.Bluetooth.BluetoothGattCharacteristic"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool NotifyCharacteristicChanged(Android.Bluetooth.BluetoothDevice arg0, Android.Bluetooth.BluetoothGattCharacteristic arg1, bool arg2)
        {
            return IExecute<bool>("notifyCharacteristicChanged", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattServer.html#removeService(android.bluetooth.BluetoothGattService)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Bluetooth.BluetoothGattService"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool RemoveService(Android.Bluetooth.BluetoothGattService arg0)
        {
            return IExecuteWithSignature<bool>("removeService", "(Landroid/bluetooth/BluetoothGattService;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattServer.html#sendResponse(android.bluetooth.BluetoothDevice,int,int,int,byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Bluetooth.BluetoothDevice"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="byte"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SendResponse(Android.Bluetooth.BluetoothDevice arg0, int arg1, int arg2, int arg3, byte[] arg4)
        {
            return IExecute<bool>("sendResponse", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattServer.html#getConnectionState(android.bluetooth.BluetoothDevice)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Bluetooth.BluetoothDevice"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetConnectionState(Android.Bluetooth.BluetoothDevice arg0)
        {
            return IExecuteWithSignature<int>("getConnectionState", "(Landroid/bluetooth/BluetoothDevice;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattServer.html#notifyCharacteristicChanged(android.bluetooth.BluetoothDevice,android.bluetooth.BluetoothGattCharacteristic,boolean,byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Bluetooth.BluetoothDevice"/></param>
        /// <param name="arg1"><see cref="Android.Bluetooth.BluetoothGattCharacteristic"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <param name="arg3"><see cref="byte"/></param>
        /// <returns><see cref="int"/></returns>
        public int NotifyCharacteristicChanged(Android.Bluetooth.BluetoothDevice arg0, Android.Bluetooth.BluetoothGattCharacteristic arg1, bool arg2, byte[] arg3)
        {
            return IExecute<int>("notifyCharacteristicChanged", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattServer.html#getConnectedDevices()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Bluetooth.BluetoothDevice> GetConnectedDevices()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Bluetooth.BluetoothDevice>>("getConnectedDevices", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattServer.html#getDevicesMatchingConnectionStates(int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Bluetooth.BluetoothDevice> GetDevicesMatchingConnectionStates(int[] arg0)
        {
            return IExecuteWithSignature<Java.Util.List<Android.Bluetooth.BluetoothDevice>>("getDevicesMatchingConnectionStates", "([I)Ljava/util/List;", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattServer.html#getServices()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Bluetooth.BluetoothGattService> GetServices()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Bluetooth.BluetoothGattService>>("getServices", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattServer.html#cancelConnection(android.bluetooth.BluetoothDevice)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Bluetooth.BluetoothDevice"/></param>
        public void CancelConnection(Android.Bluetooth.BluetoothDevice arg0)
        {
            IExecuteWithSignature("cancelConnection", "(Landroid/bluetooth/BluetoothDevice;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattServer.html#clearServices()"/>
        /// </summary>
        public void ClearServices()
        {
            IExecuteWithSignature("clearServices", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattServer.html#close()"/>
        /// </summary>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattServer.html#readPhy(android.bluetooth.BluetoothDevice)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Bluetooth.BluetoothDevice"/></param>
        public void ReadPhy(Android.Bluetooth.BluetoothDevice arg0)
        {
            IExecuteWithSignature("readPhy", "(Landroid/bluetooth/BluetoothDevice;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattServer.html#setPreferredPhy(android.bluetooth.BluetoothDevice,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Bluetooth.BluetoothDevice"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public void SetPreferredPhy(Android.Bluetooth.BluetoothDevice arg0, int arg1, int arg2, int arg3)
        {
            IExecute("setPreferredPhy", arg0, arg1, arg2, arg3);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}