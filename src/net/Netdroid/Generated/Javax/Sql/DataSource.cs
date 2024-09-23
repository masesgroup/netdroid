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

namespace Javax.Sql
{
    #region DataSource declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/javax/sql/DataSource.html"/>
    /// </summary>
    public partial class DataSource : MASES.JCOBridge.C2JBridge.JVMBridgeBase<DataSource>
    {
        const string _bridgeClassName = "javax.sql.DataSource";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("DataSource class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public DataSource() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("DataSource class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public DataSource(params object[] args) : base(args) { }
    
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
        public override bool IsBridgeInterface => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;
    
        // TODO: complete the class
    
    }
    #endregion

    #region IDataSource
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IDataSource
    {
        #region Instance methods
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion

    #region DataSource implementation
    public partial class DataSource : Javax.Sql.IDataSource, Javax.Sql.ICommonDataSource, Java.Sql.IWrapper
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Sql.DataSource"/> to <see cref="Javax.Sql.CommonDataSource"/>
        /// </summary>
        public static implicit operator Javax.Sql.CommonDataSource(Javax.Sql.DataSource t) => t.Cast<Javax.Sql.CommonDataSource>();
        /// <summary>
        /// Converter from <see cref="Javax.Sql.DataSource"/> to <see cref="Java.Sql.Wrapper"/>
        /// </summary>
        public static implicit operator Java.Sql.Wrapper(Javax.Sql.DataSource t) => t.Cast<Java.Sql.Wrapper>();
    
        #endregion
    
        #region Fields
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/sql/DataSource.html#getLoginTimeout()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public int GetLoginTimeout()
        {
            return IExecuteWithSignature<int>("getLoginTimeout", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/sql/DataSource.html#getLogWriter()"/>
        /// </summary>
        /// <returns><see cref="Java.Io.PrintWriter"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Io.PrintWriter GetLogWriter()
        {
            return IExecuteWithSignature<Java.Io.PrintWriter>("getLogWriter", "()Ljava/io/PrintWriter;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/sql/DataSource.html#getConnection()"/>
        /// </summary>
        /// <returns><see cref="Java.Sql.Connection"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Sql.Connection GetConnection()
        {
            return IExecuteWithSignature<Java.Sql.Connection>("getConnection", "()Ljava/sql/Connection;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/sql/DataSource.html#getConnection(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Sql.Connection"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Sql.Connection GetConnection(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return IExecute<Java.Sql.Connection>("getConnection", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/sql/DataSource.html#setLoginTimeout(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetLoginTimeout(int arg0)
        {
            IExecuteWithSignature("setLoginTimeout", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/sql/DataSource.html#setLogWriter(java.io.PrintWriter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.PrintWriter"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetLogWriter(Java.Io.PrintWriter arg0)
        {
            IExecuteWithSignature("setLogWriter", "(Ljava/io/PrintWriter;)V", arg0);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}