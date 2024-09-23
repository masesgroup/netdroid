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

namespace Java.Net
{
    #region URL declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/java/net/URL.html"/>
    /// </summary>
    public partial class URL : Java.Io.Serializable
    {
        const string _bridgeClassName = "java.net.URL";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public URL() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public URL(params object[] args) : base(args) { }
    
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

    #region URL implementation
    public partial class URL
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/URL.html#%3Cinit%3E(java.lang.String,java.lang.String,int,java.lang.String,java.net.URLStreamHandler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        /// <param name="arg4"><see cref="Java.Net.URLStreamHandler"/></param>
        /// <exception cref="Java.Net.MalformedURLException"/>
        public URL(Java.Lang.String arg0, Java.Lang.String arg1, int arg2, Java.Lang.String arg3, Java.Net.URLStreamHandler arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/URL.html#%3Cinit%3E(java.lang.String,java.lang.String,int,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Net.MalformedURLException"/>
        public URL(Java.Lang.String arg0, Java.Lang.String arg1, int arg2, Java.Lang.String arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/URL.html#%3Cinit%3E(java.lang.String,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Net.MalformedURLException"/>
        public URL(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.String arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/URL.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Net.MalformedURLException"/>
        public URL(Java.Lang.String arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/URL.html#%3Cinit%3E(java.net.URL,java.lang.String,java.net.URLStreamHandler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URL"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Net.URLStreamHandler"/></param>
        /// <exception cref="Java.Net.MalformedURLException"/>
        public URL(Java.Net.URL arg0, Java.Lang.String arg1, Java.Net.URLStreamHandler arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/URL.html#%3Cinit%3E(java.net.URL,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URL"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Net.MalformedURLException"/>
        public URL(Java.Net.URL arg0, Java.Lang.String arg1)
            : base(arg0, arg1)
        {
        }
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/URL.html#setURLStreamHandlerFactory(java.net.URLStreamHandlerFactory)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URLStreamHandlerFactory"/></param>
        public static void SetURLStreamHandlerFactory(Java.Net.URLStreamHandlerFactory arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "setURLStreamHandlerFactory", "(Ljava/net/URLStreamHandlerFactory;)V", arg0);
        }
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/URL.html#sameFile(java.net.URL)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URL"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SameFile(Java.Net.URL arg0)
        {
            return IExecuteWithSignature<bool>("sameFile", "(Ljava/net/URL;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/URL.html#openStream()"/>
        /// </summary>
        /// <returns><see cref="Java.Io.InputStream"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Io.InputStream OpenStream()
        {
            return IExecuteWithSignature<Java.Io.InputStream>("openStream", "()Ljava/io/InputStream;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/URL.html#getContent()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public object GetContent()
        {
            return IExecuteWithSignature("getContent", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/URL.html#getContent(java.lang.Class[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public object GetContent(Java.Lang.Class[] arg0)
        {
            return IExecuteWithSignature("getContent", "([Ljava/lang/Class;)Ljava/lang/Object;", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/URL.html#getDefaultPort()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetDefaultPort()
        {
            return IExecuteWithSignature<int>("getDefaultPort", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/URL.html#getPort()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetPort()
        {
            return IExecuteWithSignature<int>("getPort", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/URL.html#getAuthority()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetAuthority()
        {
            return IExecuteWithSignature<Java.Lang.String>("getAuthority", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/URL.html#getFile()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetFile()
        {
            return IExecuteWithSignature<Java.Lang.String>("getFile", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/URL.html#getHost()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetHost()
        {
            return IExecuteWithSignature<Java.Lang.String>("getHost", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/URL.html#getPath()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetPath()
        {
            return IExecuteWithSignature<Java.Lang.String>("getPath", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/URL.html#getProtocol()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetProtocol()
        {
            return IExecuteWithSignature<Java.Lang.String>("getProtocol", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/URL.html#getQuery()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetQuery()
        {
            return IExecuteWithSignature<Java.Lang.String>("getQuery", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/URL.html#getRef()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetRef()
        {
            return IExecuteWithSignature<Java.Lang.String>("getRef", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/URL.html#getUserInfo()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetUserInfo()
        {
            return IExecuteWithSignature<Java.Lang.String>("getUserInfo", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/URL.html#toExternalForm()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String ToExternalForm()
        {
            return IExecuteWithSignature<Java.Lang.String>("toExternalForm", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/URL.html#toURI()"/>
        /// </summary>
        /// <returns><see cref="Java.Net.URI"/></returns>
        /// <exception cref="Java.Net.URISyntaxException"/>
        public Java.Net.URI ToURI()
        {
            return IExecuteWithSignature<Java.Net.URI>("toURI", "()Ljava/net/URI;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/URL.html#openConnection()"/>
        /// </summary>
        /// <returns><see cref="Java.Net.URLConnection"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Net.URLConnection OpenConnection()
        {
            return IExecuteWithSignature<Java.Net.URLConnection>("openConnection", "()Ljava/net/URLConnection;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/URL.html#openConnection(java.net.Proxy)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.Proxy"/></param>
        /// <returns><see cref="Java.Net.URLConnection"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Net.URLConnection OpenConnection(Java.Net.Proxy arg0)
        {
            return IExecuteWithSignature<Java.Net.URLConnection>("openConnection", "(Ljava/net/Proxy;)Ljava/net/URLConnection;", arg0);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}