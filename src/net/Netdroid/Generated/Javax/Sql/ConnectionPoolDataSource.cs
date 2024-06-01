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
*  This file is generated by MASES.JNetReflector (ver. 2.5.1.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Sql
{
    #region IConnectionPoolDataSource
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IConnectionPoolDataSource : Javax.Sql.ICommonDataSource
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ConnectionPoolDataSource
    public partial class ConnectionPoolDataSource : Javax.Sql.IConnectionPoolDataSource
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
        /// <see href="https://developer.android.com/reference/java.sql/javax/sql/ConnectionPoolDataSource.html#getLoginTimeout()"/> <see href="https://developer.android.com/reference/java.sql/javax/sql/ConnectionPoolDataSource.html#setLoginTimeout(int)"/>
        /// </summary>
        public int LoginTimeout
        {
            get { return IExecuteWithSignature<int>("getLoginTimeout", "()I"); } set { IExecuteWithSignature("setLoginTimeout", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.sql/javax/sql/ConnectionPoolDataSource.html#getLogWriter()"/> <see href="https://developer.android.com/reference/java.sql/javax/sql/ConnectionPoolDataSource.html#setLogWriter(java.io.PrintWriter)"/>
        /// </summary>
        public Java.Io.PrintWriter LogWriter
        {
            get { return IExecuteWithSignature<Java.Io.PrintWriter>("getLogWriter", "()Ljava/io/PrintWriter;"); } set { IExecuteWithSignature("setLogWriter", "(Ljava/io/PrintWriter;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.sql/javax/sql/ConnectionPoolDataSource.html#getPooledConnection()"/> 
        /// </summary>
        public Javax.Sql.PooledConnection PooledConnection
        {
            get { return IExecuteWithSignature<Javax.Sql.PooledConnection>("getPooledConnection", "()Ljavax/sql/PooledConnection;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.sql/javax/sql/ConnectionPoolDataSource.html#getPooledConnection(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Sql.PooledConnection"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Javax.Sql.PooledConnection GetPooledConnection(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return IExecute<Javax.Sql.PooledConnection>("getPooledConnection", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}