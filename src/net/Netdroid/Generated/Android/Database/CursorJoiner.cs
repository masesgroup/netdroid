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

namespace Android.Database
{
    #region CursorJoiner
    public partial class CursorJoiner
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/CursorJoiner.html#%3Cinit%3E(android.database.Cursor,java.lang.String[],android.database.Cursor,java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Database.Cursor"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Android.Database.Cursor"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        public CursorJoiner(Android.Database.Cursor arg0, Java.Lang.String[] arg1, Android.Database.Cursor arg2, Java.Lang.String[] arg3)
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
        /// <see href="https://developer.android.com/reference/android/database/CursorJoiner.html#hasNext()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasNext()
        {
            return IExecuteWithSignature<bool>("hasNext", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/CursorJoiner.html#next()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        public object Next()
        {
            return IExecuteWithSignature("next", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/CursorJoiner.html#iterator()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Iterator"/></returns>
        public Java.Util.Iterator<Android.Database.CursorJoiner.Result> Iterator()
        {
            return IExecuteWithSignature<Java.Util.Iterator<Android.Database.CursorJoiner.Result>>("iterator", "()Ljava/util/Iterator;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/CursorJoiner.html#remove()"/>
        /// </summary>
        public void Remove()
        {
            IExecuteWithSignature("remove", "()V");
        }

        #endregion

        #region Nested classes
        #region Result
        public partial class Result
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/database/CursorJoiner.Result.html#BOTH"/>
            /// </summary>
            public static Android.Database.CursorJoiner.Result BOTH { get { if (!_BOTHReady) { _BOTHContent = SGetField<Android.Database.CursorJoiner.Result>(LocalBridgeClazz, "BOTH"); _BOTHReady = true; } return _BOTHContent; } }
            private static Android.Database.CursorJoiner.Result _BOTHContent = default;
            private static bool _BOTHReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/database/CursorJoiner.Result.html#LEFT"/>
            /// </summary>
            public static Android.Database.CursorJoiner.Result LEFT { get { if (!_LEFTReady) { _LEFTContent = SGetField<Android.Database.CursorJoiner.Result>(LocalBridgeClazz, "LEFT"); _LEFTReady = true; } return _LEFTContent; } }
            private static Android.Database.CursorJoiner.Result _LEFTContent = default;
            private static bool _LEFTReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/database/CursorJoiner.Result.html#RIGHT"/>
            /// </summary>
            public static Android.Database.CursorJoiner.Result RIGHT { get { if (!_RIGHTReady) { _RIGHTContent = SGetField<Android.Database.CursorJoiner.Result>(LocalBridgeClazz, "RIGHT"); _RIGHTReady = true; } return _RIGHTContent; } }
            private static Android.Database.CursorJoiner.Result _RIGHTContent = default;
            private static bool _RIGHTReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/database/CursorJoiner.Result.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Database.CursorJoiner.Result"/></returns>
            public static Android.Database.CursorJoiner.Result ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Android.Database.CursorJoiner.Result>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Landroid/database/CursorJoiner$Result;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/database/CursorJoiner.Result.html#values()"/>
            /// </summary>
            /// <returns><see cref="Android.Database.CursorJoiner.Result"/></returns>
            public static Android.Database.CursorJoiner.Result[] Values()
            {
                return SExecuteWithSignatureArray<Android.Database.CursorJoiner.Result>(LocalBridgeClazz, "values", "()[Landroid/database/CursorJoiner$Result;");
            }

            #endregion

            #region Instance methods

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