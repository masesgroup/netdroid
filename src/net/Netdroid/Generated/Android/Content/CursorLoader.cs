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

namespace Android.Content
{
    #region CursorLoader
    public partial class CursorLoader
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/CursorLoader.html#%3Cinit%3E(android.content.Context,android.net.Uri,java.lang.String[],java.lang.String,java.lang.String[],java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Net.Uri"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        /// <param name="arg4"><see cref="Java.Lang.String"/></param>
        /// <param name="arg5"><see cref="Java.Lang.String"/></param>
        [System.Obsolete()]
        public CursorLoader(Android.Content.Context arg0, Android.Net.Uri arg1, Java.Lang.String[] arg2, Java.Lang.String arg3, Java.Lang.String[] arg4, Java.Lang.String arg5)
            : base(arg0, arg1, arg2, arg3, arg4, arg5)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/CursorLoader.html#%3Cinit%3E(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        [System.Obsolete()]
        public CursorLoader(Android.Content.Context arg0)
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
        /// <see href="https://developer.android.com/reference/android/content/CursorLoader.html#getProjection()"/> <see href="https://developer.android.com/reference/android/content/CursorLoader.html#setProjection(java.lang.String[])"/>
        /// </summary>
        [System.Obsolete()]
        public Java.Lang.String[] Projection
        {
            get { return IExecuteWithSignatureArray<Java.Lang.String>("getProjection", "()[Ljava/lang/String;"); } set { IExecuteWithSignature("setProjection", "([Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/CursorLoader.html#getSelection()"/> <see href="https://developer.android.com/reference/android/content/CursorLoader.html#setSelection(java.lang.String)"/>
        /// </summary>
        [System.Obsolete()]
        public Java.Lang.String Selection
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getSelection", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setSelection", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/CursorLoader.html#getSelectionArgs()"/> <see href="https://developer.android.com/reference/android/content/CursorLoader.html#setSelectionArgs(java.lang.String[])"/>
        /// </summary>
        [System.Obsolete()]
        public Java.Lang.String[] SelectionArgs
        {
            get { return IExecuteWithSignatureArray<Java.Lang.String>("getSelectionArgs", "()[Ljava/lang/String;"); } set { IExecuteWithSignature("setSelectionArgs", "([Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/CursorLoader.html#getSortOrder()"/> <see href="https://developer.android.com/reference/android/content/CursorLoader.html#setSortOrder(java.lang.String)"/>
        /// </summary>
        [System.Obsolete()]
        public Java.Lang.String SortOrder
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getSortOrder", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setSortOrder", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/CursorLoader.html#getUri()"/> <see href="https://developer.android.com/reference/android/content/CursorLoader.html#setUri(android.net.Uri)"/>
        /// </summary>
        [System.Obsolete()]
        public Android.Net.Uri Uri
        {
            get { return IExecuteWithSignature<Android.Net.Uri>("getUri", "()Landroid/net/Uri;"); } set { IExecuteWithSignature("setUri", "(Landroid/net/Uri;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/CursorLoader.html#deliverResult(android.database.Cursor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Database.Cursor"/></param>
        [System.Obsolete()]
        public void DeliverResult(Android.Database.Cursor arg0)
        {
            IExecuteWithSignature("deliverResult", "(Landroid/database/Cursor;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/CursorLoader.html#onCanceled(android.database.Cursor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Database.Cursor"/></param>
        [System.Obsolete()]
        public void OnCanceled(Android.Database.Cursor arg0)
        {
            IExecuteWithSignature("onCanceled", "(Landroid/database/Cursor;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}