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

namespace Android.Database.Sqlite
{
    #region SQLiteStatement
    public partial class SQLiteStatement
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
        /// <see href="https://developer.android.com/reference/android/database/sqlite/SQLiteStatement.html#simpleQueryForBlobFileDescriptor()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.ParcelFileDescriptor"/></returns>
        public Android.Os.ParcelFileDescriptor SimpleQueryForBlobFileDescriptor()
        {
            return IExecuteWithSignature<Android.Os.ParcelFileDescriptor>("simpleQueryForBlobFileDescriptor", "()Landroid/os/ParcelFileDescriptor;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/sqlite/SQLiteStatement.html#executeUpdateDelete()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int ExecuteUpdateDelete()
        {
            return IExecuteWithSignature<int>("executeUpdateDelete", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/sqlite/SQLiteStatement.html#simpleQueryForString()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String SimpleQueryForString()
        {
            return IExecuteWithSignature<Java.Lang.String>("simpleQueryForString", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/sqlite/SQLiteStatement.html#executeInsert()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long ExecuteInsert()
        {
            return IExecuteWithSignature<long>("executeInsert", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/sqlite/SQLiteStatement.html#simpleQueryForLong()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long SimpleQueryForLong()
        {
            return IExecuteWithSignature<long>("simpleQueryForLong", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/sqlite/SQLiteStatement.html#execute()"/>
        /// </summary>
        public void Execute()
        {
            IExecuteWithSignature("execute", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}