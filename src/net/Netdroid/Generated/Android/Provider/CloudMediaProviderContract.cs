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

namespace Android.Provider
{
    #region CloudMediaProviderContract declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/provider/CloudMediaProviderContract.html"/>
    /// </summary>
    public partial class CloudMediaProviderContract : MASES.JCOBridge.C2JBridge.JVMBridgeBase<CloudMediaProviderContract>
    {
        const string _bridgeClassName = "android.provider.CloudMediaProviderContract";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public CloudMediaProviderContract() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public CloudMediaProviderContract(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => false;
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
        #region AlbumColumns declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/CloudMediaProviderContract.AlbumColumns.html"/>
        /// </summary>
        public partial class AlbumColumns : MASES.JCOBridge.C2JBridge.JVMBridgeBase<AlbumColumns>
        {
            const string _bridgeClassName = "android.provider.CloudMediaProviderContract$AlbumColumns";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public AlbumColumns() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public AlbumColumns(params object[] args) : base(args) { }

            private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
            private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
            /// </summary>
            public override string BridgeClassName => _bridgeClassName;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
            /// </summary>
            public override bool IsBridgeAbstract => false;
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
            public override bool IsBridgeStatic => true;

            // TODO: complete the class

        }
        #endregion

        #region MediaCollectionInfo declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/CloudMediaProviderContract.MediaCollectionInfo.html"/>
        /// </summary>
        public partial class MediaCollectionInfo : MASES.JCOBridge.C2JBridge.JVMBridgeBase<MediaCollectionInfo>
        {
            const string _bridgeClassName = "android.provider.CloudMediaProviderContract$MediaCollectionInfo";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public MediaCollectionInfo() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public MediaCollectionInfo(params object[] args) : base(args) { }

            private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
            private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
            /// </summary>
            public override string BridgeClassName => _bridgeClassName;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
            /// </summary>
            public override bool IsBridgeAbstract => false;
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
            public override bool IsBridgeStatic => true;

            // TODO: complete the class

        }
        #endregion

        #region MediaColumns declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/CloudMediaProviderContract.MediaColumns.html"/>
        /// </summary>
        public partial class MediaColumns : MASES.JCOBridge.C2JBridge.JVMBridgeBase<MediaColumns>
        {
            const string _bridgeClassName = "android.provider.CloudMediaProviderContract$MediaColumns";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public MediaColumns() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public MediaColumns(params object[] args) : base(args) { }

            private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
            private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
            /// </summary>
            public override string BridgeClassName => _bridgeClassName;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
            /// </summary>
            public override bool IsBridgeAbstract => false;
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
            public override bool IsBridgeStatic => true;

            // TODO: complete the class

        }
        #endregion

    
    }
    #endregion

    #region CloudMediaProviderContract implementation
    public partial class CloudMediaProviderContract
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/CloudMediaProviderContract.html#EXTRA_ALBUM_ID"/>
        /// </summary>
        public static Java.Lang.String EXTRA_ALBUM_ID { get { if (!_EXTRA_ALBUM_IDReady) { _EXTRA_ALBUM_IDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_ALBUM_ID"); _EXTRA_ALBUM_IDReady = true; } return _EXTRA_ALBUM_IDContent; } }
        private static Java.Lang.String _EXTRA_ALBUM_IDContent = default;
        private static bool _EXTRA_ALBUM_IDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/CloudMediaProviderContract.html#EXTRA_LOOPING_PLAYBACK_ENABLED"/>
        /// </summary>
        public static Java.Lang.String EXTRA_LOOPING_PLAYBACK_ENABLED { get { if (!_EXTRA_LOOPING_PLAYBACK_ENABLEDReady) { _EXTRA_LOOPING_PLAYBACK_ENABLEDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_LOOPING_PLAYBACK_ENABLED"); _EXTRA_LOOPING_PLAYBACK_ENABLEDReady = true; } return _EXTRA_LOOPING_PLAYBACK_ENABLEDContent; } }
        private static Java.Lang.String _EXTRA_LOOPING_PLAYBACK_ENABLEDContent = default;
        private static bool _EXTRA_LOOPING_PLAYBACK_ENABLEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/CloudMediaProviderContract.html#EXTRA_MEDIA_COLLECTION_ID"/>
        /// </summary>
        public static Java.Lang.String EXTRA_MEDIA_COLLECTION_ID { get { if (!_EXTRA_MEDIA_COLLECTION_IDReady) { _EXTRA_MEDIA_COLLECTION_IDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_MEDIA_COLLECTION_ID"); _EXTRA_MEDIA_COLLECTION_IDReady = true; } return _EXTRA_MEDIA_COLLECTION_IDContent; } }
        private static Java.Lang.String _EXTRA_MEDIA_COLLECTION_IDContent = default;
        private static bool _EXTRA_MEDIA_COLLECTION_IDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/CloudMediaProviderContract.html#EXTRA_PAGE_SIZE"/>
        /// </summary>
        public static Java.Lang.String EXTRA_PAGE_SIZE { get { if (!_EXTRA_PAGE_SIZEReady) { _EXTRA_PAGE_SIZEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_PAGE_SIZE"); _EXTRA_PAGE_SIZEReady = true; } return _EXTRA_PAGE_SIZEContent; } }
        private static Java.Lang.String _EXTRA_PAGE_SIZEContent = default;
        private static bool _EXTRA_PAGE_SIZEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/CloudMediaProviderContract.html#EXTRA_PAGE_TOKEN"/>
        /// </summary>
        public static Java.Lang.String EXTRA_PAGE_TOKEN { get { if (!_EXTRA_PAGE_TOKENReady) { _EXTRA_PAGE_TOKENContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_PAGE_TOKEN"); _EXTRA_PAGE_TOKENReady = true; } return _EXTRA_PAGE_TOKENContent; } }
        private static Java.Lang.String _EXTRA_PAGE_TOKENContent = default;
        private static bool _EXTRA_PAGE_TOKENReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/CloudMediaProviderContract.html#EXTRA_PREVIEW_THUMBNAIL"/>
        /// </summary>
        public static Java.Lang.String EXTRA_PREVIEW_THUMBNAIL { get { if (!_EXTRA_PREVIEW_THUMBNAILReady) { _EXTRA_PREVIEW_THUMBNAILContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_PREVIEW_THUMBNAIL"); _EXTRA_PREVIEW_THUMBNAILReady = true; } return _EXTRA_PREVIEW_THUMBNAILContent; } }
        private static Java.Lang.String _EXTRA_PREVIEW_THUMBNAILContent = default;
        private static bool _EXTRA_PREVIEW_THUMBNAILReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/CloudMediaProviderContract.html#EXTRA_SURFACE_CONTROLLER_AUDIO_MUTE_ENABLED"/>
        /// </summary>
        public static Java.Lang.String EXTRA_SURFACE_CONTROLLER_AUDIO_MUTE_ENABLED { get { if (!_EXTRA_SURFACE_CONTROLLER_AUDIO_MUTE_ENABLEDReady) { _EXTRA_SURFACE_CONTROLLER_AUDIO_MUTE_ENABLEDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_SURFACE_CONTROLLER_AUDIO_MUTE_ENABLED"); _EXTRA_SURFACE_CONTROLLER_AUDIO_MUTE_ENABLEDReady = true; } return _EXTRA_SURFACE_CONTROLLER_AUDIO_MUTE_ENABLEDContent; } }
        private static Java.Lang.String _EXTRA_SURFACE_CONTROLLER_AUDIO_MUTE_ENABLEDContent = default;
        private static bool _EXTRA_SURFACE_CONTROLLER_AUDIO_MUTE_ENABLEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/CloudMediaProviderContract.html#EXTRA_SYNC_GENERATION"/>
        /// </summary>
        public static Java.Lang.String EXTRA_SYNC_GENERATION { get { if (!_EXTRA_SYNC_GENERATIONReady) { _EXTRA_SYNC_GENERATIONContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_SYNC_GENERATION"); _EXTRA_SYNC_GENERATIONReady = true; } return _EXTRA_SYNC_GENERATIONContent; } }
        private static Java.Lang.String _EXTRA_SYNC_GENERATIONContent = default;
        private static bool _EXTRA_SYNC_GENERATIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/CloudMediaProviderContract.html#MANAGE_CLOUD_MEDIA_PROVIDERS_PERMISSION"/>
        /// </summary>
        public static Java.Lang.String MANAGE_CLOUD_MEDIA_PROVIDERS_PERMISSION { get { if (!_MANAGE_CLOUD_MEDIA_PROVIDERS_PERMISSIONReady) { _MANAGE_CLOUD_MEDIA_PROVIDERS_PERMISSIONContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "MANAGE_CLOUD_MEDIA_PROVIDERS_PERMISSION"); _MANAGE_CLOUD_MEDIA_PROVIDERS_PERMISSIONReady = true; } return _MANAGE_CLOUD_MEDIA_PROVIDERS_PERMISSIONContent; } }
        private static Java.Lang.String _MANAGE_CLOUD_MEDIA_PROVIDERS_PERMISSIONContent = default;
        private static bool _MANAGE_CLOUD_MEDIA_PROVIDERS_PERMISSIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/CloudMediaProviderContract.html#PROVIDER_INTERFACE"/>
        /// </summary>
        public static Java.Lang.String PROVIDER_INTERFACE { get { if (!_PROVIDER_INTERFACEReady) { _PROVIDER_INTERFACEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "PROVIDER_INTERFACE"); _PROVIDER_INTERFACEReady = true; } return _PROVIDER_INTERFACEContent; } }
        private static Java.Lang.String _PROVIDER_INTERFACEContent = default;
        private static bool _PROVIDER_INTERFACEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes
        #region AlbumColumns implementation
        public partial class AlbumColumns
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/CloudMediaProviderContract.AlbumColumns.html#DATE_TAKEN_MILLIS"/>
            /// </summary>
            public static Java.Lang.String DATE_TAKEN_MILLIS { get { if (!_DATE_TAKEN_MILLISReady) { _DATE_TAKEN_MILLISContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "DATE_TAKEN_MILLIS"); _DATE_TAKEN_MILLISReady = true; } return _DATE_TAKEN_MILLISContent; } }
            private static Java.Lang.String _DATE_TAKEN_MILLISContent = default;
            private static bool _DATE_TAKEN_MILLISReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/CloudMediaProviderContract.AlbumColumns.html#DISPLAY_NAME"/>
            /// </summary>
            public static Java.Lang.String DISPLAY_NAME { get { if (!_DISPLAY_NAMEReady) { _DISPLAY_NAMEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "DISPLAY_NAME"); _DISPLAY_NAMEReady = true; } return _DISPLAY_NAMEContent; } }
            private static Java.Lang.String _DISPLAY_NAMEContent = default;
            private static bool _DISPLAY_NAMEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/CloudMediaProviderContract.AlbumColumns.html#ID"/>
            /// </summary>
            public static Java.Lang.String ID { get { if (!_IDReady) { _IDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ID"); _IDReady = true; } return _IDContent; } }
            private static Java.Lang.String _IDContent = default;
            private static bool _IDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/CloudMediaProviderContract.AlbumColumns.html#MEDIA_COUNT"/>
            /// </summary>
            public static Java.Lang.String MEDIA_COUNT { get { if (!_MEDIA_COUNTReady) { _MEDIA_COUNTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "MEDIA_COUNT"); _MEDIA_COUNTReady = true; } return _MEDIA_COUNTContent; } }
            private static Java.Lang.String _MEDIA_COUNTContent = default;
            private static bool _MEDIA_COUNTReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/CloudMediaProviderContract.AlbumColumns.html#MEDIA_COVER_ID"/>
            /// </summary>
            public static Java.Lang.String MEDIA_COVER_ID { get { if (!_MEDIA_COVER_IDReady) { _MEDIA_COVER_IDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "MEDIA_COVER_ID"); _MEDIA_COVER_IDReady = true; } return _MEDIA_COVER_IDContent; } }
            private static Java.Lang.String _MEDIA_COVER_IDContent = default;
            private static bool _MEDIA_COVER_IDReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region MediaCollectionInfo implementation
        public partial class MediaCollectionInfo
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/CloudMediaProviderContract.MediaCollectionInfo.html#ACCOUNT_CONFIGURATION_INTENT"/>
            /// </summary>
            public static Java.Lang.String ACCOUNT_CONFIGURATION_INTENT { get { if (!_ACCOUNT_CONFIGURATION_INTENTReady) { _ACCOUNT_CONFIGURATION_INTENTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACCOUNT_CONFIGURATION_INTENT"); _ACCOUNT_CONFIGURATION_INTENTReady = true; } return _ACCOUNT_CONFIGURATION_INTENTContent; } }
            private static Java.Lang.String _ACCOUNT_CONFIGURATION_INTENTContent = default;
            private static bool _ACCOUNT_CONFIGURATION_INTENTReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/CloudMediaProviderContract.MediaCollectionInfo.html#ACCOUNT_NAME"/>
            /// </summary>
            public static Java.Lang.String ACCOUNT_NAME { get { if (!_ACCOUNT_NAMEReady) { _ACCOUNT_NAMEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACCOUNT_NAME"); _ACCOUNT_NAMEReady = true; } return _ACCOUNT_NAMEContent; } }
            private static Java.Lang.String _ACCOUNT_NAMEContent = default;
            private static bool _ACCOUNT_NAMEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/CloudMediaProviderContract.MediaCollectionInfo.html#LAST_MEDIA_SYNC_GENERATION"/>
            /// </summary>
            public static Java.Lang.String LAST_MEDIA_SYNC_GENERATION { get { if (!_LAST_MEDIA_SYNC_GENERATIONReady) { _LAST_MEDIA_SYNC_GENERATIONContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "LAST_MEDIA_SYNC_GENERATION"); _LAST_MEDIA_SYNC_GENERATIONReady = true; } return _LAST_MEDIA_SYNC_GENERATIONContent; } }
            private static Java.Lang.String _LAST_MEDIA_SYNC_GENERATIONContent = default;
            private static bool _LAST_MEDIA_SYNC_GENERATIONReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/CloudMediaProviderContract.MediaCollectionInfo.html#MEDIA_COLLECTION_ID"/>
            /// </summary>
            public static Java.Lang.String MEDIA_COLLECTION_ID { get { if (!_MEDIA_COLLECTION_IDReady) { _MEDIA_COLLECTION_IDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "MEDIA_COLLECTION_ID"); _MEDIA_COLLECTION_IDReady = true; } return _MEDIA_COLLECTION_IDContent; } }
            private static Java.Lang.String _MEDIA_COLLECTION_IDContent = default;
            private static bool _MEDIA_COLLECTION_IDReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region MediaColumns implementation
        public partial class MediaColumns
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/CloudMediaProviderContract.MediaColumns.html#STANDARD_MIME_TYPE_EXTENSION_ANIMATED_WEBP"/>
            /// </summary>
            public static int STANDARD_MIME_TYPE_EXTENSION_ANIMATED_WEBP { get { if (!_STANDARD_MIME_TYPE_EXTENSION_ANIMATED_WEBPReady) { _STANDARD_MIME_TYPE_EXTENSION_ANIMATED_WEBPContent = SGetField<int>(LocalBridgeClazz, "STANDARD_MIME_TYPE_EXTENSION_ANIMATED_WEBP"); _STANDARD_MIME_TYPE_EXTENSION_ANIMATED_WEBPReady = true; } return _STANDARD_MIME_TYPE_EXTENSION_ANIMATED_WEBPContent; } }
            private static int _STANDARD_MIME_TYPE_EXTENSION_ANIMATED_WEBPContent = default;
            private static bool _STANDARD_MIME_TYPE_EXTENSION_ANIMATED_WEBPReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/CloudMediaProviderContract.MediaColumns.html#STANDARD_MIME_TYPE_EXTENSION_GIF"/>
            /// </summary>
            public static int STANDARD_MIME_TYPE_EXTENSION_GIF { get { if (!_STANDARD_MIME_TYPE_EXTENSION_GIFReady) { _STANDARD_MIME_TYPE_EXTENSION_GIFContent = SGetField<int>(LocalBridgeClazz, "STANDARD_MIME_TYPE_EXTENSION_GIF"); _STANDARD_MIME_TYPE_EXTENSION_GIFReady = true; } return _STANDARD_MIME_TYPE_EXTENSION_GIFContent; } }
            private static int _STANDARD_MIME_TYPE_EXTENSION_GIFContent = default;
            private static bool _STANDARD_MIME_TYPE_EXTENSION_GIFReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/CloudMediaProviderContract.MediaColumns.html#STANDARD_MIME_TYPE_EXTENSION_MOTION_PHOTO"/>
            /// </summary>
            public static int STANDARD_MIME_TYPE_EXTENSION_MOTION_PHOTO { get { if (!_STANDARD_MIME_TYPE_EXTENSION_MOTION_PHOTOReady) { _STANDARD_MIME_TYPE_EXTENSION_MOTION_PHOTOContent = SGetField<int>(LocalBridgeClazz, "STANDARD_MIME_TYPE_EXTENSION_MOTION_PHOTO"); _STANDARD_MIME_TYPE_EXTENSION_MOTION_PHOTOReady = true; } return _STANDARD_MIME_TYPE_EXTENSION_MOTION_PHOTOContent; } }
            private static int _STANDARD_MIME_TYPE_EXTENSION_MOTION_PHOTOContent = default;
            private static bool _STANDARD_MIME_TYPE_EXTENSION_MOTION_PHOTOReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/CloudMediaProviderContract.MediaColumns.html#STANDARD_MIME_TYPE_EXTENSION_NONE"/>
            /// </summary>
            public static int STANDARD_MIME_TYPE_EXTENSION_NONE { get { if (!_STANDARD_MIME_TYPE_EXTENSION_NONEReady) { _STANDARD_MIME_TYPE_EXTENSION_NONEContent = SGetField<int>(LocalBridgeClazz, "STANDARD_MIME_TYPE_EXTENSION_NONE"); _STANDARD_MIME_TYPE_EXTENSION_NONEReady = true; } return _STANDARD_MIME_TYPE_EXTENSION_NONEContent; } }
            private static int _STANDARD_MIME_TYPE_EXTENSION_NONEContent = default;
            private static bool _STANDARD_MIME_TYPE_EXTENSION_NONEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/CloudMediaProviderContract.MediaColumns.html#DATE_TAKEN_MILLIS"/>
            /// </summary>
            public static Java.Lang.String DATE_TAKEN_MILLIS { get { if (!_DATE_TAKEN_MILLISReady) { _DATE_TAKEN_MILLISContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "DATE_TAKEN_MILLIS"); _DATE_TAKEN_MILLISReady = true; } return _DATE_TAKEN_MILLISContent; } }
            private static Java.Lang.String _DATE_TAKEN_MILLISContent = default;
            private static bool _DATE_TAKEN_MILLISReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/CloudMediaProviderContract.MediaColumns.html#DURATION_MILLIS"/>
            /// </summary>
            public static Java.Lang.String DURATION_MILLIS { get { if (!_DURATION_MILLISReady) { _DURATION_MILLISContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "DURATION_MILLIS"); _DURATION_MILLISReady = true; } return _DURATION_MILLISContent; } }
            private static Java.Lang.String _DURATION_MILLISContent = default;
            private static bool _DURATION_MILLISReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/CloudMediaProviderContract.MediaColumns.html#HEIGHT"/>
            /// </summary>
            public static Java.Lang.String HEIGHT { get { if (!_HEIGHTReady) { _HEIGHTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "HEIGHT"); _HEIGHTReady = true; } return _HEIGHTContent; } }
            private static Java.Lang.String _HEIGHTContent = default;
            private static bool _HEIGHTReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/CloudMediaProviderContract.MediaColumns.html#ID"/>
            /// </summary>
            public static Java.Lang.String ID { get { if (!_IDReady) { _IDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ID"); _IDReady = true; } return _IDContent; } }
            private static Java.Lang.String _IDContent = default;
            private static bool _IDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/CloudMediaProviderContract.MediaColumns.html#IS_FAVORITE"/>
            /// </summary>
            public static Java.Lang.String IS_FAVORITE { get { if (!_IS_FAVORITEReady) { _IS_FAVORITEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "IS_FAVORITE"); _IS_FAVORITEReady = true; } return _IS_FAVORITEContent; } }
            private static Java.Lang.String _IS_FAVORITEContent = default;
            private static bool _IS_FAVORITEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/CloudMediaProviderContract.MediaColumns.html#MEDIA_STORE_URI"/>
            /// </summary>
            public static Java.Lang.String MEDIA_STORE_URI { get { if (!_MEDIA_STORE_URIReady) { _MEDIA_STORE_URIContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "MEDIA_STORE_URI"); _MEDIA_STORE_URIReady = true; } return _MEDIA_STORE_URIContent; } }
            private static Java.Lang.String _MEDIA_STORE_URIContent = default;
            private static bool _MEDIA_STORE_URIReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/CloudMediaProviderContract.MediaColumns.html#MIME_TYPE"/>
            /// </summary>
            public static Java.Lang.String MIME_TYPE { get { if (!_MIME_TYPEReady) { _MIME_TYPEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "MIME_TYPE"); _MIME_TYPEReady = true; } return _MIME_TYPEContent; } }
            private static Java.Lang.String _MIME_TYPEContent = default;
            private static bool _MIME_TYPEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/CloudMediaProviderContract.MediaColumns.html#ORIENTATION"/>
            /// </summary>
            public static Java.Lang.String ORIENTATION { get { if (!_ORIENTATIONReady) { _ORIENTATIONContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ORIENTATION"); _ORIENTATIONReady = true; } return _ORIENTATIONContent; } }
            private static Java.Lang.String _ORIENTATIONContent = default;
            private static bool _ORIENTATIONReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/CloudMediaProviderContract.MediaColumns.html#SIZE_BYTES"/>
            /// </summary>
            public static Java.Lang.String SIZE_BYTES { get { if (!_SIZE_BYTESReady) { _SIZE_BYTESContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SIZE_BYTES"); _SIZE_BYTESReady = true; } return _SIZE_BYTESContent; } }
            private static Java.Lang.String _SIZE_BYTESContent = default;
            private static bool _SIZE_BYTESReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/CloudMediaProviderContract.MediaColumns.html#STANDARD_MIME_TYPE_EXTENSION"/>
            /// </summary>
            public static Java.Lang.String STANDARD_MIME_TYPE_EXTENSION { get { if (!_STANDARD_MIME_TYPE_EXTENSIONReady) { _STANDARD_MIME_TYPE_EXTENSIONContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "STANDARD_MIME_TYPE_EXTENSION"); _STANDARD_MIME_TYPE_EXTENSIONReady = true; } return _STANDARD_MIME_TYPE_EXTENSIONContent; } }
            private static Java.Lang.String _STANDARD_MIME_TYPE_EXTENSIONContent = default;
            private static bool _STANDARD_MIME_TYPE_EXTENSIONReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/CloudMediaProviderContract.MediaColumns.html#SYNC_GENERATION"/>
            /// </summary>
            public static Java.Lang.String SYNC_GENERATION { get { if (!_SYNC_GENERATIONReady) { _SYNC_GENERATIONContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SYNC_GENERATION"); _SYNC_GENERATIONReady = true; } return _SYNC_GENERATIONContent; } }
            private static Java.Lang.String _SYNC_GENERATIONContent = default;
            private static bool _SYNC_GENERATIONReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/CloudMediaProviderContract.MediaColumns.html#WIDTH"/>
            /// </summary>
            public static Java.Lang.String WIDTH { get { if (!_WIDTHReady) { _WIDTHContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "WIDTH"); _WIDTHReady = true; } return _WIDTHContent; } }
            private static Java.Lang.String _WIDTHContent = default;
            private static bool _WIDTHReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods

            #endregion

            #region Instance methods

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