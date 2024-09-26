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

namespace Android.Hardware
{
    #region SensorEventCallback declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/hardware/SensorEventCallback.html"/>
    /// </summary>
    public partial class SensorEventCallback : MASES.JCOBridge.C2JBridge.JVMBridgeBase<SensorEventCallback>
    {
        const string _bridgeClassName = "android.hardware.SensorEventCallback";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("SensorEventCallback class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public SensorEventCallback() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("SensorEventCallback class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public SensorEventCallback(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => true;
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

    #region SensorEventCallback implementation
    public partial class SensorEventCallback
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Android.Hardware.SensorEventCallback"/> to <see cref="Android.Hardware.SensorEventListener2"/>
        /// </summary>
        public static implicit operator Android.Hardware.SensorEventListener2(Android.Hardware.SensorEventCallback t) => t.Cast<Android.Hardware.SensorEventListener2>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/SensorEventCallback.html#onAccuracyChanged(android.hardware.Sensor,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Hardware.Sensor"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void OnAccuracyChanged(Android.Hardware.Sensor arg0, int arg1)
        {
            IExecuteWithSignature("onAccuracyChanged", "(Landroid/hardware/Sensor;I)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/SensorEventCallback.html#onFlushCompleted(android.hardware.Sensor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Hardware.Sensor"/></param>
        public void OnFlushCompleted(Android.Hardware.Sensor arg0)
        {
            IExecuteWithSignature("onFlushCompleted", "(Landroid/hardware/Sensor;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/SensorEventCallback.html#onSensorAdditionalInfo(android.hardware.SensorAdditionalInfo)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Hardware.SensorAdditionalInfo"/></param>
        public void OnSensorAdditionalInfo(Android.Hardware.SensorAdditionalInfo arg0)
        {
            IExecuteWithSignature("onSensorAdditionalInfo", "(Landroid/hardware/SensorAdditionalInfo;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/SensorEventCallback.html#onSensorChanged(android.hardware.SensorEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Hardware.SensorEvent"/></param>
        public void OnSensorChanged(Android.Hardware.SensorEvent arg0)
        {
            IExecuteWithSignature("onSensorChanged", "(Landroid/hardware/SensorEvent;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}