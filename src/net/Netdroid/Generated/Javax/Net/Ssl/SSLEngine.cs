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

namespace Javax.Net.Ssl
{
    #region SSLEngine
    public partial class SSLEngine
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
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLEngine.html#getEnableSessionCreation()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool GetEnableSessionCreation()
        {
            return IExecuteWithSignature<bool>("getEnableSessionCreation", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLEngine.html#getNeedClientAuth()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool GetNeedClientAuth()
        {
            return IExecuteWithSignature<bool>("getNeedClientAuth", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLEngine.html#getUseClientMode()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool GetUseClientMode()
        {
            return IExecuteWithSignature<bool>("getUseClientMode", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLEngine.html#getWantClientAuth()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool GetWantClientAuth()
        {
            return IExecuteWithSignature<bool>("getWantClientAuth", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLEngine.html#isInboundDone()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsInboundDone()
        {
            return IExecuteWithSignature<bool>("isInboundDone", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLEngine.html#isOutboundDone()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsOutboundDone()
        {
            return IExecuteWithSignature<bool>("isOutboundDone", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLEngine.html#getDelegatedTask()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.Runnable"/></returns>
        public Java.Lang.Runnable GetDelegatedTask()
        {
            return IExecuteWithSignature<Java.Lang.Runnable>("getDelegatedTask", "()Ljava/lang/Runnable;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLEngine.html#getEnabledCipherSuites()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String[] GetEnabledCipherSuites()
        {
            return IExecuteWithSignatureArray<Java.Lang.String>("getEnabledCipherSuites", "()[Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLEngine.html#getEnabledProtocols()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String[] GetEnabledProtocols()
        {
            return IExecuteWithSignatureArray<Java.Lang.String>("getEnabledProtocols", "()[Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLEngine.html#getSupportedCipherSuites()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String[] GetSupportedCipherSuites()
        {
            return IExecuteWithSignatureArray<Java.Lang.String>("getSupportedCipherSuites", "()[Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLEngine.html#getSupportedProtocols()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String[] GetSupportedProtocols()
        {
            return IExecuteWithSignatureArray<Java.Lang.String>("getSupportedProtocols", "()[Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLEngine.html#unwrap(java.nio.ByteBuffer,java.nio.ByteBuffer[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg1"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="Javax.Net.Ssl.SSLEngineResult"/></returns>
        /// <exception cref="Javax.Net.Ssl.SSLException"/>
        public Javax.Net.Ssl.SSLEngineResult Unwrap(Java.Nio.ByteBuffer arg0, Java.Nio.ByteBuffer[] arg1, int arg2, int arg3)
        {
            return IExecute<Javax.Net.Ssl.SSLEngineResult>("unwrap", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLEngine.html#wrap(java.nio.ByteBuffer[],int,int,java.nio.ByteBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <returns><see cref="Javax.Net.Ssl.SSLEngineResult"/></returns>
        /// <exception cref="Javax.Net.Ssl.SSLException"/>
        public Javax.Net.Ssl.SSLEngineResult Wrap(Java.Nio.ByteBuffer[] arg0, int arg1, int arg2, Java.Nio.ByteBuffer arg3)
        {
            return IExecute<Javax.Net.Ssl.SSLEngineResult>("wrap", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLEngine.html#getHandshakeStatus()"/>
        /// </summary>
        /// <returns><see cref="Javax.Net.Ssl.SSLEngineResult.HandshakeStatus"/></returns>
        public Javax.Net.Ssl.SSLEngineResult.HandshakeStatus GetHandshakeStatus()
        {
            return IExecuteWithSignature<Javax.Net.Ssl.SSLEngineResult.HandshakeStatus>("getHandshakeStatus", "()Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLEngine.html#getSession()"/>
        /// </summary>
        /// <returns><see cref="Javax.Net.Ssl.SSLSession"/></returns>
        public Javax.Net.Ssl.SSLSession GetSession()
        {
            return IExecuteWithSignature<Javax.Net.Ssl.SSLSession>("getSession", "()Ljavax/net/ssl/SSLSession;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLEngine.html#beginHandshake()"/>
        /// </summary>
        /// <exception cref="Javax.Net.Ssl.SSLException"/>
        public void BeginHandshake()
        {
            IExecuteWithSignature("beginHandshake", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLEngine.html#closeInbound()"/>
        /// </summary>
        /// <exception cref="Javax.Net.Ssl.SSLException"/>
        public void CloseInbound()
        {
            IExecuteWithSignature("closeInbound", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLEngine.html#closeOutbound()"/>
        /// </summary>
        public void CloseOutbound()
        {
            IExecuteWithSignature("closeOutbound", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLEngine.html#setEnabledCipherSuites(java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetEnabledCipherSuites(Java.Lang.String[] arg0)
        {
            IExecuteWithSignature("setEnabledCipherSuites", "([Ljava/lang/String;)V", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLEngine.html#setEnabledProtocols(java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetEnabledProtocols(Java.Lang.String[] arg0)
        {
            IExecuteWithSignature("setEnabledProtocols", "([Ljava/lang/String;)V", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLEngine.html#setEnableSessionCreation(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetEnableSessionCreation(bool arg0)
        {
            IExecuteWithSignature("setEnableSessionCreation", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLEngine.html#setNeedClientAuth(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetNeedClientAuth(bool arg0)
        {
            IExecuteWithSignature("setNeedClientAuth", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLEngine.html#setUseClientMode(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetUseClientMode(bool arg0)
        {
            IExecuteWithSignature("setUseClientMode", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLEngine.html#setWantClientAuth(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetWantClientAuth(bool arg0)
        {
            IExecuteWithSignature("setWantClientAuth", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLEngine.html#getPeerPort()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetPeerPort()
        {
            return IExecuteWithSignature<int>("getPeerPort", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLEngine.html#getApplicationProtocol()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetApplicationProtocol()
        {
            return IExecuteWithSignature<Java.Lang.String>("getApplicationProtocol", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLEngine.html#getHandshakeApplicationProtocol()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetHandshakeApplicationProtocol()
        {
            return IExecuteWithSignature<Java.Lang.String>("getHandshakeApplicationProtocol", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLEngine.html#getPeerHost()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetPeerHost()
        {
            return IExecuteWithSignature<Java.Lang.String>("getPeerHost", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLEngine.html#getHandshakeApplicationProtocolSelector()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Function.BiFunction"/></returns>
        public Java.Util.Function.BiFunction<Javax.Net.Ssl.SSLEngine, Java.Util.List<Java.Lang.String>, Java.Lang.String> GetHandshakeApplicationProtocolSelector()
        {
            return IExecuteWithSignature<Java.Util.Function.BiFunction<Javax.Net.Ssl.SSLEngine, Java.Util.List<Java.Lang.String>, Java.Lang.String>>("getHandshakeApplicationProtocolSelector", "()Ljava/util/function/BiFunction;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLEngine.html#getHandshakeApplicationProtocolSelector()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Function.BiFunction"/></returns>
        public Java.Util.Function.BiFunction<Javax.Net.Ssl.SSLEngine, Java.Util.List<Java.Lang.String>, Java.Lang.String> GetHandshakeApplicationProtocolSelectorDirect()
        {
            return IExecuteWithSignature<Java.Util.Function.BiFunctionDirect<Javax.Net.Ssl.SSLEngine, Java.Util.List<Java.Lang.String>, Java.Lang.String>, Java.Util.Function.BiFunction<Javax.Net.Ssl.SSLEngine, Java.Util.List<Java.Lang.String>, Java.Lang.String>>("getHandshakeApplicationProtocolSelector", "()Ljava/util/function/BiFunction;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLEngine.html#unwrap(java.nio.ByteBuffer,java.nio.ByteBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg1"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <returns><see cref="Javax.Net.Ssl.SSLEngineResult"/></returns>
        /// <exception cref="Javax.Net.Ssl.SSLException"/>
        public Javax.Net.Ssl.SSLEngineResult Unwrap(Java.Nio.ByteBuffer arg0, Java.Nio.ByteBuffer arg1)
        {
            return IExecute<Javax.Net.Ssl.SSLEngineResult>("unwrap", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLEngine.html#unwrap(java.nio.ByteBuffer,java.nio.ByteBuffer[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg1"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <returns><see cref="Javax.Net.Ssl.SSLEngineResult"/></returns>
        /// <exception cref="Javax.Net.Ssl.SSLException"/>
        public Javax.Net.Ssl.SSLEngineResult Unwrap(Java.Nio.ByteBuffer arg0, Java.Nio.ByteBuffer[] arg1)
        {
            return IExecute<Javax.Net.Ssl.SSLEngineResult>("unwrap", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLEngine.html#wrap(java.nio.ByteBuffer,java.nio.ByteBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg1"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <returns><see cref="Javax.Net.Ssl.SSLEngineResult"/></returns>
        /// <exception cref="Javax.Net.Ssl.SSLException"/>
        public Javax.Net.Ssl.SSLEngineResult Wrap(Java.Nio.ByteBuffer arg0, Java.Nio.ByteBuffer arg1)
        {
            return IExecute<Javax.Net.Ssl.SSLEngineResult>("wrap", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLEngine.html#wrap(java.nio.ByteBuffer[],java.nio.ByteBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg1"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <returns><see cref="Javax.Net.Ssl.SSLEngineResult"/></returns>
        /// <exception cref="Javax.Net.Ssl.SSLException"/>
        public Javax.Net.Ssl.SSLEngineResult Wrap(Java.Nio.ByteBuffer[] arg0, Java.Nio.ByteBuffer arg1)
        {
            return IExecute<Javax.Net.Ssl.SSLEngineResult>("wrap", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLEngine.html#getSSLParameters()"/>
        /// </summary>
        /// <returns><see cref="Javax.Net.Ssl.SSLParameters"/></returns>
        public Javax.Net.Ssl.SSLParameters GetSSLParameters()
        {
            return IExecuteWithSignature<Javax.Net.Ssl.SSLParameters>("getSSLParameters", "()Ljavax/net/ssl/SSLParameters;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLEngine.html#getHandshakeSession()"/>
        /// </summary>
        /// <returns><see cref="Javax.Net.Ssl.SSLSession"/></returns>
        public Javax.Net.Ssl.SSLSession GetHandshakeSession()
        {
            return IExecuteWithSignature<Javax.Net.Ssl.SSLSession>("getHandshakeSession", "()Ljavax/net/ssl/SSLSession;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLEngine.html#setHandshakeApplicationProtocolSelector(java.util.function.BiFunction)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.BiFunction"/></param>
        public void SetHandshakeApplicationProtocolSelector(Java.Util.Function.BiFunction<Javax.Net.Ssl.SSLEngine, Java.Util.List<Java.Lang.String>, Java.Lang.String> arg0)
        {
            IExecuteWithSignature("setHandshakeApplicationProtocolSelector", "(Ljava/util/function/BiFunction;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLEngine.html#setSSLParameters(javax.net.ssl.SSLParameters)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Net.Ssl.SSLParameters"/></param>
        public void SetSSLParameters(Javax.Net.Ssl.SSLParameters arg0)
        {
            IExecuteWithSignature("setSSLParameters", "(Ljavax/net/ssl/SSLParameters;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}