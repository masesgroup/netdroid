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

namespace Java.Lang
{
    #region Process
    public partial class Process
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
        /// <see href="https://developer.android.com/reference/java/lang/Process.html#exitValue()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int ExitValue()
        {
            return IExecuteWithSignature<int>("exitValue", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/Process.html#waitFor()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public int WaitFor()
        {
            return IExecuteWithSignature<int>("waitFor", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/Process.html#getErrorStream()"/>
        /// </summary>
        /// <returns><see cref="Java.Io.InputStream"/></returns>
        public Java.Io.InputStream GetErrorStream()
        {
            return IExecuteWithSignature<Java.Io.InputStream>("getErrorStream", "()Ljava/io/InputStream;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/Process.html#getInputStream()"/>
        /// </summary>
        /// <returns><see cref="Java.Io.InputStream"/></returns>
        public Java.Io.InputStream GetInputStream()
        {
            return IExecuteWithSignature<Java.Io.InputStream>("getInputStream", "()Ljava/io/InputStream;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/Process.html#getOutputStream()"/>
        /// </summary>
        /// <returns><see cref="Java.Io.OutputStream"/></returns>
        public Java.Io.OutputStream GetOutputStream()
        {
            return IExecuteWithSignature<Java.Io.OutputStream>("getOutputStream", "()Ljava/io/OutputStream;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/Process.html#destroy()"/>
        /// </summary>
        public void Destroy()
        {
            IExecuteWithSignature("destroy", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/Process.html#isAlive()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsAlive()
        {
            return IExecuteWithSignature<bool>("isAlive", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/Process.html#supportsNormalTermination()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool SupportsNormalTermination()
        {
            return IExecuteWithSignature<bool>("supportsNormalTermination", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/Process.html#waitFor(long,java.util.concurrent.TimeUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public bool WaitFor(long arg0, Java.Util.Concurrent.TimeUnit arg1)
        {
            return IExecute<bool>("waitFor", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/Process.html#errorReader()"/>
        /// </summary>
        /// <returns><see cref="Java.Io.BufferedReader"/></returns>
        public Java.Io.BufferedReader ErrorReader()
        {
            return IExecuteWithSignature<Java.Io.BufferedReader>("errorReader", "()Ljava/io/BufferedReader;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/Process.html#errorReader(java.nio.charset.Charset)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.Charset.Charset"/></param>
        /// <returns><see cref="Java.Io.BufferedReader"/></returns>
        public Java.Io.BufferedReader ErrorReader(Java.Nio.Charset.Charset arg0)
        {
            return IExecuteWithSignature<Java.Io.BufferedReader>("errorReader", "(Ljava/nio/charset/Charset;)Ljava/io/BufferedReader;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/Process.html#inputReader()"/>
        /// </summary>
        /// <returns><see cref="Java.Io.BufferedReader"/></returns>
        public Java.Io.BufferedReader InputReader()
        {
            return IExecuteWithSignature<Java.Io.BufferedReader>("inputReader", "()Ljava/io/BufferedReader;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/Process.html#inputReader(java.nio.charset.Charset)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.Charset.Charset"/></param>
        /// <returns><see cref="Java.Io.BufferedReader"/></returns>
        public Java.Io.BufferedReader InputReader(Java.Nio.Charset.Charset arg0)
        {
            return IExecuteWithSignature<Java.Io.BufferedReader>("inputReader", "(Ljava/nio/charset/Charset;)Ljava/io/BufferedReader;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/Process.html#outputWriter()"/>
        /// </summary>
        /// <returns><see cref="Java.Io.BufferedWriter"/></returns>
        public Java.Io.BufferedWriter OutputWriter()
        {
            return IExecuteWithSignature<Java.Io.BufferedWriter>("outputWriter", "()Ljava/io/BufferedWriter;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/Process.html#outputWriter(java.nio.charset.Charset)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.Charset.Charset"/></param>
        /// <returns><see cref="Java.Io.BufferedWriter"/></returns>
        public Java.Io.BufferedWriter OutputWriter(Java.Nio.Charset.Charset arg0)
        {
            return IExecuteWithSignature<Java.Io.BufferedWriter>("outputWriter", "(Ljava/nio/charset/Charset;)Ljava/io/BufferedWriter;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/Process.html#destroyForcibly()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.Process"/></returns>
        public Java.Lang.Process DestroyForcibly()
        {
            return IExecuteWithSignature<Java.Lang.Process>("destroyForcibly", "()Ljava/lang/Process;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/Process.html#onExit()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Concurrent.CompletableFuture"/></returns>
        public Java.Util.Concurrent.CompletableFuture<Java.Lang.Process> OnExit()
        {
            return IExecuteWithSignature<Java.Util.Concurrent.CompletableFuture<Java.Lang.Process>>("onExit", "()Ljava/util/concurrent/CompletableFuture;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/Process.html#pid()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long Pid()
        {
            return IExecuteWithSignature<long>("pid", "()J");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}