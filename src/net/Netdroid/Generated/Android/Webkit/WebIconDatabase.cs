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

namespace Android.Webkit
{
    #region WebIconDatabase
    public partial class WebIconDatabase
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebIconDatabase.html#getInstance()"/>
        /// </summary>
        /// <returns><see cref="Android.Webkit.WebIconDatabase"/></returns>
        [global::System.Obsolete()]
        public static Android.Webkit.WebIconDatabase GetInstance()
        {
            return SExecuteWithSignature<Android.Webkit.WebIconDatabase>(LocalBridgeClazz, "getInstance", "()Landroid/webkit/WebIconDatabase;");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebIconDatabase.html#close()"/>
        /// </summary>
        [global::System.Obsolete()]
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebIconDatabase.html#open(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        [global::System.Obsolete()]
        public void Open(Java.Lang.String arg0)
        {
            IExecuteWithSignature("open", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebIconDatabase.html#releaseIconForPageUrl(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        [global::System.Obsolete()]
        public void ReleaseIconForPageUrl(Java.Lang.String arg0)
        {
            IExecuteWithSignature("releaseIconForPageUrl", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebIconDatabase.html#removeAllIcons()"/>
        /// </summary>
        [global::System.Obsolete()]
        public void RemoveAllIcons()
        {
            IExecuteWithSignature("removeAllIcons", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebIconDatabase.html#requestIconForPageUrl(java.lang.String,android.webkit.WebIconDatabase.IconListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Android.Webkit.WebIconDatabase.IconListener"/></param>
        [global::System.Obsolete()]
        public void RequestIconForPageUrl(Java.Lang.String arg0, Android.Webkit.WebIconDatabase.IconListener arg1)
        {
            IExecute("requestIconForPageUrl", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebIconDatabase.html#retainIconForPageUrl(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        [global::System.Obsolete()]
        public void RetainIconForPageUrl(Java.Lang.String arg0)
        {
            IExecuteWithSignature("retainIconForPageUrl", "(Ljava/lang/String;)V", arg0);
        }

        #endregion

        #region Nested classes
        #region IconListener
        public partial class IconListener
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
            /// Handlers initializer for <see cref="IconListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onReceivedIcon", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Lang.String>>>(OnReceivedIconEventHandler));

            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/webkit/WebIconDatabase.IconListener.html#onReceivedIcon(java.lang.String,android.graphics.Bitmap)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnReceivedIcon"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action<Java.Lang.String, Android.Graphics.Bitmap> OnOnReceivedIcon { get; set; } = null;

            void OnReceivedIconEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Lang.String>> data)
            {
                var methodToExecute = (OnOnReceivedIcon != null) ? OnOnReceivedIcon : OnReceivedIcon;
                methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<Android.Graphics.Bitmap>(0));
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/webkit/WebIconDatabase.IconListener.html#onReceivedIcon(java.lang.String,android.graphics.Bitmap)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="Android.Graphics.Bitmap"/></param>
            [global::System.Obsolete()]
            public virtual void OnReceivedIcon(Java.Lang.String arg0, Android.Graphics.Bitmap arg1)
            {
                
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region IconListenerDirect
        public partial class IconListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/webkit/WebIconDatabase.IconListener.html#onReceivedIcon(java.lang.String,android.graphics.Bitmap)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="Android.Graphics.Bitmap"/></param>
            [global::System.Obsolete()]
            public override void OnReceivedIcon(Java.Lang.String arg0, Android.Graphics.Bitmap arg1)
            {
                IExecute("onReceivedIcon", arg0, arg1);
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