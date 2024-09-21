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
*  This file is generated by MASES.JNetReflector (ver. 2.5.9.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Io
{
    #region PrintStream declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/java/io/PrintStream.html"/>
    /// </summary>
    public partial class PrintStream : Java.Io.FilterOutputStream
    {
        const string _bridgeClassName = "java.io.PrintStream";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public PrintStream() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public PrintStream(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region PrintStream implementation
    public partial class PrintStream : Java.Lang.IAppendable, Java.Io.ICloseable
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/PrintStream.html#%3Cinit%3E(java.io.File,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Io.FileNotFoundException"/>
        /// <exception cref="Java.Io.UnsupportedEncodingException"/>
        public PrintStream(Java.Io.File arg0, Java.Lang.String arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/PrintStream.html#%3Cinit%3E(java.io.File,java.nio.charset.Charset)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <param name="arg1"><see cref="Java.Nio.Charset.Charset"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public PrintStream(Java.Io.File arg0, Java.Nio.Charset.Charset arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/PrintStream.html#%3Cinit%3E(java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <exception cref="Java.Io.FileNotFoundException"/>
        public PrintStream(Java.Io.File arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/PrintStream.html#%3Cinit%3E(java.io.OutputStream,boolean,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.OutputStream"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Io.UnsupportedEncodingException"/>
        public PrintStream(Java.Io.OutputStream arg0, bool arg1, Java.Lang.String arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/PrintStream.html#%3Cinit%3E(java.io.OutputStream,boolean,java.nio.charset.Charset)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.OutputStream"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <param name="arg2"><see cref="Java.Nio.Charset.Charset"/></param>
        public PrintStream(Java.Io.OutputStream arg0, bool arg1, Java.Nio.Charset.Charset arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/PrintStream.html#%3Cinit%3E(java.io.OutputStream,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.OutputStream"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public PrintStream(Java.Io.OutputStream arg0, bool arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/PrintStream.html#%3Cinit%3E(java.io.OutputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.OutputStream"/></param>
        public PrintStream(Java.Io.OutputStream arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/PrintStream.html#%3Cinit%3E(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Io.FileNotFoundException"/>
        /// <exception cref="Java.Io.UnsupportedEncodingException"/>
        public PrintStream(Java.Lang.String arg0, Java.Lang.String arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/PrintStream.html#%3Cinit%3E(java.lang.String,java.nio.charset.Charset)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Nio.Charset.Charset"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public PrintStream(Java.Lang.String arg0, Java.Nio.Charset.Charset arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/PrintStream.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Io.FileNotFoundException"/>
        public PrintStream(Java.Lang.String arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Io.PrintStream"/> to <see cref="Java.Lang.Appendable"/>
        /// </summary>
        public static implicit operator Java.Lang.Appendable(Java.Io.PrintStream t) => t.Cast<Java.Lang.Appendable>();
        /// <summary>
        /// Converter from <see cref="Java.Io.PrintStream"/> to <see cref="Java.Io.Closeable"/>
        /// </summary>
        public static implicit operator Java.Io.Closeable(Java.Io.PrintStream t) => t.Cast<Java.Io.Closeable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/PrintStream.html#checkError()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool CheckError()
        {
            return IExecuteWithSignature<bool>("checkError", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/PrintStream.html#format(java.lang.String,java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="Java.Io.PrintStream"/></returns>
        public Java.Io.PrintStream Format(Java.Lang.String arg0, params object[] arg1)
        {
            if (arg1.Length == 0) return IExecute<Java.Io.PrintStream>("format", arg0); else return IExecute<Java.Io.PrintStream>("format", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/PrintStream.html#format(java.util.Locale,java.lang.String,java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <returns><see cref="Java.Io.PrintStream"/></returns>
        public Java.Io.PrintStream Format(Java.Util.Locale arg0, Java.Lang.String arg1, params object[] arg2)
        {
            if (arg2.Length == 0) return IExecute<Java.Io.PrintStream>("format", arg0, arg1); else return IExecute<Java.Io.PrintStream>("format", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/PrintStream.html#printf(java.lang.String,java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="Java.Io.PrintStream"/></returns>
        public Java.Io.PrintStream Printf(Java.Lang.String arg0, params object[] arg1)
        {
            if (arg1.Length == 0) return IExecute<Java.Io.PrintStream>("printf", arg0); else return IExecute<Java.Io.PrintStream>("printf", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/PrintStream.html#printf(java.util.Locale,java.lang.String,java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <returns><see cref="Java.Io.PrintStream"/></returns>
        public Java.Io.PrintStream Printf(Java.Util.Locale arg0, Java.Lang.String arg1, params object[] arg2)
        {
            if (arg2.Length == 0) return IExecute<Java.Io.PrintStream>("printf", arg0, arg1); else return IExecute<Java.Io.PrintStream>("printf", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/PrintStream.html#append(char)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <returns><see cref="Java.Lang.Appendable"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Lang.Appendable Append(char arg0)
        {
            return IExecuteWithSignature<Java.Lang.Appendable>("append", "(C)Ljava/lang/Appendable;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/PrintStream.html#append(java.lang.CharSequence,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.Appendable"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Lang.Appendable Append(Java.Lang.CharSequence arg0, int arg1, int arg2)
        {
            return IExecute<Java.Lang.Appendable>("append", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/PrintStream.html#append(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="Java.Lang.Appendable"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Lang.Appendable Append(Java.Lang.CharSequence arg0)
        {
            return IExecuteWithSignature<Java.Lang.Appendable>("append", "(Ljava/lang/CharSequence;)Ljava/lang/Appendable;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/PrintStream.html#print(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void Print(bool arg0)
        {
            IExecuteWithSignature("print", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/PrintStream.html#print(char)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        public void Print(char arg0)
        {
            IExecuteWithSignature("print", "(C)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/PrintStream.html#print(char[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        public void Print(char[] arg0)
        {
            IExecuteWithSignature("print", "([C)V", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/PrintStream.html#print(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        public void Print(double arg0)
        {
            IExecuteWithSignature("print", "(D)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/PrintStream.html#print(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        public void Print(float arg0)
        {
            IExecuteWithSignature("print", "(F)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/PrintStream.html#print(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void Print(int arg0)
        {
            IExecuteWithSignature("print", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/PrintStream.html#print(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public void Print(object arg0)
        {
            IExecuteWithSignature("print", "(Ljava/lang/Object;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/PrintStream.html#print(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void Print(Java.Lang.String arg0)
        {
            IExecuteWithSignature("print", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/PrintStream.html#print(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public void Print(long arg0)
        {
            IExecuteWithSignature("print", "(J)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/PrintStream.html#println()"/>
        /// </summary>
        public void Println()
        {
            IExecuteWithSignature("println", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/PrintStream.html#println(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void Println(bool arg0)
        {
            IExecuteWithSignature("println", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/PrintStream.html#println(char)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        public void Println(char arg0)
        {
            IExecuteWithSignature("println", "(C)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/PrintStream.html#println(char[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        public void Println(char[] arg0)
        {
            IExecuteWithSignature("println", "([C)V", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/PrintStream.html#println(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        public void Println(double arg0)
        {
            IExecuteWithSignature("println", "(D)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/PrintStream.html#println(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        public void Println(float arg0)
        {
            IExecuteWithSignature("println", "(F)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/PrintStream.html#println(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void Println(int arg0)
        {
            IExecuteWithSignature("println", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/PrintStream.html#println(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public void Println(object arg0)
        {
            IExecuteWithSignature("println", "(Ljava/lang/Object;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/PrintStream.html#println(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void Println(Java.Lang.String arg0)
        {
            IExecuteWithSignature("println", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/PrintStream.html#println(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public void Println(long arg0)
        {
            IExecuteWithSignature("println", "(J)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/PrintStream.html#writeBytes(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        public void WriteBytes(byte[] arg0)
        {
            IExecuteWithSignature("writeBytes", "([B)V", new object[] { arg0 });
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}