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
    #region SensorEventCallback
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
            IExecute("onAccuracyChanged", arg0, arg1);
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