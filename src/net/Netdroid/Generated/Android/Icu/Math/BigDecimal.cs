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

namespace Android.Icu.Math
{
    #region BigDecimal
    public partial class BigDecimal : Java.Lang.IComparable<Android.Icu.Math.BigDecimal>
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/math/BigDecimal.html#%3Cinit%3E(char[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public BigDecimal(char[] arg0, int arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/math/BigDecimal.html#%3Cinit%3E(char[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        public BigDecimal(char[] arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/math/BigDecimal.html#%3Cinit%3E(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        public BigDecimal(double arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/math/BigDecimal.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public BigDecimal(int arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/math/BigDecimal.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public BigDecimal(Java.Lang.String arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/math/BigDecimal.html#%3Cinit%3E(java.math.BigDecimal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigDecimal"/></param>
        public BigDecimal(Java.Math.BigDecimal arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/math/BigDecimal.html#%3Cinit%3E(java.math.BigInteger,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigInteger"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public BigDecimal(Java.Math.BigInteger arg0, int arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/math/BigDecimal.html#%3Cinit%3E(java.math.BigInteger)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigInteger"/></param>
        public BigDecimal(Java.Math.BigInteger arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/math/BigDecimal.html#%3Cinit%3E(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public BigDecimal(long arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Android.Icu.Math.BigDecimal"/> to <see cref="Java.Lang.Comparable"/>
        /// </summary>
        public static implicit operator Java.Lang.Comparable(Android.Icu.Math.BigDecimal t) => t.Cast<Java.Lang.Comparable>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/math/BigDecimal.html#ONE"/>
        /// </summary>
        public static Android.Icu.Math.BigDecimal ONE { get { if (!_ONEReady) { _ONEContent = SGetField<Android.Icu.Math.BigDecimal>(LocalBridgeClazz, "ONE"); _ONEReady = true; } return _ONEContent; } }
        private static Android.Icu.Math.BigDecimal _ONEContent = default;
        private static bool _ONEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/math/BigDecimal.html#TEN"/>
        /// </summary>
        public static Android.Icu.Math.BigDecimal TEN { get { if (!_TENReady) { _TENContent = SGetField<Android.Icu.Math.BigDecimal>(LocalBridgeClazz, "TEN"); _TENReady = true; } return _TENContent; } }
        private static Android.Icu.Math.BigDecimal _TENContent = default;
        private static bool _TENReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/math/BigDecimal.html#ZERO"/>
        /// </summary>
        public static Android.Icu.Math.BigDecimal ZERO { get { if (!_ZEROReady) { _ZEROContent = SGetField<Android.Icu.Math.BigDecimal>(LocalBridgeClazz, "ZERO"); _ZEROReady = true; } return _ZEROContent; } }
        private static Android.Icu.Math.BigDecimal _ZEROContent = default;
        private static bool _ZEROReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/math/BigDecimal.html#ROUND_CEILING"/>
        /// </summary>
        public static int ROUND_CEILING { get { if (!_ROUND_CEILINGReady) { _ROUND_CEILINGContent = SGetField<int>(LocalBridgeClazz, "ROUND_CEILING"); _ROUND_CEILINGReady = true; } return _ROUND_CEILINGContent; } }
        private static int _ROUND_CEILINGContent = default;
        private static bool _ROUND_CEILINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/math/BigDecimal.html#ROUND_DOWN"/>
        /// </summary>
        public static int ROUND_DOWN { get { if (!_ROUND_DOWNReady) { _ROUND_DOWNContent = SGetField<int>(LocalBridgeClazz, "ROUND_DOWN"); _ROUND_DOWNReady = true; } return _ROUND_DOWNContent; } }
        private static int _ROUND_DOWNContent = default;
        private static bool _ROUND_DOWNReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/math/BigDecimal.html#ROUND_FLOOR"/>
        /// </summary>
        public static int ROUND_FLOOR { get { if (!_ROUND_FLOORReady) { _ROUND_FLOORContent = SGetField<int>(LocalBridgeClazz, "ROUND_FLOOR"); _ROUND_FLOORReady = true; } return _ROUND_FLOORContent; } }
        private static int _ROUND_FLOORContent = default;
        private static bool _ROUND_FLOORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/math/BigDecimal.html#ROUND_HALF_DOWN"/>
        /// </summary>
        public static int ROUND_HALF_DOWN { get { if (!_ROUND_HALF_DOWNReady) { _ROUND_HALF_DOWNContent = SGetField<int>(LocalBridgeClazz, "ROUND_HALF_DOWN"); _ROUND_HALF_DOWNReady = true; } return _ROUND_HALF_DOWNContent; } }
        private static int _ROUND_HALF_DOWNContent = default;
        private static bool _ROUND_HALF_DOWNReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/math/BigDecimal.html#ROUND_HALF_EVEN"/>
        /// </summary>
        public static int ROUND_HALF_EVEN { get { if (!_ROUND_HALF_EVENReady) { _ROUND_HALF_EVENContent = SGetField<int>(LocalBridgeClazz, "ROUND_HALF_EVEN"); _ROUND_HALF_EVENReady = true; } return _ROUND_HALF_EVENContent; } }
        private static int _ROUND_HALF_EVENContent = default;
        private static bool _ROUND_HALF_EVENReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/math/BigDecimal.html#ROUND_HALF_UP"/>
        /// </summary>
        public static int ROUND_HALF_UP { get { if (!_ROUND_HALF_UPReady) { _ROUND_HALF_UPContent = SGetField<int>(LocalBridgeClazz, "ROUND_HALF_UP"); _ROUND_HALF_UPReady = true; } return _ROUND_HALF_UPContent; } }
        private static int _ROUND_HALF_UPContent = default;
        private static bool _ROUND_HALF_UPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/math/BigDecimal.html#ROUND_UNNECESSARY"/>
        /// </summary>
        public static int ROUND_UNNECESSARY { get { if (!_ROUND_UNNECESSARYReady) { _ROUND_UNNECESSARYContent = SGetField<int>(LocalBridgeClazz, "ROUND_UNNECESSARY"); _ROUND_UNNECESSARYReady = true; } return _ROUND_UNNECESSARYContent; } }
        private static int _ROUND_UNNECESSARYContent = default;
        private static bool _ROUND_UNNECESSARYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/math/BigDecimal.html#ROUND_UP"/>
        /// </summary>
        public static int ROUND_UP { get { if (!_ROUND_UPReady) { _ROUND_UPContent = SGetField<int>(LocalBridgeClazz, "ROUND_UP"); _ROUND_UPReady = true; } return _ROUND_UPContent; } }
        private static int _ROUND_UPContent = default;
        private static bool _ROUND_UPReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/math/BigDecimal.html#valueOf(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="Android.Icu.Math.BigDecimal"/></returns>
        public static Android.Icu.Math.BigDecimal ValueOf(double arg0)
        {
            return SExecuteWithSignature<Android.Icu.Math.BigDecimal>(LocalBridgeClazz, "valueOf", "(D)Landroid/icu/math/BigDecimal;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/math/BigDecimal.html#valueOf(long,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Android.Icu.Math.BigDecimal"/></returns>
        public static Android.Icu.Math.BigDecimal ValueOf(long arg0, int arg1)
        {
            return SExecute<Android.Icu.Math.BigDecimal>(LocalBridgeClazz, "valueOf", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/math/BigDecimal.html#valueOf(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Android.Icu.Math.BigDecimal"/></returns>
        public static Android.Icu.Math.BigDecimal ValueOf(long arg0)
        {
            return SExecuteWithSignature<Android.Icu.Math.BigDecimal>(LocalBridgeClazz, "valueOf", "(J)Landroid/icu/math/BigDecimal;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/math/BigDecimal.html#abs()"/>
        /// </summary>
        /// <returns><see cref="Android.Icu.Math.BigDecimal"/></returns>
        public Android.Icu.Math.BigDecimal Abs()
        {
            return IExecuteWithSignature<Android.Icu.Math.BigDecimal>("abs", "()Landroid/icu/math/BigDecimal;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/math/BigDecimal.html#abs(android.icu.math.MathContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Math.MathContext"/></param>
        /// <returns><see cref="Android.Icu.Math.BigDecimal"/></returns>
        public Android.Icu.Math.BigDecimal Abs(Android.Icu.Math.MathContext arg0)
        {
            return IExecuteWithSignature<Android.Icu.Math.BigDecimal>("abs", "(Landroid/icu/math/MathContext;)Landroid/icu/math/BigDecimal;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/math/BigDecimal.html#add(android.icu.math.BigDecimal,android.icu.math.MathContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Math.BigDecimal"/></param>
        /// <param name="arg1"><see cref="Android.Icu.Math.MathContext"/></param>
        /// <returns><see cref="Android.Icu.Math.BigDecimal"/></returns>
        public Android.Icu.Math.BigDecimal Add(Android.Icu.Math.BigDecimal arg0, Android.Icu.Math.MathContext arg1)
        {
            return IExecute<Android.Icu.Math.BigDecimal>("add", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/math/BigDecimal.html#add(android.icu.math.BigDecimal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Math.BigDecimal"/></param>
        /// <returns><see cref="Android.Icu.Math.BigDecimal"/></returns>
        public Android.Icu.Math.BigDecimal Add(Android.Icu.Math.BigDecimal arg0)
        {
            return IExecuteWithSignature<Android.Icu.Math.BigDecimal>("add", "(Landroid/icu/math/BigDecimal;)Landroid/icu/math/BigDecimal;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/math/BigDecimal.html#divide(android.icu.math.BigDecimal,android.icu.math.MathContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Math.BigDecimal"/></param>
        /// <param name="arg1"><see cref="Android.Icu.Math.MathContext"/></param>
        /// <returns><see cref="Android.Icu.Math.BigDecimal"/></returns>
        public Android.Icu.Math.BigDecimal Divide(Android.Icu.Math.BigDecimal arg0, Android.Icu.Math.MathContext arg1)
        {
            return IExecute<Android.Icu.Math.BigDecimal>("divide", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/math/BigDecimal.html#divide(android.icu.math.BigDecimal,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Math.BigDecimal"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Android.Icu.Math.BigDecimal"/></returns>
        public Android.Icu.Math.BigDecimal Divide(Android.Icu.Math.BigDecimal arg0, int arg1, int arg2)
        {
            return IExecute<Android.Icu.Math.BigDecimal>("divide", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/math/BigDecimal.html#divide(android.icu.math.BigDecimal,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Math.BigDecimal"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Android.Icu.Math.BigDecimal"/></returns>
        public Android.Icu.Math.BigDecimal Divide(Android.Icu.Math.BigDecimal arg0, int arg1)
        {
            return IExecute<Android.Icu.Math.BigDecimal>("divide", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/math/BigDecimal.html#divide(android.icu.math.BigDecimal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Math.BigDecimal"/></param>
        /// <returns><see cref="Android.Icu.Math.BigDecimal"/></returns>
        public Android.Icu.Math.BigDecimal Divide(Android.Icu.Math.BigDecimal arg0)
        {
            return IExecuteWithSignature<Android.Icu.Math.BigDecimal>("divide", "(Landroid/icu/math/BigDecimal;)Landroid/icu/math/BigDecimal;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/math/BigDecimal.html#divideInteger(android.icu.math.BigDecimal,android.icu.math.MathContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Math.BigDecimal"/></param>
        /// <param name="arg1"><see cref="Android.Icu.Math.MathContext"/></param>
        /// <returns><see cref="Android.Icu.Math.BigDecimal"/></returns>
        public Android.Icu.Math.BigDecimal DivideInteger(Android.Icu.Math.BigDecimal arg0, Android.Icu.Math.MathContext arg1)
        {
            return IExecute<Android.Icu.Math.BigDecimal>("divideInteger", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/math/BigDecimal.html#divideInteger(android.icu.math.BigDecimal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Math.BigDecimal"/></param>
        /// <returns><see cref="Android.Icu.Math.BigDecimal"/></returns>
        public Android.Icu.Math.BigDecimal DivideInteger(Android.Icu.Math.BigDecimal arg0)
        {
            return IExecuteWithSignature<Android.Icu.Math.BigDecimal>("divideInteger", "(Landroid/icu/math/BigDecimal;)Landroid/icu/math/BigDecimal;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/math/BigDecimal.html#max(android.icu.math.BigDecimal,android.icu.math.MathContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Math.BigDecimal"/></param>
        /// <param name="arg1"><see cref="Android.Icu.Math.MathContext"/></param>
        /// <returns><see cref="Android.Icu.Math.BigDecimal"/></returns>
        public Android.Icu.Math.BigDecimal Max(Android.Icu.Math.BigDecimal arg0, Android.Icu.Math.MathContext arg1)
        {
            return IExecute<Android.Icu.Math.BigDecimal>("max", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/math/BigDecimal.html#max(android.icu.math.BigDecimal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Math.BigDecimal"/></param>
        /// <returns><see cref="Android.Icu.Math.BigDecimal"/></returns>
        public Android.Icu.Math.BigDecimal Max(Android.Icu.Math.BigDecimal arg0)
        {
            return IExecuteWithSignature<Android.Icu.Math.BigDecimal>("max", "(Landroid/icu/math/BigDecimal;)Landroid/icu/math/BigDecimal;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/math/BigDecimal.html#min(android.icu.math.BigDecimal,android.icu.math.MathContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Math.BigDecimal"/></param>
        /// <param name="arg1"><see cref="Android.Icu.Math.MathContext"/></param>
        /// <returns><see cref="Android.Icu.Math.BigDecimal"/></returns>
        public Android.Icu.Math.BigDecimal Min(Android.Icu.Math.BigDecimal arg0, Android.Icu.Math.MathContext arg1)
        {
            return IExecute<Android.Icu.Math.BigDecimal>("min", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/math/BigDecimal.html#min(android.icu.math.BigDecimal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Math.BigDecimal"/></param>
        /// <returns><see cref="Android.Icu.Math.BigDecimal"/></returns>
        public Android.Icu.Math.BigDecimal Min(Android.Icu.Math.BigDecimal arg0)
        {
            return IExecuteWithSignature<Android.Icu.Math.BigDecimal>("min", "(Landroid/icu/math/BigDecimal;)Landroid/icu/math/BigDecimal;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/math/BigDecimal.html#movePointLeft(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Icu.Math.BigDecimal"/></returns>
        public Android.Icu.Math.BigDecimal MovePointLeft(int arg0)
        {
            return IExecuteWithSignature<Android.Icu.Math.BigDecimal>("movePointLeft", "(I)Landroid/icu/math/BigDecimal;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/math/BigDecimal.html#movePointRight(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Icu.Math.BigDecimal"/></returns>
        public Android.Icu.Math.BigDecimal MovePointRight(int arg0)
        {
            return IExecuteWithSignature<Android.Icu.Math.BigDecimal>("movePointRight", "(I)Landroid/icu/math/BigDecimal;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/math/BigDecimal.html#multiply(android.icu.math.BigDecimal,android.icu.math.MathContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Math.BigDecimal"/></param>
        /// <param name="arg1"><see cref="Android.Icu.Math.MathContext"/></param>
        /// <returns><see cref="Android.Icu.Math.BigDecimal"/></returns>
        public Android.Icu.Math.BigDecimal Multiply(Android.Icu.Math.BigDecimal arg0, Android.Icu.Math.MathContext arg1)
        {
            return IExecute<Android.Icu.Math.BigDecimal>("multiply", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/math/BigDecimal.html#multiply(android.icu.math.BigDecimal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Math.BigDecimal"/></param>
        /// <returns><see cref="Android.Icu.Math.BigDecimal"/></returns>
        public Android.Icu.Math.BigDecimal Multiply(Android.Icu.Math.BigDecimal arg0)
        {
            return IExecuteWithSignature<Android.Icu.Math.BigDecimal>("multiply", "(Landroid/icu/math/BigDecimal;)Landroid/icu/math/BigDecimal;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/math/BigDecimal.html#negate()"/>
        /// </summary>
        /// <returns><see cref="Android.Icu.Math.BigDecimal"/></returns>
        public Android.Icu.Math.BigDecimal Negate()
        {
            return IExecuteWithSignature<Android.Icu.Math.BigDecimal>("negate", "()Landroid/icu/math/BigDecimal;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/math/BigDecimal.html#negate(android.icu.math.MathContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Math.MathContext"/></param>
        /// <returns><see cref="Android.Icu.Math.BigDecimal"/></returns>
        public Android.Icu.Math.BigDecimal Negate(Android.Icu.Math.MathContext arg0)
        {
            return IExecuteWithSignature<Android.Icu.Math.BigDecimal>("negate", "(Landroid/icu/math/MathContext;)Landroid/icu/math/BigDecimal;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/math/BigDecimal.html#plus()"/>
        /// </summary>
        /// <returns><see cref="Android.Icu.Math.BigDecimal"/></returns>
        public Android.Icu.Math.BigDecimal Plus()
        {
            return IExecuteWithSignature<Android.Icu.Math.BigDecimal>("plus", "()Landroid/icu/math/BigDecimal;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/math/BigDecimal.html#plus(android.icu.math.MathContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Math.MathContext"/></param>
        /// <returns><see cref="Android.Icu.Math.BigDecimal"/></returns>
        public Android.Icu.Math.BigDecimal Plus(Android.Icu.Math.MathContext arg0)
        {
            return IExecuteWithSignature<Android.Icu.Math.BigDecimal>("plus", "(Landroid/icu/math/MathContext;)Landroid/icu/math/BigDecimal;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/math/BigDecimal.html#pow(android.icu.math.BigDecimal,android.icu.math.MathContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Math.BigDecimal"/></param>
        /// <param name="arg1"><see cref="Android.Icu.Math.MathContext"/></param>
        /// <returns><see cref="Android.Icu.Math.BigDecimal"/></returns>
        public Android.Icu.Math.BigDecimal Pow(Android.Icu.Math.BigDecimal arg0, Android.Icu.Math.MathContext arg1)
        {
            return IExecute<Android.Icu.Math.BigDecimal>("pow", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/math/BigDecimal.html#pow(android.icu.math.BigDecimal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Math.BigDecimal"/></param>
        /// <returns><see cref="Android.Icu.Math.BigDecimal"/></returns>
        public Android.Icu.Math.BigDecimal Pow(Android.Icu.Math.BigDecimal arg0)
        {
            return IExecuteWithSignature<Android.Icu.Math.BigDecimal>("pow", "(Landroid/icu/math/BigDecimal;)Landroid/icu/math/BigDecimal;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/math/BigDecimal.html#remainder(android.icu.math.BigDecimal,android.icu.math.MathContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Math.BigDecimal"/></param>
        /// <param name="arg1"><see cref="Android.Icu.Math.MathContext"/></param>
        /// <returns><see cref="Android.Icu.Math.BigDecimal"/></returns>
        public Android.Icu.Math.BigDecimal Remainder(Android.Icu.Math.BigDecimal arg0, Android.Icu.Math.MathContext arg1)
        {
            return IExecute<Android.Icu.Math.BigDecimal>("remainder", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/math/BigDecimal.html#remainder(android.icu.math.BigDecimal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Math.BigDecimal"/></param>
        /// <returns><see cref="Android.Icu.Math.BigDecimal"/></returns>
        public Android.Icu.Math.BigDecimal Remainder(Android.Icu.Math.BigDecimal arg0)
        {
            return IExecuteWithSignature<Android.Icu.Math.BigDecimal>("remainder", "(Landroid/icu/math/BigDecimal;)Landroid/icu/math/BigDecimal;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/math/BigDecimal.html#setScale(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Android.Icu.Math.BigDecimal"/></returns>
        public Android.Icu.Math.BigDecimal SetScale(int arg0, int arg1)
        {
            return IExecute<Android.Icu.Math.BigDecimal>("setScale", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/math/BigDecimal.html#setScale(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Icu.Math.BigDecimal"/></returns>
        public Android.Icu.Math.BigDecimal SetScale(int arg0)
        {
            return IExecuteWithSignature<Android.Icu.Math.BigDecimal>("setScale", "(I)Landroid/icu/math/BigDecimal;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/math/BigDecimal.html#subtract(android.icu.math.BigDecimal,android.icu.math.MathContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Math.BigDecimal"/></param>
        /// <param name="arg1"><see cref="Android.Icu.Math.MathContext"/></param>
        /// <returns><see cref="Android.Icu.Math.BigDecimal"/></returns>
        public Android.Icu.Math.BigDecimal Subtract(Android.Icu.Math.BigDecimal arg0, Android.Icu.Math.MathContext arg1)
        {
            return IExecute<Android.Icu.Math.BigDecimal>("subtract", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/math/BigDecimal.html#subtract(android.icu.math.BigDecimal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Math.BigDecimal"/></param>
        /// <returns><see cref="Android.Icu.Math.BigDecimal"/></returns>
        public Android.Icu.Math.BigDecimal Subtract(Android.Icu.Math.BigDecimal arg0)
        {
            return IExecuteWithSignature<Android.Icu.Math.BigDecimal>("subtract", "(Landroid/icu/math/BigDecimal;)Landroid/icu/math/BigDecimal;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/math/BigDecimal.html#byteValueExact()"/>
        /// </summary>
        /// <returns><see cref="byte"/></returns>
        public byte ByteValueExact()
        {
            return IExecuteWithSignature<byte>("byteValueExact", "()B");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/math/BigDecimal.html#toCharArray()"/>
        /// </summary>
        /// <returns><see cref="char"/></returns>
        public char[] ToCharArray()
        {
            return IExecuteWithSignatureArray<char>("toCharArray", "()[C");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/math/BigDecimal.html#compareTo(android.icu.math.BigDecimal,android.icu.math.MathContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Math.BigDecimal"/></param>
        /// <param name="arg1"><see cref="Android.Icu.Math.MathContext"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(Android.Icu.Math.BigDecimal arg0, Android.Icu.Math.MathContext arg1)
        {
            return IExecute<int>("compareTo", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/math/BigDecimal.html#compareTo(android.icu.math.BigDecimal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Math.BigDecimal"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(Android.Icu.Math.BigDecimal arg0)
        {
            return IExecuteWithSignature<int>("compareTo", "(Landroid/icu/math/BigDecimal;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/math/BigDecimal.html#compareTo(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(object arg0)
        {
            return IExecuteWithSignature<int>("compareTo", "(Ljava/lang/Object;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/math/BigDecimal.html#intValueExact()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int IntValueExact()
        {
            return IExecuteWithSignature<int>("intValueExact", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/math/BigDecimal.html#scale()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Scale()
        {
            return IExecuteWithSignature<int>("scale", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/math/BigDecimal.html#signum()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Signum()
        {
            return IExecuteWithSignature<int>("signum", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/math/BigDecimal.html#format(int,int,int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String Format(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5)
        {
            return IExecute<Java.Lang.String>("format", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/math/BigDecimal.html#format(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String Format(int arg0, int arg1)
        {
            return IExecute<Java.Lang.String>("format", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/math/BigDecimal.html#toBigDecimal()"/>
        /// </summary>
        /// <returns><see cref="Java.Math.BigDecimal"/></returns>
        public Java.Math.BigDecimal ToBigDecimal()
        {
            return IExecuteWithSignature<Java.Math.BigDecimal>("toBigDecimal", "()Ljava/math/BigDecimal;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/math/BigDecimal.html#toBigInteger()"/>
        /// </summary>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger ToBigInteger()
        {
            return IExecuteWithSignature<Java.Math.BigInteger>("toBigInteger", "()Ljava/math/BigInteger;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/math/BigDecimal.html#toBigIntegerExact()"/>
        /// </summary>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger ToBigIntegerExact()
        {
            return IExecuteWithSignature<Java.Math.BigInteger>("toBigIntegerExact", "()Ljava/math/BigInteger;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/math/BigDecimal.html#unscaledValue()"/>
        /// </summary>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger UnscaledValue()
        {
            return IExecuteWithSignature<Java.Math.BigInteger>("unscaledValue", "()Ljava/math/BigInteger;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/math/BigDecimal.html#longValueExact()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long LongValueExact()
        {
            return IExecuteWithSignature<long>("longValueExact", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/math/BigDecimal.html#shortValueExact()"/>
        /// </summary>
        /// <returns><see cref="short"/></returns>
        public short ShortValueExact()
        {
            return IExecuteWithSignature<short>("shortValueExact", "()S");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}