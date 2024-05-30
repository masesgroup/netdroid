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
*  This file is generated by MASES.JNetReflector (ver. 2.5.1.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Adservices.Measurement
{
    #region MeasurementManager
    public partial class MeasurementManager
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/measurement/MeasurementManager.html#MEASUREMENT_API_STATE_DISABLED"/>
        /// </summary>
        public static int MEASUREMENT_API_STATE_DISABLED { get { if (!_MEASUREMENT_API_STATE_DISABLEDReady) { _MEASUREMENT_API_STATE_DISABLEDContent = SGetField<int>(LocalBridgeClazz, "MEASUREMENT_API_STATE_DISABLED"); _MEASUREMENT_API_STATE_DISABLEDReady = true; } return _MEASUREMENT_API_STATE_DISABLEDContent; } }
        private static int _MEASUREMENT_API_STATE_DISABLEDContent = default;
        private static bool _MEASUREMENT_API_STATE_DISABLEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/measurement/MeasurementManager.html#MEASUREMENT_API_STATE_ENABLED"/>
        /// </summary>
        public static int MEASUREMENT_API_STATE_ENABLED { get { if (!_MEASUREMENT_API_STATE_ENABLEDReady) { _MEASUREMENT_API_STATE_ENABLEDContent = SGetField<int>(LocalBridgeClazz, "MEASUREMENT_API_STATE_ENABLED"); _MEASUREMENT_API_STATE_ENABLEDReady = true; } return _MEASUREMENT_API_STATE_ENABLEDContent; } }
        private static int _MEASUREMENT_API_STATE_ENABLEDContent = default;
        private static bool _MEASUREMENT_API_STATE_ENABLEDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/measurement/MeasurementManager.html#get(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <returns><see cref="Android.Adservices.Measurement.MeasurementManager"/></returns>
        public static Android.Adservices.Measurement.MeasurementManager Get(Android.Content.Context arg0)
        {
            return SExecuteWithSignature<Android.Adservices.Measurement.MeasurementManager>(LocalBridgeClazz, "get", "(Landroid/content/Context;)Landroid/adservices/measurement/MeasurementManager;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/measurement/MeasurementManager.html#deleteRegistrations(android.adservices.measurement.DeletionRequest,java.util.concurrent.Executor,android.os.OutcomeReceiver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Adservices.Measurement.DeletionRequest"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg2"><see cref="Android.Os.OutcomeReceiver"/></param>
        public void DeleteRegistrations(Android.Adservices.Measurement.DeletionRequest arg0, Java.Util.Concurrent.Executor arg1, Android.Os.OutcomeReceiver<object, Java.Lang.Exception> arg2)
        {
            IExecute("deleteRegistrations", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/measurement/MeasurementManager.html#getMeasurementApiStatus(java.util.concurrent.Executor,android.os.OutcomeReceiver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg1"><see cref="Android.Os.OutcomeReceiver"/></param>
        public void GetMeasurementApiStatus(Java.Util.Concurrent.Executor arg0, Android.Os.OutcomeReceiver<Java.Lang.Integer, Java.Lang.Exception> arg1)
        {
            IExecute("getMeasurementApiStatus", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/measurement/MeasurementManager.html#registerSource(android.net.Uri,android.view.InputEvent,java.util.concurrent.Executor,android.os.OutcomeReceiver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
        /// <param name="arg1"><see cref="Android.View.InputEvent"/></param>
        /// <param name="arg2"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg3"><see cref="Android.Os.OutcomeReceiver"/></param>
        public void RegisterSource(Android.Net.Uri arg0, Android.View.InputEvent arg1, Java.Util.Concurrent.Executor arg2, Android.Os.OutcomeReceiver<object, Java.Lang.Exception> arg3)
        {
            IExecute("registerSource", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/measurement/MeasurementManager.html#registerTrigger(android.net.Uri,java.util.concurrent.Executor,android.os.OutcomeReceiver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg2"><see cref="Android.Os.OutcomeReceiver"/></param>
        public void RegisterTrigger(Android.Net.Uri arg0, Java.Util.Concurrent.Executor arg1, Android.Os.OutcomeReceiver<object, Java.Lang.Exception> arg2)
        {
            IExecute("registerTrigger", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/measurement/MeasurementManager.html#registerWebSource(android.adservices.measurement.WebSourceRegistrationRequest,java.util.concurrent.Executor,android.os.OutcomeReceiver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Adservices.Measurement.WebSourceRegistrationRequest"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg2"><see cref="Android.Os.OutcomeReceiver"/></param>
        public void RegisterWebSource(Android.Adservices.Measurement.WebSourceRegistrationRequest arg0, Java.Util.Concurrent.Executor arg1, Android.Os.OutcomeReceiver<object, Java.Lang.Exception> arg2)
        {
            IExecute("registerWebSource", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/measurement/MeasurementManager.html#registerWebTrigger(android.adservices.measurement.WebTriggerRegistrationRequest,java.util.concurrent.Executor,android.os.OutcomeReceiver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Adservices.Measurement.WebTriggerRegistrationRequest"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg2"><see cref="Android.Os.OutcomeReceiver"/></param>
        public void RegisterWebTrigger(Android.Adservices.Measurement.WebTriggerRegistrationRequest arg0, Java.Util.Concurrent.Executor arg1, Android.Os.OutcomeReceiver<object, Java.Lang.Exception> arg2)
        {
            IExecute("registerWebTrigger", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}