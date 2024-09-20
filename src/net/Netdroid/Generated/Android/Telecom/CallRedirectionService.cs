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

namespace Android.Telecom
{
    #region CallRedirectionService
    public partial class CallRedirectionService
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/CallRedirectionService.html#SERVICE_INTERFACE"/>
        /// </summary>
        public static Java.Lang.String SERVICE_INTERFACE { get { if (!_SERVICE_INTERFACEReady) { _SERVICE_INTERFACEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SERVICE_INTERFACE"); _SERVICE_INTERFACEReady = true; } return _SERVICE_INTERFACEContent; } }
        private static Java.Lang.String _SERVICE_INTERFACEContent = default;
        private static bool _SERVICE_INTERFACEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/CallRedirectionService.html#onPlaceCall(android.net.Uri,android.telecom.PhoneAccountHandle,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
        /// <param name="arg1"><see cref="Android.Telecom.PhoneAccountHandle"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        public void OnPlaceCall(Android.Net.Uri arg0, Android.Telecom.PhoneAccountHandle arg1, bool arg2)
        {
            IExecute("onPlaceCall", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/CallRedirectionService.html#cancelCall()"/>
        /// </summary>
        public void CancelCall()
        {
            IExecuteWithSignature("cancelCall", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/CallRedirectionService.html#placeCallUnmodified()"/>
        /// </summary>
        public void PlaceCallUnmodified()
        {
            IExecuteWithSignature("placeCallUnmodified", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/CallRedirectionService.html#redirectCall(android.net.Uri,android.telecom.PhoneAccountHandle,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
        /// <param name="arg1"><see cref="Android.Telecom.PhoneAccountHandle"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        public void RedirectCall(Android.Net.Uri arg0, Android.Telecom.PhoneAccountHandle arg1, bool arg2)
        {
            IExecute("redirectCall", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/CallRedirectionService.html#onRedirectionTimeout()"/>
        /// </summary>
        public void OnRedirectionTimeout()
        {
            IExecuteWithSignature("onRedirectionTimeout", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}