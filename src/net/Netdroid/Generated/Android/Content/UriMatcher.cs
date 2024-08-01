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
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Content
{
    #region UriMatcher
    public partial class UriMatcher
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/UriMatcher.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public UriMatcher(int arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/UriMatcher.html#NO_MATCH"/>
        /// </summary>
        public static int NO_MATCH { get { if (!_NO_MATCHReady) { _NO_MATCHContent = SGetField<int>(LocalBridgeClazz, "NO_MATCH"); _NO_MATCHReady = true; } return _NO_MATCHContent; } }
        private static int _NO_MATCHContent = default;
        private static bool _NO_MATCHReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/UriMatcher.html#match(android.net.Uri)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
        /// <returns><see cref="int"/></returns>
        public int Match(Android.Net.Uri arg0)
        {
            return IExecuteWithSignature<int>("match", "(Landroid/net/Uri;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/UriMatcher.html#addURI(java.lang.String,java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public void AddURI(Java.Lang.String arg0, Java.Lang.String arg1, int arg2)
        {
            IExecute("addURI", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}