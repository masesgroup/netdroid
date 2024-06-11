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
    #region UnlocalizedNumberRangeFormatter
    public partial class UnlocalizedNumberRangeFormatter
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
        /// <see href="https://developer.android.com/reference/android/icu/number/UnlocalizedNumberRangeFormatter.html#locale(android.icu.util.ULocale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Util.ULocale"/></param>
        /// <returns><see cref="Android.Icu.Number.LocalizedNumberRangeFormatter"/></returns>
        public Android.Icu.Number.LocalizedNumberRangeFormatter Locale(Android.Icu.Util.ULocale arg0)
        {
            return IExecuteWithSignature<Android.Icu.Number.LocalizedNumberRangeFormatter>("locale", "(Landroid/icu/util/ULocale;)Landroid/icu/number/LocalizedNumberRangeFormatter;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/number/UnlocalizedNumberRangeFormatter.html#locale(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Android.Icu.Number.LocalizedNumberRangeFormatter"/></returns>
        public Android.Icu.Number.LocalizedNumberRangeFormatter Locale(Java.Util.Locale arg0)
        {
            return IExecuteWithSignature<Android.Icu.Number.LocalizedNumberRangeFormatter>("locale", "(Ljava/util/Locale;)Landroid/icu/number/LocalizedNumberRangeFormatter;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}