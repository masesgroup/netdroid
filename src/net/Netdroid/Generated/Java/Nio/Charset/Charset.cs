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

namespace Java.Nio.Charset
{
    #region Charset
    public partial class Charset
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/charset/Charset.html#isSupported(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsSupported(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isSupported", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/charset/Charset.html#defaultCharset()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.Charset.Charset"/></returns>
        public static Java.Nio.Charset.Charset DefaultCharset()
        {
            return SExecuteWithSignature<Java.Nio.Charset.Charset>(LocalBridgeClazz, "defaultCharset", "()Ljava/nio/charset/Charset;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/charset/Charset.html#forName(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Nio.Charset.Charset"/></returns>
        public static Java.Nio.Charset.Charset ForName(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Nio.Charset.Charset>(LocalBridgeClazz, "forName", "(Ljava/lang/String;)Ljava/nio/charset/Charset;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/charset/Charset.html#availableCharsets()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.SortedMap"/></returns>
        public static Java.Util.SortedMap<Java.Lang.String, Java.Nio.Charset.Charset> AvailableCharsets()
        {
            return SExecuteWithSignature<Java.Util.SortedMap<Java.Lang.String, Java.Nio.Charset.Charset>>(LocalBridgeClazz, "availableCharsets", "()Ljava/util/SortedMap;");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/charset/Charset.html#contains(java.nio.charset.Charset)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.Charset.Charset"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Contains(Java.Nio.Charset.Charset arg0)
        {
            return IExecuteWithSignature<bool>("contains", "(Ljava/nio/charset/Charset;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/charset/Charset.html#newDecoder()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.Charset.CharsetDecoder"/></returns>
        public Java.Nio.Charset.CharsetDecoder NewDecoder()
        {
            return IExecuteWithSignature<Java.Nio.Charset.CharsetDecoder>("newDecoder", "()Ljava/nio/charset/CharsetDecoder;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/charset/Charset.html#newEncoder()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.Charset.CharsetEncoder"/></returns>
        public Java.Nio.Charset.CharsetEncoder NewEncoder()
        {
            return IExecuteWithSignature<Java.Nio.Charset.CharsetEncoder>("newEncoder", "()Ljava/nio/charset/CharsetEncoder;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/charset/Charset.html#canEncode()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool CanEncode()
        {
            return IExecuteWithSignature<bool>("canEncode", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/charset/Charset.html#isRegistered()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsRegistered()
        {
            return IExecuteWithSignature<bool>("isRegistered", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/charset/Charset.html#compareTo(java.nio.charset.Charset)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.Charset.Charset"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(Java.Nio.Charset.Charset arg0)
        {
            return IExecuteWithSignature<int>("compareTo", "(Ljava/nio/charset/Charset;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/charset/Charset.html#name()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String Name()
        {
            return IExecuteWithSignature<Java.Lang.String>("name", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/charset/Charset.html#encode(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Nio.ByteBuffer"/></returns>
        public Java.Nio.ByteBuffer Encode(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Nio.ByteBuffer>("encode", "(Ljava/lang/String;)Ljava/nio/ByteBuffer;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/charset/Charset.html#encode(java.nio.CharBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.CharBuffer"/></param>
        /// <returns><see cref="Java.Nio.ByteBuffer"/></returns>
        public Java.Nio.ByteBuffer Encode(Java.Nio.CharBuffer arg0)
        {
            return IExecuteWithSignature<Java.Nio.ByteBuffer>("encode", "(Ljava/nio/CharBuffer;)Ljava/nio/ByteBuffer;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/charset/Charset.html#decode(java.nio.ByteBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <returns><see cref="Java.Nio.CharBuffer"/></returns>
        public Java.Nio.CharBuffer Decode(Java.Nio.ByteBuffer arg0)
        {
            return IExecuteWithSignature<Java.Nio.CharBuffer>("decode", "(Ljava/nio/ByteBuffer;)Ljava/nio/CharBuffer;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/charset/Charset.html#aliases()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Java.Lang.String> Aliases()
        {
            return IExecuteWithSignature<Java.Util.Set<Java.Lang.String>>("aliases", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/charset/Charset.html#compareTo(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(object arg0)
        {
            return IExecuteWithSignature<int>("compareTo", "(Ljava/lang/Object;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/charset/Charset.html#displayName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String DisplayName()
        {
            return IExecuteWithSignature<Java.Lang.String>("displayName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/charset/Charset.html#displayName(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String DisplayName(Java.Util.Locale arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("displayName", "(Ljava/util/Locale;)Ljava/lang/String;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}