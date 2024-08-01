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

namespace Android.Hardware
{
    #region ISensorEventListener2
    /// <summary>
    /// .NET interface for org.mases.netdroid.generated.android.hardware.SensorEventListener2 implementing <see href="https://developer.android.com/reference/android/hardware/SensorEventListener2.html"/>
    /// </summary>
    public partial interface ISensorEventListener2
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region SensorEventListener2
    public partial class SensorEventListener2 : Android.Hardware.ISensorEventListener2
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
        /// Handlers initializer for <see cref="SensorEventListener2"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("onAccuracyChanged", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Android.Hardware.Sensor>>>(OnAccuracyChangedEventHandler));
            AddEventHandler("onSensorChanged", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Android.Hardware.SensorEvent>>>(OnSensorChangedEventHandler));
            AddEventHandler("onFlushCompleted", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Android.Hardware.Sensor>>>(OnFlushCompletedEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/hardware/SensorEventListener.html#onAccuracyChanged(android.hardware.Sensor,int)"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnAccuracyChanged"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Android.Hardware.Sensor, int> OnOnAccuracyChanged { get; set; } = null;

        void OnAccuracyChangedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.Hardware.Sensor>> data)
        {
            var methodToExecute = (OnOnAccuracyChanged != null) ? OnOnAccuracyChanged : OnAccuracyChanged;
            methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<int>(0));
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/SensorEventListener.html#onAccuracyChanged(android.hardware.Sensor,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Hardware.Sensor"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public virtual void OnAccuracyChanged(Android.Hardware.Sensor arg0, int arg1)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/hardware/SensorEventListener.html#onSensorChanged(android.hardware.SensorEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnSensorChanged"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Android.Hardware.SensorEvent> OnOnSensorChanged { get; set; } = null;

        void OnSensorChangedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.Hardware.SensorEvent>> data)
        {
            var methodToExecute = (OnOnSensorChanged != null) ? OnOnSensorChanged : OnSensorChanged;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/SensorEventListener.html#onSensorChanged(android.hardware.SensorEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Hardware.SensorEvent"/></param>
        public virtual void OnSensorChanged(Android.Hardware.SensorEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/hardware/SensorEventListener2.html#onFlushCompleted(android.hardware.Sensor)"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnFlushCompleted"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Android.Hardware.Sensor> OnOnFlushCompleted { get; set; } = null;

        void OnFlushCompletedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.Hardware.Sensor>> data)
        {
            var methodToExecute = (OnOnFlushCompleted != null) ? OnOnFlushCompleted : OnFlushCompleted;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/SensorEventListener2.html#onFlushCompleted(android.hardware.Sensor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Hardware.Sensor"/></param>
        public virtual void OnFlushCompleted(Android.Hardware.Sensor arg0)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region SensorEventListener2Direct
    public partial class SensorEventListener2Direct : Android.Hardware.ISensorEventListener2
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
        /// <see href="https://developer.android.com/reference/android/hardware/SensorEventListener.html#onAccuracyChanged(android.hardware.Sensor,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Hardware.Sensor"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public override void OnAccuracyChanged(Android.Hardware.Sensor arg0, int arg1)
        {
            IExecute("onAccuracyChanged", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/SensorEventListener.html#onSensorChanged(android.hardware.SensorEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Hardware.SensorEvent"/></param>
        public override void OnSensorChanged(Android.Hardware.SensorEvent arg0)
        {
            IExecute("onSensorChanged", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/SensorEventListener2.html#onFlushCompleted(android.hardware.Sensor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Hardware.Sensor"/></param>
        public override void OnFlushCompleted(Android.Hardware.Sensor arg0)
        {
            IExecuteWithSignature("onFlushCompleted", "(Landroid/hardware/Sensor;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}