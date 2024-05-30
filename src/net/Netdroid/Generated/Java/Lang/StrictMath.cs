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
    #region StrictMath
    public partial class StrictMath
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StrictMath.html#E"/>
        /// </summary>
        public static double E { get { if (!_EReady) { _EContent = SGetField<double>(LocalBridgeClazz, "E"); _EReady = true; } return _EContent; } }
        private static double _EContent = default;
        private static bool _EReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StrictMath.html#PI"/>
        /// </summary>
        public static double PI { get { if (!_PIReady) { _PIContent = SGetField<double>(LocalBridgeClazz, "PI"); _PIReady = true; } return _PIContent; } }
        private static double _PIContent = default;
        private static bool _PIReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StrictMath.html#abs(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public static double Abs(double arg0)
        {
            return SExecuteWithSignature<double>(LocalBridgeClazz, "abs", "(D)D", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StrictMath.html#cbrt(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public static double Cbrt(double arg0)
        {
            return SExecuteWithSignature<double>(LocalBridgeClazz, "cbrt", "(D)D", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StrictMath.html#ceil(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public static double Ceil(double arg0)
        {
            return SExecuteWithSignature<double>(LocalBridgeClazz, "ceil", "(D)D", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StrictMath.html#copySign(double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public static double CopySign(double arg0, double arg1)
        {
            return SExecute<double>(LocalBridgeClazz, "copySign", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StrictMath.html#exp(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public static double Exp(double arg0)
        {
            return SExecuteWithSignature<double>(LocalBridgeClazz, "exp", "(D)D", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StrictMath.html#floor(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public static double Floor(double arg0)
        {
            return SExecuteWithSignature<double>(LocalBridgeClazz, "floor", "(D)D", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StrictMath.html#fma(double,double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <param name="arg2"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public static double Fma(double arg0, double arg1, double arg2)
        {
            return SExecute<double>(LocalBridgeClazz, "fma", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StrictMath.html#hypot(double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public static double Hypot(double arg0, double arg1)
        {
            return SExecute<double>(LocalBridgeClazz, "hypot", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StrictMath.html#max(double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public static double Max(double arg0, double arg1)
        {
            return SExecute<double>(LocalBridgeClazz, "max", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StrictMath.html#min(double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public static double Min(double arg0, double arg1)
        {
            return SExecute<double>(LocalBridgeClazz, "min", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StrictMath.html#nextAfter(double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public static double NextAfter(double arg0, double arg1)
        {
            return SExecute<double>(LocalBridgeClazz, "nextAfter", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StrictMath.html#nextDown(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public static double NextDown(double arg0)
        {
            return SExecuteWithSignature<double>(LocalBridgeClazz, "nextDown", "(D)D", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StrictMath.html#nextUp(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public static double NextUp(double arg0)
        {
            return SExecuteWithSignature<double>(LocalBridgeClazz, "nextUp", "(D)D", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StrictMath.html#pow(double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public static double Pow(double arg0, double arg1)
        {
            return SExecute<double>(LocalBridgeClazz, "pow", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StrictMath.html#random()"/>
        /// </summary>
        /// <returns><see cref="double"/></returns>
        public static double Random()
        {
            return SExecuteWithSignature<double>(LocalBridgeClazz, "random", "()D");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StrictMath.html#rint(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public static double Rint(double arg0)
        {
            return SExecuteWithSignature<double>(LocalBridgeClazz, "rint", "(D)D", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StrictMath.html#scalb(double,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="double"/></returns>
        public static double Scalb(double arg0, int arg1)
        {
            return SExecute<double>(LocalBridgeClazz, "scalb", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StrictMath.html#signum(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public static double Signum(double arg0)
        {
            return SExecuteWithSignature<double>(LocalBridgeClazz, "signum", "(D)D", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StrictMath.html#toDegrees(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public static double ToDegrees(double arg0)
        {
            return SExecuteWithSignature<double>(LocalBridgeClazz, "toDegrees", "(D)D", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StrictMath.html#toRadians(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public static double ToRadians(double arg0)
        {
            return SExecuteWithSignature<double>(LocalBridgeClazz, "toRadians", "(D)D", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StrictMath.html#ulp(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public static double Ulp(double arg0)
        {
            return SExecuteWithSignature<double>(LocalBridgeClazz, "ulp", "(D)D", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StrictMath.html#abs(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="float"/></returns>
        public static float Abs(float arg0)
        {
            return SExecuteWithSignature<float>(LocalBridgeClazz, "abs", "(F)F", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StrictMath.html#copySign(float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <returns><see cref="float"/></returns>
        public static float CopySign(float arg0, float arg1)
        {
            return SExecute<float>(LocalBridgeClazz, "copySign", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StrictMath.html#fma(float,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <returns><see cref="float"/></returns>
        public static float Fma(float arg0, float arg1, float arg2)
        {
            return SExecute<float>(LocalBridgeClazz, "fma", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StrictMath.html#max(float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <returns><see cref="float"/></returns>
        public static float Max(float arg0, float arg1)
        {
            return SExecute<float>(LocalBridgeClazz, "max", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StrictMath.html#min(float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <returns><see cref="float"/></returns>
        public static float Min(float arg0, float arg1)
        {
            return SExecute<float>(LocalBridgeClazz, "min", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StrictMath.html#nextAfter(float,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <returns><see cref="float"/></returns>
        public static float NextAfter(float arg0, double arg1)
        {
            return SExecute<float>(LocalBridgeClazz, "nextAfter", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StrictMath.html#nextDown(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="float"/></returns>
        public static float NextDown(float arg0)
        {
            return SExecuteWithSignature<float>(LocalBridgeClazz, "nextDown", "(F)F", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StrictMath.html#nextUp(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="float"/></returns>
        public static float NextUp(float arg0)
        {
            return SExecuteWithSignature<float>(LocalBridgeClazz, "nextUp", "(F)F", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StrictMath.html#scalb(float,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="float"/></returns>
        public static float Scalb(float arg0, int arg1)
        {
            return SExecute<float>(LocalBridgeClazz, "scalb", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StrictMath.html#signum(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="float"/></returns>
        public static float Signum(float arg0)
        {
            return SExecuteWithSignature<float>(LocalBridgeClazz, "signum", "(F)F", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StrictMath.html#ulp(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="float"/></returns>
        public static float Ulp(float arg0)
        {
            return SExecuteWithSignature<float>(LocalBridgeClazz, "ulp", "(F)F", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StrictMath.html#abs(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int Abs(int arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "abs", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StrictMath.html#absExact(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int AbsExact(int arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "absExact", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StrictMath.html#addExact(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int AddExact(int arg0, int arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "addExact", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StrictMath.html#decrementExact(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int DecrementExact(int arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "decrementExact", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StrictMath.html#floorDiv(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int FloorDiv(int arg0, int arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "floorDiv", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StrictMath.html#floorMod(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int FloorMod(int arg0, int arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "floorMod", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StrictMath.html#floorMod(long,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int FloorMod(long arg0, int arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "floorMod", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StrictMath.html#getExponent(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="int"/></returns>
        public static int GetExponent(double arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "getExponent", "(D)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StrictMath.html#getExponent(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="int"/></returns>
        public static int GetExponent(float arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "getExponent", "(F)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StrictMath.html#incrementExact(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int IncrementExact(int arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "incrementExact", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StrictMath.html#max(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int Max(int arg0, int arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "max", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StrictMath.html#min(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int Min(int arg0, int arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "min", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StrictMath.html#multiplyExact(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int MultiplyExact(int arg0, int arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "multiplyExact", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StrictMath.html#negateExact(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int NegateExact(int arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "negateExact", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StrictMath.html#round(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="int"/></returns>
        public static int Round(float arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "round", "(F)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StrictMath.html#subtractExact(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int SubtractExact(int arg0, int arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "subtractExact", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StrictMath.html#toIntExact(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="int"/></returns>
        public static int ToIntExact(long arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "toIntExact", "(J)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StrictMath.html#abs(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public static long Abs(long arg0)
        {
            return SExecuteWithSignature<long>(LocalBridgeClazz, "abs", "(J)J", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StrictMath.html#absExact(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public static long AbsExact(long arg0)
        {
            return SExecuteWithSignature<long>(LocalBridgeClazz, "absExact", "(J)J", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StrictMath.html#addExact(long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public static long AddExact(long arg0, long arg1)
        {
            return SExecute<long>(LocalBridgeClazz, "addExact", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StrictMath.html#decrementExact(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public static long DecrementExact(long arg0)
        {
            return SExecuteWithSignature<long>(LocalBridgeClazz, "decrementExact", "(J)J", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StrictMath.html#floorDiv(long,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="long"/></returns>
        public static long FloorDiv(long arg0, int arg1)
        {
            return SExecute<long>(LocalBridgeClazz, "floorDiv", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StrictMath.html#floorDiv(long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public static long FloorDiv(long arg0, long arg1)
        {
            return SExecute<long>(LocalBridgeClazz, "floorDiv", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StrictMath.html#floorMod(long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public static long FloorMod(long arg0, long arg1)
        {
            return SExecute<long>(LocalBridgeClazz, "floorMod", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StrictMath.html#incrementExact(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public static long IncrementExact(long arg0)
        {
            return SExecuteWithSignature<long>(LocalBridgeClazz, "incrementExact", "(J)J", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StrictMath.html#max(long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public static long Max(long arg0, long arg1)
        {
            return SExecute<long>(LocalBridgeClazz, "max", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StrictMath.html#min(long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public static long Min(long arg0, long arg1)
        {
            return SExecute<long>(LocalBridgeClazz, "min", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StrictMath.html#multiplyExact(long,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="long"/></returns>
        public static long MultiplyExact(long arg0, int arg1)
        {
            return SExecute<long>(LocalBridgeClazz, "multiplyExact", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StrictMath.html#multiplyExact(long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public static long MultiplyExact(long arg0, long arg1)
        {
            return SExecute<long>(LocalBridgeClazz, "multiplyExact", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StrictMath.html#multiplyFull(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="long"/></returns>
        public static long MultiplyFull(int arg0, int arg1)
        {
            return SExecute<long>(LocalBridgeClazz, "multiplyFull", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StrictMath.html#multiplyHigh(long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public static long MultiplyHigh(long arg0, long arg1)
        {
            return SExecute<long>(LocalBridgeClazz, "multiplyHigh", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StrictMath.html#negateExact(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public static long NegateExact(long arg0)
        {
            return SExecuteWithSignature<long>(LocalBridgeClazz, "negateExact", "(J)J", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StrictMath.html#round(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="long"/></returns>
        public static long Round(double arg0)
        {
            return SExecuteWithSignature<long>(LocalBridgeClazz, "round", "(D)J", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StrictMath.html#subtractExact(long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public static long SubtractExact(long arg0, long arg1)
        {
            return SExecute<long>(LocalBridgeClazz, "subtractExact", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StrictMath.html#acos(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public static double Acos(double arg0)
        {
            return SExecuteWithSignature<double>(LocalBridgeClazz, "acos", "(D)D", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StrictMath.html#asin(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public static double Asin(double arg0)
        {
            return SExecuteWithSignature<double>(LocalBridgeClazz, "asin", "(D)D", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StrictMath.html#atan(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public static double Atan(double arg0)
        {
            return SExecuteWithSignature<double>(LocalBridgeClazz, "atan", "(D)D", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StrictMath.html#atan2(double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public static double Atan2(double arg0, double arg1)
        {
            return SExecute<double>(LocalBridgeClazz, "atan2", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StrictMath.html#cos(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public static double Cos(double arg0)
        {
            return SExecuteWithSignature<double>(LocalBridgeClazz, "cos", "(D)D", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StrictMath.html#cosh(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public static double Cosh(double arg0)
        {
            return SExecuteWithSignature<double>(LocalBridgeClazz, "cosh", "(D)D", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StrictMath.html#expm1(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public static double Expm1(double arg0)
        {
            return SExecuteWithSignature<double>(LocalBridgeClazz, "expm1", "(D)D", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StrictMath.html#IEEEremainder(double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public static double IEEEremainder(double arg0, double arg1)
        {
            return SExecute<double>(LocalBridgeClazz, "IEEEremainder", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StrictMath.html#log(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public static double Log(double arg0)
        {
            return SExecuteWithSignature<double>(LocalBridgeClazz, "log", "(D)D", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StrictMath.html#log10(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public static double Log10(double arg0)
        {
            return SExecuteWithSignature<double>(LocalBridgeClazz, "log10", "(D)D", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StrictMath.html#log1p(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public static double Log1p(double arg0)
        {
            return SExecuteWithSignature<double>(LocalBridgeClazz, "log1p", "(D)D", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StrictMath.html#sin(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public static double Sin(double arg0)
        {
            return SExecuteWithSignature<double>(LocalBridgeClazz, "sin", "(D)D", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StrictMath.html#sinh(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public static double Sinh(double arg0)
        {
            return SExecuteWithSignature<double>(LocalBridgeClazz, "sinh", "(D)D", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StrictMath.html#sqrt(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public static double Sqrt(double arg0)
        {
            return SExecuteWithSignature<double>(LocalBridgeClazz, "sqrt", "(D)D", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StrictMath.html#tan(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public static double Tan(double arg0)
        {
            return SExecuteWithSignature<double>(LocalBridgeClazz, "tan", "(D)D", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StrictMath.html#tanh(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public static double Tanh(double arg0)
        {
            return SExecuteWithSignature<double>(LocalBridgeClazz, "tanh", "(D)D", arg0);
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}