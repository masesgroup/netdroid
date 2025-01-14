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
    #region SQLiteCursor declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/database/sqlite/SQLiteCursor.html"/>
    /// </summary>
    public partial class SQLiteCursor : Android.Database.AbstractWindowedCursor
    {
        const string _bridgeClassName = "android.database.sqlite.SQLiteCursor";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public SQLiteCursor() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public SQLiteCursor(params object[] args) : base(args) { }
    
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

    #region SQLiteCursor implementation
    public partial class SQLiteCursor
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/sqlite/SQLiteCursor.html#%3Cinit%3E(android.database.sqlite.SQLiteCursorDriver,java.lang.String,android.database.sqlite.SQLiteQuery)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Database.Sqlite.SQLiteCursorDriver"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Android.Database.Sqlite.SQLiteQuery"/></param>
        public SQLiteCursor(Android.Database.Sqlite.SQLiteCursorDriver arg0, Java.Lang.String arg1, Android.Database.Sqlite.SQLiteQuery arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/sqlite/SQLiteCursor.html#%3Cinit%3E(android.database.sqlite.SQLiteDatabase,android.database.sqlite.SQLiteCursorDriver,java.lang.String,android.database.sqlite.SQLiteQuery)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Database.Sqlite.SQLiteDatabase"/></param>
        /// <param name="arg1"><see cref="Android.Database.Sqlite.SQLiteCursorDriver"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Android.Database.Sqlite.SQLiteQuery"/></param>
        [global::System.Obsolete()]
        public SQLiteCursor(Android.Database.Sqlite.SQLiteDatabase arg0, Android.Database.Sqlite.SQLiteCursorDriver arg1, Java.Lang.String arg2, Android.Database.Sqlite.SQLiteQuery arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/sqlite/SQLiteCursor.html#getDatabase()"/>
        /// </summary>
        /// <returns><see cref="Android.Database.Sqlite.SQLiteDatabase"/></returns>
        public Android.Database.Sqlite.SQLiteDatabase GetDatabase()
        {
            return IExecuteWithSignature<Android.Database.Sqlite.SQLiteDatabase>("getDatabase", "()Landroid/database/sqlite/SQLiteDatabase;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/sqlite/SQLiteCursor.html#setFillWindowForwardOnly(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetFillWindowForwardOnly(bool arg0)
        {
            IExecuteWithSignature("setFillWindowForwardOnly", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/sqlite/SQLiteCursor.html#setSelectionArguments(java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetSelectionArguments(Java.Lang.String[] arg0)
        {
            IExecuteWithSignature("setSelectionArguments", "([Ljava/lang/String;)V", new object[] { arg0 });
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}