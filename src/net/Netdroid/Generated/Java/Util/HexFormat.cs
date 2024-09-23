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

namespace Java.Util
{
    #region HexFormat declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/java/util/HexFormat.html"/>
    /// </summary>
    public partial class HexFormat : MASES.JCOBridge.C2JBridge.JVMBridgeBase<HexFormat>
    {
        const string _bridgeClassName = "java.util.HexFormat";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public HexFormat() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public HexFormat(params object[] args) : base(args) { }
    
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

    #region HexFormat implementation
    public partial class HexFormat
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/HexFormat.html#isHexDigit(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsHexDigit(int arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isHexDigit", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/HexFormat.html#fromHexDigit(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int FromHexDigit(int arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "fromHexDigit", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/HexFormat.html#fromHexDigits(java.lang.CharSequence,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int FromHexDigits(Java.Lang.CharSequence arg0, int arg1, int arg2)
        {
            return SExecute<int>(LocalBridgeClazz, "fromHexDigits", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/HexFormat.html#fromHexDigits(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="int"/></returns>
        public static int FromHexDigits(Java.Lang.CharSequence arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "fromHexDigits", "(Ljava/lang/CharSequence;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/HexFormat.html#of()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.HexFormat"/></returns>
        public static Java.Util.HexFormat Of()
        {
            return SExecuteWithSignature<Java.Util.HexFormat>(LocalBridgeClazz, "of", "()Ljava/util/HexFormat;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/HexFormat.html#ofDelimiter(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.HexFormat"/></returns>
        public static Java.Util.HexFormat OfDelimiter(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Util.HexFormat>(LocalBridgeClazz, "ofDelimiter", "(Ljava/lang/String;)Ljava/util/HexFormat;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/HexFormat.html#fromHexDigitsToLong(java.lang.CharSequence,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="long"/></returns>
        public static long FromHexDigitsToLong(Java.Lang.CharSequence arg0, int arg1, int arg2)
        {
            return SExecute<long>(LocalBridgeClazz, "fromHexDigitsToLong", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/HexFormat.html#fromHexDigitsToLong(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="long"/></returns>
        public static long FromHexDigitsToLong(Java.Lang.CharSequence arg0)
        {
            return SExecuteWithSignature<long>(LocalBridgeClazz, "fromHexDigitsToLong", "(Ljava/lang/CharSequence;)J", arg0);
        }
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/HexFormat.html#formatHex(java.lang.Appendable,byte[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="A"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <typeparam name="A"><see cref="Java.Lang.IAppendable"/></typeparam>
        /// <returns><typeparamref name="A"/></returns>
        public A FormatHex<A>(A arg0, byte[] arg1, int arg2, int arg3) where A : Java.Lang.IAppendable, new()
        {
            return IExecute<A>("formatHex", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/HexFormat.html#formatHex(java.lang.Appendable,byte[])"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="A"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <typeparam name="A"><see cref="Java.Lang.IAppendable"/></typeparam>
        /// <returns><typeparamref name="A"/></returns>
        public A FormatHex<A>(A arg0, byte[] arg1) where A : Java.Lang.IAppendable, new()
        {
            return IExecute<A>("formatHex", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/HexFormat.html#toHexDigits(java.lang.Appendable,byte)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="A"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <typeparam name="A"><see cref="Java.Lang.IAppendable"/></typeparam>
        /// <returns><typeparamref name="A"/></returns>
        public A ToHexDigits<A>(A arg0, byte arg1) where A : Java.Lang.IAppendable, new()
        {
            return IExecute<A>("toHexDigits", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/HexFormat.html#isUpperCase()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsUpperCase()
        {
            return IExecuteWithSignature<bool>("isUpperCase", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/HexFormat.html#parseHex(char[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="byte"/></returns>
        public byte[] ParseHex(char[] arg0, int arg1, int arg2)
        {
            return IExecuteArray<byte>("parseHex", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/HexFormat.html#parseHex(java.lang.CharSequence,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="byte"/></returns>
        public byte[] ParseHex(Java.Lang.CharSequence arg0, int arg1, int arg2)
        {
            return IExecuteArray<byte>("parseHex", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/HexFormat.html#parseHex(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="byte"/></returns>
        public byte[] ParseHex(Java.Lang.CharSequence arg0)
        {
            return IExecuteWithSignatureArray<byte>("parseHex", "(Ljava/lang/CharSequence;)[B", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/HexFormat.html#toHighHexDigit(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="char"/></returns>
        public char ToHighHexDigit(int arg0)
        {
            return IExecuteWithSignature<char>("toHighHexDigit", "(I)C", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/HexFormat.html#toLowHexDigit(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="char"/></returns>
        public char ToLowHexDigit(int arg0)
        {
            return IExecuteWithSignature<char>("toLowHexDigit", "(I)C", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/HexFormat.html#delimiter()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String Delimiter()
        {
            return IExecuteWithSignature<Java.Lang.String>("delimiter", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/HexFormat.html#formatHex(byte[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String FormatHex(byte[] arg0, int arg1, int arg2)
        {
            return IExecute<Java.Lang.String>("formatHex", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/HexFormat.html#formatHex(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String FormatHex(byte[] arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("formatHex", "([B)Ljava/lang/String;", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/HexFormat.html#prefix()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String Prefix()
        {
            return IExecuteWithSignature<Java.Lang.String>("prefix", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/HexFormat.html#suffix()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String Suffix()
        {
            return IExecuteWithSignature<Java.Lang.String>("suffix", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/HexFormat.html#toHexDigits(byte)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String ToHexDigits(byte arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("toHexDigits", "(B)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/HexFormat.html#toHexDigits(char)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String ToHexDigits(char arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("toHexDigits", "(C)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/HexFormat.html#toHexDigits(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String ToHexDigits(int arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("toHexDigits", "(I)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/HexFormat.html#toHexDigits(long,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String ToHexDigits(long arg0, int arg1)
        {
            return IExecute<Java.Lang.String>("toHexDigits", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/HexFormat.html#toHexDigits(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String ToHexDigits(long arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("toHexDigits", "(J)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/HexFormat.html#toHexDigits(short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String ToHexDigits(short arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("toHexDigits", "(S)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/HexFormat.html#withDelimiter(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.HexFormat"/></returns>
        public Java.Util.HexFormat WithDelimiter(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Util.HexFormat>("withDelimiter", "(Ljava/lang/String;)Ljava/util/HexFormat;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/HexFormat.html#withLowerCase()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.HexFormat"/></returns>
        public Java.Util.HexFormat WithLowerCase()
        {
            return IExecuteWithSignature<Java.Util.HexFormat>("withLowerCase", "()Ljava/util/HexFormat;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/HexFormat.html#withPrefix(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.HexFormat"/></returns>
        public Java.Util.HexFormat WithPrefix(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Util.HexFormat>("withPrefix", "(Ljava/lang/String;)Ljava/util/HexFormat;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/HexFormat.html#withSuffix(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.HexFormat"/></returns>
        public Java.Util.HexFormat WithSuffix(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Util.HexFormat>("withSuffix", "(Ljava/lang/String;)Ljava/util/HexFormat;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/HexFormat.html#withUpperCase()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.HexFormat"/></returns>
        public Java.Util.HexFormat WithUpperCase()
        {
            return IExecuteWithSignature<Java.Util.HexFormat>("withUpperCase", "()Ljava/util/HexFormat;");
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}