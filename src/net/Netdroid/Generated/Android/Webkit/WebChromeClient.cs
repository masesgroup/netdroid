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

namespace Android.Webkit
{
    #region WebChromeClient
    public partial class WebChromeClient
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
        /// <see href="https://developer.android.com/reference/android/webkit/WebChromeClient.html#getDefaultVideoPoster()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.Bitmap"/></returns>
        public Android.Graphics.Bitmap GetDefaultVideoPoster()
        {
            return IExecuteWithSignature<Android.Graphics.Bitmap>("getDefaultVideoPoster", "()Landroid/graphics/Bitmap;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebChromeClient.html#getVideoLoadingProgressView()"/>
        /// </summary>
        /// <returns><see cref="Android.View.View"/></returns>
        public Android.View.View GetVideoLoadingProgressView()
        {
            return IExecuteWithSignature<Android.View.View>("getVideoLoadingProgressView", "()Landroid/view/View;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebChromeClient.html#onConsoleMessage(android.webkit.ConsoleMessage)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Webkit.ConsoleMessage"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool OnConsoleMessage(Android.Webkit.ConsoleMessage arg0)
        {
            return IExecuteWithSignature<bool>("onConsoleMessage", "(Landroid/webkit/ConsoleMessage;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebChromeClient.html#onCreateWindow(android.webkit.WebView,boolean,boolean,android.os.Message)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Webkit.WebView"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <param name="arg3"><see cref="Android.Os.Message"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool OnCreateWindow(Android.Webkit.WebView arg0, bool arg1, bool arg2, Android.Os.Message arg3)
        {
            return IExecute<bool>("onCreateWindow", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebChromeClient.html#onJsAlert(android.webkit.WebView,java.lang.String,java.lang.String,android.webkit.JsResult)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Webkit.WebView"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Android.Webkit.JsResult"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool OnJsAlert(Android.Webkit.WebView arg0, Java.Lang.String arg1, Java.Lang.String arg2, Android.Webkit.JsResult arg3)
        {
            return IExecute<bool>("onJsAlert", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebChromeClient.html#onJsBeforeUnload(android.webkit.WebView,java.lang.String,java.lang.String,android.webkit.JsResult)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Webkit.WebView"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Android.Webkit.JsResult"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool OnJsBeforeUnload(Android.Webkit.WebView arg0, Java.Lang.String arg1, Java.Lang.String arg2, Android.Webkit.JsResult arg3)
        {
            return IExecute<bool>("onJsBeforeUnload", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebChromeClient.html#onJsConfirm(android.webkit.WebView,java.lang.String,java.lang.String,android.webkit.JsResult)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Webkit.WebView"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Android.Webkit.JsResult"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool OnJsConfirm(Android.Webkit.WebView arg0, Java.Lang.String arg1, Java.Lang.String arg2, Android.Webkit.JsResult arg3)
        {
            return IExecute<bool>("onJsConfirm", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebChromeClient.html#onJsPrompt(android.webkit.WebView,java.lang.String,java.lang.String,java.lang.String,android.webkit.JsPromptResult)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Webkit.WebView"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        /// <param name="arg4"><see cref="Android.Webkit.JsPromptResult"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool OnJsPrompt(Android.Webkit.WebView arg0, Java.Lang.String arg1, Java.Lang.String arg2, Java.Lang.String arg3, Android.Webkit.JsPromptResult arg4)
        {
            return IExecute<bool>("onJsPrompt", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebChromeClient.html#onJsTimeout()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool OnJsTimeout()
        {
            return IExecuteWithSignature<bool>("onJsTimeout", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebChromeClient.html#onShowFileChooser(android.webkit.WebView,android.webkit.ValueCallback,android.webkit.WebChromeClient.FileChooserParams)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Webkit.WebView"/></param>
        /// <param name="arg1"><see cref="Android.Webkit.ValueCallback"/></param>
        /// <param name="arg2"><see cref="Android.Webkit.WebChromeClient.FileChooserParams"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool OnShowFileChooser(Android.Webkit.WebView arg0, Android.Webkit.ValueCallback<Android.Net.Uri[]> arg1, Android.Webkit.WebChromeClient.FileChooserParams arg2)
        {
            return IExecute<bool>("onShowFileChooser", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebChromeClient.html#getVisitedHistory(android.webkit.ValueCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Webkit.ValueCallback"/></param>
        public void GetVisitedHistory(Android.Webkit.ValueCallback<Java.Lang.String[]> arg0)
        {
            IExecuteWithSignature("getVisitedHistory", "(Landroid/webkit/ValueCallback;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebChromeClient.html#onCloseWindow(android.webkit.WebView)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Webkit.WebView"/></param>
        public void OnCloseWindow(Android.Webkit.WebView arg0)
        {
            IExecuteWithSignature("onCloseWindow", "(Landroid/webkit/WebView;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebChromeClient.html#onConsoleMessage(java.lang.String,int,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        [global::System.Obsolete()]
        public void OnConsoleMessage(Java.Lang.String arg0, int arg1, Java.Lang.String arg2)
        {
            IExecute("onConsoleMessage", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebChromeClient.html#onExceededDatabaseQuota(java.lang.String,java.lang.String,long,long,long,android.webkit.WebStorage.QuotaUpdater)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="long"/></param>
        /// <param name="arg4"><see cref="long"/></param>
        /// <param name="arg5"><see cref="Android.Webkit.WebStorage.QuotaUpdater"/></param>
        [global::System.Obsolete()]
        public void OnExceededDatabaseQuota(Java.Lang.String arg0, Java.Lang.String arg1, long arg2, long arg3, long arg4, Android.Webkit.WebStorage.QuotaUpdater arg5)
        {
            IExecute("onExceededDatabaseQuota", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebChromeClient.html#onGeolocationPermissionsHidePrompt()"/>
        /// </summary>
        public void OnGeolocationPermissionsHidePrompt()
        {
            IExecuteWithSignature("onGeolocationPermissionsHidePrompt", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebChromeClient.html#onGeolocationPermissionsShowPrompt(java.lang.String,android.webkit.GeolocationPermissions.Callback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Android.Webkit.GeolocationPermissions.Callback"/></param>
        public void OnGeolocationPermissionsShowPrompt(Java.Lang.String arg0, Android.Webkit.GeolocationPermissions.Callback arg1)
        {
            IExecute("onGeolocationPermissionsShowPrompt", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebChromeClient.html#onHideCustomView()"/>
        /// </summary>
        public void OnHideCustomView()
        {
            IExecuteWithSignature("onHideCustomView", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebChromeClient.html#onPermissionRequest(android.webkit.PermissionRequest)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Webkit.PermissionRequest"/></param>
        public void OnPermissionRequest(Android.Webkit.PermissionRequest arg0)
        {
            IExecuteWithSignature("onPermissionRequest", "(Landroid/webkit/PermissionRequest;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebChromeClient.html#onPermissionRequestCanceled(android.webkit.PermissionRequest)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Webkit.PermissionRequest"/></param>
        public void OnPermissionRequestCanceled(Android.Webkit.PermissionRequest arg0)
        {
            IExecuteWithSignature("onPermissionRequestCanceled", "(Landroid/webkit/PermissionRequest;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebChromeClient.html#onProgressChanged(android.webkit.WebView,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Webkit.WebView"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void OnProgressChanged(Android.Webkit.WebView arg0, int arg1)
        {
            IExecute("onProgressChanged", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebChromeClient.html#onReceivedIcon(android.webkit.WebView,android.graphics.Bitmap)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Webkit.WebView"/></param>
        /// <param name="arg1"><see cref="Android.Graphics.Bitmap"/></param>
        public void OnReceivedIcon(Android.Webkit.WebView arg0, Android.Graphics.Bitmap arg1)
        {
            IExecute("onReceivedIcon", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebChromeClient.html#onReceivedTitle(android.webkit.WebView,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Webkit.WebView"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public void OnReceivedTitle(Android.Webkit.WebView arg0, Java.Lang.String arg1)
        {
            IExecute("onReceivedTitle", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebChromeClient.html#onReceivedTouchIconUrl(android.webkit.WebView,java.lang.String,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Webkit.WebView"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        public void OnReceivedTouchIconUrl(Android.Webkit.WebView arg0, Java.Lang.String arg1, bool arg2)
        {
            IExecute("onReceivedTouchIconUrl", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebChromeClient.html#onRequestFocus(android.webkit.WebView)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Webkit.WebView"/></param>
        public void OnRequestFocus(Android.Webkit.WebView arg0)
        {
            IExecuteWithSignature("onRequestFocus", "(Landroid/webkit/WebView;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebChromeClient.html#onShowCustomView(android.view.View,android.webkit.WebChromeClient.CustomViewCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <param name="arg1"><see cref="Android.Webkit.WebChromeClient.CustomViewCallback"/></param>
        public void OnShowCustomView(Android.View.View arg0, Android.Webkit.WebChromeClient.CustomViewCallback arg1)
        {
            IExecute("onShowCustomView", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebChromeClient.html#onShowCustomView(android.view.View,int,android.webkit.WebChromeClient.CustomViewCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Android.Webkit.WebChromeClient.CustomViewCallback"/></param>
        [global::System.Obsolete()]
        public void OnShowCustomView(Android.View.View arg0, int arg1, Android.Webkit.WebChromeClient.CustomViewCallback arg2)
        {
            IExecute("onShowCustomView", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes
        #region CustomViewCallback
        public partial class CustomViewCallback
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
            /// <see href="https://developer.android.com/reference/android/webkit/WebChromeClient.CustomViewCallback.html#onCustomViewHidden()"/>
            /// </summary>
            public void OnCustomViewHidden()
            {
                IExecuteWithSignature("onCustomViewHidden", "()V");
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region FileChooserParams
        public partial class FileChooserParams
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/webkit/WebChromeClient.FileChooserParams.html#MODE_OPEN"/>
            /// </summary>
            public static int MODE_OPEN { get { if (!_MODE_OPENReady) { _MODE_OPENContent = SGetField<int>(LocalBridgeClazz, "MODE_OPEN"); _MODE_OPENReady = true; } return _MODE_OPENContent; } }
            private static int _MODE_OPENContent = default;
            private static bool _MODE_OPENReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/webkit/WebChromeClient.FileChooserParams.html#MODE_OPEN_MULTIPLE"/>
            /// </summary>
            public static int MODE_OPEN_MULTIPLE { get { if (!_MODE_OPEN_MULTIPLEReady) { _MODE_OPEN_MULTIPLEContent = SGetField<int>(LocalBridgeClazz, "MODE_OPEN_MULTIPLE"); _MODE_OPEN_MULTIPLEReady = true; } return _MODE_OPEN_MULTIPLEContent; } }
            private static int _MODE_OPEN_MULTIPLEContent = default;
            private static bool _MODE_OPEN_MULTIPLEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/webkit/WebChromeClient.FileChooserParams.html#MODE_SAVE"/>
            /// </summary>
            public static int MODE_SAVE { get { if (!_MODE_SAVEReady) { _MODE_SAVEContent = SGetField<int>(LocalBridgeClazz, "MODE_SAVE"); _MODE_SAVEReady = true; } return _MODE_SAVEContent; } }
            private static int _MODE_SAVEContent = default;
            private static bool _MODE_SAVEReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/webkit/WebChromeClient.FileChooserParams.html#parseResult(int,android.content.Intent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="Android.Content.Intent"/></param>
            /// <returns><see cref="Android.Net.Uri"/></returns>
            public static Android.Net.Uri[] ParseResult(int arg0, Android.Content.Intent arg1)
            {
                return SExecuteArray<Android.Net.Uri>(LocalBridgeClazz, "parseResult", arg0, arg1);
            }

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/webkit/WebChromeClient.FileChooserParams.html#createIntent()"/>
            /// </summary>
            /// <returns><see cref="Android.Content.Intent"/></returns>
            public Android.Content.Intent CreateIntent()
            {
                return IExecuteWithSignature<Android.Content.Intent>("createIntent", "()Landroid/content/Intent;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/webkit/WebChromeClient.FileChooserParams.html#isCaptureEnabled()"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool IsCaptureEnabled()
            {
                return IExecuteWithSignature<bool>("isCaptureEnabled", "()Z");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/webkit/WebChromeClient.FileChooserParams.html#getMode()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetMode()
            {
                return IExecuteWithSignature<int>("getMode", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/webkit/WebChromeClient.FileChooserParams.html#getTitle()"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.CharSequence"/></returns>
            public Java.Lang.CharSequence GetTitle()
            {
                return IExecuteWithSignature<Java.Lang.CharSequence>("getTitle", "()Ljava/lang/CharSequence;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/webkit/WebChromeClient.FileChooserParams.html#getFilenameHint()"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String GetFilenameHint()
            {
                return IExecuteWithSignature<Java.Lang.String>("getFilenameHint", "()Ljava/lang/String;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/webkit/WebChromeClient.FileChooserParams.html#getAcceptTypes()"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String[] GetAcceptTypes()
            {
                return IExecuteWithSignatureArray<Java.Lang.String>("getAcceptTypes", "()[Ljava/lang/String;");
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