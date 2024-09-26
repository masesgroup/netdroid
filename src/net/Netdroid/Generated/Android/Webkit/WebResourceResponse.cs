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
    #region WebResourceResponse declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/webkit/WebResourceResponse.html"/>
    /// </summary>
    public partial class WebResourceResponse : MASES.JCOBridge.C2JBridge.JVMBridgeBase<WebResourceResponse>
    {
        const string _bridgeClassName = "android.webkit.WebResourceResponse";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public WebResourceResponse() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public WebResourceResponse(params object[] args) : base(args) { }

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

    }
    #endregion

    #region WebResourceResponse implementation
    public partial class WebResourceResponse
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebResourceResponse.html#%3Cinit%3E(java.lang.String,java.lang.String,int,java.lang.String,java.util.Map,java.io.InputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        /// <param name="arg4"><see cref="Java.Util.Map"/></param>
        /// <param name="arg5"><see cref="Java.Io.InputStream"/></param>
        public WebResourceResponse(Java.Lang.String arg0, Java.Lang.String arg1, int arg2, Java.Lang.String arg3, Java.Util.Map<Java.Lang.String, Java.Lang.String> arg4, Java.Io.InputStream arg5)
            : base(arg0, arg1, arg2, arg3, arg4, arg5)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebResourceResponse.html#%3Cinit%3E(java.lang.String,java.lang.String,java.io.InputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Io.InputStream"/></param>
        public WebResourceResponse(Java.Lang.String arg0, Java.Lang.String arg1, Java.Io.InputStream arg2)
            : base(arg0, arg1, arg2)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebResourceResponse.html#getStatusCode()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetStatusCode()
        {
            return IExecuteWithSignature<int>("getStatusCode", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebResourceResponse.html#getData()"/>
        /// </summary>
        /// <returns><see cref="Java.Io.InputStream"/></returns>
        public Java.Io.InputStream GetData()
        {
            return IExecuteWithSignature<Java.Io.InputStream>("getData", "()Ljava/io/InputStream;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebResourceResponse.html#getEncoding()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetEncoding()
        {
            return IExecuteWithSignature<Java.Lang.String>("getEncoding", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebResourceResponse.html#getMimeType()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetMimeType()
        {
            return IExecuteWithSignature<Java.Lang.String>("getMimeType", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebResourceResponse.html#getReasonPhrase()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetReasonPhrase()
        {
            return IExecuteWithSignature<Java.Lang.String>("getReasonPhrase", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebResourceResponse.html#getResponseHeaders()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<Java.Lang.String, Java.Lang.String> GetResponseHeaders()
        {
            return IExecuteWithSignature<Java.Util.Map<Java.Lang.String, Java.Lang.String>>("getResponseHeaders", "()Ljava/util/Map;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebResourceResponse.html#setData(java.io.InputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        public void SetData(Java.Io.InputStream arg0)
        {
            IExecuteWithSignature("setData", "(Ljava/io/InputStream;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebResourceResponse.html#setEncoding(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetEncoding(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setEncoding", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebResourceResponse.html#setMimeType(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetMimeType(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setMimeType", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebResourceResponse.html#setResponseHeaders(java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        public void SetResponseHeaders(Java.Util.Map<Java.Lang.String, Java.Lang.String> arg0)
        {
            IExecuteWithSignature("setResponseHeaders", "(Ljava/util/Map;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebResourceResponse.html#setStatusCodeAndReasonPhrase(int,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public void SetStatusCodeAndReasonPhrase(int arg0, Java.Lang.String arg1)
        {
            IExecuteWithSignature("setStatusCodeAndReasonPhrase", "(ILjava/lang/String;)V", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}