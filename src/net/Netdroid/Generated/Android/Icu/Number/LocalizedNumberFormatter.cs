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
*  This file is generated by MASES.JNetReflector (ver. 2.5.6.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Icu.Number
{
    #region LocalizedNumberFormatter
    public partial class LocalizedNumberFormatter
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
        /// <see href="https://developer.android.com/reference/android/icu/number/LocalizedNumberFormatter.html#format(android.icu.util.Measure)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Util.Measure"/></param>
        /// <returns><see cref="Android.Icu.Number.FormattedNumber"/></returns>
        public Android.Icu.Number.FormattedNumber Format(Android.Icu.Util.Measure arg0)
        {
            return IExecuteWithSignature<Android.Icu.Number.FormattedNumber>("format", "(Landroid/icu/util/Measure;)Landroid/icu/number/FormattedNumber;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/number/LocalizedNumberFormatter.html#format(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="Android.Icu.Number.FormattedNumber"/></returns>
        public Android.Icu.Number.FormattedNumber Format(double arg0)
        {
            return IExecuteWithSignature<Android.Icu.Number.FormattedNumber>("format", "(D)Landroid/icu/number/FormattedNumber;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/number/LocalizedNumberFormatter.html#format(java.lang.Number)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Number"/></param>
        /// <returns><see cref="Android.Icu.Number.FormattedNumber"/></returns>
        public Android.Icu.Number.FormattedNumber Format(Java.Lang.Number arg0)
        {
            return IExecuteWithSignature<Android.Icu.Number.FormattedNumber>("format", "(Ljava/lang/Number;)Landroid/icu/number/FormattedNumber;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/number/LocalizedNumberFormatter.html#format(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Android.Icu.Number.FormattedNumber"/></returns>
        public Android.Icu.Number.FormattedNumber Format(long arg0)
        {
            return IExecuteWithSignature<Android.Icu.Number.FormattedNumber>("format", "(J)Landroid/icu/number/FormattedNumber;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/number/LocalizedNumberFormatter.html#toFormat()"/>
        /// </summary>
        /// <returns><see cref="Java.Text.Format"/></returns>
        public Java.Text.Format ToFormat()
        {
            return IExecuteWithSignature<Java.Text.Format>("toFormat", "()Ljava/text/Format;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}