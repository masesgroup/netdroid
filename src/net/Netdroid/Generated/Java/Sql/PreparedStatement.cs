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

namespace Java.Sql
{
    #region PreparedStatement declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/java/sql/PreparedStatement.html"/>
    /// </summary>
    public partial class PreparedStatement : Java.Sql.Statement
    {
        const string _bridgeClassName = "java.sql.PreparedStatement";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("PreparedStatement class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public PreparedStatement() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("PreparedStatement class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public PreparedStatement(params object[] args) : base(args) { }
    
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

    #region IPreparedStatement
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IPreparedStatement : Java.Sql.IStatement
    {
        #region Instance methods
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion

    #region PreparedStatement implementation
    public partial class PreparedStatement : Java.Sql.IPreparedStatement
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
        /// <see href="https://developer.android.com/reference/java/sql/PreparedStatement.html#execute()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public bool Execute()
        {
            return IExecuteWithSignature<bool>("execute", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/PreparedStatement.html#executeUpdate()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public int ExecuteUpdate()
        {
            return IExecuteWithSignature<int>("executeUpdate", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/PreparedStatement.html#getParameterMetaData()"/>
        /// </summary>
        /// <returns><see cref="Java.Sql.ParameterMetaData"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Sql.ParameterMetaData GetParameterMetaData()
        {
            return IExecuteWithSignature<Java.Sql.ParameterMetaData>("getParameterMetaData", "()Ljava/sql/ParameterMetaData;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/PreparedStatement.html#executeQuery()"/>
        /// </summary>
        /// <returns><see cref="Java.Sql.ResultSet"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Sql.ResultSet ExecuteQuery()
        {
            return IExecuteWithSignature<Java.Sql.ResultSet>("executeQuery", "()Ljava/sql/ResultSet;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/PreparedStatement.html#getMetaData()"/>
        /// </summary>
        /// <returns><see cref="Java.Sql.ResultSetMetaData"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Sql.ResultSetMetaData GetMetaData()
        {
            return IExecuteWithSignature<Java.Sql.ResultSetMetaData>("getMetaData", "()Ljava/sql/ResultSetMetaData;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/PreparedStatement.html#addBatch()"/>
        /// </summary>
        /// <exception cref="Java.Sql.SQLException"/>
        public void AddBatch()
        {
            IExecuteWithSignature("addBatch", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/PreparedStatement.html#clearParameters()"/>
        /// </summary>
        /// <exception cref="Java.Sql.SQLException"/>
        public void ClearParameters()
        {
            IExecuteWithSignature("clearParameters", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/PreparedStatement.html#setArray(int,java.sql.Array)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Sql.Array"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetArray(int arg0, Java.Sql.Array arg1)
        {
            IExecute("setArray", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/PreparedStatement.html#setAsciiStream(int,java.io.InputStream,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Io.InputStream"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetAsciiStream(int arg0, Java.Io.InputStream arg1, int arg2)
        {
            IExecute("setAsciiStream", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/PreparedStatement.html#setAsciiStream(int,java.io.InputStream,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Io.InputStream"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetAsciiStream(int arg0, Java.Io.InputStream arg1, long arg2)
        {
            IExecute("setAsciiStream", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/PreparedStatement.html#setAsciiStream(int,java.io.InputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Io.InputStream"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetAsciiStream(int arg0, Java.Io.InputStream arg1)
        {
            IExecute("setAsciiStream", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/PreparedStatement.html#setBigDecimal(int,java.math.BigDecimal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Math.BigDecimal"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetBigDecimal(int arg0, Java.Math.BigDecimal arg1)
        {
            IExecute("setBigDecimal", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/PreparedStatement.html#setBinaryStream(int,java.io.InputStream,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Io.InputStream"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetBinaryStream(int arg0, Java.Io.InputStream arg1, int arg2)
        {
            IExecute("setBinaryStream", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/PreparedStatement.html#setBinaryStream(int,java.io.InputStream,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Io.InputStream"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetBinaryStream(int arg0, Java.Io.InputStream arg1, long arg2)
        {
            IExecute("setBinaryStream", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/PreparedStatement.html#setBinaryStream(int,java.io.InputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Io.InputStream"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetBinaryStream(int arg0, Java.Io.InputStream arg1)
        {
            IExecute("setBinaryStream", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/PreparedStatement.html#setBlob(int,java.io.InputStream,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Io.InputStream"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetBlob(int arg0, Java.Io.InputStream arg1, long arg2)
        {
            IExecute("setBlob", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/PreparedStatement.html#setBlob(int,java.io.InputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Io.InputStream"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetBlob(int arg0, Java.Io.InputStream arg1)
        {
            IExecute("setBlob", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/PreparedStatement.html#setBlob(int,java.sql.Blob)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Sql.Blob"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetBlob(int arg0, Java.Sql.Blob arg1)
        {
            IExecute("setBlob", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/PreparedStatement.html#setBoolean(int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetBoolean(int arg0, bool arg1)
        {
            IExecute("setBoolean", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/PreparedStatement.html#setByte(int,byte)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetByte(int arg0, byte arg1)
        {
            IExecute("setByte", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/PreparedStatement.html#setBytes(int,byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetBytes(int arg0, byte[] arg1)
        {
            IExecute("setBytes", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/PreparedStatement.html#setCharacterStream(int,java.io.Reader,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Io.Reader"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetCharacterStream(int arg0, Java.Io.Reader arg1, int arg2)
        {
            IExecute("setCharacterStream", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/PreparedStatement.html#setCharacterStream(int,java.io.Reader,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Io.Reader"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetCharacterStream(int arg0, Java.Io.Reader arg1, long arg2)
        {
            IExecute("setCharacterStream", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/PreparedStatement.html#setCharacterStream(int,java.io.Reader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Io.Reader"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetCharacterStream(int arg0, Java.Io.Reader arg1)
        {
            IExecute("setCharacterStream", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/PreparedStatement.html#setClob(int,java.io.Reader,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Io.Reader"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetClob(int arg0, Java.Io.Reader arg1, long arg2)
        {
            IExecute("setClob", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/PreparedStatement.html#setClob(int,java.io.Reader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Io.Reader"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetClob(int arg0, Java.Io.Reader arg1)
        {
            IExecute("setClob", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/PreparedStatement.html#setClob(int,java.sql.Clob)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Sql.Clob"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetClob(int arg0, Java.Sql.Clob arg1)
        {
            IExecute("setClob", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/PreparedStatement.html#setDate(int,java.sql.Date,java.util.Calendar)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Sql.Date"/></param>
        /// <param name="arg2"><see cref="Java.Util.Calendar"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetDate(int arg0, Java.Sql.Date arg1, Java.Util.Calendar arg2)
        {
            IExecute("setDate", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/PreparedStatement.html#setDate(int,java.sql.Date)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Sql.Date"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetDate(int arg0, Java.Sql.Date arg1)
        {
            IExecute("setDate", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/PreparedStatement.html#setDouble(int,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetDouble(int arg0, double arg1)
        {
            IExecute("setDouble", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/PreparedStatement.html#setFloat(int,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetFloat(int arg0, float arg1)
        {
            IExecute("setFloat", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/PreparedStatement.html#setInt(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetInt(int arg0, int arg1)
        {
            IExecute("setInt", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/PreparedStatement.html#setLong(int,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetLong(int arg0, long arg1)
        {
            IExecute("setLong", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/PreparedStatement.html#setNCharacterStream(int,java.io.Reader,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Io.Reader"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetNCharacterStream(int arg0, Java.Io.Reader arg1, long arg2)
        {
            IExecute("setNCharacterStream", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/PreparedStatement.html#setNCharacterStream(int,java.io.Reader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Io.Reader"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetNCharacterStream(int arg0, Java.Io.Reader arg1)
        {
            IExecute("setNCharacterStream", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/PreparedStatement.html#setNClob(int,java.io.Reader,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Io.Reader"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetNClob(int arg0, Java.Io.Reader arg1, long arg2)
        {
            IExecute("setNClob", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/PreparedStatement.html#setNClob(int,java.io.Reader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Io.Reader"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetNClob(int arg0, Java.Io.Reader arg1)
        {
            IExecute("setNClob", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/PreparedStatement.html#setNClob(int,java.sql.NClob)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Sql.NClob"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetNClob(int arg0, Java.Sql.NClob arg1)
        {
            IExecute("setNClob", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/PreparedStatement.html#setNString(int,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetNString(int arg0, Java.Lang.String arg1)
        {
            IExecute("setNString", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/PreparedStatement.html#setNull(int,int,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetNull(int arg0, int arg1, Java.Lang.String arg2)
        {
            IExecute("setNull", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/PreparedStatement.html#setNull(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetNull(int arg0, int arg1)
        {
            IExecute("setNull", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/PreparedStatement.html#setObject(int,java.lang.Object,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetObject(int arg0, object arg1, int arg2, int arg3)
        {
            IExecute("setObject", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/PreparedStatement.html#setObject(int,java.lang.Object,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetObject(int arg0, object arg1, int arg2)
        {
            IExecute("setObject", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/PreparedStatement.html#setObject(int,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetObject(int arg0, object arg1)
        {
            IExecute("setObject", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/PreparedStatement.html#setRef(int,java.sql.Ref)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Sql.Ref"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetRef(int arg0, Java.Sql.Ref arg1)
        {
            IExecute("setRef", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/PreparedStatement.html#setRowId(int,java.sql.RowId)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Sql.RowId"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetRowId(int arg0, Java.Sql.RowId arg1)
        {
            IExecute("setRowId", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/PreparedStatement.html#setShort(int,short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="short"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetShort(int arg0, short arg1)
        {
            IExecute("setShort", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/PreparedStatement.html#setSQLXML(int,java.sql.SQLXML)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Sql.SQLXML"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetSQLXML(int arg0, Java.Sql.SQLXML arg1)
        {
            IExecute("setSQLXML", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/PreparedStatement.html#setString(int,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetString(int arg0, Java.Lang.String arg1)
        {
            IExecute("setString", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/PreparedStatement.html#setTime(int,java.sql.Time,java.util.Calendar)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Sql.Time"/></param>
        /// <param name="arg2"><see cref="Java.Util.Calendar"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetTime(int arg0, Java.Sql.Time arg1, Java.Util.Calendar arg2)
        {
            IExecute("setTime", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/PreparedStatement.html#setTime(int,java.sql.Time)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Sql.Time"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetTime(int arg0, Java.Sql.Time arg1)
        {
            IExecute("setTime", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/PreparedStatement.html#setTimestamp(int,java.sql.Timestamp,java.util.Calendar)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Sql.Timestamp"/></param>
        /// <param name="arg2"><see cref="Java.Util.Calendar"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetTimestamp(int arg0, Java.Sql.Timestamp arg1, Java.Util.Calendar arg2)
        {
            IExecute("setTimestamp", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/PreparedStatement.html#setTimestamp(int,java.sql.Timestamp)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Sql.Timestamp"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetTimestamp(int arg0, Java.Sql.Timestamp arg1)
        {
            IExecute("setTimestamp", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/PreparedStatement.html#setUnicodeStream(int,java.io.InputStream,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Io.InputStream"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        [global::System.Obsolete()]
        public void SetUnicodeStream(int arg0, Java.Io.InputStream arg1, int arg2)
        {
            IExecute("setUnicodeStream", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/PreparedStatement.html#setURL(int,java.net.URL)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Net.URL"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetURL(int arg0, Java.Net.URL arg1)
        {
            IExecute("setURL", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/PreparedStatement.html#executeLargeUpdate()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public long ExecuteLargeUpdate()
        {
            return IExecuteWithSignature<long>("executeLargeUpdate", "()J");
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}