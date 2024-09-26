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

namespace Android.Webkit
{
    #region CookieManager declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/webkit/CookieManager.html"/>
    /// </summary>
    public partial class CookieManager : MASES.JCOBridge.C2JBridge.JVMBridgeBase<CookieManager>
    {
        const string _bridgeClassName = "android.webkit.CookieManager";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("CookieManager class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public CookieManager() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("CookieManager class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public CookieManager(params object[] args) : base(args) { }

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

    }
    #endregion

    #region CookieManager implementation
    public partial class CookieManager
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/CookieManager.html#getInstance()"/>
        /// </summary>
        /// <returns><see cref="Android.Webkit.CookieManager"/></returns>
        public static Android.Webkit.CookieManager GetInstance()
        {
            return SExecuteWithSignature<Android.Webkit.CookieManager>(LocalBridgeClazz, "getInstance", "()Landroid/webkit/CookieManager;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/CookieManager.html#allowFileSchemeCookies()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public static bool AllowFileSchemeCookies()
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "allowFileSchemeCookies", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/CookieManager.html#setAcceptFileSchemeCookies(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        [global::System.Obsolete()]
        public static void SetAcceptFileSchemeCookies(bool arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "setAcceptFileSchemeCookies", "(Z)V", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/CookieManager.html#acceptCookie()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool AcceptCookie()
        {
            return IExecuteWithSignature<bool>("acceptCookie", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/CookieManager.html#acceptThirdPartyCookies(android.webkit.WebView)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Webkit.WebView"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool AcceptThirdPartyCookies(Android.Webkit.WebView arg0)
        {
            return IExecuteWithSignature<bool>("acceptThirdPartyCookies", "(Landroid/webkit/WebView;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/CookieManager.html#hasCookies()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasCookies()
        {
            return IExecuteWithSignature<bool>("hasCookies", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/CookieManager.html#getCookie(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetCookie(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getCookie", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/CookieManager.html#flush()"/>
        /// </summary>
        public void Flush()
        {
            IExecuteWithSignature("flush", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/CookieManager.html#removeAllCookie()"/>
        /// </summary>
        [global::System.Obsolete()]
        public void RemoveAllCookie()
        {
            IExecuteWithSignature("removeAllCookie", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/CookieManager.html#removeAllCookies(android.webkit.ValueCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Webkit.ValueCallback"/></param>
        public void RemoveAllCookies(Android.Webkit.ValueCallback<Java.Lang.Boolean> arg0)
        {
            IExecuteWithSignature("removeAllCookies", "(Landroid/webkit/ValueCallback;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/CookieManager.html#removeExpiredCookie()"/>
        /// </summary>
        [global::System.Obsolete()]
        public void RemoveExpiredCookie()
        {
            IExecuteWithSignature("removeExpiredCookie", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/CookieManager.html#removeSessionCookie()"/>
        /// </summary>
        [global::System.Obsolete()]
        public void RemoveSessionCookie()
        {
            IExecuteWithSignature("removeSessionCookie", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/CookieManager.html#removeSessionCookies(android.webkit.ValueCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Webkit.ValueCallback"/></param>
        public void RemoveSessionCookies(Android.Webkit.ValueCallback<Java.Lang.Boolean> arg0)
        {
            IExecuteWithSignature("removeSessionCookies", "(Landroid/webkit/ValueCallback;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/CookieManager.html#setAcceptCookie(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetAcceptCookie(bool arg0)
        {
            IExecuteWithSignature("setAcceptCookie", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/CookieManager.html#setAcceptThirdPartyCookies(android.webkit.WebView,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Webkit.WebView"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public void SetAcceptThirdPartyCookies(Android.Webkit.WebView arg0, bool arg1)
        {
            IExecuteWithSignature("setAcceptThirdPartyCookies", "(Landroid/webkit/WebView;Z)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/CookieManager.html#setCookie(java.lang.String,java.lang.String,android.webkit.ValueCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Android.Webkit.ValueCallback"/></param>
        public void SetCookie(Java.Lang.String arg0, Java.Lang.String arg1, Android.Webkit.ValueCallback<Java.Lang.Boolean> arg2)
        {
            IExecuteWithSignature("setCookie", "(Ljava/lang/String;Ljava/lang/String;Landroid/webkit/ValueCallback;)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/CookieManager.html#setCookie(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public void SetCookie(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            IExecuteWithSignature("setCookie", "(Ljava/lang/String;Ljava/lang/String;)V", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}