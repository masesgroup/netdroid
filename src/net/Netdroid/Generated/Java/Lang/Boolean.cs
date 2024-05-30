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
    #region Boolean
    public partial class Boolean : Java.Io.ISerializable, Java.Lang.IComparable<Java.Lang.Boolean>, Java.Lang.Constant.IConstable
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Lang.Boolean"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Lang.Boolean t) => t.Cast<Java.Io.Serializable>();
        /// <summary>
        /// Converter from <see cref="Java.Lang.Boolean"/> to <see cref="Java.Lang.Comparable"/>
        /// </summary>
        public static implicit operator Java.Lang.Comparable(Java.Lang.Boolean t) => t.Cast<Java.Lang.Comparable>();
        /// <summary>
        /// Converter from <see cref="Java.Lang.Boolean"/> to <see cref="Java.Lang.Constant.Constable"/>
        /// </summary>
        public static implicit operator Java.Lang.Constant.Constable(Java.Lang.Boolean t) => t.Cast<Java.Lang.Constant.Constable>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/Boolean.html#FALSE"/>
        /// </summary>
        public static Java.Lang.Boolean FALSE { get { if (!_FALSEReady) { _FALSEContent = SGetField<Java.Lang.Boolean>(LocalBridgeClazz, "FALSE"); _FALSEReady = true; } return _FALSEContent; } }
        private static Java.Lang.Boolean _FALSEContent = default;
        private static bool _FALSEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/Boolean.html#TRUE"/>
        /// </summary>
        public static Java.Lang.Boolean TRUE { get { if (!_TRUEReady) { _TRUEContent = SGetField<Java.Lang.Boolean>(LocalBridgeClazz, "TRUE"); _TRUEReady = true; } return _TRUEContent; } }
        private static Java.Lang.Boolean _TRUEContent = default;
        private static bool _TRUEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/Boolean.html#TYPE"/>
        /// </summary>
        public static Java.Lang.Class TYPE { get { if (!_TYPEReady) { _TYPEContent = SGetField<Java.Lang.Class>(LocalBridgeClazz, "TYPE"); _TYPEReady = true; } return _TYPEContent; } }
        private static Java.Lang.Class _TYPEContent = default;
        private static bool _TYPEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/Boolean.html#getBoolean(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool GetBoolean(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "getBoolean", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/Boolean.html#logicalAnd(boolean,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool LogicalAnd(bool arg0, bool arg1)
        {
            return SExecute<bool>(LocalBridgeClazz, "logicalAnd", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/Boolean.html#logicalOr(boolean,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool LogicalOr(bool arg0, bool arg1)
        {
            return SExecute<bool>(LocalBridgeClazz, "logicalOr", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/Boolean.html#logicalXor(boolean,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool LogicalXor(bool arg0, bool arg1)
        {
            return SExecute<bool>(LocalBridgeClazz, "logicalXor", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/Boolean.html#parseBoolean(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool ParseBoolean(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "parseBoolean", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/Boolean.html#compare(boolean,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="int"/></returns>
        public static int Compare(bool arg0, bool arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "compare", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/Boolean.html#hashCode(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="int"/></returns>
        public static int HashCode(bool arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "hashCode", "(Z)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/Boolean.html#valueOf(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="Java.Lang.Boolean"/></returns>
        public static Java.Lang.Boolean ValueOf(bool arg0)
        {
            return SExecuteWithSignature<Java.Lang.Boolean>(LocalBridgeClazz, "valueOf", "(Z)Ljava/lang/Boolean;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/Boolean.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.Boolean"/></returns>
        public static Java.Lang.Boolean ValueOf(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Lang.Boolean>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Ljava/lang/Boolean;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/Boolean.html#toString(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String ToString(bool arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "toString", "(Z)Ljava/lang/String;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/Boolean.html#booleanValue()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool BooleanValue()
        {
            return IExecuteWithSignature<bool>("booleanValue", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/Boolean.html#compareTo(java.lang.Boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Boolean"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(Java.Lang.Boolean arg0)
        {
            return IExecuteWithSignature<int>("compareTo", "(Ljava/lang/Boolean;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/Boolean.html#compareTo(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(object arg0)
        {
            return IExecuteWithSignature<int>("compareTo", "(Ljava/lang/Object;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/Boolean.html#describeConstable()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Optional"/></returns>
        public Java.Util.Optional<Java.Lang.Constant.DynamicConstantDesc<Java.Lang.Boolean>> DescribeConstable()
        {
            return IExecuteWithSignature<Java.Util.Optional<Java.Lang.Constant.DynamicConstantDesc<Java.Lang.Boolean>>>("describeConstable", "()Ljava/util/Optional;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}