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
*  This file is generated by MASES.JNetReflector (ver. 2.5.9.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Bluetooth.Le
{
    #region AdvertisingSet declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/bluetooth/le/AdvertisingSet.html"/>
    /// </summary>
    public partial class AdvertisingSet : MASES.JCOBridge.C2JBridge.JVMBridgeBase<AdvertisingSet>
    {
        const string _bridgeClassName = "android.bluetooth.le.AdvertisingSet";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public AdvertisingSet() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public AdvertisingSet(params object[] args) : base(args) { }

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

    #region AdvertisingSet implementation
    public partial class AdvertisingSet
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
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/AdvertisingSet.html#enableAdvertising(boolean,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public void EnableAdvertising(bool arg0, int arg1, int arg2)
        {
            IExecuteWithSignature("enableAdvertising", "(ZII)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/AdvertisingSet.html#setAdvertisingData(android.bluetooth.le.AdvertiseData)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Bluetooth.Le.AdvertiseData"/></param>
        public void SetAdvertisingData(Android.Bluetooth.Le.AdvertiseData arg0)
        {
            IExecuteWithSignature("setAdvertisingData", "(Landroid/bluetooth/le/AdvertiseData;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/AdvertisingSet.html#setAdvertisingParameters(android.bluetooth.le.AdvertisingSetParameters)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Bluetooth.Le.AdvertisingSetParameters"/></param>
        public void SetAdvertisingParameters(Android.Bluetooth.Le.AdvertisingSetParameters arg0)
        {
            IExecuteWithSignature("setAdvertisingParameters", "(Landroid/bluetooth/le/AdvertisingSetParameters;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/AdvertisingSet.html#setPeriodicAdvertisingData(android.bluetooth.le.AdvertiseData)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Bluetooth.Le.AdvertiseData"/></param>
        public void SetPeriodicAdvertisingData(Android.Bluetooth.Le.AdvertiseData arg0)
        {
            IExecuteWithSignature("setPeriodicAdvertisingData", "(Landroid/bluetooth/le/AdvertiseData;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/AdvertisingSet.html#setPeriodicAdvertisingEnabled(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetPeriodicAdvertisingEnabled(bool arg0)
        {
            IExecuteWithSignature("setPeriodicAdvertisingEnabled", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/AdvertisingSet.html#setPeriodicAdvertisingParameters(android.bluetooth.le.PeriodicAdvertisingParameters)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Bluetooth.Le.PeriodicAdvertisingParameters"/></param>
        public void SetPeriodicAdvertisingParameters(Android.Bluetooth.Le.PeriodicAdvertisingParameters arg0)
        {
            IExecuteWithSignature("setPeriodicAdvertisingParameters", "(Landroid/bluetooth/le/PeriodicAdvertisingParameters;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/AdvertisingSet.html#setScanResponseData(android.bluetooth.le.AdvertiseData)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Bluetooth.Le.AdvertiseData"/></param>
        public void SetScanResponseData(Android.Bluetooth.Le.AdvertiseData arg0)
        {
            IExecuteWithSignature("setScanResponseData", "(Landroid/bluetooth/le/AdvertiseData;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}