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

namespace Android.Util
{
    #region Half
    public partial class Half
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Half.html#%3Cinit%3E(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        public Half(double arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Half.html#%3Cinit%3E(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        public Half(float arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Half.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Lang.NumberFormatException"/>
        public Half(Java.Lang.String arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Half.html#%3Cinit%3E(short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        public Half(short arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Android.Util.Half"/> to <see cref="Java.Lang.Comparable"/>
        /// </summary>
        public static implicit operator Java.Lang.Comparable(Android.Util.Half t) => t.Cast<Java.Lang.Comparable>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Half.html#MAX_EXPONENT"/>
        /// </summary>
        public static int MAX_EXPONENT { get { if (!_MAX_EXPONENTReady) { _MAX_EXPONENTContent = SGetField<int>(LocalBridgeClazz, "MAX_EXPONENT"); _MAX_EXPONENTReady = true; } return _MAX_EXPONENTContent; } }
        private static int _MAX_EXPONENTContent = default;
        private static bool _MAX_EXPONENTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Half.html#MIN_EXPONENT"/>
        /// </summary>
        public static int MIN_EXPONENT { get { if (!_MIN_EXPONENTReady) { _MIN_EXPONENTContent = SGetField<int>(LocalBridgeClazz, "MIN_EXPONENT"); _MIN_EXPONENTReady = true; } return _MIN_EXPONENTContent; } }
        private static int _MIN_EXPONENTContent = default;
        private static bool _MIN_EXPONENTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Half.html#SIZE"/>
        /// </summary>
        public static int SIZE { get { if (!_SIZEReady) { _SIZEContent = SGetField<int>(LocalBridgeClazz, "SIZE"); _SIZEReady = true; } return _SIZEContent; } }
        private static int _SIZEContent = default;
        private static bool _SIZEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Half.html#EPSILON"/>
        /// </summary>
        public static short EPSILON { get { if (!_EPSILONReady) { _EPSILONContent = SGetField<short>(LocalBridgeClazz, "EPSILON"); _EPSILONReady = true; } return _EPSILONContent; } }
        private static short _EPSILONContent = default;
        private static bool _EPSILONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Half.html#LOWEST_VALUE"/>
        /// </summary>
        public static short LOWEST_VALUE { get { if (!_LOWEST_VALUEReady) { _LOWEST_VALUEContent = SGetField<short>(LocalBridgeClazz, "LOWEST_VALUE"); _LOWEST_VALUEReady = true; } return _LOWEST_VALUEContent; } }
        private static short _LOWEST_VALUEContent = default;
        private static bool _LOWEST_VALUEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Half.html#MAX_VALUE"/>
        /// </summary>
        public static short MAX_VALUE { get { if (!_MAX_VALUEReady) { _MAX_VALUEContent = SGetField<short>(LocalBridgeClazz, "MAX_VALUE"); _MAX_VALUEReady = true; } return _MAX_VALUEContent; } }
        private static short _MAX_VALUEContent = default;
        private static bool _MAX_VALUEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Half.html#MIN_NORMAL"/>
        /// </summary>
        public static short MIN_NORMAL { get { if (!_MIN_NORMALReady) { _MIN_NORMALContent = SGetField<short>(LocalBridgeClazz, "MIN_NORMAL"); _MIN_NORMALReady = true; } return _MIN_NORMALContent; } }
        private static short _MIN_NORMALContent = default;
        private static bool _MIN_NORMALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Half.html#MIN_VALUE"/>
        /// </summary>
        public static short MIN_VALUE { get { if (!_MIN_VALUEReady) { _MIN_VALUEContent = SGetField<short>(LocalBridgeClazz, "MIN_VALUE"); _MIN_VALUEReady = true; } return _MIN_VALUEContent; } }
        private static short _MIN_VALUEContent = default;
        private static bool _MIN_VALUEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Half.html#NaN"/>
        /// </summary>
        public static short NaN { get { if (!_NaNReady) { _NaNContent = SGetField<short>(LocalBridgeClazz, "NaN"); _NaNReady = true; } return _NaNContent; } }
        private static short _NaNContent = default;
        private static bool _NaNReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Half.html#NEGATIVE_INFINITY"/>
        /// </summary>
        public static short NEGATIVE_INFINITY { get { if (!_NEGATIVE_INFINITYReady) { _NEGATIVE_INFINITYContent = SGetField<short>(LocalBridgeClazz, "NEGATIVE_INFINITY"); _NEGATIVE_INFINITYReady = true; } return _NEGATIVE_INFINITYContent; } }
        private static short _NEGATIVE_INFINITYContent = default;
        private static bool _NEGATIVE_INFINITYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Half.html#NEGATIVE_ZERO"/>
        /// </summary>
        public static short NEGATIVE_ZERO { get { if (!_NEGATIVE_ZEROReady) { _NEGATIVE_ZEROContent = SGetField<short>(LocalBridgeClazz, "NEGATIVE_ZERO"); _NEGATIVE_ZEROReady = true; } return _NEGATIVE_ZEROContent; } }
        private static short _NEGATIVE_ZEROContent = default;
        private static bool _NEGATIVE_ZEROReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Half.html#POSITIVE_INFINITY"/>
        /// </summary>
        public static short POSITIVE_INFINITY { get { if (!_POSITIVE_INFINITYReady) { _POSITIVE_INFINITYContent = SGetField<short>(LocalBridgeClazz, "POSITIVE_INFINITY"); _POSITIVE_INFINITYReady = true; } return _POSITIVE_INFINITYContent; } }
        private static short _POSITIVE_INFINITYContent = default;
        private static bool _POSITIVE_INFINITYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Half.html#POSITIVE_ZERO"/>
        /// </summary>
        public static short POSITIVE_ZERO { get { if (!_POSITIVE_ZEROReady) { _POSITIVE_ZEROContent = SGetField<short>(LocalBridgeClazz, "POSITIVE_ZERO"); _POSITIVE_ZEROReady = true; } return _POSITIVE_ZEROContent; } }
        private static short _POSITIVE_ZEROContent = default;
        private static bool _POSITIVE_ZEROReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Half.html#valueOf(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="Android.Util.Half"/></returns>
        public static Android.Util.Half ValueOf(float arg0)
        {
            return SExecuteWithSignature<Android.Util.Half>(LocalBridgeClazz, "valueOf", "(F)Landroid/util/Half;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Half.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Util.Half"/></returns>
        public static Android.Util.Half ValueOf(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Android.Util.Half>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Landroid/util/Half;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Half.html#valueOf(short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <returns><see cref="Android.Util.Half"/></returns>
        public static Android.Util.Half ValueOf(short arg0)
        {
            return SExecuteWithSignature<Android.Util.Half>(LocalBridgeClazz, "valueOf", "(S)Landroid/util/Half;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Half.html#equals(short,short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <param name="arg1"><see cref="short"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool Equals(short arg0, short arg1)
        {
            return SExecute<bool>(LocalBridgeClazz, "equals", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Half.html#greater(short,short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <param name="arg1"><see cref="short"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool Greater(short arg0, short arg1)
        {
            return SExecute<bool>(LocalBridgeClazz, "greater", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Half.html#greaterEquals(short,short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <param name="arg1"><see cref="short"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool GreaterEquals(short arg0, short arg1)
        {
            return SExecute<bool>(LocalBridgeClazz, "greaterEquals", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Half.html#isInfinite(short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsInfinite(short arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isInfinite", "(S)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Half.html#isNaN(short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsNaN(short arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isNaN", "(S)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Half.html#isNormalized(short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsNormalized(short arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isNormalized", "(S)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Half.html#less(short,short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <param name="arg1"><see cref="short"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool Less(short arg0, short arg1)
        {
            return SExecute<bool>(LocalBridgeClazz, "less", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Half.html#lessEquals(short,short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <param name="arg1"><see cref="short"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool LessEquals(short arg0, short arg1)
        {
            return SExecute<bool>(LocalBridgeClazz, "lessEquals", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Half.html#toFloat(short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <returns><see cref="float"/></returns>
        public static float ToFloat(short arg0)
        {
            return SExecuteWithSignature<float>(LocalBridgeClazz, "toFloat", "(S)F", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Half.html#compare(short,short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <param name="arg1"><see cref="short"/></param>
        /// <returns><see cref="int"/></returns>
        public static int Compare(short arg0, short arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "compare", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Half.html#getExponent(short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <returns><see cref="int"/></returns>
        public static int GetExponent(short arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "getExponent", "(S)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Half.html#getSign(short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <returns><see cref="int"/></returns>
        public static int GetSign(short arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "getSign", "(S)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Half.html#getSignificand(short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <returns><see cref="int"/></returns>
        public static int GetSignificand(short arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "getSignificand", "(S)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Half.html#halfToIntBits(short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <returns><see cref="int"/></returns>
        public static int HalfToIntBits(short arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "halfToIntBits", "(S)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Half.html#halfToRawIntBits(short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <returns><see cref="int"/></returns>
        public static int HalfToRawIntBits(short arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "halfToRawIntBits", "(S)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Half.html#hashCode(short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <returns><see cref="int"/></returns>
        public static int HashCode(short arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "hashCode", "(S)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Half.html#toHexString(short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String ToHexString(short arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "toHexString", "(S)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Half.html#toString(short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String ToString(short arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "toString", "(S)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Half.html#abs(short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <returns><see cref="short"/></returns>
        public static short Abs(short arg0)
        {
            return SExecuteWithSignature<short>(LocalBridgeClazz, "abs", "(S)S", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Half.html#ceil(short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <returns><see cref="short"/></returns>
        public static short Ceil(short arg0)
        {
            return SExecuteWithSignature<short>(LocalBridgeClazz, "ceil", "(S)S", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Half.html#copySign(short,short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <param name="arg1"><see cref="short"/></param>
        /// <returns><see cref="short"/></returns>
        public static short CopySign(short arg0, short arg1)
        {
            return SExecute<short>(LocalBridgeClazz, "copySign", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Half.html#floor(short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <returns><see cref="short"/></returns>
        public static short Floor(short arg0)
        {
            return SExecuteWithSignature<short>(LocalBridgeClazz, "floor", "(S)S", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Half.html#halfToShortBits(short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <returns><see cref="short"/></returns>
        public static short HalfToShortBits(short arg0)
        {
            return SExecuteWithSignature<short>(LocalBridgeClazz, "halfToShortBits", "(S)S", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Half.html#intBitsToHalf(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="short"/></returns>
        public static short IntBitsToHalf(int arg0)
        {
            return SExecuteWithSignature<short>(LocalBridgeClazz, "intBitsToHalf", "(I)S", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Half.html#max(short,short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <param name="arg1"><see cref="short"/></param>
        /// <returns><see cref="short"/></returns>
        public static short Max(short arg0, short arg1)
        {
            return SExecute<short>(LocalBridgeClazz, "max", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Half.html#min(short,short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <param name="arg1"><see cref="short"/></param>
        /// <returns><see cref="short"/></returns>
        public static short Min(short arg0, short arg1)
        {
            return SExecute<short>(LocalBridgeClazz, "min", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Half.html#parseHalf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="short"/></returns>
        /// <exception cref="Java.Lang.NumberFormatException"/>
        public static short ParseHalf(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<short>(LocalBridgeClazz, "parseHalf", "(Ljava/lang/String;)S", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Half.html#round(short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <returns><see cref="short"/></returns>
        public static short Round(short arg0)
        {
            return SExecuteWithSignature<short>(LocalBridgeClazz, "round", "(S)S", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Half.html#toHalf(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="short"/></returns>
        public static short ToHalf(float arg0)
        {
            return SExecuteWithSignature<short>(LocalBridgeClazz, "toHalf", "(F)S", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Half.html#trunc(short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <returns><see cref="short"/></returns>
        public static short Trunc(short arg0)
        {
            return SExecuteWithSignature<short>(LocalBridgeClazz, "trunc", "(S)S", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Half.html#isNaN()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsNaN()
        {
            return IExecuteWithSignature<bool>("isNaN", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Half.html#compareTo(android.util.Half)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Util.Half"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(Android.Util.Half arg0)
        {
            return IExecuteWithSignature<int>("compareTo", "(Landroid/util/Half;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Half.html#compareTo(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(object arg0)
        {
            return IExecuteWithSignature<int>("compareTo", "(Ljava/lang/Object;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Half.html#halfValue()"/>
        /// </summary>
        /// <returns><see cref="short"/></returns>
        public short HalfValue()
        {
            return IExecuteWithSignature<short>("halfValue", "()S");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}