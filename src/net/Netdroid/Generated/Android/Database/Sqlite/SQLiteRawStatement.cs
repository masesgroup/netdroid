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
*  This file is generated by MASES.JNetReflector (ver. 2.5.10.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Database.Sqlite
{
    #region SQLiteRawStatement declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/database/sqlite/SQLiteRawStatement.html"/>
    /// </summary>
    public partial class SQLiteRawStatement : Java.Io.Closeable
    {
        const string _bridgeClassName = "android.database.sqlite.SQLiteRawStatement";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public SQLiteRawStatement() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public SQLiteRawStatement(params object[] args) : base(args) { }
    
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

    #region SQLiteRawStatement implementation
    public partial class SQLiteRawStatement
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/sqlite/SQLiteRawStatement.html#SQLITE_DATA_TYPE_BLOB"/>
        /// </summary>
        public static int SQLITE_DATA_TYPE_BLOB { get { if (!_SQLITE_DATA_TYPE_BLOBReady) { _SQLITE_DATA_TYPE_BLOBContent = SGetField<int>(LocalBridgeClazz, "SQLITE_DATA_TYPE_BLOB"); _SQLITE_DATA_TYPE_BLOBReady = true; } return _SQLITE_DATA_TYPE_BLOBContent; } }
        private static int _SQLITE_DATA_TYPE_BLOBContent = default;
        private static bool _SQLITE_DATA_TYPE_BLOBReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/sqlite/SQLiteRawStatement.html#SQLITE_DATA_TYPE_FLOAT"/>
        /// </summary>
        public static int SQLITE_DATA_TYPE_FLOAT { get { if (!_SQLITE_DATA_TYPE_FLOATReady) { _SQLITE_DATA_TYPE_FLOATContent = SGetField<int>(LocalBridgeClazz, "SQLITE_DATA_TYPE_FLOAT"); _SQLITE_DATA_TYPE_FLOATReady = true; } return _SQLITE_DATA_TYPE_FLOATContent; } }
        private static int _SQLITE_DATA_TYPE_FLOATContent = default;
        private static bool _SQLITE_DATA_TYPE_FLOATReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/sqlite/SQLiteRawStatement.html#SQLITE_DATA_TYPE_INTEGER"/>
        /// </summary>
        public static int SQLITE_DATA_TYPE_INTEGER { get { if (!_SQLITE_DATA_TYPE_INTEGERReady) { _SQLITE_DATA_TYPE_INTEGERContent = SGetField<int>(LocalBridgeClazz, "SQLITE_DATA_TYPE_INTEGER"); _SQLITE_DATA_TYPE_INTEGERReady = true; } return _SQLITE_DATA_TYPE_INTEGERContent; } }
        private static int _SQLITE_DATA_TYPE_INTEGERContent = default;
        private static bool _SQLITE_DATA_TYPE_INTEGERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/sqlite/SQLiteRawStatement.html#SQLITE_DATA_TYPE_NULL"/>
        /// </summary>
        public static int SQLITE_DATA_TYPE_NULL { get { if (!_SQLITE_DATA_TYPE_NULLReady) { _SQLITE_DATA_TYPE_NULLContent = SGetField<int>(LocalBridgeClazz, "SQLITE_DATA_TYPE_NULL"); _SQLITE_DATA_TYPE_NULLReady = true; } return _SQLITE_DATA_TYPE_NULLContent; } }
        private static int _SQLITE_DATA_TYPE_NULLContent = default;
        private static bool _SQLITE_DATA_TYPE_NULLReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/sqlite/SQLiteRawStatement.html#SQLITE_DATA_TYPE_TEXT"/>
        /// </summary>
        public static int SQLITE_DATA_TYPE_TEXT { get { if (!_SQLITE_DATA_TYPE_TEXTReady) { _SQLITE_DATA_TYPE_TEXTContent = SGetField<int>(LocalBridgeClazz, "SQLITE_DATA_TYPE_TEXT"); _SQLITE_DATA_TYPE_TEXTReady = true; } return _SQLITE_DATA_TYPE_TEXTContent; } }
        private static int _SQLITE_DATA_TYPE_TEXTContent = default;
        private static bool _SQLITE_DATA_TYPE_TEXTReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/sqlite/SQLiteRawStatement.html#isOpen()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsOpen()
        {
            return IExecuteWithSignature<bool>("isOpen", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/sqlite/SQLiteRawStatement.html#step()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool Step()
        {
            return IExecuteWithSignature<bool>("step", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/sqlite/SQLiteRawStatement.html#getColumnBlob(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="byte"/></returns>
        public byte[] GetColumnBlob(int arg0)
        {
            return IExecuteWithSignatureArray<byte>("getColumnBlob", "(I)[B", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/sqlite/SQLiteRawStatement.html#getColumnDouble(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="double"/></returns>
        public double GetColumnDouble(int arg0)
        {
            return IExecuteWithSignature<double>("getColumnDouble", "(I)D", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/sqlite/SQLiteRawStatement.html#getColumnInt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetColumnInt(int arg0)
        {
            return IExecuteWithSignature<int>("getColumnInt", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/sqlite/SQLiteRawStatement.html#getColumnLength(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetColumnLength(int arg0)
        {
            return IExecuteWithSignature<int>("getColumnLength", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/sqlite/SQLiteRawStatement.html#getColumnType(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetColumnType(int arg0)
        {
            return IExecuteWithSignature<int>("getColumnType", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/sqlite/SQLiteRawStatement.html#getParameterCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetParameterCount()
        {
            return IExecuteWithSignature<int>("getParameterCount", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/sqlite/SQLiteRawStatement.html#getParameterIndex(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetParameterIndex(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<int>("getParameterIndex", "(Ljava/lang/String;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/sqlite/SQLiteRawStatement.html#getResultColumnCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetResultColumnCount()
        {
            return IExecuteWithSignature<int>("getResultColumnCount", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/sqlite/SQLiteRawStatement.html#readColumnBlob(int,byte[],int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int ReadColumnBlob(int arg0, byte[] arg1, int arg2, int arg3, int arg4)
        {
            return IExecuteWithSignature<int>("readColumnBlob", "(I[BIII)I", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/sqlite/SQLiteRawStatement.html#getColumnName(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetColumnName(int arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getColumnName", "(I)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/sqlite/SQLiteRawStatement.html#getColumnText(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetColumnText(int arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getColumnText", "(I)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/sqlite/SQLiteRawStatement.html#getParameterName(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetParameterName(int arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getParameterName", "(I)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/sqlite/SQLiteRawStatement.html#getColumnLong(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="long"/></returns>
        public long GetColumnLong(int arg0)
        {
            return IExecuteWithSignature<long>("getColumnLong", "(I)J", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/sqlite/SQLiteRawStatement.html#bindBlob(int,byte[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public void BindBlob(int arg0, byte[] arg1, int arg2, int arg3)
        {
            IExecuteWithSignature("bindBlob", "(I[BII)V", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/sqlite/SQLiteRawStatement.html#bindBlob(int,byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        public void BindBlob(int arg0, byte[] arg1)
        {
            IExecuteWithSignature("bindBlob", "(I[B)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/sqlite/SQLiteRawStatement.html#bindDouble(int,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        public void BindDouble(int arg0, double arg1)
        {
            IExecuteWithSignature("bindDouble", "(ID)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/sqlite/SQLiteRawStatement.html#bindInt(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void BindInt(int arg0, int arg1)
        {
            IExecuteWithSignature("bindInt", "(II)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/sqlite/SQLiteRawStatement.html#bindLong(int,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        public void BindLong(int arg0, long arg1)
        {
            IExecuteWithSignature("bindLong", "(IJ)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/sqlite/SQLiteRawStatement.html#bindNull(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void BindNull(int arg0)
        {
            IExecuteWithSignature("bindNull", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/sqlite/SQLiteRawStatement.html#bindText(int,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public void BindText(int arg0, Java.Lang.String arg1)
        {
            IExecuteWithSignature("bindText", "(ILjava/lang/String;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/sqlite/SQLiteRawStatement.html#clearBindings()"/>
        /// </summary>
        public void ClearBindings()
        {
            IExecuteWithSignature("clearBindings", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/sqlite/SQLiteRawStatement.html#close()"/>
        /// </summary>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/sqlite/SQLiteRawStatement.html#reset()"/>
        /// </summary>
        public void Reset()
        {
            IExecuteWithSignature("reset", "()V");
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}