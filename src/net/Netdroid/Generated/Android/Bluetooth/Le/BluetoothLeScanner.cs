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

namespace Android.Bluetooth.Le
{
    #region BluetoothLeScanner
    public partial class BluetoothLeScanner
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/BluetoothLeScanner.html#EXTRA_CALLBACK_TYPE"/>
        /// </summary>
        public static Java.Lang.String EXTRA_CALLBACK_TYPE { get { if (!_EXTRA_CALLBACK_TYPEReady) { _EXTRA_CALLBACK_TYPEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_CALLBACK_TYPE"); _EXTRA_CALLBACK_TYPEReady = true; } return _EXTRA_CALLBACK_TYPEContent; } }
        private static Java.Lang.String _EXTRA_CALLBACK_TYPEContent = default;
        private static bool _EXTRA_CALLBACK_TYPEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/BluetoothLeScanner.html#EXTRA_ERROR_CODE"/>
        /// </summary>
        public static Java.Lang.String EXTRA_ERROR_CODE { get { if (!_EXTRA_ERROR_CODEReady) { _EXTRA_ERROR_CODEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_ERROR_CODE"); _EXTRA_ERROR_CODEReady = true; } return _EXTRA_ERROR_CODEContent; } }
        private static Java.Lang.String _EXTRA_ERROR_CODEContent = default;
        private static bool _EXTRA_ERROR_CODEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/BluetoothLeScanner.html#EXTRA_LIST_SCAN_RESULT"/>
        /// </summary>
        public static Java.Lang.String EXTRA_LIST_SCAN_RESULT { get { if (!_EXTRA_LIST_SCAN_RESULTReady) { _EXTRA_LIST_SCAN_RESULTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_LIST_SCAN_RESULT"); _EXTRA_LIST_SCAN_RESULTReady = true; } return _EXTRA_LIST_SCAN_RESULTContent; } }
        private static Java.Lang.String _EXTRA_LIST_SCAN_RESULTContent = default;
        private static bool _EXTRA_LIST_SCAN_RESULTReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/BluetoothLeScanner.html#startScan(java.util.List,android.bluetooth.le.ScanSettings,android.app.PendingIntent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        /// <param name="arg1"><see cref="Android.Bluetooth.Le.ScanSettings"/></param>
        /// <param name="arg2"><see cref="Android.App.PendingIntent"/></param>
        /// <returns><see cref="int"/></returns>
        public int StartScan(Java.Util.List<Android.Bluetooth.Le.ScanFilter> arg0, Android.Bluetooth.Le.ScanSettings arg1, Android.App.PendingIntent arg2)
        {
            return IExecute<int>("startScan", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/BluetoothLeScanner.html#flushPendingScanResults(android.bluetooth.le.ScanCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Bluetooth.Le.ScanCallback"/></param>
        public void FlushPendingScanResults(Android.Bluetooth.Le.ScanCallback arg0)
        {
            IExecuteWithSignature("flushPendingScanResults", "(Landroid/bluetooth/le/ScanCallback;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/BluetoothLeScanner.html#startScan(android.bluetooth.le.ScanCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Bluetooth.Le.ScanCallback"/></param>
        public void StartScan(Android.Bluetooth.Le.ScanCallback arg0)
        {
            IExecuteWithSignature("startScan", "(Landroid/bluetooth/le/ScanCallback;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/BluetoothLeScanner.html#startScan(java.util.List,android.bluetooth.le.ScanSettings,android.bluetooth.le.ScanCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        /// <param name="arg1"><see cref="Android.Bluetooth.Le.ScanSettings"/></param>
        /// <param name="arg2"><see cref="Android.Bluetooth.Le.ScanCallback"/></param>
        public void StartScan(Java.Util.List<Android.Bluetooth.Le.ScanFilter> arg0, Android.Bluetooth.Le.ScanSettings arg1, Android.Bluetooth.Le.ScanCallback arg2)
        {
            IExecute("startScan", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/BluetoothLeScanner.html#stopScan(android.app.PendingIntent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.PendingIntent"/></param>
        public void StopScan(Android.App.PendingIntent arg0)
        {
            IExecuteWithSignature("stopScan", "(Landroid/app/PendingIntent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/BluetoothLeScanner.html#stopScan(android.bluetooth.le.ScanCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Bluetooth.Le.ScanCallback"/></param>
        public void StopScan(Android.Bluetooth.Le.ScanCallback arg0)
        {
            IExecuteWithSignature("stopScan", "(Landroid/bluetooth/le/ScanCallback;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}