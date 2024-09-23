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

namespace Android.Net.Http
{
    #region HttpResponseCache declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/net/http/HttpResponseCache.html"/>
    /// </summary>
    public partial class HttpResponseCache : Java.Net.ResponseCache
    {
        const string _bridgeClassName = "android.net.http.HttpResponseCache";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public HttpResponseCache() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public HttpResponseCache(params object[] args) : base(args) { }
    
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

    #region HttpResponseCache implementation
    public partial class HttpResponseCache
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Android.Net.Http.HttpResponseCache"/> to <see cref="Java.Io.Closeable"/>
        /// </summary>
        public static implicit operator Java.Io.Closeable(Android.Net.Http.HttpResponseCache t) => t.Cast<Java.Io.Closeable>();
    
        #endregion
    
        #region Fields
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/http/HttpResponseCache.html#getInstalled()"/>
        /// </summary>
        /// <returns><see cref="Android.Net.Http.HttpResponseCache"/></returns>
        public static Android.Net.Http.HttpResponseCache GetInstalled()
        {
            return SExecuteWithSignature<Android.Net.Http.HttpResponseCache>(LocalBridgeClazz, "getInstalled", "()Landroid/net/http/HttpResponseCache;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/http/HttpResponseCache.html#install(java.io.File,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="Android.Net.Http.HttpResponseCache"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static Android.Net.Http.HttpResponseCache Install(Java.Io.File arg0, long arg1)
        {
            return SExecute<Android.Net.Http.HttpResponseCache>(LocalBridgeClazz, "install", arg0, arg1);
        }
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/http/HttpResponseCache.html#getHitCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetHitCount()
        {
            return IExecuteWithSignature<int>("getHitCount", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/http/HttpResponseCache.html#getNetworkCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetNetworkCount()
        {
            return IExecuteWithSignature<int>("getNetworkCount", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/http/HttpResponseCache.html#getRequestCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetRequestCount()
        {
            return IExecuteWithSignature<int>("getRequestCount", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/http/HttpResponseCache.html#maxSize()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long MaxSize()
        {
            return IExecuteWithSignature<long>("maxSize", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/http/HttpResponseCache.html#size()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long Size()
        {
            return IExecuteWithSignature<long>("size", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/http/HttpResponseCache.html#close()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/http/HttpResponseCache.html#delete()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        public void Delete()
        {
            IExecuteWithSignature("delete", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/http/HttpResponseCache.html#flush()"/>
        /// </summary>
        public void Flush()
        {
            IExecuteWithSignature("flush", "()V");
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}