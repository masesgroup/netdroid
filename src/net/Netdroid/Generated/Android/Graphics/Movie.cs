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

namespace Android.Graphics
{
    #region Movie
    public partial class Movie
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Movie.html#decodeFile(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Graphics.Movie"/></returns>
        [global::System.Obsolete()]
        public static Android.Graphics.Movie DecodeFile(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Android.Graphics.Movie>(LocalBridgeClazz, "decodeFile", "(Ljava/lang/String;)Landroid/graphics/Movie;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Movie.html#decodeStream(java.io.InputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <returns><see cref="Android.Graphics.Movie"/></returns>
        [global::System.Obsolete()]
        public static Android.Graphics.Movie DecodeStream(Java.Io.InputStream arg0)
        {
            return SExecuteWithSignature<Android.Graphics.Movie>(LocalBridgeClazz, "decodeStream", "(Ljava/io/InputStream;)Landroid/graphics/Movie;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Movie.html#decodeByteArray(byte[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Android.Graphics.Movie"/></returns>
        [global::System.Obsolete()]
        public static Android.Graphics.Movie DecodeByteArray(byte[] arg0, int arg1, int arg2)
        {
            return SExecute<Android.Graphics.Movie>(LocalBridgeClazz, "decodeByteArray", arg0, arg1, arg2);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Movie.html#isOpaque()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool IsOpaque()
        {
            return IExecuteWithSignature<bool>("isOpaque", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Movie.html#setTime(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool SetTime(int arg0)
        {
            return IExecuteWithSignature<bool>("setTime", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Movie.html#duration()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int Duration()
        {
            return IExecuteWithSignature<int>("duration", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Movie.html#height()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int Height()
        {
            return IExecuteWithSignature<int>("height", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Movie.html#width()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int Width()
        {
            return IExecuteWithSignature<int>("width", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Movie.html#draw(android.graphics.Canvas,float,float,android.graphics.Paint)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Canvas"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="Android.Graphics.Paint"/></param>
        [global::System.Obsolete()]
        public void Draw(Android.Graphics.Canvas arg0, float arg1, float arg2, Android.Graphics.Paint arg3)
        {
            IExecute("draw", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Movie.html#draw(android.graphics.Canvas,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Canvas"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        [global::System.Obsolete()]
        public void Draw(Android.Graphics.Canvas arg0, float arg1, float arg2)
        {
            IExecute("draw", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}