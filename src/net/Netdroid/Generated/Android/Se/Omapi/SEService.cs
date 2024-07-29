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
*  This file is generated by MASES.JNetReflector (ver. 2.5.6.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Se.Omapi
{
    #region SEService
    public partial class SEService
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/se/omapi/SEService.html#%3Cinit%3E(android.content.Context,java.util.concurrent.Executor,android.se.omapi.SEService.OnConnectedListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg2"><see cref="Android.Se.Omapi.SEService.OnConnectedListener"/></param>
        public SEService(Android.Content.Context arg0, Java.Util.Concurrent.Executor arg1, Android.Se.Omapi.SEService.OnConnectedListener arg2)
            : base(arg0, arg1, arg2)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/se/omapi/SEService.html#ACTION_SECURE_ELEMENT_STATE_CHANGED"/>
        /// </summary>
        public static Java.Lang.String ACTION_SECURE_ELEMENT_STATE_CHANGED { get { if (!_ACTION_SECURE_ELEMENT_STATE_CHANGEDReady) { _ACTION_SECURE_ELEMENT_STATE_CHANGEDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACTION_SECURE_ELEMENT_STATE_CHANGED"); _ACTION_SECURE_ELEMENT_STATE_CHANGEDReady = true; } return _ACTION_SECURE_ELEMENT_STATE_CHANGEDContent; } }
        private static Java.Lang.String _ACTION_SECURE_ELEMENT_STATE_CHANGEDContent = default;
        private static bool _ACTION_SECURE_ELEMENT_STATE_CHANGEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/se/omapi/SEService.html#EXTRA_READER_NAME"/>
        /// </summary>
        public static Java.Lang.String EXTRA_READER_NAME { get { if (!_EXTRA_READER_NAMEReady) { _EXTRA_READER_NAMEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_READER_NAME"); _EXTRA_READER_NAMEReady = true; } return _EXTRA_READER_NAMEContent; } }
        private static Java.Lang.String _EXTRA_READER_NAMEContent = default;
        private static bool _EXTRA_READER_NAMEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/se/omapi/SEService.html#EXTRA_READER_STATE"/>
        /// </summary>
        public static Java.Lang.String EXTRA_READER_STATE { get { if (!_EXTRA_READER_STATEReady) { _EXTRA_READER_STATEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_READER_STATE"); _EXTRA_READER_STATEReady = true; } return _EXTRA_READER_STATEContent; } }
        private static Java.Lang.String _EXTRA_READER_STATEContent = default;
        private static bool _EXTRA_READER_STATEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/se/omapi/SEService.html#getUiccReader(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Se.Omapi.Reader"/></returns>
        public Android.Se.Omapi.Reader GetUiccReader(int arg0)
        {
            return IExecuteWithSignature<Android.Se.Omapi.Reader>("getUiccReader", "(I)Landroid/se/omapi/Reader;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/se/omapi/SEService.html#getReaders()"/>
        /// </summary>
        /// <returns><see cref="Android.Se.Omapi.Reader"/></returns>
        public Android.Se.Omapi.Reader[] GetReaders()
        {
            return IExecuteWithSignatureArray<Android.Se.Omapi.Reader>("getReaders", "()[Landroid/se/omapi/Reader;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/se/omapi/SEService.html#isConnected()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsConnected()
        {
            return IExecuteWithSignature<bool>("isConnected", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/se/omapi/SEService.html#getVersion()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetVersion()
        {
            return IExecuteWithSignature<Java.Lang.String>("getVersion", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/se/omapi/SEService.html#shutdown()"/>
        /// </summary>
        public void Shutdown()
        {
            IExecuteWithSignature("shutdown", "()V");
        }

        #endregion

        #region Nested classes
        #region OnConnectedListener
        public partial class OnConnectedListener
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
            /// Handlers initializer for <see cref="OnConnectedListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onConnected", new global::System.EventHandler<CLRListenerEventArgs<CLREventData>>(OnConnectedEventHandler));

            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/se/omapi/SEService.OnConnectedListener.html#onConnected()"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnConnected"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action OnOnConnected { get; set; } = null;

            void OnConnectedEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
            {
                var methodToExecute = (OnOnConnected != null) ? OnOnConnected : OnConnected;
                methodToExecute.Invoke();
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/se/omapi/SEService.OnConnectedListener.html#onConnected()"/>
            /// </summary>
            public virtual void OnConnected()
            {
                
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OnConnectedListenerDirect
        public partial class OnConnectedListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/se/omapi/SEService.OnConnectedListener.html#onConnected()"/>
            /// </summary>
            public override void OnConnected()
            {
                IExecuteWithSignature("onConnected", "()V");
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
}