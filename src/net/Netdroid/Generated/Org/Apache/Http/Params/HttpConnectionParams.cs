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

namespace Org.Apache.Http.Params
{
    #region HttpConnectionParams declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/org/apache/http/params/HttpConnectionParams.html"/>
    /// </summary>
    [global::System.Obsolete()]
    public partial class HttpConnectionParams : Org.Apache.Http.Params.CoreConnectionPNames
    {
        const string _bridgeClassName = "org.apache.http.params.HttpConnectionParams";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public HttpConnectionParams() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public HttpConnectionParams(params object[] args) : base(args) { }

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

    #region HttpConnectionParams implementation
    public partial class HttpConnectionParams
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/apache/http/params/HttpConnectionParams.html#getTcpNoDelay(org.apache.http.params.HttpParams)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Http.Params.HttpParams"/></param>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public static bool GetTcpNoDelay(Org.Apache.Http.Params.HttpParams arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "getTcpNoDelay", "(Lorg/apache/http/params/HttpParams;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/apache/http/params/HttpConnectionParams.html#isStaleCheckingEnabled(org.apache.http.params.HttpParams)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Http.Params.HttpParams"/></param>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public static bool IsStaleCheckingEnabled(Org.Apache.Http.Params.HttpParams arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isStaleCheckingEnabled", "(Lorg/apache/http/params/HttpParams;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/apache/http/params/HttpConnectionParams.html#getConnectionTimeout(org.apache.http.params.HttpParams)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Http.Params.HttpParams"/></param>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public static int GetConnectionTimeout(Org.Apache.Http.Params.HttpParams arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "getConnectionTimeout", "(Lorg/apache/http/params/HttpParams;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/apache/http/params/HttpConnectionParams.html#getLinger(org.apache.http.params.HttpParams)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Http.Params.HttpParams"/></param>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public static int GetLinger(Org.Apache.Http.Params.HttpParams arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "getLinger", "(Lorg/apache/http/params/HttpParams;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/apache/http/params/HttpConnectionParams.html#getSocketBufferSize(org.apache.http.params.HttpParams)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Http.Params.HttpParams"/></param>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public static int GetSocketBufferSize(Org.Apache.Http.Params.HttpParams arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "getSocketBufferSize", "(Lorg/apache/http/params/HttpParams;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/apache/http/params/HttpConnectionParams.html#getSoTimeout(org.apache.http.params.HttpParams)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Http.Params.HttpParams"/></param>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public static int GetSoTimeout(Org.Apache.Http.Params.HttpParams arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "getSoTimeout", "(Lorg/apache/http/params/HttpParams;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/apache/http/params/HttpConnectionParams.html#setConnectionTimeout(org.apache.http.params.HttpParams,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Http.Params.HttpParams"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        [global::System.Obsolete()]
        public static void SetConnectionTimeout(Org.Apache.Http.Params.HttpParams arg0, int arg1)
        {
            SExecute(LocalBridgeClazz, "setConnectionTimeout", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/apache/http/params/HttpConnectionParams.html#setLinger(org.apache.http.params.HttpParams,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Http.Params.HttpParams"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        [global::System.Obsolete()]
        public static void SetLinger(Org.Apache.Http.Params.HttpParams arg0, int arg1)
        {
            SExecute(LocalBridgeClazz, "setLinger", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/apache/http/params/HttpConnectionParams.html#setSocketBufferSize(org.apache.http.params.HttpParams,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Http.Params.HttpParams"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        [global::System.Obsolete()]
        public static void SetSocketBufferSize(Org.Apache.Http.Params.HttpParams arg0, int arg1)
        {
            SExecute(LocalBridgeClazz, "setSocketBufferSize", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/apache/http/params/HttpConnectionParams.html#setSoTimeout(org.apache.http.params.HttpParams,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Http.Params.HttpParams"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        [global::System.Obsolete()]
        public static void SetSoTimeout(Org.Apache.Http.Params.HttpParams arg0, int arg1)
        {
            SExecute(LocalBridgeClazz, "setSoTimeout", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/apache/http/params/HttpConnectionParams.html#setStaleCheckingEnabled(org.apache.http.params.HttpParams,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Http.Params.HttpParams"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        [global::System.Obsolete()]
        public static void SetStaleCheckingEnabled(Org.Apache.Http.Params.HttpParams arg0, bool arg1)
        {
            SExecute(LocalBridgeClazz, "setStaleCheckingEnabled", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/apache/http/params/HttpConnectionParams.html#setTcpNoDelay(org.apache.http.params.HttpParams,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Http.Params.HttpParams"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        [global::System.Obsolete()]
        public static void SetTcpNoDelay(Org.Apache.Http.Params.HttpParams arg0, bool arg1)
        {
            SExecute(LocalBridgeClazz, "setTcpNoDelay", arg0, arg1);
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}