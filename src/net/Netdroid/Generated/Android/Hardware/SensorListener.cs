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
    #region SensorListener declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/hardware/SensorListener.html"/>
    /// </summary>
    [global::System.Obsolete()]
    public partial class SensorListener : MASES.JCOBridge.C2JBridge.JVMBridgeListener
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public SensorListener() { InitializeHandlers(); }

        const string _bridgeClassName = "org.mases.netdroid.generated.android.hardware.SensorListener";
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;

    
        // TODO: complete the class

    }
    #endregion

    #region SensorListenerDirect declaration
    /// <summary>
    /// Direct override of <see cref="SensorListener"/> or its generic type if there is one
    /// </summary>
    public partial class SensorListenerDirect : SensorListener
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
        /// </summary>
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override void InitializeHandlers() { }

        const string _bridgeClassName = "android.hardware.SensorListener";
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
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
        public override bool IsBridgeInterface => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;
    }
    #endregion

    #region ISensorListener
    /// <summary>
    /// .NET interface for org.mases.netdroid.generated.android.hardware.SensorListener implementing <see href="https://developer.android.com/reference/android/hardware/SensorListener.html"/>
    /// </summary>
    public partial interface ISensorListener
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region SensorListener implementation
    public partial class SensorListener : Android.Hardware.ISensorListener
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
        /// Handlers initializer for <see cref="SensorListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("onAccuracyChanged", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(OnAccuracyChangedEventHandler));
            AddEventHandler("onSensorChanged", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(OnSensorChangedEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/hardware/SensorListener.html#onAccuracyChanged(int,int)"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnAccuracyChanged"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<int, int> OnOnAccuracyChanged { get; set; } = null;

        bool hasOverrideOnAccuracyChanged = true;
        void OnAccuracyChangedEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideOnAccuracyChanged = true;
            var methodToExecute = (OnOnAccuracyChanged != null) ? OnOnAccuracyChanged : OnAccuracyChanged;
            methodToExecute.Invoke(data.EventData.GetAt<int>(0), data.EventData.GetAt<int>(1));
            data.EventData.TypedEventData.HasOverride = hasOverrideOnAccuracyChanged;
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/SensorListener.html#onAccuracyChanged(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        [global::System.Obsolete()]
        public virtual void OnAccuracyChanged(int arg0, int arg1)
        {
            hasOverrideOnAccuracyChanged = false;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/hardware/SensorListener.html#onSensorChanged(int,float[])"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnSensorChanged"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<int, float[]> OnOnSensorChanged { get; set; } = null;

        bool hasOverrideOnSensorChanged = true;
        void OnSensorChangedEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideOnSensorChanged = true;
            var methodToExecute = (OnOnSensorChanged != null) ? OnOnSensorChanged : OnSensorChanged;
            methodToExecute.Invoke(data.EventData.GetAt<int>(0), data.EventData.GetAt<float[]>(1));
            data.EventData.TypedEventData.HasOverride = hasOverrideOnSensorChanged;
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/SensorListener.html#onSensorChanged(int,float[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        [global::System.Obsolete()]
        public virtual void OnSensorChanged(int arg0, float[] arg1)
        {
            hasOverrideOnSensorChanged = false;
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region SensorListenerDirect implementation
    public partial class SensorListenerDirect : Android.Hardware.ISensorListener
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
        /// <see href="https://developer.android.com/reference/android/hardware/SensorListener.html#onAccuracyChanged(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        [global::System.Obsolete()]
        public override void OnAccuracyChanged(int arg0, int arg1)
        {
            IExecuteWithSignature("onAccuracyChanged", "(II)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/SensorListener.html#onSensorChanged(int,float[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        [global::System.Obsolete()]
        public override void OnSensorChanged(int arg0, float[] arg1)
        {
            IExecuteWithSignature("onSensorChanged", "(I[F)V", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}