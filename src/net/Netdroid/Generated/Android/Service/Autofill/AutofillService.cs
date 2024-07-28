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
*  This file is generated by MASES.JNetReflector (ver. 2.5.5.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Service.Autofill
{
    #region AutofillService
    public partial class AutofillService
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/autofill/AutofillService.html#EXTRA_FILL_RESPONSE"/>
        /// </summary>
        public static Java.Lang.String EXTRA_FILL_RESPONSE { get { if (!_EXTRA_FILL_RESPONSEReady) { _EXTRA_FILL_RESPONSEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_FILL_RESPONSE"); _EXTRA_FILL_RESPONSEReady = true; } return _EXTRA_FILL_RESPONSEContent; } }
        private static Java.Lang.String _EXTRA_FILL_RESPONSEContent = default;
        private static bool _EXTRA_FILL_RESPONSEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/autofill/AutofillService.html#SERVICE_INTERFACE"/>
        /// </summary>
        public static Java.Lang.String SERVICE_INTERFACE { get { if (!_SERVICE_INTERFACEReady) { _SERVICE_INTERFACEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SERVICE_INTERFACE"); _SERVICE_INTERFACEReady = true; } return _SERVICE_INTERFACEContent; } }
        private static Java.Lang.String _SERVICE_INTERFACEContent = default;
        private static bool _SERVICE_INTERFACEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/autofill/AutofillService.html#SERVICE_META_DATA"/>
        /// </summary>
        public static Java.Lang.String SERVICE_META_DATA { get { if (!_SERVICE_META_DATAReady) { _SERVICE_META_DATAContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SERVICE_META_DATA"); _SERVICE_META_DATAReady = true; } return _SERVICE_META_DATAContent; } }
        private static Java.Lang.String _SERVICE_META_DATAContent = default;
        private static bool _SERVICE_META_DATAReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/autofill/AutofillService.html#onFillRequest(android.service.autofill.FillRequest,android.os.CancellationSignal,android.service.autofill.FillCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Service.Autofill.FillRequest"/></param>
        /// <param name="arg1"><see cref="Android.Os.CancellationSignal"/></param>
        /// <param name="arg2"><see cref="Android.Service.Autofill.FillCallback"/></param>
        public void OnFillRequest(Android.Service.Autofill.FillRequest arg0, Android.Os.CancellationSignal arg1, Android.Service.Autofill.FillCallback arg2)
        {
            IExecute("onFillRequest", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/autofill/AutofillService.html#onSaveRequest(android.service.autofill.SaveRequest,android.service.autofill.SaveCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Service.Autofill.SaveRequest"/></param>
        /// <param name="arg1"><see cref="Android.Service.Autofill.SaveCallback"/></param>
        public void OnSaveRequest(Android.Service.Autofill.SaveRequest arg0, Android.Service.Autofill.SaveCallback arg1)
        {
            IExecute("onSaveRequest", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/autofill/AutofillService.html#getFillEventHistory()"/>
        /// </summary>
        /// <returns><see cref="Android.Service.Autofill.FillEventHistory"/></returns>
        public Android.Service.Autofill.FillEventHistory GetFillEventHistory()
        {
            return IExecuteWithSignature<Android.Service.Autofill.FillEventHistory>("getFillEventHistory", "()Landroid/service/autofill/FillEventHistory;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/autofill/AutofillService.html#onConnected()"/>
        /// </summary>
        public void OnConnected()
        {
            IExecuteWithSignature("onConnected", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/autofill/AutofillService.html#onDisconnected()"/>
        /// </summary>
        public void OnDisconnected()
        {
            IExecuteWithSignature("onDisconnected", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/autofill/AutofillService.html#onSavedDatasetsInfoRequest(android.service.autofill.SavedDatasetsInfoCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Service.Autofill.SavedDatasetsInfoCallback"/></param>
        public void OnSavedDatasetsInfoRequest(Android.Service.Autofill.SavedDatasetsInfoCallback arg0)
        {
            IExecuteWithSignature("onSavedDatasetsInfoRequest", "(Landroid/service/autofill/SavedDatasetsInfoCallback;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}