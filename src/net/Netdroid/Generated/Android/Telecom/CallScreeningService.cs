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

namespace Android.Telecom
{
    #region CallScreeningService
    public partial class CallScreeningService
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/CallScreeningService.html#SERVICE_INTERFACE"/>
        /// </summary>
        public static Java.Lang.String SERVICE_INTERFACE { get { if (!_SERVICE_INTERFACEReady) { _SERVICE_INTERFACEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SERVICE_INTERFACE"); _SERVICE_INTERFACEReady = true; } return _SERVICE_INTERFACEContent; } }
        private static Java.Lang.String _SERVICE_INTERFACEContent = default;
        private static bool _SERVICE_INTERFACEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/CallScreeningService.html#onScreenCall(android.telecom.Call.Details)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Telecom.Call.Details"/></param>
        public void OnScreenCall(Android.Telecom.Call.Details arg0)
        {
            IExecuteWithSignature("onScreenCall", "(Landroid/telecom/Call$Details;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/CallScreeningService.html#respondToCall(android.telecom.Call.Details,android.telecom.CallScreeningService.CallResponse)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Telecom.Call.Details"/></param>
        /// <param name="arg1"><see cref="Android.Telecom.CallScreeningService.CallResponse"/></param>
        public void RespondToCall(Android.Telecom.Call.Details arg0, Android.Telecom.CallScreeningService.CallResponse arg1)
        {
            IExecute("respondToCall", arg0, arg1);
        }

        #endregion

        #region Nested classes
        #region CallResponse
        public partial class CallResponse
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telecom/CallScreeningService.CallResponse.html#CALL_COMPOSER_ATTACHMENT_LOCATION"/>
            /// </summary>
            public static int CALL_COMPOSER_ATTACHMENT_LOCATION { get { if (!_CALL_COMPOSER_ATTACHMENT_LOCATIONReady) { _CALL_COMPOSER_ATTACHMENT_LOCATIONContent = SGetField<int>(LocalBridgeClazz, "CALL_COMPOSER_ATTACHMENT_LOCATION"); _CALL_COMPOSER_ATTACHMENT_LOCATIONReady = true; } return _CALL_COMPOSER_ATTACHMENT_LOCATIONContent; } }
            private static int _CALL_COMPOSER_ATTACHMENT_LOCATIONContent = default;
            private static bool _CALL_COMPOSER_ATTACHMENT_LOCATIONReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telecom/CallScreeningService.CallResponse.html#CALL_COMPOSER_ATTACHMENT_PICTURE"/>
            /// </summary>
            public static int CALL_COMPOSER_ATTACHMENT_PICTURE { get { if (!_CALL_COMPOSER_ATTACHMENT_PICTUREReady) { _CALL_COMPOSER_ATTACHMENT_PICTUREContent = SGetField<int>(LocalBridgeClazz, "CALL_COMPOSER_ATTACHMENT_PICTURE"); _CALL_COMPOSER_ATTACHMENT_PICTUREReady = true; } return _CALL_COMPOSER_ATTACHMENT_PICTUREContent; } }
            private static int _CALL_COMPOSER_ATTACHMENT_PICTUREContent = default;
            private static bool _CALL_COMPOSER_ATTACHMENT_PICTUREReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telecom/CallScreeningService.CallResponse.html#CALL_COMPOSER_ATTACHMENT_PRIORITY"/>
            /// </summary>
            public static int CALL_COMPOSER_ATTACHMENT_PRIORITY { get { if (!_CALL_COMPOSER_ATTACHMENT_PRIORITYReady) { _CALL_COMPOSER_ATTACHMENT_PRIORITYContent = SGetField<int>(LocalBridgeClazz, "CALL_COMPOSER_ATTACHMENT_PRIORITY"); _CALL_COMPOSER_ATTACHMENT_PRIORITYReady = true; } return _CALL_COMPOSER_ATTACHMENT_PRIORITYContent; } }
            private static int _CALL_COMPOSER_ATTACHMENT_PRIORITYContent = default;
            private static bool _CALL_COMPOSER_ATTACHMENT_PRIORITYReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telecom/CallScreeningService.CallResponse.html#CALL_COMPOSER_ATTACHMENT_SUBJECT"/>
            /// </summary>
            public static int CALL_COMPOSER_ATTACHMENT_SUBJECT { get { if (!_CALL_COMPOSER_ATTACHMENT_SUBJECTReady) { _CALL_COMPOSER_ATTACHMENT_SUBJECTContent = SGetField<int>(LocalBridgeClazz, "CALL_COMPOSER_ATTACHMENT_SUBJECT"); _CALL_COMPOSER_ATTACHMENT_SUBJECTReady = true; } return _CALL_COMPOSER_ATTACHMENT_SUBJECTContent; } }
            private static int _CALL_COMPOSER_ATTACHMENT_SUBJECTContent = default;
            private static bool _CALL_COMPOSER_ATTACHMENT_SUBJECTReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telecom/CallScreeningService.CallResponse.html#getDisallowCall()"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool GetDisallowCall()
            {
                return IExecuteWithSignature<bool>("getDisallowCall", "()Z");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telecom/CallScreeningService.CallResponse.html#getRejectCall()"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool GetRejectCall()
            {
                return IExecuteWithSignature<bool>("getRejectCall", "()Z");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telecom/CallScreeningService.CallResponse.html#getSilenceCall()"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool GetSilenceCall()
            {
                return IExecuteWithSignature<bool>("getSilenceCall", "()Z");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telecom/CallScreeningService.CallResponse.html#getSkipCallLog()"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool GetSkipCallLog()
            {
                return IExecuteWithSignature<bool>("getSkipCallLog", "()Z");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telecom/CallScreeningService.CallResponse.html#getSkipNotification()"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool GetSkipNotification()
            {
                return IExecuteWithSignature<bool>("getSkipNotification", "()Z");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telecom/CallScreeningService.CallResponse.html#getCallComposerAttachmentsToShow()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetCallComposerAttachmentsToShow()
            {
                return IExecuteWithSignature<int>("getCallComposerAttachmentsToShow", "()I");
            }

            #endregion

            #region Nested classes
            #region Builder
            public partial class Builder
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
                /// <see href="https://developer.android.com/reference/android/telecom/CallScreeningService.CallResponse.Builder.html#build()"/>
                /// </summary>
                /// <returns><see cref="Android.Telecom.CallScreeningService.CallResponse"/></returns>
                public Android.Telecom.CallScreeningService.CallResponse Build()
                {
                    return IExecuteWithSignature<Android.Telecom.CallScreeningService.CallResponse>("build", "()Landroid/telecom/CallScreeningService$CallResponse;");
                }
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/telecom/CallScreeningService.CallResponse.Builder.html#setCallComposerAttachmentsToShow(int)"/>
                /// </summary>
                /// <param name="arg0"><see cref="int"/></param>
                /// <returns><see cref="Android.Telecom.CallScreeningService.CallResponse.Builder"/></returns>
                public Android.Telecom.CallScreeningService.CallResponse.Builder SetCallComposerAttachmentsToShow(int arg0)
                {
                    return IExecuteWithSignature<Android.Telecom.CallScreeningService.CallResponse.Builder>("setCallComposerAttachmentsToShow", "(I)Landroid/telecom/CallScreeningService$CallResponse$Builder;", arg0);
                }
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/telecom/CallScreeningService.CallResponse.Builder.html#setDisallowCall(boolean)"/>
                /// </summary>
                /// <param name="arg0"><see cref="bool"/></param>
                /// <returns><see cref="Android.Telecom.CallScreeningService.CallResponse.Builder"/></returns>
                public Android.Telecom.CallScreeningService.CallResponse.Builder SetDisallowCall(bool arg0)
                {
                    return IExecuteWithSignature<Android.Telecom.CallScreeningService.CallResponse.Builder>("setDisallowCall", "(Z)Landroid/telecom/CallScreeningService$CallResponse$Builder;", arg0);
                }
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/telecom/CallScreeningService.CallResponse.Builder.html#setRejectCall(boolean)"/>
                /// </summary>
                /// <param name="arg0"><see cref="bool"/></param>
                /// <returns><see cref="Android.Telecom.CallScreeningService.CallResponse.Builder"/></returns>
                public Android.Telecom.CallScreeningService.CallResponse.Builder SetRejectCall(bool arg0)
                {
                    return IExecuteWithSignature<Android.Telecom.CallScreeningService.CallResponse.Builder>("setRejectCall", "(Z)Landroid/telecom/CallScreeningService$CallResponse$Builder;", arg0);
                }
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/telecom/CallScreeningService.CallResponse.Builder.html#setSilenceCall(boolean)"/>
                /// </summary>
                /// <param name="arg0"><see cref="bool"/></param>
                /// <returns><see cref="Android.Telecom.CallScreeningService.CallResponse.Builder"/></returns>
                public Android.Telecom.CallScreeningService.CallResponse.Builder SetSilenceCall(bool arg0)
                {
                    return IExecuteWithSignature<Android.Telecom.CallScreeningService.CallResponse.Builder>("setSilenceCall", "(Z)Landroid/telecom/CallScreeningService$CallResponse$Builder;", arg0);
                }
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/telecom/CallScreeningService.CallResponse.Builder.html#setSkipCallLog(boolean)"/>
                /// </summary>
                /// <param name="arg0"><see cref="bool"/></param>
                /// <returns><see cref="Android.Telecom.CallScreeningService.CallResponse.Builder"/></returns>
                public Android.Telecom.CallScreeningService.CallResponse.Builder SetSkipCallLog(bool arg0)
                {
                    return IExecuteWithSignature<Android.Telecom.CallScreeningService.CallResponse.Builder>("setSkipCallLog", "(Z)Landroid/telecom/CallScreeningService$CallResponse$Builder;", arg0);
                }
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/telecom/CallScreeningService.CallResponse.Builder.html#setSkipNotification(boolean)"/>
                /// </summary>
                /// <param name="arg0"><see cref="bool"/></param>
                /// <returns><see cref="Android.Telecom.CallScreeningService.CallResponse.Builder"/></returns>
                public Android.Telecom.CallScreeningService.CallResponse.Builder SetSkipNotification(bool arg0)
                {
                    return IExecuteWithSignature<Android.Telecom.CallScreeningService.CallResponse.Builder>("setSkipNotification", "(Z)Landroid/telecom/CallScreeningService$CallResponse$Builder;", arg0);
                }

                #endregion

                #region Nested classes

                #endregion

                // TODO: complete the class
            }
            #endregion

        
            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}