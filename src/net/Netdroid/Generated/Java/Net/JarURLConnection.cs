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
    #region JarURLConnection declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/java/net/JarURLConnection.html"/>
    /// </summary>
    public partial class JarURLConnection : Java.Net.URLConnection
    {
        const string _bridgeClassName = "java.net.JarURLConnection";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("JarURLConnection class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public JarURLConnection() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("JarURLConnection class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public JarURLConnection(params object[] args) : base(args) { }
    
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

    #region JarURLConnection implementation
    public partial class JarURLConnection
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
        /// <see href="https://developer.android.com/reference/java/net/JarURLConnection.html#getJarFile()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Jar.JarFile"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Util.Jar.JarFile GetJarFile()
        {
            return IExecuteWithSignature<Java.Util.Jar.JarFile>("getJarFile", "()Ljava/util/jar/JarFile;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/JarURLConnection.html#getEntryName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetEntryName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getEntryName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/JarURLConnection.html#getJarFileURL()"/>
        /// </summary>
        /// <returns><see cref="Java.Net.URL"/></returns>
        public Java.Net.URL GetJarFileURL()
        {
            return IExecuteWithSignature<Java.Net.URL>("getJarFileURL", "()Ljava/net/URL;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/JarURLConnection.html#getCertificates()"/>
        /// </summary>
        /// <returns><see cref="Java.Security.Cert.Certificate"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Security.Cert.Certificate[] GetCertificates()
        {
            return IExecuteWithSignatureArray<Java.Security.Cert.Certificate>("getCertificates", "()[Ljava/security/cert/Certificate;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/JarURLConnection.html#getAttributes()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Jar.Attributes"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Util.Jar.Attributes GetAttributes()
        {
            return IExecuteWithSignature<Java.Util.Jar.Attributes>("getAttributes", "()Ljava/util/jar/Attributes;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/JarURLConnection.html#getMainAttributes()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Jar.Attributes"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Util.Jar.Attributes GetMainAttributes()
        {
            return IExecuteWithSignature<Java.Util.Jar.Attributes>("getMainAttributes", "()Ljava/util/jar/Attributes;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/JarURLConnection.html#getJarEntry()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Jar.JarEntry"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Util.Jar.JarEntry GetJarEntry()
        {
            return IExecuteWithSignature<Java.Util.Jar.JarEntry>("getJarEntry", "()Ljava/util/jar/JarEntry;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/JarURLConnection.html#getManifest()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Jar.Manifest"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Util.Jar.Manifest GetManifest()
        {
            return IExecuteWithSignature<Java.Util.Jar.Manifest>("getManifest", "()Ljava/util/jar/Manifest;");
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}