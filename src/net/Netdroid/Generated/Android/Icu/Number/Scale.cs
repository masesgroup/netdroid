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

namespace Android.Icu.Number
{
    #region Scale
    public partial class Scale
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/number/Scale.html#byBigDecimal(java.math.BigDecimal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigDecimal"/></param>
        /// <returns><see cref="Android.Icu.Number.Scale"/></returns>
        public static Android.Icu.Number.Scale ByBigDecimal(Java.Math.BigDecimal arg0)
        {
            return SExecuteWithSignature<Android.Icu.Number.Scale>(LocalBridgeClazz, "byBigDecimal", "(Ljava/math/BigDecimal;)Landroid/icu/number/Scale;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/number/Scale.html#byDouble(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="Android.Icu.Number.Scale"/></returns>
        public static Android.Icu.Number.Scale ByDouble(double arg0)
        {
            return SExecuteWithSignature<Android.Icu.Number.Scale>(LocalBridgeClazz, "byDouble", "(D)Landroid/icu/number/Scale;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/number/Scale.html#byDoubleAndPowerOfTen(double,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Android.Icu.Number.Scale"/></returns>
        public static Android.Icu.Number.Scale ByDoubleAndPowerOfTen(double arg0, int arg1)
        {
            return SExecute<Android.Icu.Number.Scale>(LocalBridgeClazz, "byDoubleAndPowerOfTen", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/number/Scale.html#none()"/>
        /// </summary>
        /// <returns><see cref="Android.Icu.Number.Scale"/></returns>
        public static Android.Icu.Number.Scale None()
        {
            return SExecuteWithSignature<Android.Icu.Number.Scale>(LocalBridgeClazz, "none", "()Landroid/icu/number/Scale;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/number/Scale.html#powerOfTen(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Icu.Number.Scale"/></returns>
        public static Android.Icu.Number.Scale PowerOfTen(int arg0)
        {
            return SExecuteWithSignature<Android.Icu.Number.Scale>(LocalBridgeClazz, "powerOfTen", "(I)Landroid/icu/number/Scale;", arg0);
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