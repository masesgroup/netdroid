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

namespace Android.Os
{
    #region LocaleList
    public partial class LocaleList
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/LocaleList.html#%3Cinit%3E(java.util.Locale[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        public LocaleList(params Java.Util.Locale[] arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/LocaleList.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/LocaleList.html#forLanguageTags(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Os.LocaleList"/></returns>
        public static Android.Os.LocaleList ForLanguageTags(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Android.Os.LocaleList>(LocalBridgeClazz, "forLanguageTags", "(Ljava/lang/String;)Landroid/os/LocaleList;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/LocaleList.html#getAdjustedDefault()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.LocaleList"/></returns>
        public static Android.Os.LocaleList GetAdjustedDefault()
        {
            return SExecuteWithSignature<Android.Os.LocaleList>(LocalBridgeClazz, "getAdjustedDefault", "()Landroid/os/LocaleList;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/LocaleList.html#getDefault()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.LocaleList"/></returns>
        public static Android.Os.LocaleList GetDefault()
        {
            return SExecuteWithSignature<Android.Os.LocaleList>(LocalBridgeClazz, "getDefault", "()Landroid/os/LocaleList;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/LocaleList.html#getEmptyLocaleList()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.LocaleList"/></returns>
        public static Android.Os.LocaleList GetEmptyLocaleList()
        {
            return SExecuteWithSignature<Android.Os.LocaleList>(LocalBridgeClazz, "getEmptyLocaleList", "()Landroid/os/LocaleList;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/LocaleList.html#isPseudoLocale(android.icu.util.ULocale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Util.ULocale"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsPseudoLocale(Android.Icu.Util.ULocale arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isPseudoLocale", "(Landroid/icu/util/ULocale;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/LocaleList.html#matchesLanguageAndScript(java.util.Locale,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool MatchesLanguageAndScript(Java.Util.Locale arg0, Java.Util.Locale arg1)
        {
            return SExecute<bool>(LocalBridgeClazz, "matchesLanguageAndScript", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/LocaleList.html#setDefault(android.os.LocaleList)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.LocaleList"/></param>
        public static void SetDefault(Android.Os.LocaleList arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "setDefault", "(Landroid/os/LocaleList;)V", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/LocaleList.html#isEmpty()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsEmpty()
        {
            return IExecuteWithSignature<bool>("isEmpty", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/LocaleList.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/LocaleList.html#indexOf(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="int"/></returns>
        public int IndexOf(Java.Util.Locale arg0)
        {
            return IExecuteWithSignature<int>("indexOf", "(Ljava/util/Locale;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/LocaleList.html#size()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Size()
        {
            return IExecuteWithSignature<int>("size", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/LocaleList.html#toLanguageTags()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String ToLanguageTags()
        {
            return IExecuteWithSignature<Java.Lang.String>("toLanguageTags", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/LocaleList.html#get(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.Locale"/></returns>
        public Java.Util.Locale Get(int arg0)
        {
            return IExecuteWithSignature<Java.Util.Locale>("get", "(I)Ljava/util/Locale;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/LocaleList.html#getFirstMatch(java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.Locale"/></returns>
        public Java.Util.Locale GetFirstMatch(Java.Lang.String[] arg0)
        {
            return IExecuteWithSignature<Java.Util.Locale>("getFirstMatch", "([Ljava/lang/String;)Ljava/util/Locale;", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/LocaleList.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecute("writeToParcel", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}