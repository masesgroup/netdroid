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
*  This file is generated by MASES.JNetReflector (ver. 2.5.2.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Database.Sqlite
{
    #region ISQLiteTransactionListener
    /// <summary>
    /// .NET interface for org.mases.netdroid.generated.android.database.sqlite.SQLiteTransactionListener implementing <see href="https://developer.android.com/reference/android/database/sqlite/SQLiteTransactionListener.html"/>
    /// </summary>
    public partial interface ISQLiteTransactionListener
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region SQLiteTransactionListener
    public partial class SQLiteTransactionListener : Android.Database.Sqlite.ISQLiteTransactionListener
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
        /// Handlers initializer for <see cref="SQLiteTransactionListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("onBegin", new global::System.EventHandler<CLRListenerEventArgs<CLREventData>>(OnBeginEventHandler));
            AddEventHandler("onCommit", new global::System.EventHandler<CLRListenerEventArgs<CLREventData>>(OnCommitEventHandler));
            AddEventHandler("onRollback", new global::System.EventHandler<CLRListenerEventArgs<CLREventData>>(OnRollbackEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/database/sqlite/SQLiteTransactionListener.html#onBegin()"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnBegin"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action OnOnBegin { get; set; } = null;

        void OnBeginEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnOnBegin != null) ? OnOnBegin : OnBegin;
            methodToExecute.Invoke();
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/sqlite/SQLiteTransactionListener.html#onBegin()"/>
        /// </summary>
        public virtual void OnBegin()
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/database/sqlite/SQLiteTransactionListener.html#onCommit()"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnCommit"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action OnOnCommit { get; set; } = null;

        void OnCommitEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnOnCommit != null) ? OnOnCommit : OnCommit;
            methodToExecute.Invoke();
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/sqlite/SQLiteTransactionListener.html#onCommit()"/>
        /// </summary>
        public virtual void OnCommit()
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/database/sqlite/SQLiteTransactionListener.html#onRollback()"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnRollback"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action OnOnRollback { get; set; } = null;

        void OnRollbackEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnOnRollback != null) ? OnOnRollback : OnRollback;
            methodToExecute.Invoke();
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/sqlite/SQLiteTransactionListener.html#onRollback()"/>
        /// </summary>
        public virtual void OnRollback()
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region SQLiteTransactionListenerDirect
    public partial class SQLiteTransactionListenerDirect : Android.Database.Sqlite.ISQLiteTransactionListener
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
        /// <see href="https://developer.android.com/reference/android/database/sqlite/SQLiteTransactionListener.html#onBegin()"/>
        /// </summary>
        public override void OnBegin()
        {
            IExecuteWithSignature("onBegin", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/sqlite/SQLiteTransactionListener.html#onCommit()"/>
        /// </summary>
        public override void OnCommit()
        {
            IExecuteWithSignature("onCommit", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/sqlite/SQLiteTransactionListener.html#onRollback()"/>
        /// </summary>
        public override void OnRollback()
        {
            IExecuteWithSignature("onRollback", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}