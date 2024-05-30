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
    #region Console
    public partial class Console
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
        /// <see href="https://developer.android.com/reference/java.base/java/io/Console.html#readPassword()"/>
        /// </summary>
        /// <returns><see cref="char"/></returns>
        public char[] ReadPassword()
        {
            return IExecuteWithSignatureArray<char>("readPassword", "()[C");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/io/Console.html#readPassword(java.lang.String,java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="char"/></returns>
        public char[] ReadPassword(Java.Lang.String arg0, params object[] arg1)
        {
            if (arg1.Length == 0) return IExecuteArray<char>("readPassword", arg0); else return IExecuteArray<char>("readPassword", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/io/Console.html#format(java.lang.String,java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="Java.Io.Console"/></returns>
        public Java.Io.Console Format(Java.Lang.String arg0, params object[] arg1)
        {
            if (arg1.Length == 0) return IExecute<Java.Io.Console>("format", arg0); else return IExecute<Java.Io.Console>("format", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/io/Console.html#printf(java.lang.String,java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="Java.Io.Console"/></returns>
        public Java.Io.Console Printf(Java.Lang.String arg0, params object[] arg1)
        {
            if (arg1.Length == 0) return IExecute<Java.Io.Console>("printf", arg0); else return IExecute<Java.Io.Console>("printf", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/io/Console.html#writer()"/>
        /// </summary>
        /// <returns><see cref="Java.Io.PrintWriter"/></returns>
        public Java.Io.PrintWriter Writer()
        {
            return IExecuteWithSignature<Java.Io.PrintWriter>("writer", "()Ljava/io/PrintWriter;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/io/Console.html#reader()"/>
        /// </summary>
        /// <returns><see cref="Java.Io.Reader"/></returns>
        public Java.Io.Reader Reader()
        {
            return IExecuteWithSignature<Java.Io.Reader>("reader", "()Ljava/io/Reader;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/io/Console.html#readLine()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String ReadLine()
        {
            return IExecuteWithSignature<Java.Lang.String>("readLine", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/io/Console.html#readLine(java.lang.String,java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String ReadLine(Java.Lang.String arg0, params object[] arg1)
        {
            if (arg1.Length == 0) return IExecute<Java.Lang.String>("readLine", arg0); else return IExecute<Java.Lang.String>("readLine", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/io/Console.html#charset()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.Charset.Charset"/></returns>
        public Java.Nio.Charset.Charset Charset()
        {
            return IExecuteWithSignature<Java.Nio.Charset.Charset>("charset", "()Ljava/nio/charset/Charset;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/io/Console.html#flush()"/>
        /// </summary>
        public void Flush()
        {
            IExecuteWithSignature("flush", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}