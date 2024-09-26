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
    #region HttpEngine declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/net/http/HttpEngine.html"/>
    /// </summary>
    public partial class HttpEngine : MASES.JCOBridge.C2JBridge.JVMBridgeBase<HttpEngine>
    {
        const string _bridgeClassName = "android.net.http.HttpEngine";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("HttpEngine class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public HttpEngine() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("HttpEngine class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public HttpEngine(params object[] args) : base(args) { }

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
        #region Builder declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/http/HttpEngine.Builder.html"/>
        /// </summary>
        public partial class Builder : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Builder>
        {
            const string _bridgeClassName = "android.net.http.HttpEngine$Builder";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public Builder() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public Builder(params object[] args) : base(args) { }

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

    #region HttpEngine implementation
    public partial class HttpEngine
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/http/HttpEngine.html#getVersionString()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String GetVersionString()
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "getVersionString", "()Ljava/lang/String;");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/http/HttpEngine.html#newBidirectionalStreamBuilder(java.lang.String,java.util.concurrent.Executor,android.net.http.BidirectionalStream.Callback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg2"><see cref="Android.Net.Http.BidirectionalStream.Callback"/></param>
        /// <returns><see cref="Android.Net.Http.BidirectionalStream.Builder"/></returns>
        public Android.Net.Http.BidirectionalStream.Builder NewBidirectionalStreamBuilder(Java.Lang.String arg0, Java.Util.Concurrent.Executor arg1, Android.Net.Http.BidirectionalStream.Callback arg2)
        {
            return IExecuteWithSignature<Android.Net.Http.BidirectionalStream.Builder>("newBidirectionalStreamBuilder", "(Ljava/lang/String;Ljava/util/concurrent/Executor;Landroid/net/http/BidirectionalStream$Callback;)Landroid/net/http/BidirectionalStream$Builder;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/http/HttpEngine.html#newUrlRequestBuilder(java.lang.String,java.util.concurrent.Executor,android.net.http.UrlRequest.Callback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg2"><see cref="Android.Net.Http.UrlRequest.Callback"/></param>
        /// <returns><see cref="Android.Net.Http.UrlRequest.Builder"/></returns>
        public Android.Net.Http.UrlRequest.Builder NewUrlRequestBuilder(Java.Lang.String arg0, Java.Util.Concurrent.Executor arg1, Android.Net.Http.UrlRequest.Callback arg2)
        {
            return IExecuteWithSignature<Android.Net.Http.UrlRequest.Builder>("newUrlRequestBuilder", "(Ljava/lang/String;Ljava/util/concurrent/Executor;Landroid/net/http/UrlRequest$Callback;)Landroid/net/http/UrlRequest$Builder;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/http/HttpEngine.html#openConnection(java.net.URL)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URL"/></param>
        /// <returns><see cref="Java.Net.URLConnection"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Net.URLConnection OpenConnection(Java.Net.URL arg0)
        {
            return IExecuteWithSignature<Java.Net.URLConnection>("openConnection", "(Ljava/net/URL;)Ljava/net/URLConnection;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/http/HttpEngine.html#createUrlStreamHandlerFactory()"/>
        /// </summary>
        /// <returns><see cref="Java.Net.URLStreamHandlerFactory"/></returns>
        public Java.Net.URLStreamHandlerFactory CreateUrlStreamHandlerFactory()
        {
            return IExecuteWithSignature<Java.Net.URLStreamHandlerFactory>("createUrlStreamHandlerFactory", "()Ljava/net/URLStreamHandlerFactory;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/http/HttpEngine.html#shutdown()"/>
        /// </summary>
        public void Shutdown()
        {
            IExecuteWithSignature("shutdown", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/http/HttpEngine.html#bindToNetwork(android.net.Network)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Network"/></param>
        public void BindToNetwork(Android.Net.Network arg0)
        {
            IExecuteWithSignature("bindToNetwork", "(Landroid/net/Network;)V", arg0);
        }

        #endregion

        #region Nested classes
        #region Builder implementation
        public partial class Builder
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/http/HttpEngine.Builder.html#%3Cinit%3E(android.content.Context)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Content.Context"/></param>
            public Builder(Android.Content.Context arg0)
                : base(arg0)
            {
            }

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/http/HttpEngine.Builder.html#HTTP_CACHE_DISABLED"/>
            /// </summary>
            public static int HTTP_CACHE_DISABLED { get { if (!_HTTP_CACHE_DISABLEDReady) { _HTTP_CACHE_DISABLEDContent = SGetField<int>(LocalBridgeClazz, "HTTP_CACHE_DISABLED"); _HTTP_CACHE_DISABLEDReady = true; } return _HTTP_CACHE_DISABLEDContent; } }
            private static int _HTTP_CACHE_DISABLEDContent = default;
            private static bool _HTTP_CACHE_DISABLEDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/http/HttpEngine.Builder.html#HTTP_CACHE_DISK"/>
            /// </summary>
            public static int HTTP_CACHE_DISK { get { if (!_HTTP_CACHE_DISKReady) { _HTTP_CACHE_DISKContent = SGetField<int>(LocalBridgeClazz, "HTTP_CACHE_DISK"); _HTTP_CACHE_DISKReady = true; } return _HTTP_CACHE_DISKContent; } }
            private static int _HTTP_CACHE_DISKContent = default;
            private static bool _HTTP_CACHE_DISKReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/http/HttpEngine.Builder.html#HTTP_CACHE_DISK_NO_HTTP"/>
            /// </summary>
            public static int HTTP_CACHE_DISK_NO_HTTP { get { if (!_HTTP_CACHE_DISK_NO_HTTPReady) { _HTTP_CACHE_DISK_NO_HTTPContent = SGetField<int>(LocalBridgeClazz, "HTTP_CACHE_DISK_NO_HTTP"); _HTTP_CACHE_DISK_NO_HTTPReady = true; } return _HTTP_CACHE_DISK_NO_HTTPContent; } }
            private static int _HTTP_CACHE_DISK_NO_HTTPContent = default;
            private static bool _HTTP_CACHE_DISK_NO_HTTPReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/http/HttpEngine.Builder.html#HTTP_CACHE_IN_MEMORY"/>
            /// </summary>
            public static int HTTP_CACHE_IN_MEMORY { get { if (!_HTTP_CACHE_IN_MEMORYReady) { _HTTP_CACHE_IN_MEMORYContent = SGetField<int>(LocalBridgeClazz, "HTTP_CACHE_IN_MEMORY"); _HTTP_CACHE_IN_MEMORYReady = true; } return _HTTP_CACHE_IN_MEMORYContent; } }
            private static int _HTTP_CACHE_IN_MEMORYContent = default;
            private static bool _HTTP_CACHE_IN_MEMORYReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/http/HttpEngine.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Net.Http.HttpEngine"/></returns>
            public Android.Net.Http.HttpEngine Build()
            {
                return IExecuteWithSignature<Android.Net.Http.HttpEngine>("build", "()Landroid/net/http/HttpEngine;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/http/HttpEngine.Builder.html#addPublicKeyPins(java.lang.String,java.util.Set,boolean,java.time.Instant)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="Java.Util.Set"/></param>
            /// <param name="arg2"><see cref="bool"/></param>
            /// <param name="arg3"><see cref="Java.Time.Instant"/></param>
            /// <returns><see cref="Android.Net.Http.HttpEngine.Builder"/></returns>
            public Android.Net.Http.HttpEngine.Builder AddPublicKeyPins(Java.Lang.String arg0, Java.Util.Set<byte[]> arg1, bool arg2, Java.Time.Instant arg3)
            {
                return IExecuteWithSignature<Android.Net.Http.HttpEngine.Builder>("addPublicKeyPins", "(Ljava/lang/String;Ljava/util/Set;ZLjava/time/Instant;)Landroid/net/http/HttpEngine$Builder;", arg0, arg1, arg2, arg3);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/http/HttpEngine.Builder.html#addQuicHint(java.lang.String,int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            /// <returns><see cref="Android.Net.Http.HttpEngine.Builder"/></returns>
            public Android.Net.Http.HttpEngine.Builder AddQuicHint(Java.Lang.String arg0, int arg1, int arg2)
            {
                return IExecuteWithSignature<Android.Net.Http.HttpEngine.Builder>("addQuicHint", "(Ljava/lang/String;II)Landroid/net/http/HttpEngine$Builder;", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/http/HttpEngine.Builder.html#setConnectionMigrationOptions(android.net.http.ConnectionMigrationOptions)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.Http.ConnectionMigrationOptions"/></param>
            /// <returns><see cref="Android.Net.Http.HttpEngine.Builder"/></returns>
            public Android.Net.Http.HttpEngine.Builder SetConnectionMigrationOptions(Android.Net.Http.ConnectionMigrationOptions arg0)
            {
                return IExecuteWithSignature<Android.Net.Http.HttpEngine.Builder>("setConnectionMigrationOptions", "(Landroid/net/http/ConnectionMigrationOptions;)Landroid/net/http/HttpEngine$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/http/HttpEngine.Builder.html#setDnsOptions(android.net.http.DnsOptions)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.Http.DnsOptions"/></param>
            /// <returns><see cref="Android.Net.Http.HttpEngine.Builder"/></returns>
            public Android.Net.Http.HttpEngine.Builder SetDnsOptions(Android.Net.Http.DnsOptions arg0)
            {
                return IExecuteWithSignature<Android.Net.Http.HttpEngine.Builder>("setDnsOptions", "(Landroid/net/http/DnsOptions;)Landroid/net/http/HttpEngine$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/http/HttpEngine.Builder.html#setEnableBrotli(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Net.Http.HttpEngine.Builder"/></returns>
            public Android.Net.Http.HttpEngine.Builder SetEnableBrotli(bool arg0)
            {
                return IExecuteWithSignature<Android.Net.Http.HttpEngine.Builder>("setEnableBrotli", "(Z)Landroid/net/http/HttpEngine$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/http/HttpEngine.Builder.html#setEnableHttp2(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Net.Http.HttpEngine.Builder"/></returns>
            public Android.Net.Http.HttpEngine.Builder SetEnableHttp2(bool arg0)
            {
                return IExecuteWithSignature<Android.Net.Http.HttpEngine.Builder>("setEnableHttp2", "(Z)Landroid/net/http/HttpEngine$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/http/HttpEngine.Builder.html#setEnableHttpCache(int,long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="long"/></param>
            /// <returns><see cref="Android.Net.Http.HttpEngine.Builder"/></returns>
            public Android.Net.Http.HttpEngine.Builder SetEnableHttpCache(int arg0, long arg1)
            {
                return IExecuteWithSignature<Android.Net.Http.HttpEngine.Builder>("setEnableHttpCache", "(IJ)Landroid/net/http/HttpEngine$Builder;", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/http/HttpEngine.Builder.html#setEnablePublicKeyPinningBypassForLocalTrustAnchors(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Net.Http.HttpEngine.Builder"/></returns>
            public Android.Net.Http.HttpEngine.Builder SetEnablePublicKeyPinningBypassForLocalTrustAnchors(bool arg0)
            {
                return IExecuteWithSignature<Android.Net.Http.HttpEngine.Builder>("setEnablePublicKeyPinningBypassForLocalTrustAnchors", "(Z)Landroid/net/http/HttpEngine$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/http/HttpEngine.Builder.html#setEnableQuic(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Net.Http.HttpEngine.Builder"/></returns>
            public Android.Net.Http.HttpEngine.Builder SetEnableQuic(bool arg0)
            {
                return IExecuteWithSignature<Android.Net.Http.HttpEngine.Builder>("setEnableQuic", "(Z)Landroid/net/http/HttpEngine$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/http/HttpEngine.Builder.html#setQuicOptions(android.net.http.QuicOptions)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.Http.QuicOptions"/></param>
            /// <returns><see cref="Android.Net.Http.HttpEngine.Builder"/></returns>
            public Android.Net.Http.HttpEngine.Builder SetQuicOptions(Android.Net.Http.QuicOptions arg0)
            {
                return IExecuteWithSignature<Android.Net.Http.HttpEngine.Builder>("setQuicOptions", "(Landroid/net/http/QuicOptions;)Landroid/net/http/HttpEngine$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/http/HttpEngine.Builder.html#setStoragePath(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Net.Http.HttpEngine.Builder"/></returns>
            public Android.Net.Http.HttpEngine.Builder SetStoragePath(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.Net.Http.HttpEngine.Builder>("setStoragePath", "(Ljava/lang/String;)Landroid/net/http/HttpEngine$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/http/HttpEngine.Builder.html#setUserAgent(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Net.Http.HttpEngine.Builder"/></returns>
            public Android.Net.Http.HttpEngine.Builder SetUserAgent(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.Net.Http.HttpEngine.Builder>("setUserAgent", "(Ljava/lang/String;)Landroid/net/http/HttpEngine$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/http/HttpEngine.Builder.html#getDefaultUserAgent()"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String GetDefaultUserAgent()
            {
                return IExecuteWithSignature<Java.Lang.String>("getDefaultUserAgent", "()Ljava/lang/String;");
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