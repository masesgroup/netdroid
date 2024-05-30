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
    #region Float
    public partial class Float : Java.Lang.IComparable<Java.Lang.Float>, Java.Lang.Constant.IConstable, Java.Lang.Constant.IConstantDesc
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Lang.Float"/> to <see cref="Java.Lang.Comparable"/>
        /// </summary>
        public static implicit operator Java.Lang.Comparable(Java.Lang.Float t) => t.Cast<Java.Lang.Comparable>();
        /// <summary>
        /// Converter from <see cref="Java.Lang.Float"/> to <see cref="Java.Lang.Constant.Constable"/>
        /// </summary>
        public static implicit operator Java.Lang.Constant.Constable(Java.Lang.Float t) => t.Cast<Java.Lang.Constant.Constable>();
        /// <summary>
        /// Converter from <see cref="Java.Lang.Float"/> to <see cref="Java.Lang.Constant.ConstantDesc"/>
        /// </summary>
        public static implicit operator Java.Lang.Constant.ConstantDesc(Java.Lang.Float t) => t.Cast<Java.Lang.Constant.ConstantDesc>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/Float.html#MAX_VALUE"/>
        /// </summary>
        public static float MAX_VALUE { get { if (!_MAX_VALUEReady) { _MAX_VALUEContent = SGetField<float>(LocalBridgeClazz, "MAX_VALUE"); _MAX_VALUEReady = true; } return _MAX_VALUEContent; } }
        private static float _MAX_VALUEContent = default;
        private static bool _MAX_VALUEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/Float.html#MIN_NORMAL"/>
        /// </summary>
        public static float MIN_NORMAL { get { if (!_MIN_NORMALReady) { _MIN_NORMALContent = SGetField<float>(LocalBridgeClazz, "MIN_NORMAL"); _MIN_NORMALReady = true; } return _MIN_NORMALContent; } }
        private static float _MIN_NORMALContent = default;
        private static bool _MIN_NORMALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/Float.html#MIN_VALUE"/>
        /// </summary>
        public static float MIN_VALUE { get { if (!_MIN_VALUEReady) { _MIN_VALUEContent = SGetField<float>(LocalBridgeClazz, "MIN_VALUE"); _MIN_VALUEReady = true; } return _MIN_VALUEContent; } }
        private static float _MIN_VALUEContent = default;
        private static bool _MIN_VALUEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/Float.html#NaN"/>
        /// </summary>
        public static float NaN { get { if (!_NaNReady) { _NaNContent = SGetField<float>(LocalBridgeClazz, "NaN"); _NaNReady = true; } return _NaNContent; } }
        private static float _NaNContent = default;
        private static bool _NaNReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/Float.html#NEGATIVE_INFINITY"/>
        /// </summary>
        public static float NEGATIVE_INFINITY { get { if (!_NEGATIVE_INFINITYReady) { _NEGATIVE_INFINITYContent = SGetField<float>(LocalBridgeClazz, "NEGATIVE_INFINITY"); _NEGATIVE_INFINITYReady = true; } return _NEGATIVE_INFINITYContent; } }
        private static float _NEGATIVE_INFINITYContent = default;
        private static bool _NEGATIVE_INFINITYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/Float.html#POSITIVE_INFINITY"/>
        /// </summary>
        public static float POSITIVE_INFINITY { get { if (!_POSITIVE_INFINITYReady) { _POSITIVE_INFINITYContent = SGetField<float>(LocalBridgeClazz, "POSITIVE_INFINITY"); _POSITIVE_INFINITYReady = true; } return _POSITIVE_INFINITYContent; } }
        private static float _POSITIVE_INFINITYContent = default;
        private static bool _POSITIVE_INFINITYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/Float.html#BYTES"/>
        /// </summary>
        public static int BYTES { get { if (!_BYTESReady) { _BYTESContent = SGetField<int>(LocalBridgeClazz, "BYTES"); _BYTESReady = true; } return _BYTESContent; } }
        private static int _BYTESContent = default;
        private static bool _BYTESReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/Float.html#MAX_EXPONENT"/>
        /// </summary>
        public static int MAX_EXPONENT { get { if (!_MAX_EXPONENTReady) { _MAX_EXPONENTContent = SGetField<int>(LocalBridgeClazz, "MAX_EXPONENT"); _MAX_EXPONENTReady = true; } return _MAX_EXPONENTContent; } }
        private static int _MAX_EXPONENTContent = default;
        private static bool _MAX_EXPONENTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/Float.html#MIN_EXPONENT"/>
        /// </summary>
        public static int MIN_EXPONENT { get { if (!_MIN_EXPONENTReady) { _MIN_EXPONENTContent = SGetField<int>(LocalBridgeClazz, "MIN_EXPONENT"); _MIN_EXPONENTReady = true; } return _MIN_EXPONENTContent; } }
        private static int _MIN_EXPONENTContent = default;
        private static bool _MIN_EXPONENTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/Float.html#SIZE"/>
        /// </summary>
        public static int SIZE { get { if (!_SIZEReady) { _SIZEContent = SGetField<int>(LocalBridgeClazz, "SIZE"); _SIZEReady = true; } return _SIZEContent; } }
        private static int _SIZEContent = default;
        private static bool _SIZEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/Float.html#TYPE"/>
        /// </summary>
        public static Java.Lang.Class TYPE { get { if (!_TYPEReady) { _TYPEContent = SGetField<Java.Lang.Class>(LocalBridgeClazz, "TYPE"); _TYPEReady = true; } return _TYPEContent; } }
        private static Java.Lang.Class _TYPEContent = default;
        private static bool _TYPEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/Float.html#isFinite(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsFinite(float arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isFinite", "(F)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/Float.html#isInfinite(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsInfinite(float arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isInfinite", "(F)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/Float.html#isNaN(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsNaN(float arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isNaN", "(F)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/Float.html#max(float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <returns><see cref="float"/></returns>
        public static float Max(float arg0, float arg1)
        {
            return SExecute<float>(LocalBridgeClazz, "max", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/Float.html#min(float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <returns><see cref="float"/></returns>
        public static float Min(float arg0, float arg1)
        {
            return SExecute<float>(LocalBridgeClazz, "min", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/Float.html#parseFloat(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="float"/></returns>
        /// <exception cref="Java.Lang.NumberFormatException"/>
        public static float ParseFloat(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<float>(LocalBridgeClazz, "parseFloat", "(Ljava/lang/String;)F", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/Float.html#sum(float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <returns><see cref="float"/></returns>
        public static float Sum(float arg0, float arg1)
        {
            return SExecute<float>(LocalBridgeClazz, "sum", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/Float.html#compare(float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <returns><see cref="int"/></returns>
        public static int Compare(float arg0, float arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "compare", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/Float.html#floatToIntBits(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="int"/></returns>
        public static int FloatToIntBits(float arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "floatToIntBits", "(F)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/Float.html#hashCode(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="int"/></returns>
        public static int HashCode(float arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "hashCode", "(F)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/Float.html#valueOf(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="Java.Lang.Float"/></returns>
        public static Java.Lang.Float ValueOf(float arg0)
        {
            return SExecuteWithSignature<Java.Lang.Float>(LocalBridgeClazz, "valueOf", "(F)Ljava/lang/Float;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/Float.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.Float"/></returns>
        /// <exception cref="Java.Lang.NumberFormatException"/>
        public static Java.Lang.Float ValueOf(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Lang.Float>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Ljava/lang/Float;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/Float.html#toHexString(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String ToHexString(float arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "toHexString", "(F)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/Float.html#toString(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String ToString(float arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "toString", "(F)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/Float.html#intBitsToFloat(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="float"/></returns>
        public static float IntBitsToFloat(int arg0)
        {
            return SExecuteWithSignature<float>(LocalBridgeClazz, "intBitsToFloat", "(I)F", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/Float.html#floatToRawIntBits(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="int"/></returns>
        public static int FloatToRawIntBits(float arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "floatToRawIntBits", "(F)I", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/Float.html#isInfinite()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsInfinite()
        {
            return IExecuteWithSignature<bool>("isInfinite", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/Float.html#isNaN()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsNaN()
        {
            return IExecuteWithSignature<bool>("isNaN", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/Float.html#compareTo(java.lang.Float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Float"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(Java.Lang.Float arg0)
        {
            return IExecuteWithSignature<int>("compareTo", "(Ljava/lang/Float;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/Float.html#compareTo(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(object arg0)
        {
            return IExecuteWithSignature<int>("compareTo", "(Ljava/lang/Object;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/Float.html#resolveConstantDesc(java.lang.invoke.MethodHandles.Lookup)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Invoke.MethodHandles.Lookup"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Lang.ReflectiveOperationException"/>
        public object ResolveConstantDesc(Java.Lang.Invoke.MethodHandles.Lookup arg0)
        {
            return IExecuteWithSignature("resolveConstantDesc", "(Ljava/lang/invoke/MethodHandles$Lookup;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/Float.html#describeConstable()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Optional"/></returns>
        public Java.Util.Optional<Java.Lang.Float> DescribeConstable()
        {
            return IExecuteWithSignature<Java.Util.Optional<Java.Lang.Float>>("describeConstable", "()Ljava/util/Optional;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}