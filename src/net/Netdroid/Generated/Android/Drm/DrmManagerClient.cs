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

namespace Android.Drm
{
    #region DrmManagerClient
    public partial class DrmManagerClient
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/drm/DrmManagerClient.html#%3Cinit%3E(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        [global::System.Obsolete()]
        public DrmManagerClient(Android.Content.Context arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/drm/DrmManagerClient.html#ERROR_NONE"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int ERROR_NONE { get { if (!_ERROR_NONEReady) { _ERROR_NONEContent = SGetField<int>(LocalBridgeClazz, "ERROR_NONE"); _ERROR_NONEReady = true; } return _ERROR_NONEContent; } }
        private static int _ERROR_NONEContent = default;
        private static bool _ERROR_NONEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/drm/DrmManagerClient.html#ERROR_UNKNOWN"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int ERROR_UNKNOWN { get { if (!_ERROR_UNKNOWNReady) { _ERROR_UNKNOWNContent = SGetField<int>(LocalBridgeClazz, "ERROR_UNKNOWN"); _ERROR_UNKNOWNReady = true; } return _ERROR_UNKNOWNContent; } }
        private static int _ERROR_UNKNOWNContent = default;
        private static bool _ERROR_UNKNOWNReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/drm/DrmManagerClient.html#getConstraints(android.net.Uri,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Android.Content.ContentValues"/></returns>
        [global::System.Obsolete()]
        public Android.Content.ContentValues GetConstraints(Android.Net.Uri arg0, int arg1)
        {
            return IExecute<Android.Content.ContentValues>("getConstraints", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/drm/DrmManagerClient.html#getConstraints(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Android.Content.ContentValues"/></returns>
        [global::System.Obsolete()]
        public Android.Content.ContentValues GetConstraints(Java.Lang.String arg0, int arg1)
        {
            return IExecute<Android.Content.ContentValues>("getConstraints", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/drm/DrmManagerClient.html#getMetadata(android.net.Uri)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
        /// <returns><see cref="Android.Content.ContentValues"/></returns>
        [global::System.Obsolete()]
        public Android.Content.ContentValues GetMetadata(Android.Net.Uri arg0)
        {
            return IExecuteWithSignature<Android.Content.ContentValues>("getMetadata", "(Landroid/net/Uri;)Landroid/content/ContentValues;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/drm/DrmManagerClient.html#getMetadata(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Content.ContentValues"/></returns>
        [global::System.Obsolete()]
        public Android.Content.ContentValues GetMetadata(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Android.Content.ContentValues>("getMetadata", "(Ljava/lang/String;)Landroid/content/ContentValues;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/drm/DrmManagerClient.html#closeConvertSession(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Drm.DrmConvertedStatus"/></returns>
        [global::System.Obsolete()]
        public Android.Drm.DrmConvertedStatus CloseConvertSession(int arg0)
        {
            return IExecuteWithSignature<Android.Drm.DrmConvertedStatus>("closeConvertSession", "(I)Landroid/drm/DrmConvertedStatus;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/drm/DrmManagerClient.html#convertData(int,byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <returns><see cref="Android.Drm.DrmConvertedStatus"/></returns>
        [global::System.Obsolete()]
        public Android.Drm.DrmConvertedStatus ConvertData(int arg0, byte[] arg1)
        {
            return IExecute<Android.Drm.DrmConvertedStatus>("convertData", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/drm/DrmManagerClient.html#acquireDrmInfo(android.drm.DrmInfoRequest)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Drm.DrmInfoRequest"/></param>
        /// <returns><see cref="Android.Drm.DrmInfo"/></returns>
        [global::System.Obsolete()]
        public Android.Drm.DrmInfo AcquireDrmInfo(Android.Drm.DrmInfoRequest arg0)
        {
            return IExecuteWithSignature<Android.Drm.DrmInfo>("acquireDrmInfo", "(Landroid/drm/DrmInfoRequest;)Landroid/drm/DrmInfo;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/drm/DrmManagerClient.html#canHandle(android.net.Uri,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool CanHandle(Android.Net.Uri arg0, Java.Lang.String arg1)
        {
            return IExecute<bool>("canHandle", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/drm/DrmManagerClient.html#canHandle(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool CanHandle(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return IExecute<bool>("canHandle", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/drm/DrmManagerClient.html#acquireRights(android.drm.DrmInfoRequest)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Drm.DrmInfoRequest"/></param>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int AcquireRights(Android.Drm.DrmInfoRequest arg0)
        {
            return IExecuteWithSignature<int>("acquireRights", "(Landroid/drm/DrmInfoRequest;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/drm/DrmManagerClient.html#checkRightsStatus(android.net.Uri,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int CheckRightsStatus(Android.Net.Uri arg0, int arg1)
        {
            return IExecute<int>("checkRightsStatus", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/drm/DrmManagerClient.html#checkRightsStatus(android.net.Uri)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int CheckRightsStatus(Android.Net.Uri arg0)
        {
            return IExecuteWithSignature<int>("checkRightsStatus", "(Landroid/net/Uri;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/drm/DrmManagerClient.html#checkRightsStatus(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int CheckRightsStatus(Java.Lang.String arg0, int arg1)
        {
            return IExecute<int>("checkRightsStatus", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/drm/DrmManagerClient.html#checkRightsStatus(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int CheckRightsStatus(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<int>("checkRightsStatus", "(Ljava/lang/String;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/drm/DrmManagerClient.html#getDrmObjectType(android.net.Uri,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int GetDrmObjectType(Android.Net.Uri arg0, Java.Lang.String arg1)
        {
            return IExecute<int>("getDrmObjectType", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/drm/DrmManagerClient.html#getDrmObjectType(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int GetDrmObjectType(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return IExecute<int>("getDrmObjectType", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/drm/DrmManagerClient.html#openConvertSession(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int OpenConvertSession(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<int>("openConvertSession", "(Ljava/lang/String;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/drm/DrmManagerClient.html#processDrmInfo(android.drm.DrmInfo)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Drm.DrmInfo"/></param>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int ProcessDrmInfo(Android.Drm.DrmInfo arg0)
        {
            return IExecuteWithSignature<int>("processDrmInfo", "(Landroid/drm/DrmInfo;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/drm/DrmManagerClient.html#removeAllRights()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int RemoveAllRights()
        {
            return IExecuteWithSignature<int>("removeAllRights", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/drm/DrmManagerClient.html#removeRights(android.net.Uri)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int RemoveRights(Android.Net.Uri arg0)
        {
            return IExecuteWithSignature<int>("removeRights", "(Landroid/net/Uri;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/drm/DrmManagerClient.html#removeRights(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int RemoveRights(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<int>("removeRights", "(Ljava/lang/String;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/drm/DrmManagerClient.html#saveRights(android.drm.DrmRights,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Drm.DrmRights"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        [global::System.Obsolete()]
        public int SaveRights(Android.Drm.DrmRights arg0, Java.Lang.String arg1, Java.Lang.String arg2)
        {
            return IExecute<int>("saveRights", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/drm/DrmManagerClient.html#getOriginalMimeType(android.net.Uri)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        [global::System.Obsolete()]
        public Java.Lang.String GetOriginalMimeType(Android.Net.Uri arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getOriginalMimeType", "(Landroid/net/Uri;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/drm/DrmManagerClient.html#getOriginalMimeType(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        [global::System.Obsolete()]
        public Java.Lang.String GetOriginalMimeType(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getOriginalMimeType", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/drm/DrmManagerClient.html#getAvailableDrmEngines()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        [global::System.Obsolete()]
        public Java.Lang.String[] GetAvailableDrmEngines()
        {
            return IExecuteWithSignatureArray<Java.Lang.String>("getAvailableDrmEngines", "()[Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/drm/DrmManagerClient.html#getAvailableDrmSupportInfo()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Collection"/></returns>
        [global::System.Obsolete()]
        public Java.Util.Collection<Android.Drm.DrmSupportInfo> GetAvailableDrmSupportInfo()
        {
            return IExecuteWithSignature<Java.Util.Collection<Android.Drm.DrmSupportInfo>>("getAvailableDrmSupportInfo", "()Ljava/util/Collection;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/drm/DrmManagerClient.html#setOnErrorListener(android.drm.DrmManagerClient.OnErrorListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Drm.DrmManagerClient.OnErrorListener"/></param>
        [global::System.Obsolete()]
        public void SetOnErrorListener(Android.Drm.DrmManagerClient.OnErrorListener arg0)
        {
            IExecuteWithSignature("setOnErrorListener", "(Landroid/drm/DrmManagerClient$OnErrorListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/drm/DrmManagerClient.html#setOnEventListener(android.drm.DrmManagerClient.OnEventListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Drm.DrmManagerClient.OnEventListener"/></param>
        [global::System.Obsolete()]
        public void SetOnEventListener(Android.Drm.DrmManagerClient.OnEventListener arg0)
        {
            IExecuteWithSignature("setOnEventListener", "(Landroid/drm/DrmManagerClient$OnEventListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/drm/DrmManagerClient.html#setOnInfoListener(android.drm.DrmManagerClient.OnInfoListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Drm.DrmManagerClient.OnInfoListener"/></param>
        [global::System.Obsolete()]
        public void SetOnInfoListener(Android.Drm.DrmManagerClient.OnInfoListener arg0)
        {
            IExecuteWithSignature("setOnInfoListener", "(Landroid/drm/DrmManagerClient$OnInfoListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/drm/DrmManagerClient.html#close()"/>
        /// </summary>
        [global::System.Obsolete()]
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/drm/DrmManagerClient.html#release()"/>
        /// </summary>
        [global::System.Obsolete()]
        public void Release()
        {
            IExecuteWithSignature("release", "()V");
        }

        #endregion

        #region Nested classes
        #region OnErrorListener
        public partial class OnErrorListener
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
            /// Handlers initializer for <see cref="OnErrorListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onError", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Android.Drm.DrmManagerClient>>>(OnErrorEventHandler));

            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/drm/DrmManagerClient.OnErrorListener.html#onError(android.drm.DrmManagerClient,android.drm.DrmErrorEvent)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnError"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action<Android.Drm.DrmManagerClient, Android.Drm.DrmErrorEvent> OnOnError { get; set; } = null;

            void OnErrorEventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.Drm.DrmManagerClient>> data)
            {
                var methodToExecute = (OnOnError != null) ? OnOnError : OnError;
                methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<Android.Drm.DrmErrorEvent>(0));
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/drm/DrmManagerClient.OnErrorListener.html#onError(android.drm.DrmManagerClient,android.drm.DrmErrorEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Drm.DrmManagerClient"/></param>
            /// <param name="arg1"><see cref="Android.Drm.DrmErrorEvent"/></param>
            [global::System.Obsolete()]
            public virtual void OnError(Android.Drm.DrmManagerClient arg0, Android.Drm.DrmErrorEvent arg1)
            {
                
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OnErrorListenerDirect
        public partial class OnErrorListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/drm/DrmManagerClient.OnErrorListener.html#onError(android.drm.DrmManagerClient,android.drm.DrmErrorEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Drm.DrmManagerClient"/></param>
            /// <param name="arg1"><see cref="Android.Drm.DrmErrorEvent"/></param>
            [global::System.Obsolete()]
            public override void OnError(Android.Drm.DrmManagerClient arg0, Android.Drm.DrmErrorEvent arg1)
            {
                IExecute("onError", arg0, arg1);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OnEventListener
        public partial class OnEventListener
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
            /// Handlers initializer for <see cref="OnEventListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onEvent", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Android.Drm.DrmManagerClient>>>(OnEventEventHandler));

            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/drm/DrmManagerClient.OnEventListener.html#onEvent(android.drm.DrmManagerClient,android.drm.DrmEvent)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnEvent"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action<Android.Drm.DrmManagerClient, Android.Drm.DrmEvent> OnOnEvent { get; set; } = null;

            void OnEventEventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.Drm.DrmManagerClient>> data)
            {
                var methodToExecute = (OnOnEvent != null) ? OnOnEvent : OnEvent;
                methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<Android.Drm.DrmEvent>(0));
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/drm/DrmManagerClient.OnEventListener.html#onEvent(android.drm.DrmManagerClient,android.drm.DrmEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Drm.DrmManagerClient"/></param>
            /// <param name="arg1"><see cref="Android.Drm.DrmEvent"/></param>
            [global::System.Obsolete()]
            public virtual void OnEvent(Android.Drm.DrmManagerClient arg0, Android.Drm.DrmEvent arg1)
            {
                
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OnEventListenerDirect
        public partial class OnEventListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/drm/DrmManagerClient.OnEventListener.html#onEvent(android.drm.DrmManagerClient,android.drm.DrmEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Drm.DrmManagerClient"/></param>
            /// <param name="arg1"><see cref="Android.Drm.DrmEvent"/></param>
            [global::System.Obsolete()]
            public override void OnEvent(Android.Drm.DrmManagerClient arg0, Android.Drm.DrmEvent arg1)
            {
                IExecute("onEvent", arg0, arg1);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OnInfoListener
        public partial class OnInfoListener
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
            /// Handlers initializer for <see cref="OnInfoListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onInfo", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Android.Drm.DrmManagerClient>>>(OnInfoEventHandler));

            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/drm/DrmManagerClient.OnInfoListener.html#onInfo(android.drm.DrmManagerClient,android.drm.DrmInfoEvent)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnInfo"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action<Android.Drm.DrmManagerClient, Android.Drm.DrmInfoEvent> OnOnInfo { get; set; } = null;

            void OnInfoEventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.Drm.DrmManagerClient>> data)
            {
                var methodToExecute = (OnOnInfo != null) ? OnOnInfo : OnInfo;
                methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<Android.Drm.DrmInfoEvent>(0));
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/drm/DrmManagerClient.OnInfoListener.html#onInfo(android.drm.DrmManagerClient,android.drm.DrmInfoEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Drm.DrmManagerClient"/></param>
            /// <param name="arg1"><see cref="Android.Drm.DrmInfoEvent"/></param>
            [global::System.Obsolete()]
            public virtual void OnInfo(Android.Drm.DrmManagerClient arg0, Android.Drm.DrmInfoEvent arg1)
            {
                
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OnInfoListenerDirect
        public partial class OnInfoListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/drm/DrmManagerClient.OnInfoListener.html#onInfo(android.drm.DrmManagerClient,android.drm.DrmInfoEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Drm.DrmManagerClient"/></param>
            /// <param name="arg1"><see cref="Android.Drm.DrmInfoEvent"/></param>
            [global::System.Obsolete()]
            public override void OnInfo(Android.Drm.DrmManagerClient arg0, Android.Drm.DrmInfoEvent arg1)
            {
                IExecute("onInfo", arg0, arg1);
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