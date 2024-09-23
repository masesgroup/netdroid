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
*  This file is generated by MASES.JNetReflector (ver. 2.5.9.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Icu.Text
{
    #region DecimalFormat declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/icu/text/DecimalFormat.html"/>
    /// </summary>
    public partial class DecimalFormat : Android.Icu.Text.NumberFormat
    {
        const string _bridgeClassName = "android.icu.text.DecimalFormat";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public DecimalFormat() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public DecimalFormat(params object[] args) : base(args) { }
    
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
    
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;
    
        // TODO: complete the class
    
    }
    #endregion

    #region DecimalFormat implementation
    public partial class DecimalFormat
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DecimalFormat.html#%3Cinit%3E(java.lang.String,android.icu.text.DecimalFormatSymbols,android.icu.text.CurrencyPluralInfo,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Android.Icu.Text.DecimalFormatSymbols"/></param>
        /// <param name="arg2"><see cref="Android.Icu.Text.CurrencyPluralInfo"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public DecimalFormat(Java.Lang.String arg0, Android.Icu.Text.DecimalFormatSymbols arg1, Android.Icu.Text.CurrencyPluralInfo arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DecimalFormat.html#%3Cinit%3E(java.lang.String,android.icu.text.DecimalFormatSymbols)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Android.Icu.Text.DecimalFormatSymbols"/></param>
        public DecimalFormat(Java.Lang.String arg0, Android.Icu.Text.DecimalFormatSymbols arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DecimalFormat.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public DecimalFormat(Java.Lang.String arg0)
            : base(arg0)
        {
        }
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DecimalFormat.html#MINIMUM_GROUPING_DIGITS_AUTO"/>
        /// </summary>
        public static int MINIMUM_GROUPING_DIGITS_AUTO { get { if (!_MINIMUM_GROUPING_DIGITS_AUTOReady) { _MINIMUM_GROUPING_DIGITS_AUTOContent = SGetField<int>(LocalBridgeClazz, "MINIMUM_GROUPING_DIGITS_AUTO"); _MINIMUM_GROUPING_DIGITS_AUTOReady = true; } return _MINIMUM_GROUPING_DIGITS_AUTOContent; } }
        private static int _MINIMUM_GROUPING_DIGITS_AUTOContent = default;
        private static bool _MINIMUM_GROUPING_DIGITS_AUTOReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DecimalFormat.html#MINIMUM_GROUPING_DIGITS_MIN2"/>
        /// </summary>
        public static int MINIMUM_GROUPING_DIGITS_MIN2 { get { if (!_MINIMUM_GROUPING_DIGITS_MIN2Ready) { _MINIMUM_GROUPING_DIGITS_MIN2Content = SGetField<int>(LocalBridgeClazz, "MINIMUM_GROUPING_DIGITS_MIN2"); _MINIMUM_GROUPING_DIGITS_MIN2Ready = true; } return _MINIMUM_GROUPING_DIGITS_MIN2Content; } }
        private static int _MINIMUM_GROUPING_DIGITS_MIN2Content = default;
        private static bool _MINIMUM_GROUPING_DIGITS_MIN2Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DecimalFormat.html#PAD_AFTER_PREFIX"/>
        /// </summary>
        public static int PAD_AFTER_PREFIX { get { if (!_PAD_AFTER_PREFIXReady) { _PAD_AFTER_PREFIXContent = SGetField<int>(LocalBridgeClazz, "PAD_AFTER_PREFIX"); _PAD_AFTER_PREFIXReady = true; } return _PAD_AFTER_PREFIXContent; } }
        private static int _PAD_AFTER_PREFIXContent = default;
        private static bool _PAD_AFTER_PREFIXReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DecimalFormat.html#PAD_AFTER_SUFFIX"/>
        /// </summary>
        public static int PAD_AFTER_SUFFIX { get { if (!_PAD_AFTER_SUFFIXReady) { _PAD_AFTER_SUFFIXContent = SGetField<int>(LocalBridgeClazz, "PAD_AFTER_SUFFIX"); _PAD_AFTER_SUFFIXReady = true; } return _PAD_AFTER_SUFFIXContent; } }
        private static int _PAD_AFTER_SUFFIXContent = default;
        private static bool _PAD_AFTER_SUFFIXReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DecimalFormat.html#PAD_BEFORE_PREFIX"/>
        /// </summary>
        public static int PAD_BEFORE_PREFIX { get { if (!_PAD_BEFORE_PREFIXReady) { _PAD_BEFORE_PREFIXContent = SGetField<int>(LocalBridgeClazz, "PAD_BEFORE_PREFIX"); _PAD_BEFORE_PREFIXReady = true; } return _PAD_BEFORE_PREFIXContent; } }
        private static int _PAD_BEFORE_PREFIXContent = default;
        private static bool _PAD_BEFORE_PREFIXReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DecimalFormat.html#PAD_BEFORE_SUFFIX"/>
        /// </summary>
        public static int PAD_BEFORE_SUFFIX { get { if (!_PAD_BEFORE_SUFFIXReady) { _PAD_BEFORE_SUFFIXContent = SGetField<int>(LocalBridgeClazz, "PAD_BEFORE_SUFFIX"); _PAD_BEFORE_SUFFIXReady = true; } return _PAD_BEFORE_SUFFIXContent; } }
        private static int _PAD_BEFORE_SUFFIXContent = default;
        private static bool _PAD_BEFORE_SUFFIXReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DecimalFormat.html#getParseMaxDigits()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int GetParseMaxDigits()
        {
            return IExecuteWithSignature<int>("getParseMaxDigits", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DecimalFormat.html#getMathContextICU()"/>
        /// </summary>
        /// <returns><see cref="Android.Icu.Math.MathContext"/></returns>
        public Android.Icu.Math.MathContext GetMathContextICU()
        {
            return IExecuteWithSignature<Android.Icu.Math.MathContext>("getMathContextICU", "()Landroid/icu/math/MathContext;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DecimalFormat.html#getCurrencyPluralInfo()"/>
        /// </summary>
        /// <returns><see cref="Android.Icu.Text.CurrencyPluralInfo"/></returns>
        public Android.Icu.Text.CurrencyPluralInfo GetCurrencyPluralInfo()
        {
            return IExecuteWithSignature<Android.Icu.Text.CurrencyPluralInfo>("getCurrencyPluralInfo", "()Landroid/icu/text/CurrencyPluralInfo;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DecimalFormat.html#getDecimalFormatSymbols()"/>
        /// </summary>
        /// <returns><see cref="Android.Icu.Text.DecimalFormatSymbols"/></returns>
        public Android.Icu.Text.DecimalFormatSymbols GetDecimalFormatSymbols()
        {
            return IExecuteWithSignature<Android.Icu.Text.DecimalFormatSymbols>("getDecimalFormatSymbols", "()Landroid/icu/text/DecimalFormatSymbols;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DecimalFormat.html#getCurrencyUsage()"/>
        /// </summary>
        /// <returns><see cref="Android.Icu.Util.Currency.CurrencyUsage"/></returns>
        public Android.Icu.Util.Currency.CurrencyUsage GetCurrencyUsage()
        {
            return IExecuteWithSignature<Android.Icu.Util.Currency.CurrencyUsage>("getCurrencyUsage", "()Landroid/icu/util/Currency$CurrencyUsage;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DecimalFormat.html#areSignificantDigitsUsed()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool AreSignificantDigitsUsed()
        {
            return IExecuteWithSignature<bool>("areSignificantDigitsUsed", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DecimalFormat.html#isDecimalPatternMatchRequired()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsDecimalPatternMatchRequired()
        {
            return IExecuteWithSignature<bool>("isDecimalPatternMatchRequired", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DecimalFormat.html#isDecimalSeparatorAlwaysShown()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsDecimalSeparatorAlwaysShown()
        {
            return IExecuteWithSignature<bool>("isDecimalSeparatorAlwaysShown", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DecimalFormat.html#isExponentSignAlwaysShown()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsExponentSignAlwaysShown()
        {
            return IExecuteWithSignature<bool>("isExponentSignAlwaysShown", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DecimalFormat.html#isParseBigDecimal()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsParseBigDecimal()
        {
            return IExecuteWithSignature<bool>("isParseBigDecimal", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DecimalFormat.html#isParseCaseSensitive()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsParseCaseSensitive()
        {
            return IExecuteWithSignature<bool>("isParseCaseSensitive", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DecimalFormat.html#isParseNoExponent()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsParseNoExponent()
        {
            return IExecuteWithSignature<bool>("isParseNoExponent", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DecimalFormat.html#isScientificNotation()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsScientificNotation()
        {
            return IExecuteWithSignature<bool>("isScientificNotation", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DecimalFormat.html#isSignAlwaysShown()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsSignAlwaysShown()
        {
            return IExecuteWithSignature<bool>("isSignAlwaysShown", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DecimalFormat.html#getMinimumExponentDigits()"/>
        /// </summary>
        /// <returns><see cref="byte"/></returns>
        public byte GetMinimumExponentDigits()
        {
            return IExecuteWithSignature<byte>("getMinimumExponentDigits", "()B");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DecimalFormat.html#getPadCharacter()"/>
        /// </summary>
        /// <returns><see cref="char"/></returns>
        public char GetPadCharacter()
        {
            return IExecuteWithSignature<char>("getPadCharacter", "()C");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DecimalFormat.html#getFormatWidth()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetFormatWidth()
        {
            return IExecuteWithSignature<int>("getFormatWidth", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DecimalFormat.html#getGroupingSize()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetGroupingSize()
        {
            return IExecuteWithSignature<int>("getGroupingSize", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DecimalFormat.html#getMaximumSignificantDigits()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetMaximumSignificantDigits()
        {
            return IExecuteWithSignature<int>("getMaximumSignificantDigits", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DecimalFormat.html#getMinimumGroupingDigits()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetMinimumGroupingDigits()
        {
            return IExecuteWithSignature<int>("getMinimumGroupingDigits", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DecimalFormat.html#getMinimumSignificantDigits()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetMinimumSignificantDigits()
        {
            return IExecuteWithSignature<int>("getMinimumSignificantDigits", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DecimalFormat.html#getMultiplier()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetMultiplier()
        {
            return IExecuteWithSignature<int>("getMultiplier", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DecimalFormat.html#getPadPosition()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetPadPosition()
        {
            return IExecuteWithSignature<int>("getPadPosition", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DecimalFormat.html#getSecondaryGroupingSize()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetSecondaryGroupingSize()
        {
            return IExecuteWithSignature<int>("getSecondaryGroupingSize", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DecimalFormat.html#getNegativePrefix()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetNegativePrefix()
        {
            return IExecuteWithSignature<Java.Lang.String>("getNegativePrefix", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DecimalFormat.html#getNegativeSuffix()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetNegativeSuffix()
        {
            return IExecuteWithSignature<Java.Lang.String>("getNegativeSuffix", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DecimalFormat.html#getPositivePrefix()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetPositivePrefix()
        {
            return IExecuteWithSignature<Java.Lang.String>("getPositivePrefix", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DecimalFormat.html#getPositiveSuffix()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetPositiveSuffix()
        {
            return IExecuteWithSignature<Java.Lang.String>("getPositiveSuffix", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DecimalFormat.html#toLocalizedPattern()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String ToLocalizedPattern()
        {
            return IExecuteWithSignature<Java.Lang.String>("toLocalizedPattern", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DecimalFormat.html#toPattern()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String ToPattern()
        {
            return IExecuteWithSignature<Java.Lang.String>("toPattern", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DecimalFormat.html#getRoundingIncrement()"/>
        /// </summary>
        /// <returns><see cref="Java.Math.BigDecimal"/></returns>
        public Java.Math.BigDecimal GetRoundingIncrement()
        {
            return IExecuteWithSignature<Java.Math.BigDecimal>("getRoundingIncrement", "()Ljava/math/BigDecimal;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DecimalFormat.html#getMathContext()"/>
        /// </summary>
        /// <returns><see cref="Java.Math.MathContext"/></returns>
        public Java.Math.MathContext GetMathContext()
        {
            return IExecuteWithSignature<Java.Math.MathContext>("getMathContext", "()Ljava/math/MathContext;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DecimalFormat.html#applyLocalizedPattern(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void ApplyLocalizedPattern(Java.Lang.String arg0)
        {
            IExecuteWithSignature("applyLocalizedPattern", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DecimalFormat.html#applyPattern(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void ApplyPattern(Java.Lang.String arg0)
        {
            IExecuteWithSignature("applyPattern", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DecimalFormat.html#setCurrencyPluralInfo(android.icu.text.CurrencyPluralInfo)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Text.CurrencyPluralInfo"/></param>
        public void SetCurrencyPluralInfo(Android.Icu.Text.CurrencyPluralInfo arg0)
        {
            IExecuteWithSignature("setCurrencyPluralInfo", "(Landroid/icu/text/CurrencyPluralInfo;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DecimalFormat.html#setCurrencyUsage(android.icu.util.Currency.CurrencyUsage)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Util.Currency.CurrencyUsage"/></param>
        public void SetCurrencyUsage(Android.Icu.Util.Currency.CurrencyUsage arg0)
        {
            IExecuteWithSignature("setCurrencyUsage", "(Landroid/icu/util/Currency$CurrencyUsage;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DecimalFormat.html#setDecimalFormatSymbols(android.icu.text.DecimalFormatSymbols)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Text.DecimalFormatSymbols"/></param>
        public void SetDecimalFormatSymbols(Android.Icu.Text.DecimalFormatSymbols arg0)
        {
            IExecuteWithSignature("setDecimalFormatSymbols", "(Landroid/icu/text/DecimalFormatSymbols;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DecimalFormat.html#setDecimalPatternMatchRequired(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetDecimalPatternMatchRequired(bool arg0)
        {
            IExecuteWithSignature("setDecimalPatternMatchRequired", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DecimalFormat.html#setDecimalSeparatorAlwaysShown(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetDecimalSeparatorAlwaysShown(bool arg0)
        {
            IExecuteWithSignature("setDecimalSeparatorAlwaysShown", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DecimalFormat.html#setExponentSignAlwaysShown(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetExponentSignAlwaysShown(bool arg0)
        {
            IExecuteWithSignature("setExponentSignAlwaysShown", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DecimalFormat.html#setFormatWidth(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetFormatWidth(int arg0)
        {
            IExecuteWithSignature("setFormatWidth", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DecimalFormat.html#setGroupingSize(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetGroupingSize(int arg0)
        {
            IExecuteWithSignature("setGroupingSize", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DecimalFormat.html#setMathContext(java.math.MathContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.MathContext"/></param>
        public void SetMathContext(Java.Math.MathContext arg0)
        {
            IExecuteWithSignature("setMathContext", "(Ljava/math/MathContext;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DecimalFormat.html#setMathContextICU(android.icu.math.MathContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Math.MathContext"/></param>
        public void SetMathContextICU(Android.Icu.Math.MathContext arg0)
        {
            IExecuteWithSignature("setMathContextICU", "(Landroid/icu/math/MathContext;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DecimalFormat.html#setMaximumSignificantDigits(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetMaximumSignificantDigits(int arg0)
        {
            IExecuteWithSignature("setMaximumSignificantDigits", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DecimalFormat.html#setMinimumExponentDigits(byte)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        public void SetMinimumExponentDigits(byte arg0)
        {
            IExecuteWithSignature("setMinimumExponentDigits", "(B)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DecimalFormat.html#setMinimumGroupingDigits(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetMinimumGroupingDigits(int arg0)
        {
            IExecuteWithSignature("setMinimumGroupingDigits", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DecimalFormat.html#setMinimumSignificantDigits(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetMinimumSignificantDigits(int arg0)
        {
            IExecuteWithSignature("setMinimumSignificantDigits", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DecimalFormat.html#setMultiplier(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetMultiplier(int arg0)
        {
            IExecuteWithSignature("setMultiplier", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DecimalFormat.html#setNegativePrefix(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetNegativePrefix(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setNegativePrefix", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DecimalFormat.html#setNegativeSuffix(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetNegativeSuffix(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setNegativeSuffix", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DecimalFormat.html#setPadCharacter(char)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        public void SetPadCharacter(char arg0)
        {
            IExecuteWithSignature("setPadCharacter", "(C)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DecimalFormat.html#setPadPosition(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetPadPosition(int arg0)
        {
            IExecuteWithSignature("setPadPosition", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DecimalFormat.html#setParseBigDecimal(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetParseBigDecimal(bool arg0)
        {
            IExecuteWithSignature("setParseBigDecimal", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DecimalFormat.html#setParseCaseSensitive(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetParseCaseSensitive(bool arg0)
        {
            IExecuteWithSignature("setParseCaseSensitive", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DecimalFormat.html#setParseNoExponent(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetParseNoExponent(bool arg0)
        {
            IExecuteWithSignature("setParseNoExponent", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DecimalFormat.html#setPositivePrefix(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetPositivePrefix(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setPositivePrefix", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DecimalFormat.html#setPositiveSuffix(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetPositiveSuffix(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setPositiveSuffix", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DecimalFormat.html#setRoundingIncrement(android.icu.math.BigDecimal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Math.BigDecimal"/></param>
        public void SetRoundingIncrement(Android.Icu.Math.BigDecimal arg0)
        {
            IExecuteWithSignature("setRoundingIncrement", "(Landroid/icu/math/BigDecimal;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DecimalFormat.html#setRoundingIncrement(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        public void SetRoundingIncrement(double arg0)
        {
            IExecuteWithSignature("setRoundingIncrement", "(D)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DecimalFormat.html#setRoundingIncrement(java.math.BigDecimal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigDecimal"/></param>
        public void SetRoundingIncrement(Java.Math.BigDecimal arg0)
        {
            IExecuteWithSignature("setRoundingIncrement", "(Ljava/math/BigDecimal;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DecimalFormat.html#setScientificNotation(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetScientificNotation(bool arg0)
        {
            IExecuteWithSignature("setScientificNotation", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DecimalFormat.html#setSecondaryGroupingSize(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetSecondaryGroupingSize(int arg0)
        {
            IExecuteWithSignature("setSecondaryGroupingSize", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DecimalFormat.html#setSignAlwaysShown(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetSignAlwaysShown(bool arg0)
        {
            IExecuteWithSignature("setSignAlwaysShown", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DecimalFormat.html#setSignificantDigitsUsed(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetSignificantDigitsUsed(bool arg0)
        {
            IExecuteWithSignature("setSignificantDigitsUsed", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DecimalFormat.html#setParseMaxDigits(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        [global::System.Obsolete()]
        public void SetParseMaxDigits(int arg0)
        {
            IExecuteWithSignature("setParseMaxDigits", "(I)V", arg0);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}