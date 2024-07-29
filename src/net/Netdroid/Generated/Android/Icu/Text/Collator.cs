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

namespace Android.Icu.Text
{
    #region Collator
    public partial class Collator : Java.Util.IComparator<object>, Android.Icu.Util.IFreezable<Android.Icu.Text.Collator>, Java.Lang.ICloneable
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Android.Icu.Text.Collator"/> to <see cref="Java.Util.Comparator"/>
        /// </summary>
        public static implicit operator Java.Util.Comparator(Android.Icu.Text.Collator t) => t.Cast<Java.Util.Comparator>();
        /// <summary>
        /// Converter from <see cref="Android.Icu.Text.Collator"/> to <see cref="Android.Icu.Util.Freezable"/>
        /// </summary>
        public static implicit operator Android.Icu.Util.Freezable(Android.Icu.Text.Collator t) => t.Cast<Android.Icu.Util.Freezable>();
        /// <summary>
        /// Converter from <see cref="Android.Icu.Text.Collator"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Android.Icu.Text.Collator t) => t.Cast<Java.Lang.Cloneable>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Collator.html#CANONICAL_DECOMPOSITION"/>
        /// </summary>
        public static int CANONICAL_DECOMPOSITION { get { if (!_CANONICAL_DECOMPOSITIONReady) { _CANONICAL_DECOMPOSITIONContent = SGetField<int>(LocalBridgeClazz, "CANONICAL_DECOMPOSITION"); _CANONICAL_DECOMPOSITIONReady = true; } return _CANONICAL_DECOMPOSITIONContent; } }
        private static int _CANONICAL_DECOMPOSITIONContent = default;
        private static bool _CANONICAL_DECOMPOSITIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Collator.html#FULL_DECOMPOSITION"/>
        /// </summary>
        public static int FULL_DECOMPOSITION { get { if (!_FULL_DECOMPOSITIONReady) { _FULL_DECOMPOSITIONContent = SGetField<int>(LocalBridgeClazz, "FULL_DECOMPOSITION"); _FULL_DECOMPOSITIONReady = true; } return _FULL_DECOMPOSITIONContent; } }
        private static int _FULL_DECOMPOSITIONContent = default;
        private static bool _FULL_DECOMPOSITIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Collator.html#IDENTICAL"/>
        /// </summary>
        public static int IDENTICAL { get { if (!_IDENTICALReady) { _IDENTICALContent = SGetField<int>(LocalBridgeClazz, "IDENTICAL"); _IDENTICALReady = true; } return _IDENTICALContent; } }
        private static int _IDENTICALContent = default;
        private static bool _IDENTICALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Collator.html#NO_DECOMPOSITION"/>
        /// </summary>
        public static int NO_DECOMPOSITION { get { if (!_NO_DECOMPOSITIONReady) { _NO_DECOMPOSITIONContent = SGetField<int>(LocalBridgeClazz, "NO_DECOMPOSITION"); _NO_DECOMPOSITIONReady = true; } return _NO_DECOMPOSITIONContent; } }
        private static int _NO_DECOMPOSITIONContent = default;
        private static bool _NO_DECOMPOSITIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Collator.html#PRIMARY"/>
        /// </summary>
        public static int PRIMARY { get { if (!_PRIMARYReady) { _PRIMARYContent = SGetField<int>(LocalBridgeClazz, "PRIMARY"); _PRIMARYReady = true; } return _PRIMARYContent; } }
        private static int _PRIMARYContent = default;
        private static bool _PRIMARYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Collator.html#QUATERNARY"/>
        /// </summary>
        public static int QUATERNARY { get { if (!_QUATERNARYReady) { _QUATERNARYContent = SGetField<int>(LocalBridgeClazz, "QUATERNARY"); _QUATERNARYReady = true; } return _QUATERNARYContent; } }
        private static int _QUATERNARYContent = default;
        private static bool _QUATERNARYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Collator.html#SECONDARY"/>
        /// </summary>
        public static int SECONDARY { get { if (!_SECONDARYReady) { _SECONDARYContent = SGetField<int>(LocalBridgeClazz, "SECONDARY"); _SECONDARYReady = true; } return _SECONDARYContent; } }
        private static int _SECONDARYContent = default;
        private static bool _SECONDARYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Collator.html#TERTIARY"/>
        /// </summary>
        public static int TERTIARY { get { if (!_TERTIARYReady) { _TERTIARYContent = SGetField<int>(LocalBridgeClazz, "TERTIARY"); _TERTIARYReady = true; } return _TERTIARYContent; } }
        private static int _TERTIARYContent = default;
        private static bool _TERTIARYReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Collator.html#getInstance()"/>
        /// </summary>
        /// <returns><see cref="Android.Icu.Text.Collator"/></returns>
        public static Android.Icu.Text.Collator GetInstance()
        {
            return SExecuteWithSignature<Android.Icu.Text.Collator>(LocalBridgeClazz, "getInstance", "()Landroid/icu/text/Collator;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Collator.html#getInstance(android.icu.util.ULocale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Util.ULocale"/></param>
        /// <returns><see cref="Android.Icu.Text.Collator"/></returns>
        public static Android.Icu.Text.Collator GetInstance(Android.Icu.Util.ULocale arg0)
        {
            return SExecuteWithSignature<Android.Icu.Text.Collator>(LocalBridgeClazz, "getInstance", "(Landroid/icu/util/ULocale;)Landroid/icu/text/Collator;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Collator.html#getInstance(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Android.Icu.Text.Collator"/></returns>
        public static Android.Icu.Text.Collator GetInstance(Java.Util.Locale arg0)
        {
            return SExecuteWithSignature<Android.Icu.Text.Collator>(LocalBridgeClazz, "getInstance", "(Ljava/util/Locale;)Landroid/icu/text/Collator;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Collator.html#getFunctionalEquivalent(java.lang.String,android.icu.util.ULocale,boolean[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Android.Icu.Util.ULocale"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <returns><see cref="Android.Icu.Util.ULocale"/></returns>
        public static Android.Icu.Util.ULocale GetFunctionalEquivalent(Java.Lang.String arg0, Android.Icu.Util.ULocale arg1, bool[] arg2)
        {
            return SExecute<Android.Icu.Util.ULocale>(LocalBridgeClazz, "getFunctionalEquivalent", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Collator.html#getFunctionalEquivalent(java.lang.String,android.icu.util.ULocale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Android.Icu.Util.ULocale"/></param>
        /// <returns><see cref="Android.Icu.Util.ULocale"/></returns>
        public static Android.Icu.Util.ULocale GetFunctionalEquivalent(Java.Lang.String arg0, Android.Icu.Util.ULocale arg1)
        {
            return SExecute<Android.Icu.Util.ULocale>(LocalBridgeClazz, "getFunctionalEquivalent", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Collator.html#getAvailableULocales()"/>
        /// </summary>
        /// <returns><see cref="Android.Icu.Util.ULocale"/></returns>
        public static Android.Icu.Util.ULocale[] GetAvailableULocales()
        {
            return SExecuteWithSignatureArray<Android.Icu.Util.ULocale>(LocalBridgeClazz, "getAvailableULocales", "()[Landroid/icu/util/ULocale;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Collator.html#getKeywords()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String[] GetKeywords()
        {
            return SExecuteWithSignatureArray<Java.Lang.String>(LocalBridgeClazz, "getKeywords", "()[Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Collator.html#getKeywordValues(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String[] GetKeywordValues(Java.Lang.String arg0)
        {
            return SExecuteWithSignatureArray<Java.Lang.String>(LocalBridgeClazz, "getKeywordValues", "(Ljava/lang/String;)[Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Collator.html#getKeywordValuesForLocale(java.lang.String,android.icu.util.ULocale,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Android.Icu.Util.ULocale"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String[] GetKeywordValuesForLocale(Java.Lang.String arg0, Android.Icu.Util.ULocale arg1, bool arg2)
        {
            return SExecuteArray<Java.Lang.String>(LocalBridgeClazz, "getKeywordValuesForLocale", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Collator.html#getEquivalentReorderCodes(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int[] GetEquivalentReorderCodes(int arg0)
        {
            return SExecuteWithSignatureArray<int>(LocalBridgeClazz, "getEquivalentReorderCodes", "(I)[I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Collator.html#getDisplayName(android.icu.util.ULocale,android.icu.util.ULocale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Util.ULocale"/></param>
        /// <param name="arg1"><see cref="Android.Icu.Util.ULocale"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String GetDisplayName(Android.Icu.Util.ULocale arg0, Android.Icu.Util.ULocale arg1)
        {
            return SExecute<Java.Lang.String>(LocalBridgeClazz, "getDisplayName", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Collator.html#getDisplayName(android.icu.util.ULocale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Util.ULocale"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String GetDisplayName(Android.Icu.Util.ULocale arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "getDisplayName", "(Landroid/icu/util/ULocale;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Collator.html#getDisplayName(java.util.Locale,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String GetDisplayName(Java.Util.Locale arg0, Java.Util.Locale arg1)
        {
            return SExecute<Java.Lang.String>(LocalBridgeClazz, "getDisplayName", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Collator.html#getDisplayName(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String GetDisplayName(Java.Util.Locale arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "getDisplayName", "(Ljava/util/Locale;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Collator.html#getAvailableLocales()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Locale"/></returns>
        public static Java.Util.Locale[] GetAvailableLocales()
        {
            return SExecuteWithSignatureArray<Java.Util.Locale>(LocalBridgeClazz, "getAvailableLocales", "()[Ljava/util/Locale;");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Collator.html#getCollationKey(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Icu.Text.CollationKey"/></returns>
        public Android.Icu.Text.CollationKey GetCollationKey(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Android.Icu.Text.CollationKey>("getCollationKey", "(Ljava/lang/String;)Landroid/icu/text/CollationKey;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Collator.html#getUCAVersion()"/>
        /// </summary>
        /// <returns><see cref="Android.Icu.Util.VersionInfo"/></returns>
        public Android.Icu.Util.VersionInfo GetUCAVersion()
        {
            return IExecuteWithSignature<Android.Icu.Util.VersionInfo>("getUCAVersion", "()Landroid/icu/util/VersionInfo;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Collator.html#getVersion()"/>
        /// </summary>
        /// <returns><see cref="Android.Icu.Util.VersionInfo"/></returns>
        public Android.Icu.Util.VersionInfo GetVersion()
        {
            return IExecuteWithSignature<Android.Icu.Util.VersionInfo>("getVersion", "()Landroid/icu/util/VersionInfo;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Collator.html#compare(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="int"/></returns>
        public int Compare(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return IExecute<int>("compare", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Collator.html#getVariableTop()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetVariableTop()
        {
            return IExecuteWithSignature<int>("getVariableTop", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Collator.html#setMaxVariable(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Icu.Text.Collator"/></returns>
        public Android.Icu.Text.Collator SetMaxVariable(int arg0)
        {
            return IExecuteWithSignature<Android.Icu.Text.Collator>("setMaxVariable", "(I)Landroid/icu/text/Collator;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Collator.html#getTailoredSet()"/>
        /// </summary>
        /// <returns><see cref="Android.Icu.Text.UnicodeSet"/></returns>
        public Android.Icu.Text.UnicodeSet GetTailoredSet()
        {
            return IExecuteWithSignature<Android.Icu.Text.UnicodeSet>("getTailoredSet", "()Landroid/icu/text/UnicodeSet;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Collator.html#equals(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Equals(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return IExecute<bool>("equals", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Collator.html#isFrozen()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsFrozen()
        {
            return IExecuteWithSignature<bool>("isFrozen", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Collator.html#compare(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int Compare(object arg0, object arg1)
        {
            return IExecute<int>("compare", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Collator.html#getDecomposition()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetDecomposition()
        {
            return IExecuteWithSignature<int>("getDecomposition", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Collator.html#getMaxVariable()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetMaxVariable()
        {
            return IExecuteWithSignature<int>("getMaxVariable", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Collator.html#getStrength()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetStrength()
        {
            return IExecuteWithSignature<int>("getStrength", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Collator.html#getReorderCodes()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int[] GetReorderCodes()
        {
            return IExecuteWithSignatureArray<int>("getReorderCodes", "()[I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Collator.html#cloneAsThawed()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        public object CloneAsThawed()
        {
            return IExecuteWithSignature("cloneAsThawed", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Collator.html#freeze()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        public object Freeze()
        {
            return IExecuteWithSignature("freeze", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Collator.html#setDecomposition(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetDecomposition(int arg0)
        {
            IExecuteWithSignature("setDecomposition", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Collator.html#setReorderCodes(int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetReorderCodes(params int[] arg0)
        {
            if (arg0.Length == 0) IExecuteWithSignature("setReorderCodes", "([I)V"); else IExecuteWithSignature("setReorderCodes", "([I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Collator.html#setStrength(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetStrength(int arg0)
        {
            IExecuteWithSignature("setStrength", "(I)V", arg0);
        }

        #endregion

        #region Nested classes
        #region ReorderCodes
        public partial class ReorderCodes
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/Collator.ReorderCodes.html#CURRENCY"/>
            /// </summary>
            public static int CURRENCY { get { if (!_CURRENCYReady) { _CURRENCYContent = SGetField<int>(LocalBridgeClazz, "CURRENCY"); _CURRENCYReady = true; } return _CURRENCYContent; } }
            private static int _CURRENCYContent = default;
            private static bool _CURRENCYReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/Collator.ReorderCodes.html#DEFAULT"/>
            /// </summary>
            public static int DEFAULT { get { if (!_DEFAULTReady) { _DEFAULTContent = SGetField<int>(LocalBridgeClazz, "DEFAULT"); _DEFAULTReady = true; } return _DEFAULTContent; } }
            private static int _DEFAULTContent = default;
            private static bool _DEFAULTReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/Collator.ReorderCodes.html#DIGIT"/>
            /// </summary>
            public static int DIGIT { get { if (!_DIGITReady) { _DIGITContent = SGetField<int>(LocalBridgeClazz, "DIGIT"); _DIGITReady = true; } return _DIGITContent; } }
            private static int _DIGITContent = default;
            private static bool _DIGITReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/Collator.ReorderCodes.html#FIRST"/>
            /// </summary>
            public static int FIRST { get { if (!_FIRSTReady) { _FIRSTContent = SGetField<int>(LocalBridgeClazz, "FIRST"); _FIRSTReady = true; } return _FIRSTContent; } }
            private static int _FIRSTContent = default;
            private static bool _FIRSTReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/Collator.ReorderCodes.html#NONE"/>
            /// </summary>
            public static int NONE { get { if (!_NONEReady) { _NONEContent = SGetField<int>(LocalBridgeClazz, "NONE"); _NONEReady = true; } return _NONEContent; } }
            private static int _NONEContent = default;
            private static bool _NONEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/Collator.ReorderCodes.html#OTHERS"/>
            /// </summary>
            public static int OTHERS { get { if (!_OTHERSReady) { _OTHERSContent = SGetField<int>(LocalBridgeClazz, "OTHERS"); _OTHERSReady = true; } return _OTHERSContent; } }
            private static int _OTHERSContent = default;
            private static bool _OTHERSReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/Collator.ReorderCodes.html#PUNCTUATION"/>
            /// </summary>
            public static int PUNCTUATION { get { if (!_PUNCTUATIONReady) { _PUNCTUATIONContent = SGetField<int>(LocalBridgeClazz, "PUNCTUATION"); _PUNCTUATIONReady = true; } return _PUNCTUATIONContent; } }
            private static int _PUNCTUATIONContent = default;
            private static bool _PUNCTUATIONReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/Collator.ReorderCodes.html#SPACE"/>
            /// </summary>
            public static int SPACE { get { if (!_SPACEReady) { _SPACEContent = SGetField<int>(LocalBridgeClazz, "SPACE"); _SPACEReady = true; } return _SPACEContent; } }
            private static int _SPACEContent = default;
            private static bool _SPACEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/Collator.ReorderCodes.html#SYMBOL"/>
            /// </summary>
            public static int SYMBOL { get { if (!_SYMBOLReady) { _SYMBOLContent = SGetField<int>(LocalBridgeClazz, "SYMBOL"); _SYMBOLReady = true; } return _SYMBOLContent; } }
            private static int _SYMBOLContent = default;
            private static bool _SYMBOLReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}