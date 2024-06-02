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

namespace Java.Io
{
    #region OutputStream
    public partial class OutputStream : Java.Io.ICloseable, Java.Io.IFlushable
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Io.OutputStream"/> to <see cref="Java.Io.Closeable"/>
        /// </summary>
        public static implicit operator Java.Io.Closeable(Java.Io.OutputStream t) => t.Cast<Java.Io.Closeable>();
        /// <summary>
        /// Converter from <see cref="Java.Io.OutputStream"/> to <see cref="Java.Io.Flushable"/>
        /// </summary>
        public static implicit operator Java.Io.Flushable(Java.Io.OutputStream t) => t.Cast<Java.Io.Flushable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/OutputStream.html#nullOutputStream()"/>
        /// </summary>
        /// <returns><see cref="Java.Io.OutputStream"/></returns>
        public static Java.Io.OutputStream NullOutputStream()
        {
            return SExecuteWithSignature<Java.Io.OutputStream>(LocalBridgeClazz, "nullOutputStream", "()Ljava/io/OutputStream;");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/OutputStream.html#write(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void Write(int arg0)
        {
            IExecuteWithSignature("write", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/OutputStream.html#close()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/OutputStream.html#flush()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        public void Flush()
        {
            IExecuteWithSignature("flush", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/OutputStream.html#write(byte[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void Write(byte[] arg0, int arg1, int arg2)
        {
            IExecute("write", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/OutputStream.html#write(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void Write(byte[] arg0)
        {
            IExecuteWithSignature("write", "([B)V", new object[] { arg0 });
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}