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
*  This file is generated by MASES.JNetReflector (ver. 2.5.10.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Bluetooth
{
    #region BluetoothManager declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothManager.html"/>
    /// </summary>
    public partial class BluetoothManager : MASES.JCOBridge.C2JBridge.JVMBridgeBase<BluetoothManager>
    {
        const string _bridgeClassName = "android.bluetooth.BluetoothManager";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public BluetoothManager() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public BluetoothManager(params object[] args) : base(args) { }
    
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
    
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;
    
        // TODO: complete the class
    
    }
    #endregion

    #region BluetoothManager implementation
    public partial class BluetoothManager
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
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothManager.html#getAdapter()"/>
        /// </summary>
        /// <returns><see cref="Android.Bluetooth.BluetoothAdapter"/></returns>
        public Android.Bluetooth.BluetoothAdapter GetAdapter()
        {
            return IExecuteWithSignature<Android.Bluetooth.BluetoothAdapter>("getAdapter", "()Landroid/bluetooth/BluetoothAdapter;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothManager.html#openGattServer(android.content.Context,android.bluetooth.BluetoothGattServerCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Bluetooth.BluetoothGattServerCallback"/></param>
        /// <returns><see cref="Android.Bluetooth.BluetoothGattServer"/></returns>
        public Android.Bluetooth.BluetoothGattServer OpenGattServer(Android.Content.Context arg0, Android.Bluetooth.BluetoothGattServerCallback arg1)
        {
            return IExecuteWithSignature<Android.Bluetooth.BluetoothGattServer>("openGattServer", "(Landroid/content/Context;Landroid/bluetooth/BluetoothGattServerCallback;)Landroid/bluetooth/BluetoothGattServer;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothManager.html#getConnectionState(android.bluetooth.BluetoothDevice,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Bluetooth.BluetoothDevice"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetConnectionState(Android.Bluetooth.BluetoothDevice arg0, int arg1)
        {
            return IExecuteWithSignature<int>("getConnectionState", "(Landroid/bluetooth/BluetoothDevice;I)I", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothManager.html#getConnectedDevices(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Bluetooth.BluetoothDevice> GetConnectedDevices(int arg0)
        {
            return IExecuteWithSignature<Java.Util.List<Android.Bluetooth.BluetoothDevice>>("getConnectedDevices", "(I)Ljava/util/List;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothManager.html#getDevicesMatchingConnectionStates(int,int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Bluetooth.BluetoothDevice> GetDevicesMatchingConnectionStates(int arg0, int[] arg1)
        {
            return IExecuteWithSignature<Java.Util.List<Android.Bluetooth.BluetoothDevice>>("getDevicesMatchingConnectionStates", "(I[I)Ljava/util/List;", arg0, arg1);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}