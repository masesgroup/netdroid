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

namespace Java.Io
{
    #region Reader
    public partial class Reader : Java.Lang.IReadable, Java.Io.ICloseable
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Io.Reader"/> to <see cref="Java.Lang.Readable"/>
        /// </summary>
        public static implicit operator Java.Lang.Readable(Java.Io.Reader t) => t.Cast<Java.Lang.Readable>();
        /// <summary>
        /// Converter from <see cref="Java.Io.Reader"/> to <see cref="Java.Io.Closeable"/>
        /// </summary>
        public static implicit operator Java.Io.Closeable(Java.Io.Reader t) => t.Cast<Java.Io.Closeable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/Reader.html#nullReader()"/>
        /// </summary>
        /// <returns><see cref="Java.Io.Reader"/></returns>
        public static Java.Io.Reader NullReader()
        {
            return SExecuteWithSignature<Java.Io.Reader>(LocalBridgeClazz, "nullReader", "()Ljava/io/Reader;");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/Reader.html#read(char[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int Read(char[] arg0, int arg1, int arg2)
        {
            return IExecute<int>("read", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/Reader.html#close()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/Reader.html#markSupported()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool MarkSupported()
        {
            return IExecuteWithSignature<bool>("markSupported", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/Reader.html#ready()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public bool Ready()
        {
            return IExecuteWithSignature<bool>("ready", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/Reader.html#read()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int Read()
        {
            return IExecuteWithSignature<int>("read", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/Reader.html#read(char[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int Read(char[] arg0)
        {
            return IExecuteWithSignature<int>("read", "([C)I", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/Reader.html#read(java.nio.CharBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.CharBuffer"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int Read(Java.Nio.CharBuffer arg0)
        {
            return IExecuteWithSignature<int>("read", "(Ljava/nio/CharBuffer;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/Reader.html#skip(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public long Skip(long arg0)
        {
            return IExecuteWithSignature<long>("skip", "(J)J", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/Reader.html#transferTo(java.io.Writer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.Writer"/></param>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public long TransferTo(Java.Io.Writer arg0)
        {
            return IExecuteWithSignature<long>("transferTo", "(Ljava/io/Writer;)J", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/Reader.html#mark(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void Mark(int arg0)
        {
            IExecuteWithSignature("mark", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/Reader.html#reset()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        public void Reset()
        {
            IExecuteWithSignature("reset", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}