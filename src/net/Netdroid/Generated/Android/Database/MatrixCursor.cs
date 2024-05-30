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

namespace Android.Database
{
    #region MatrixCursor
    public partial class MatrixCursor
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/MatrixCursor.html#%3Cinit%3E(java.lang.String[],int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public MatrixCursor(Java.Lang.String[] arg0, int arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/MatrixCursor.html#%3Cinit%3E(java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public MatrixCursor(Java.Lang.String[] arg0)
            : base(arg0)
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
        /// <see href="https://developer.android.com/reference/android/database/MatrixCursor.html#newRow()"/>
        /// </summary>
        /// <returns><see cref="Android.Database.MatrixCursor.RowBuilder"/></returns>
        public Android.Database.MatrixCursor.RowBuilder NewRow()
        {
            return IExecuteWithSignature<Android.Database.MatrixCursor.RowBuilder>("newRow", "()Landroid/database/MatrixCursor$RowBuilder;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/MatrixCursor.html#addRow(java.lang.Iterable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Iterable"/></param>
        public void AddRow(Java.Lang.Iterable<object> arg0)
        {
            IExecuteWithSignature("addRow", "(Ljava/lang/Iterable;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/MatrixCursor.html#addRow(java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public void AddRow(object[] arg0)
        {
            IExecuteWithSignature("addRow", "([Ljava/lang/Object;)V", new object[] { arg0 });
        }

        #endregion

        #region Nested classes
        #region RowBuilder
        public partial class RowBuilder
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
            /// <see href="https://developer.android.com/reference/android/database/MatrixCursor.RowBuilder.html#add(java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><see cref="object"/></param>
            /// <returns><see cref="Android.Database.MatrixCursor.RowBuilder"/></returns>
            public Android.Database.MatrixCursor.RowBuilder Add(object arg0)
            {
                return IExecuteWithSignature<Android.Database.MatrixCursor.RowBuilder>("add", "(Ljava/lang/Object;)Landroid/database/MatrixCursor$RowBuilder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/database/MatrixCursor.RowBuilder.html#add(java.lang.String,java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="object"/></param>
            /// <returns><see cref="Android.Database.MatrixCursor.RowBuilder"/></returns>
            public Android.Database.MatrixCursor.RowBuilder Add(Java.Lang.String arg0, object arg1)
            {
                return IExecute<Android.Database.MatrixCursor.RowBuilder>("add", arg0, arg1);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}