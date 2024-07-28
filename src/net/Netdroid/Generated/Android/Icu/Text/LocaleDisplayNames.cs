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

namespace Android.Icu.Text
{
    #region LocaleDisplayNames
    public partial class LocaleDisplayNames
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/LocaleDisplayNames.html#getInstance(android.icu.util.ULocale,android.icu.text.DisplayContext[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Util.ULocale"/></param>
        /// <param name="arg1"><see cref="Android.Icu.Text.DisplayContext"/></param>
        /// <returns><see cref="Android.Icu.Text.LocaleDisplayNames"/></returns>
        public static Android.Icu.Text.LocaleDisplayNames GetInstance(Android.Icu.Util.ULocale arg0, params Android.Icu.Text.DisplayContext[] arg1)
        {
            if (arg1.Length == 0) return SExecute<Android.Icu.Text.LocaleDisplayNames>(LocalBridgeClazz, "getInstance", arg0); else return SExecute<Android.Icu.Text.LocaleDisplayNames>(LocalBridgeClazz, "getInstance", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/LocaleDisplayNames.html#getInstance(android.icu.util.ULocale,android.icu.text.LocaleDisplayNames.DialectHandling)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Util.ULocale"/></param>
        /// <param name="arg1"><see cref="Android.Icu.Text.LocaleDisplayNames.DialectHandling"/></param>
        /// <returns><see cref="Android.Icu.Text.LocaleDisplayNames"/></returns>
        public static Android.Icu.Text.LocaleDisplayNames GetInstance(Android.Icu.Util.ULocale arg0, Android.Icu.Text.LocaleDisplayNames.DialectHandling arg1)
        {
            return SExecute<Android.Icu.Text.LocaleDisplayNames>(LocalBridgeClazz, "getInstance", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/LocaleDisplayNames.html#getInstance(android.icu.util.ULocale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Util.ULocale"/></param>
        /// <returns><see cref="Android.Icu.Text.LocaleDisplayNames"/></returns>
        public static Android.Icu.Text.LocaleDisplayNames GetInstance(Android.Icu.Util.ULocale arg0)
        {
            return SExecuteWithSignature<Android.Icu.Text.LocaleDisplayNames>(LocalBridgeClazz, "getInstance", "(Landroid/icu/util/ULocale;)Landroid/icu/text/LocaleDisplayNames;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/LocaleDisplayNames.html#getInstance(java.util.Locale,android.icu.text.DisplayContext[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <param name="arg1"><see cref="Android.Icu.Text.DisplayContext"/></param>
        /// <returns><see cref="Android.Icu.Text.LocaleDisplayNames"/></returns>
        public static Android.Icu.Text.LocaleDisplayNames GetInstance(Java.Util.Locale arg0, params Android.Icu.Text.DisplayContext[] arg1)
        {
            if (arg1.Length == 0) return SExecute<Android.Icu.Text.LocaleDisplayNames>(LocalBridgeClazz, "getInstance", arg0); else return SExecute<Android.Icu.Text.LocaleDisplayNames>(LocalBridgeClazz, "getInstance", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/LocaleDisplayNames.html#getInstance(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Android.Icu.Text.LocaleDisplayNames"/></returns>
        public static Android.Icu.Text.LocaleDisplayNames GetInstance(Java.Util.Locale arg0)
        {
            return SExecuteWithSignature<Android.Icu.Text.LocaleDisplayNames>(LocalBridgeClazz, "getInstance", "(Ljava/util/Locale;)Landroid/icu/text/LocaleDisplayNames;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/LocaleDisplayNames.html#getContext(android.icu.text.DisplayContext.Type)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Text.DisplayContext.Type"/></param>
        /// <returns><see cref="Android.Icu.Text.DisplayContext"/></returns>
        public Android.Icu.Text.DisplayContext GetContext(Android.Icu.Text.DisplayContext.Type arg0)
        {
            return IExecuteWithSignature<Android.Icu.Text.DisplayContext>("getContext", "(Landroid/icu/text/DisplayContext$Type;)Landroid/icu/text/DisplayContext;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/LocaleDisplayNames.html#getDialectHandling()"/>
        /// </summary>
        /// <returns><see cref="Android.Icu.Text.LocaleDisplayNames.DialectHandling"/></returns>
        public Android.Icu.Text.LocaleDisplayNames.DialectHandling GetDialectHandling()
        {
            return IExecuteWithSignature<Android.Icu.Text.LocaleDisplayNames.DialectHandling>("getDialectHandling", "()Landroid/icu/text/LocaleDisplayNames$DialectHandling;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/LocaleDisplayNames.html#getLocale()"/>
        /// </summary>
        /// <returns><see cref="Android.Icu.Util.ULocale"/></returns>
        public Android.Icu.Util.ULocale GetLocale()
        {
            return IExecuteWithSignature<Android.Icu.Util.ULocale>("getLocale", "()Landroid/icu/util/ULocale;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/LocaleDisplayNames.html#keyDisplayName(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String KeyDisplayName(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("keyDisplayName", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/LocaleDisplayNames.html#keyValueDisplayName(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String KeyValueDisplayName(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return IExecute<Java.Lang.String>("keyValueDisplayName", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/LocaleDisplayNames.html#languageDisplayName(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String LanguageDisplayName(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("languageDisplayName", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/LocaleDisplayNames.html#localeDisplayName(android.icu.util.ULocale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Util.ULocale"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String LocaleDisplayName(Android.Icu.Util.ULocale arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("localeDisplayName", "(Landroid/icu/util/ULocale;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/LocaleDisplayNames.html#localeDisplayName(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String LocaleDisplayName(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("localeDisplayName", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/LocaleDisplayNames.html#localeDisplayName(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String LocaleDisplayName(Java.Util.Locale arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("localeDisplayName", "(Ljava/util/Locale;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/LocaleDisplayNames.html#regionDisplayName(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String RegionDisplayName(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("regionDisplayName", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/LocaleDisplayNames.html#scriptDisplayName(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String ScriptDisplayName(int arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("scriptDisplayName", "(I)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/LocaleDisplayNames.html#scriptDisplayName(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String ScriptDisplayName(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("scriptDisplayName", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/LocaleDisplayNames.html#variantDisplayName(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String VariantDisplayName(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("variantDisplayName", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/LocaleDisplayNames.html#getUiListCompareWholeItems(java.util.Set,java.util.Comparator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Set"/></param>
        /// <param name="arg1"><see cref="Java.Util.Comparator"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Icu.Text.LocaleDisplayNames.UiListItem> GetUiListCompareWholeItems(Java.Util.Set<Android.Icu.Util.ULocale> arg0, Java.Util.Comparator<Android.Icu.Text.LocaleDisplayNames.UiListItem> arg1)
        {
            return IExecute<Java.Util.List<Android.Icu.Text.LocaleDisplayNames.UiListItem>>("getUiListCompareWholeItems", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/LocaleDisplayNames.html#getUiList(java.util.Set,boolean,java.util.Comparator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Set"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <param name="arg2"><see cref="Java.Util.Comparator"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Icu.Text.LocaleDisplayNames.UiListItem> GetUiList(Java.Util.Set<Android.Icu.Util.ULocale> arg0, bool arg1, Java.Util.Comparator<object> arg2)
        {
            return IExecute<Java.Util.List<Android.Icu.Text.LocaleDisplayNames.UiListItem>>("getUiList", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes
        #region DialectHandling
        public partial class DialectHandling
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/LocaleDisplayNames.DialectHandling.html#DIALECT_NAMES"/>
            /// </summary>
            public static Android.Icu.Text.LocaleDisplayNames.DialectHandling DIALECT_NAMES { get { if (!_DIALECT_NAMESReady) { _DIALECT_NAMESContent = SGetField<Android.Icu.Text.LocaleDisplayNames.DialectHandling>(LocalBridgeClazz, "DIALECT_NAMES"); _DIALECT_NAMESReady = true; } return _DIALECT_NAMESContent; } }
            private static Android.Icu.Text.LocaleDisplayNames.DialectHandling _DIALECT_NAMESContent = default;
            private static bool _DIALECT_NAMESReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/LocaleDisplayNames.DialectHandling.html#STANDARD_NAMES"/>
            /// </summary>
            public static Android.Icu.Text.LocaleDisplayNames.DialectHandling STANDARD_NAMES { get { if (!_STANDARD_NAMESReady) { _STANDARD_NAMESContent = SGetField<Android.Icu.Text.LocaleDisplayNames.DialectHandling>(LocalBridgeClazz, "STANDARD_NAMES"); _STANDARD_NAMESReady = true; } return _STANDARD_NAMESContent; } }
            private static Android.Icu.Text.LocaleDisplayNames.DialectHandling _STANDARD_NAMESContent = default;
            private static bool _STANDARD_NAMESReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/LocaleDisplayNames.DialectHandling.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Icu.Text.LocaleDisplayNames.DialectHandling"/></returns>
            public static Android.Icu.Text.LocaleDisplayNames.DialectHandling ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Android.Icu.Text.LocaleDisplayNames.DialectHandling>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Landroid/icu/text/LocaleDisplayNames$DialectHandling;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/LocaleDisplayNames.DialectHandling.html#values()"/>
            /// </summary>
            /// <returns><see cref="Android.Icu.Text.LocaleDisplayNames.DialectHandling"/></returns>
            public static Android.Icu.Text.LocaleDisplayNames.DialectHandling[] Values()
            {
                return SExecuteWithSignatureArray<Android.Icu.Text.LocaleDisplayNames.DialectHandling>(LocalBridgeClazz, "values", "()[Landroid/icu/text/LocaleDisplayNames$DialectHandling;");
            }

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region UiListItem
        public partial class UiListItem
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/LocaleDisplayNames.UiListItem.html#%3Cinit%3E(android.icu.util.ULocale,android.icu.util.ULocale,java.lang.String,java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Icu.Util.ULocale"/></param>
            /// <param name="arg1"><see cref="Android.Icu.Util.ULocale"/></param>
            /// <param name="arg2"><see cref="Java.Lang.String"/></param>
            /// <param name="arg3"><see cref="Java.Lang.String"/></param>
            public UiListItem(Android.Icu.Util.ULocale arg0, Android.Icu.Util.ULocale arg1, Java.Lang.String arg2, Java.Lang.String arg3)
                : base(arg0, arg1, arg2, arg3)
            {
            }

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/LocaleDisplayNames.UiListItem.html#minimized"/>
            /// </summary>
            public Android.Icu.Util.ULocale minimized { get { if (!_minimizedReady) { _minimizedContent = IGetField<Android.Icu.Util.ULocale>("minimized"); _minimizedReady = true; } return _minimizedContent; } }
            private Android.Icu.Util.ULocale _minimizedContent = default;
            private bool _minimizedReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/LocaleDisplayNames.UiListItem.html#modified"/>
            /// </summary>
            public Android.Icu.Util.ULocale modified { get { if (!_modifiedReady) { _modifiedContent = IGetField<Android.Icu.Util.ULocale>("modified"); _modifiedReady = true; } return _modifiedContent; } }
            private Android.Icu.Util.ULocale _modifiedContent = default;
            private bool _modifiedReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/LocaleDisplayNames.UiListItem.html#nameInDisplayLocale"/>
            /// </summary>
            public Java.Lang.String nameInDisplayLocale { get { if (!_nameInDisplayLocaleReady) { _nameInDisplayLocaleContent = IGetField<Java.Lang.String>("nameInDisplayLocale"); _nameInDisplayLocaleReady = true; } return _nameInDisplayLocaleContent; } }
            private Java.Lang.String _nameInDisplayLocaleContent = default;
            private bool _nameInDisplayLocaleReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/LocaleDisplayNames.UiListItem.html#nameInSelf"/>
            /// </summary>
            public Java.Lang.String nameInSelf { get { if (!_nameInSelfReady) { _nameInSelfContent = IGetField<Java.Lang.String>("nameInSelf"); _nameInSelfReady = true; } return _nameInSelfContent; } }
            private Java.Lang.String _nameInSelfContent = default;
            private bool _nameInSelfReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/LocaleDisplayNames.UiListItem.html#getComparator(java.util.Comparator,boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Comparator"/></param>
            /// <param name="arg1"><see cref="bool"/></param>
            /// <returns><see cref="Java.Util.Comparator"/></returns>
            public static Java.Util.Comparator<Android.Icu.Text.LocaleDisplayNames.UiListItem> GetComparator(Java.Util.Comparator<object> arg0, bool arg1)
            {
                return SExecute<Java.Util.Comparator<Android.Icu.Text.LocaleDisplayNames.UiListItem>>(LocalBridgeClazz, "getComparator", arg0, arg1);
            }

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