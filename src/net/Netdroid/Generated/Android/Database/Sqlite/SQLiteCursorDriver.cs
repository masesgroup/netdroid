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

namespace Android.Database.Sqlite
{
    #region ISQLiteCursorDriver
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ISQLiteCursorDriver
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/sqlite/SQLiteCursorDriver.html#query(android.database.sqlite.SQLiteDatabase.CursorFactory,java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Database.Sqlite.SQLiteDatabase.CursorFactory"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Database.Cursor"/></returns>
        Android.Database.Cursor Query(Android.Database.Sqlite.SQLiteDatabase.CursorFactory arg0, Java.Lang.String[] arg1);
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/sqlite/SQLiteCursorDriver.html#cursorClosed()"/>
        /// </summary>
        void CursorClosed();
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/sqlite/SQLiteCursorDriver.html#cursorDeactivated()"/>
        /// </summary>
        void CursorDeactivated();
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/sqlite/SQLiteCursorDriver.html#cursorRequeried(android.database.Cursor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Database.Cursor"/></param>
        void CursorRequeried(Android.Database.Cursor arg0);
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/sqlite/SQLiteCursorDriver.html#setBindArguments(java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        void SetBindArguments(Java.Lang.String[] arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region SQLiteCursorDriver
    public partial class SQLiteCursorDriver : Android.Database.Sqlite.ISQLiteCursorDriver
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
        /// <see href="https://developer.android.com/reference/android/database/sqlite/SQLiteCursorDriver.html#query(android.database.sqlite.SQLiteDatabase.CursorFactory,java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Database.Sqlite.SQLiteDatabase.CursorFactory"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Database.Cursor"/></returns>
        public Android.Database.Cursor Query(Android.Database.Sqlite.SQLiteDatabase.CursorFactory arg0, Java.Lang.String[] arg1)
        {
            return IExecute<Android.Database.Cursor>("query", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/sqlite/SQLiteCursorDriver.html#cursorClosed()"/>
        /// </summary>
        public void CursorClosed()
        {
            IExecuteWithSignature("cursorClosed", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/sqlite/SQLiteCursorDriver.html#cursorDeactivated()"/>
        /// </summary>
        public void CursorDeactivated()
        {
            IExecuteWithSignature("cursorDeactivated", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/sqlite/SQLiteCursorDriver.html#cursorRequeried(android.database.Cursor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Database.Cursor"/></param>
        public void CursorRequeried(Android.Database.Cursor arg0)
        {
            IExecuteWithSignature("cursorRequeried", "(Landroid/database/Cursor;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/sqlite/SQLiteCursorDriver.html#setBindArguments(java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetBindArguments(Java.Lang.String[] arg0)
        {
            IExecuteWithSignature("setBindArguments", "([Ljava/lang/String;)V", new object[] { arg0 });
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}