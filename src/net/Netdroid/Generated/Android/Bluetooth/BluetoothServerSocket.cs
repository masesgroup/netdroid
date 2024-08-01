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
    #region BluetoothServerSocket
    public partial class BluetoothServerSocket
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
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothServerSocket.html#accept()"/>
        /// </summary>
        /// <returns><see cref="Android.Bluetooth.BluetoothSocket"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Android.Bluetooth.BluetoothSocket Accept()
        {
            return IExecuteWithSignature<Android.Bluetooth.BluetoothSocket>("accept", "()Landroid/bluetooth/BluetoothSocket;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothServerSocket.html#accept(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Bluetooth.BluetoothSocket"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Android.Bluetooth.BluetoothSocket Accept(int arg0)
        {
            return IExecuteWithSignature<Android.Bluetooth.BluetoothSocket>("accept", "(I)Landroid/bluetooth/BluetoothSocket;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothServerSocket.html#getPsm()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetPsm()
        {
            return IExecuteWithSignature<int>("getPsm", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothServerSocket.html#close()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}