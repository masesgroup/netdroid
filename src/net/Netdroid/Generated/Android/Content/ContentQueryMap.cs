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
*  This file is generated by MASES.JNetReflector (ver. 2.5.5.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Content
{
    #region ContentQueryMap
    public partial class ContentQueryMap
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ContentQueryMap.html#%3Cinit%3E(android.database.Cursor,java.lang.String,boolean,android.os.Handler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Database.Cursor"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <param name="arg3"><see cref="Android.Os.Handler"/></param>
        public ContentQueryMap(Android.Database.Cursor arg0, Java.Lang.String arg1, bool arg2, Android.Os.Handler arg3)
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
        /// <see href="https://developer.android.com/reference/android/content/ContentQueryMap.html#getValues(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Content.ContentValues"/></returns>
        public Android.Content.ContentValues GetValues(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Android.Content.ContentValues>("getValues", "(Ljava/lang/String;)Landroid/content/ContentValues;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ContentQueryMap.html#getRows()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<Java.Lang.String, Android.Content.ContentValues> GetRows()
        {
            return IExecuteWithSignature<Java.Util.Map<Java.Lang.String, Android.Content.ContentValues>>("getRows", "()Ljava/util/Map;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ContentQueryMap.html#close()"/>
        /// </summary>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ContentQueryMap.html#requery()"/>
        /// </summary>
        public void Requery()
        {
            IExecuteWithSignature("requery", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ContentQueryMap.html#setKeepUpdated(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetKeepUpdated(bool arg0)
        {
            IExecuteWithSignature("setKeepUpdated", "(Z)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}