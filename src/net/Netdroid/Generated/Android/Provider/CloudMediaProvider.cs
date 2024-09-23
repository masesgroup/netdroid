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
    #region CloudMediaProvider declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/provider/CloudMediaProvider.html"/>
    /// </summary>
    public partial class CloudMediaProvider : Android.Content.ContentProvider
    {
        const string _bridgeClassName = "android.provider.CloudMediaProvider";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("CloudMediaProvider class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public CloudMediaProvider() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("CloudMediaProvider class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public CloudMediaProvider(params object[] args) : base(args) { }
    
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
    
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
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
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;
    
        // TODO: complete the class
        #region CloudMediaSurfaceController declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/CloudMediaProvider.CloudMediaSurfaceController.html"/>
        /// </summary>
        public partial class CloudMediaSurfaceController : MASES.JCOBridge.C2JBridge.JVMBridgeBase<CloudMediaSurfaceController>
        {
            const string _bridgeClassName = "android.provider.CloudMediaProvider$CloudMediaSurfaceController";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            [global::System.Obsolete("CloudMediaSurfaceController class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public CloudMediaSurfaceController() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            [global::System.Obsolete("CloudMediaSurfaceController class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public CloudMediaSurfaceController(params object[] args) : base(args) { }
        
            private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
            private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
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
            public override bool IsBridgeInterface => false;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
            /// </summary>
            public override bool IsBridgeStatic => true;
        
            // TODO: complete the class
        
        }
        #endregion

        #region CloudMediaSurfaceStateChangedCallback declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/CloudMediaProvider.CloudMediaSurfaceStateChangedCallback.html"/>
        /// </summary>
        public partial class CloudMediaSurfaceStateChangedCallback : MASES.JCOBridge.C2JBridge.JVMBridgeBase<CloudMediaSurfaceStateChangedCallback>
        {
            const string _bridgeClassName = "android.provider.CloudMediaProvider$CloudMediaSurfaceStateChangedCallback";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public CloudMediaSurfaceStateChangedCallback() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public CloudMediaSurfaceStateChangedCallback(params object[] args) : base(args) { }
        
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

    #region CloudMediaProvider implementation
    public partial class CloudMediaProvider
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
        /// <see href="https://developer.android.com/reference/android/provider/CloudMediaProvider.html#onOpenPreview(java.lang.String,android.graphics.Point,android.os.Bundle,android.os.CancellationSignal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Android.Graphics.Point"/></param>
        /// <param name="arg2"><see cref="Android.Os.Bundle"/></param>
        /// <param name="arg3"><see cref="Android.Os.CancellationSignal"/></param>
        /// <returns><see cref="Android.Content.Res.AssetFileDescriptor"/></returns>
        /// <exception cref="Java.Io.FileNotFoundException"/>
        public Android.Content.Res.AssetFileDescriptor OnOpenPreview(Java.Lang.String arg0, Android.Graphics.Point arg1, Android.Os.Bundle arg2, Android.Os.CancellationSignal arg3)
        {
            return IExecute<Android.Content.Res.AssetFileDescriptor>("onOpenPreview", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/CloudMediaProvider.html#onQueryDeletedMedia(android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
        /// <returns><see cref="Android.Database.Cursor"/></returns>
        public Android.Database.Cursor OnQueryDeletedMedia(Android.Os.Bundle arg0)
        {
            return IExecuteWithSignature<Android.Database.Cursor>("onQueryDeletedMedia", "(Landroid/os/Bundle;)Landroid/database/Cursor;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/CloudMediaProvider.html#onQueryMedia(android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
        /// <returns><see cref="Android.Database.Cursor"/></returns>
        public Android.Database.Cursor OnQueryMedia(Android.Os.Bundle arg0)
        {
            return IExecuteWithSignature<Android.Database.Cursor>("onQueryMedia", "(Landroid/os/Bundle;)Landroid/database/Cursor;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/CloudMediaProvider.html#onGetMediaCollectionInfo(android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
        /// <returns><see cref="Android.Os.Bundle"/></returns>
        public Android.Os.Bundle OnGetMediaCollectionInfo(Android.Os.Bundle arg0)
        {
            return IExecuteWithSignature<Android.Os.Bundle>("onGetMediaCollectionInfo", "(Landroid/os/Bundle;)Landroid/os/Bundle;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/CloudMediaProvider.html#onOpenMedia(java.lang.String,android.os.Bundle,android.os.CancellationSignal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Android.Os.Bundle"/></param>
        /// <param name="arg2"><see cref="Android.Os.CancellationSignal"/></param>
        /// <returns><see cref="Android.Os.ParcelFileDescriptor"/></returns>
        /// <exception cref="Java.Io.FileNotFoundException"/>
        public Android.Os.ParcelFileDescriptor OnOpenMedia(Java.Lang.String arg0, Android.Os.Bundle arg1, Android.Os.CancellationSignal arg2)
        {
            return IExecute<Android.Os.ParcelFileDescriptor>("onOpenMedia", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/CloudMediaProvider.html#onQueryAlbums(android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
        /// <returns><see cref="Android.Database.Cursor"/></returns>
        public Android.Database.Cursor OnQueryAlbums(Android.Os.Bundle arg0)
        {
            return IExecuteWithSignature<Android.Database.Cursor>("onQueryAlbums", "(Landroid/os/Bundle;)Landroid/database/Cursor;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/CloudMediaProvider.html#onCreateCloudMediaSurfaceController(android.os.Bundle,android.provider.CloudMediaProvider.CloudMediaSurfaceStateChangedCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
        /// <param name="arg1"><see cref="Android.Provider.CloudMediaProvider.CloudMediaSurfaceStateChangedCallback"/></param>
        /// <returns><see cref="Android.Provider.CloudMediaProvider.CloudMediaSurfaceController"/></returns>
        public Android.Provider.CloudMediaProvider.CloudMediaSurfaceController OnCreateCloudMediaSurfaceController(Android.Os.Bundle arg0, Android.Provider.CloudMediaProvider.CloudMediaSurfaceStateChangedCallback arg1)
        {
            return IExecute<Android.Provider.CloudMediaProvider.CloudMediaSurfaceController>("onCreateCloudMediaSurfaceController", arg0, arg1);
        }
    
        #endregion
    
        #region Nested classes
        #region CloudMediaSurfaceController implementation
        public partial class CloudMediaSurfaceController
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
            /// <see href="https://developer.android.com/reference/android/provider/CloudMediaProvider.CloudMediaSurfaceController.html#onConfigChange(android.os.Bundle)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
            public void OnConfigChange(Android.Os.Bundle arg0)
            {
                IExecuteWithSignature("onConfigChange", "(Landroid/os/Bundle;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/CloudMediaProvider.CloudMediaSurfaceController.html#onDestroy()"/>
            /// </summary>
            public void OnDestroy()
            {
                IExecuteWithSignature("onDestroy", "()V");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/CloudMediaProvider.CloudMediaSurfaceController.html#onMediaPause(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            public void OnMediaPause(int arg0)
            {
                IExecuteWithSignature("onMediaPause", "(I)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/CloudMediaProvider.CloudMediaSurfaceController.html#onMediaPlay(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            public void OnMediaPlay(int arg0)
            {
                IExecuteWithSignature("onMediaPlay", "(I)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/CloudMediaProvider.CloudMediaSurfaceController.html#onMediaSeekTo(int,long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="long"/></param>
            public void OnMediaSeekTo(int arg0, long arg1)
            {
                IExecute("onMediaSeekTo", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/CloudMediaProvider.CloudMediaSurfaceController.html#onPlayerCreate()"/>
            /// </summary>
            public void OnPlayerCreate()
            {
                IExecuteWithSignature("onPlayerCreate", "()V");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/CloudMediaProvider.CloudMediaSurfaceController.html#onPlayerRelease()"/>
            /// </summary>
            public void OnPlayerRelease()
            {
                IExecuteWithSignature("onPlayerRelease", "()V");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/CloudMediaProvider.CloudMediaSurfaceController.html#onSurfaceChanged(int,int,int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            /// <param name="arg3"><see cref="int"/></param>
            public void OnSurfaceChanged(int arg0, int arg1, int arg2, int arg3)
            {
                IExecute("onSurfaceChanged", arg0, arg1, arg2, arg3);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/CloudMediaProvider.CloudMediaSurfaceController.html#onSurfaceCreated(int,android.view.Surface,java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="Android.View.Surface"/></param>
            /// <param name="arg2"><see cref="Java.Lang.String"/></param>
            public void OnSurfaceCreated(int arg0, Android.View.Surface arg1, Java.Lang.String arg2)
            {
                IExecute("onSurfaceCreated", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/CloudMediaProvider.CloudMediaSurfaceController.html#onSurfaceDestroyed(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            public void OnSurfaceDestroyed(int arg0)
            {
                IExecuteWithSignature("onSurfaceDestroyed", "(I)V", arg0);
            }
        
            #endregion
        
            #region Nested classes
        
            #endregion
        
            // TODO: complete the class
        }
        #endregion

        #region CloudMediaSurfaceStateChangedCallback implementation
        public partial class CloudMediaSurfaceStateChangedCallback
        {
            #region Constructors
        
            #endregion
        
            #region Class/Interface conversion operators
        
            #endregion
        
            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/CloudMediaProvider.CloudMediaSurfaceStateChangedCallback.html#PLAYBACK_STATE_BUFFERING"/>
            /// </summary>
            public static int PLAYBACK_STATE_BUFFERING { get { if (!_PLAYBACK_STATE_BUFFERINGReady) { _PLAYBACK_STATE_BUFFERINGContent = SGetField<int>(LocalBridgeClazz, "PLAYBACK_STATE_BUFFERING"); _PLAYBACK_STATE_BUFFERINGReady = true; } return _PLAYBACK_STATE_BUFFERINGContent; } }
            private static int _PLAYBACK_STATE_BUFFERINGContent = default;
            private static bool _PLAYBACK_STATE_BUFFERINGReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/CloudMediaProvider.CloudMediaSurfaceStateChangedCallback.html#PLAYBACK_STATE_COMPLETED"/>
            /// </summary>
            public static int PLAYBACK_STATE_COMPLETED { get { if (!_PLAYBACK_STATE_COMPLETEDReady) { _PLAYBACK_STATE_COMPLETEDContent = SGetField<int>(LocalBridgeClazz, "PLAYBACK_STATE_COMPLETED"); _PLAYBACK_STATE_COMPLETEDReady = true; } return _PLAYBACK_STATE_COMPLETEDContent; } }
            private static int _PLAYBACK_STATE_COMPLETEDContent = default;
            private static bool _PLAYBACK_STATE_COMPLETEDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/CloudMediaProvider.CloudMediaSurfaceStateChangedCallback.html#PLAYBACK_STATE_ERROR_PERMANENT_FAILURE"/>
            /// </summary>
            public static int PLAYBACK_STATE_ERROR_PERMANENT_FAILURE { get { if (!_PLAYBACK_STATE_ERROR_PERMANENT_FAILUREReady) { _PLAYBACK_STATE_ERROR_PERMANENT_FAILUREContent = SGetField<int>(LocalBridgeClazz, "PLAYBACK_STATE_ERROR_PERMANENT_FAILURE"); _PLAYBACK_STATE_ERROR_PERMANENT_FAILUREReady = true; } return _PLAYBACK_STATE_ERROR_PERMANENT_FAILUREContent; } }
            private static int _PLAYBACK_STATE_ERROR_PERMANENT_FAILUREContent = default;
            private static bool _PLAYBACK_STATE_ERROR_PERMANENT_FAILUREReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/CloudMediaProvider.CloudMediaSurfaceStateChangedCallback.html#PLAYBACK_STATE_ERROR_RETRIABLE_FAILURE"/>
            /// </summary>
            public static int PLAYBACK_STATE_ERROR_RETRIABLE_FAILURE { get { if (!_PLAYBACK_STATE_ERROR_RETRIABLE_FAILUREReady) { _PLAYBACK_STATE_ERROR_RETRIABLE_FAILUREContent = SGetField<int>(LocalBridgeClazz, "PLAYBACK_STATE_ERROR_RETRIABLE_FAILURE"); _PLAYBACK_STATE_ERROR_RETRIABLE_FAILUREReady = true; } return _PLAYBACK_STATE_ERROR_RETRIABLE_FAILUREContent; } }
            private static int _PLAYBACK_STATE_ERROR_RETRIABLE_FAILUREContent = default;
            private static bool _PLAYBACK_STATE_ERROR_RETRIABLE_FAILUREReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/CloudMediaProvider.CloudMediaSurfaceStateChangedCallback.html#PLAYBACK_STATE_MEDIA_SIZE_CHANGED"/>
            /// </summary>
            public static int PLAYBACK_STATE_MEDIA_SIZE_CHANGED { get { if (!_PLAYBACK_STATE_MEDIA_SIZE_CHANGEDReady) { _PLAYBACK_STATE_MEDIA_SIZE_CHANGEDContent = SGetField<int>(LocalBridgeClazz, "PLAYBACK_STATE_MEDIA_SIZE_CHANGED"); _PLAYBACK_STATE_MEDIA_SIZE_CHANGEDReady = true; } return _PLAYBACK_STATE_MEDIA_SIZE_CHANGEDContent; } }
            private static int _PLAYBACK_STATE_MEDIA_SIZE_CHANGEDContent = default;
            private static bool _PLAYBACK_STATE_MEDIA_SIZE_CHANGEDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/CloudMediaProvider.CloudMediaSurfaceStateChangedCallback.html#PLAYBACK_STATE_PAUSED"/>
            /// </summary>
            public static int PLAYBACK_STATE_PAUSED { get { if (!_PLAYBACK_STATE_PAUSEDReady) { _PLAYBACK_STATE_PAUSEDContent = SGetField<int>(LocalBridgeClazz, "PLAYBACK_STATE_PAUSED"); _PLAYBACK_STATE_PAUSEDReady = true; } return _PLAYBACK_STATE_PAUSEDContent; } }
            private static int _PLAYBACK_STATE_PAUSEDContent = default;
            private static bool _PLAYBACK_STATE_PAUSEDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/CloudMediaProvider.CloudMediaSurfaceStateChangedCallback.html#PLAYBACK_STATE_READY"/>
            /// </summary>
            public static int PLAYBACK_STATE_READY { get { if (!_PLAYBACK_STATE_READYReady) { _PLAYBACK_STATE_READYContent = SGetField<int>(LocalBridgeClazz, "PLAYBACK_STATE_READY"); _PLAYBACK_STATE_READYReady = true; } return _PLAYBACK_STATE_READYContent; } }
            private static int _PLAYBACK_STATE_READYContent = default;
            private static bool _PLAYBACK_STATE_READYReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/CloudMediaProvider.CloudMediaSurfaceStateChangedCallback.html#PLAYBACK_STATE_STARTED"/>
            /// </summary>
            public static int PLAYBACK_STATE_STARTED { get { if (!_PLAYBACK_STATE_STARTEDReady) { _PLAYBACK_STATE_STARTEDContent = SGetField<int>(LocalBridgeClazz, "PLAYBACK_STATE_STARTED"); _PLAYBACK_STATE_STARTEDReady = true; } return _PLAYBACK_STATE_STARTEDContent; } }
            private static int _PLAYBACK_STATE_STARTEDContent = default;
            private static bool _PLAYBACK_STATE_STARTEDReady = false; // this is used because in case of generics 
        
            #endregion
        
            #region Static methods
        
            #endregion
        
            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/CloudMediaProvider.CloudMediaSurfaceStateChangedCallback.html#setPlaybackState(int,int,android.os.Bundle)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="Android.Os.Bundle"/></param>
            public void SetPlaybackState(int arg0, int arg1, Android.Os.Bundle arg2)
            {
                IExecute("setPlaybackState", arg0, arg1, arg2);
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