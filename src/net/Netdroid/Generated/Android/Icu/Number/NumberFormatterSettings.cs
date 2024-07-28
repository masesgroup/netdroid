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

namespace Android.Icu.Number
{
    #region NumberFormatterSettings
    public partial class NumberFormatterSettings
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
        /// <see href="https://developer.android.com/reference/android/icu/number/NumberFormatterSettings.html#decimal(android.icu.number.NumberFormatter.DecimalSeparatorDisplay)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Number.NumberFormatter.DecimalSeparatorDisplay"/></param>
        /// <returns><see cref="Android.Icu.Number.NumberFormatterSettings"/></returns>
        public Android.Icu.Number.NumberFormatterSettings Decimal(Android.Icu.Number.NumberFormatter.DecimalSeparatorDisplay arg0)
        {
            return IExecuteWithSignature<Android.Icu.Number.NumberFormatterSettings>("decimal", "(Landroid/icu/number/NumberFormatter$DecimalSeparatorDisplay;)Landroid/icu/number/NumberFormatterSettings;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/number/NumberFormatterSettings.html#displayOptions(android.icu.text.DisplayOptions)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Text.DisplayOptions"/></param>
        /// <returns><see cref="Android.Icu.Number.NumberFormatterSettings"/></returns>
        public Android.Icu.Number.NumberFormatterSettings DisplayOptions(Android.Icu.Text.DisplayOptions arg0)
        {
            return IExecuteWithSignature<Android.Icu.Number.NumberFormatterSettings>("displayOptions", "(Landroid/icu/text/DisplayOptions;)Landroid/icu/number/NumberFormatterSettings;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/number/NumberFormatterSettings.html#grouping(android.icu.number.NumberFormatter.GroupingStrategy)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Number.NumberFormatter.GroupingStrategy"/></param>
        /// <returns><see cref="Android.Icu.Number.NumberFormatterSettings"/></returns>
        public Android.Icu.Number.NumberFormatterSettings Grouping(Android.Icu.Number.NumberFormatter.GroupingStrategy arg0)
        {
            return IExecuteWithSignature<Android.Icu.Number.NumberFormatterSettings>("grouping", "(Landroid/icu/number/NumberFormatter$GroupingStrategy;)Landroid/icu/number/NumberFormatterSettings;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/number/NumberFormatterSettings.html#integerWidth(android.icu.number.IntegerWidth)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Number.IntegerWidth"/></param>
        /// <returns><see cref="Android.Icu.Number.NumberFormatterSettings"/></returns>
        public Android.Icu.Number.NumberFormatterSettings IntegerWidth(Android.Icu.Number.IntegerWidth arg0)
        {
            return IExecuteWithSignature<Android.Icu.Number.NumberFormatterSettings>("integerWidth", "(Landroid/icu/number/IntegerWidth;)Landroid/icu/number/NumberFormatterSettings;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/number/NumberFormatterSettings.html#notation(android.icu.number.Notation)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Number.Notation"/></param>
        /// <returns><see cref="Android.Icu.Number.NumberFormatterSettings"/></returns>
        public Android.Icu.Number.NumberFormatterSettings Notation(Android.Icu.Number.Notation arg0)
        {
            return IExecuteWithSignature<Android.Icu.Number.NumberFormatterSettings>("notation", "(Landroid/icu/number/Notation;)Landroid/icu/number/NumberFormatterSettings;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/number/NumberFormatterSettings.html#perUnit(android.icu.util.MeasureUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Util.MeasureUnit"/></param>
        /// <returns><see cref="Android.Icu.Number.NumberFormatterSettings"/></returns>
        public Android.Icu.Number.NumberFormatterSettings PerUnit(Android.Icu.Util.MeasureUnit arg0)
        {
            return IExecuteWithSignature<Android.Icu.Number.NumberFormatterSettings>("perUnit", "(Landroid/icu/util/MeasureUnit;)Landroid/icu/number/NumberFormatterSettings;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/number/NumberFormatterSettings.html#precision(android.icu.number.Precision)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Number.Precision"/></param>
        /// <returns><see cref="Android.Icu.Number.NumberFormatterSettings"/></returns>
        public Android.Icu.Number.NumberFormatterSettings Precision(Android.Icu.Number.Precision arg0)
        {
            return IExecuteWithSignature<Android.Icu.Number.NumberFormatterSettings>("precision", "(Landroid/icu/number/Precision;)Landroid/icu/number/NumberFormatterSettings;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/number/NumberFormatterSettings.html#roundingMode(java.math.RoundingMode)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.RoundingMode"/></param>
        /// <returns><see cref="Android.Icu.Number.NumberFormatterSettings"/></returns>
        public Android.Icu.Number.NumberFormatterSettings RoundingMode(Java.Math.RoundingMode arg0)
        {
            return IExecuteWithSignature<Android.Icu.Number.NumberFormatterSettings>("roundingMode", "(Ljava/math/RoundingMode;)Landroid/icu/number/NumberFormatterSettings;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/number/NumberFormatterSettings.html#scale(android.icu.number.Scale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Number.Scale"/></param>
        /// <returns><see cref="Android.Icu.Number.NumberFormatterSettings"/></returns>
        public Android.Icu.Number.NumberFormatterSettings Scale(Android.Icu.Number.Scale arg0)
        {
            return IExecuteWithSignature<Android.Icu.Number.NumberFormatterSettings>("scale", "(Landroid/icu/number/Scale;)Landroid/icu/number/NumberFormatterSettings;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/number/NumberFormatterSettings.html#sign(android.icu.number.NumberFormatter.SignDisplay)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Number.NumberFormatter.SignDisplay"/></param>
        /// <returns><see cref="Android.Icu.Number.NumberFormatterSettings"/></returns>
        public Android.Icu.Number.NumberFormatterSettings Sign(Android.Icu.Number.NumberFormatter.SignDisplay arg0)
        {
            return IExecuteWithSignature<Android.Icu.Number.NumberFormatterSettings>("sign", "(Landroid/icu/number/NumberFormatter$SignDisplay;)Landroid/icu/number/NumberFormatterSettings;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/number/NumberFormatterSettings.html#symbols(android.icu.text.DecimalFormatSymbols)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Text.DecimalFormatSymbols"/></param>
        /// <returns><see cref="Android.Icu.Number.NumberFormatterSettings"/></returns>
        public Android.Icu.Number.NumberFormatterSettings Symbols(Android.Icu.Text.DecimalFormatSymbols arg0)
        {
            return IExecuteWithSignature<Android.Icu.Number.NumberFormatterSettings>("symbols", "(Landroid/icu/text/DecimalFormatSymbols;)Landroid/icu/number/NumberFormatterSettings;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/number/NumberFormatterSettings.html#symbols(android.icu.text.NumberingSystem)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Text.NumberingSystem"/></param>
        /// <returns><see cref="Android.Icu.Number.NumberFormatterSettings"/></returns>
        public Android.Icu.Number.NumberFormatterSettings Symbols(Android.Icu.Text.NumberingSystem arg0)
        {
            return IExecuteWithSignature<Android.Icu.Number.NumberFormatterSettings>("symbols", "(Landroid/icu/text/NumberingSystem;)Landroid/icu/number/NumberFormatterSettings;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/number/NumberFormatterSettings.html#unit(android.icu.util.MeasureUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Util.MeasureUnit"/></param>
        /// <returns><see cref="Android.Icu.Number.NumberFormatterSettings"/></returns>
        public Android.Icu.Number.NumberFormatterSettings Unit(Android.Icu.Util.MeasureUnit arg0)
        {
            return IExecuteWithSignature<Android.Icu.Number.NumberFormatterSettings>("unit", "(Landroid/icu/util/MeasureUnit;)Landroid/icu/number/NumberFormatterSettings;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/number/NumberFormatterSettings.html#unitWidth(android.icu.number.NumberFormatter.UnitWidth)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Number.NumberFormatter.UnitWidth"/></param>
        /// <returns><see cref="Android.Icu.Number.NumberFormatterSettings"/></returns>
        public Android.Icu.Number.NumberFormatterSettings UnitWidth(Android.Icu.Number.NumberFormatter.UnitWidth arg0)
        {
            return IExecuteWithSignature<Android.Icu.Number.NumberFormatterSettings>("unitWidth", "(Landroid/icu/number/NumberFormatter$UnitWidth;)Landroid/icu/number/NumberFormatterSettings;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/number/NumberFormatterSettings.html#usage(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Icu.Number.NumberFormatterSettings"/></returns>
        public Android.Icu.Number.NumberFormatterSettings Usage(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Android.Icu.Number.NumberFormatterSettings>("usage", "(Ljava/lang/String;)Landroid/icu/number/NumberFormatterSettings;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region NumberFormatterSettings<T>
    public partial class NumberFormatterSettings<T>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Android.Icu.Number.NumberFormatterSettings{T}"/> to <see cref="Android.Icu.Number.NumberFormatterSettings"/>
        /// </summary>
        public static implicit operator Android.Icu.Number.NumberFormatterSettings(Android.Icu.Number.NumberFormatterSettings<T> t) => t.Cast<Android.Icu.Number.NumberFormatterSettings>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/number/NumberFormatterSettings.html#decimal(android.icu.number.NumberFormatter.DecimalSeparatorDisplay)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Number.NumberFormatter.DecimalSeparatorDisplay"/></param>
        /// <returns><typeparamref name="T"/></returns>
        public T Decimal(Android.Icu.Number.NumberFormatter.DecimalSeparatorDisplay arg0)
        {
            return IExecuteWithSignature<T>("decimal", "(Landroid/icu/number/NumberFormatter$DecimalSeparatorDisplay;)Landroid/icu/number/NumberFormatterSettings;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/number/NumberFormatterSettings.html#displayOptions(android.icu.text.DisplayOptions)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Text.DisplayOptions"/></param>
        /// <returns><typeparamref name="T"/></returns>
        public T DisplayOptions(Android.Icu.Text.DisplayOptions arg0)
        {
            return IExecuteWithSignature<T>("displayOptions", "(Landroid/icu/text/DisplayOptions;)Landroid/icu/number/NumberFormatterSettings;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/number/NumberFormatterSettings.html#grouping(android.icu.number.NumberFormatter.GroupingStrategy)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Number.NumberFormatter.GroupingStrategy"/></param>
        /// <returns><typeparamref name="T"/></returns>
        public T Grouping(Android.Icu.Number.NumberFormatter.GroupingStrategy arg0)
        {
            return IExecuteWithSignature<T>("grouping", "(Landroid/icu/number/NumberFormatter$GroupingStrategy;)Landroid/icu/number/NumberFormatterSettings;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/number/NumberFormatterSettings.html#integerWidth(android.icu.number.IntegerWidth)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Number.IntegerWidth"/></param>
        /// <returns><typeparamref name="T"/></returns>
        public T IntegerWidth(Android.Icu.Number.IntegerWidth arg0)
        {
            return IExecuteWithSignature<T>("integerWidth", "(Landroid/icu/number/IntegerWidth;)Landroid/icu/number/NumberFormatterSettings;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/number/NumberFormatterSettings.html#notation(android.icu.number.Notation)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Number.Notation"/></param>
        /// <returns><typeparamref name="T"/></returns>
        public T Notation(Android.Icu.Number.Notation arg0)
        {
            return IExecuteWithSignature<T>("notation", "(Landroid/icu/number/Notation;)Landroid/icu/number/NumberFormatterSettings;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/number/NumberFormatterSettings.html#perUnit(android.icu.util.MeasureUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Util.MeasureUnit"/></param>
        /// <returns><typeparamref name="T"/></returns>
        public T PerUnit(Android.Icu.Util.MeasureUnit arg0)
        {
            return IExecuteWithSignature<T>("perUnit", "(Landroid/icu/util/MeasureUnit;)Landroid/icu/number/NumberFormatterSettings;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/number/NumberFormatterSettings.html#precision(android.icu.number.Precision)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Number.Precision"/></param>
        /// <returns><typeparamref name="T"/></returns>
        public T Precision(Android.Icu.Number.Precision arg0)
        {
            return IExecuteWithSignature<T>("precision", "(Landroid/icu/number/Precision;)Landroid/icu/number/NumberFormatterSettings;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/number/NumberFormatterSettings.html#roundingMode(java.math.RoundingMode)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.RoundingMode"/></param>
        /// <returns><typeparamref name="T"/></returns>
        public T RoundingMode(Java.Math.RoundingMode arg0)
        {
            return IExecuteWithSignature<T>("roundingMode", "(Ljava/math/RoundingMode;)Landroid/icu/number/NumberFormatterSettings;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/number/NumberFormatterSettings.html#scale(android.icu.number.Scale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Number.Scale"/></param>
        /// <returns><typeparamref name="T"/></returns>
        public T Scale(Android.Icu.Number.Scale arg0)
        {
            return IExecuteWithSignature<T>("scale", "(Landroid/icu/number/Scale;)Landroid/icu/number/NumberFormatterSettings;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/number/NumberFormatterSettings.html#sign(android.icu.number.NumberFormatter.SignDisplay)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Number.NumberFormatter.SignDisplay"/></param>
        /// <returns><typeparamref name="T"/></returns>
        public T Sign(Android.Icu.Number.NumberFormatter.SignDisplay arg0)
        {
            return IExecuteWithSignature<T>("sign", "(Landroid/icu/number/NumberFormatter$SignDisplay;)Landroid/icu/number/NumberFormatterSettings;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/number/NumberFormatterSettings.html#symbols(android.icu.text.DecimalFormatSymbols)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Text.DecimalFormatSymbols"/></param>
        /// <returns><typeparamref name="T"/></returns>
        public T Symbols(Android.Icu.Text.DecimalFormatSymbols arg0)
        {
            return IExecuteWithSignature<T>("symbols", "(Landroid/icu/text/DecimalFormatSymbols;)Landroid/icu/number/NumberFormatterSettings;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/number/NumberFormatterSettings.html#symbols(android.icu.text.NumberingSystem)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Text.NumberingSystem"/></param>
        /// <returns><typeparamref name="T"/></returns>
        public T Symbols(Android.Icu.Text.NumberingSystem arg0)
        {
            return IExecuteWithSignature<T>("symbols", "(Landroid/icu/text/NumberingSystem;)Landroid/icu/number/NumberFormatterSettings;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/number/NumberFormatterSettings.html#unit(android.icu.util.MeasureUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Util.MeasureUnit"/></param>
        /// <returns><typeparamref name="T"/></returns>
        public T Unit(Android.Icu.Util.MeasureUnit arg0)
        {
            return IExecuteWithSignature<T>("unit", "(Landroid/icu/util/MeasureUnit;)Landroid/icu/number/NumberFormatterSettings;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/number/NumberFormatterSettings.html#unitWidth(android.icu.number.NumberFormatter.UnitWidth)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Number.NumberFormatter.UnitWidth"/></param>
        /// <returns><typeparamref name="T"/></returns>
        public T UnitWidth(Android.Icu.Number.NumberFormatter.UnitWidth arg0)
        {
            return IExecuteWithSignature<T>("unitWidth", "(Landroid/icu/number/NumberFormatter$UnitWidth;)Landroid/icu/number/NumberFormatterSettings;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/number/NumberFormatterSettings.html#usage(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><typeparamref name="T"/></returns>
        public T Usage(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<T>("usage", "(Ljava/lang/String;)Landroid/icu/number/NumberFormatterSettings;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}