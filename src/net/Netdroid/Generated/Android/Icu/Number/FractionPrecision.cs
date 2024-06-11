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
*  This file is generated by MASES.JNetReflector (ver. 2.5.2.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Icu.Number
{
    #region FractionPrecision
    public partial class FractionPrecision
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
        /// <see href="https://developer.android.com/reference/android/icu/number/FractionPrecision.html#withMaxDigits(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Icu.Number.Precision"/></returns>
        public Android.Icu.Number.Precision WithMaxDigits(int arg0)
        {
            return IExecuteWithSignature<Android.Icu.Number.Precision>("withMaxDigits", "(I)Landroid/icu/number/Precision;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/number/FractionPrecision.html#withMinDigits(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Icu.Number.Precision"/></returns>
        public Android.Icu.Number.Precision WithMinDigits(int arg0)
        {
            return IExecuteWithSignature<Android.Icu.Number.Precision>("withMinDigits", "(I)Landroid/icu/number/Precision;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/number/FractionPrecision.html#withSignificantDigits(int,int,android.icu.number.NumberFormatter.RoundingPriority)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Android.Icu.Number.NumberFormatter.RoundingPriority"/></param>
        /// <returns><see cref="Android.Icu.Number.Precision"/></returns>
        public Android.Icu.Number.Precision WithSignificantDigits(int arg0, int arg1, Android.Icu.Number.NumberFormatter.RoundingPriority arg2)
        {
            return IExecute<Android.Icu.Number.Precision>("withSignificantDigits", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}