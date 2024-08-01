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
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Icu.Util
{
    #region TimeZone
    public partial class TimeZone : Java.Io.ISerializable, Java.Lang.ICloneable, Android.Icu.Util.IFreezable<Android.Icu.Util.TimeZone>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Android.Icu.Util.TimeZone"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Android.Icu.Util.TimeZone t) => t.Cast<Java.Io.Serializable>();
        /// <summary>
        /// Converter from <see cref="Android.Icu.Util.TimeZone"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Android.Icu.Util.TimeZone t) => t.Cast<Java.Lang.Cloneable>();
        /// <summary>
        /// Converter from <see cref="Android.Icu.Util.TimeZone"/> to <see cref="Android.Icu.Util.Freezable"/>
        /// </summary>
        public static implicit operator Android.Icu.Util.Freezable(Android.Icu.Util.TimeZone t) => t.Cast<Android.Icu.Util.Freezable>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/TimeZone.html#GMT_ZONE"/>
        /// </summary>
        public static Android.Icu.Util.TimeZone GMT_ZONE { get { if (!_GMT_ZONEReady) { _GMT_ZONEContent = SGetField<Android.Icu.Util.TimeZone>(LocalBridgeClazz, "GMT_ZONE"); _GMT_ZONEReady = true; } return _GMT_ZONEContent; } }
        private static Android.Icu.Util.TimeZone _GMT_ZONEContent = default;
        private static bool _GMT_ZONEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/TimeZone.html#UNKNOWN_ZONE"/>
        /// </summary>
        public static Android.Icu.Util.TimeZone UNKNOWN_ZONE { get { if (!_UNKNOWN_ZONEReady) { _UNKNOWN_ZONEContent = SGetField<Android.Icu.Util.TimeZone>(LocalBridgeClazz, "UNKNOWN_ZONE"); _UNKNOWN_ZONEReady = true; } return _UNKNOWN_ZONEContent; } }
        private static Android.Icu.Util.TimeZone _UNKNOWN_ZONEContent = default;
        private static bool _UNKNOWN_ZONEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/TimeZone.html#GENERIC_LOCATION"/>
        /// </summary>
        public static int GENERIC_LOCATION { get { if (!_GENERIC_LOCATIONReady) { _GENERIC_LOCATIONContent = SGetField<int>(LocalBridgeClazz, "GENERIC_LOCATION"); _GENERIC_LOCATIONReady = true; } return _GENERIC_LOCATIONContent; } }
        private static int _GENERIC_LOCATIONContent = default;
        private static bool _GENERIC_LOCATIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/TimeZone.html#LONG"/>
        /// </summary>
        public static int LONG { get { if (!_LONGReady) { _LONGContent = SGetField<int>(LocalBridgeClazz, "LONG"); _LONGReady = true; } return _LONGContent; } }
        private static int _LONGContent = default;
        private static bool _LONGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/TimeZone.html#LONG_GENERIC"/>
        /// </summary>
        public static int LONG_GENERIC { get { if (!_LONG_GENERICReady) { _LONG_GENERICContent = SGetField<int>(LocalBridgeClazz, "LONG_GENERIC"); _LONG_GENERICReady = true; } return _LONG_GENERICContent; } }
        private static int _LONG_GENERICContent = default;
        private static bool _LONG_GENERICReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/TimeZone.html#LONG_GMT"/>
        /// </summary>
        public static int LONG_GMT { get { if (!_LONG_GMTReady) { _LONG_GMTContent = SGetField<int>(LocalBridgeClazz, "LONG_GMT"); _LONG_GMTReady = true; } return _LONG_GMTContent; } }
        private static int _LONG_GMTContent = default;
        private static bool _LONG_GMTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/TimeZone.html#SHORT"/>
        /// </summary>
        public static int SHORT { get { if (!_SHORTReady) { _SHORTContent = SGetField<int>(LocalBridgeClazz, "SHORT"); _SHORTReady = true; } return _SHORTContent; } }
        private static int _SHORTContent = default;
        private static bool _SHORTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/TimeZone.html#SHORT_COMMONLY_USED"/>
        /// </summary>
        public static int SHORT_COMMONLY_USED { get { if (!_SHORT_COMMONLY_USEDReady) { _SHORT_COMMONLY_USEDContent = SGetField<int>(LocalBridgeClazz, "SHORT_COMMONLY_USED"); _SHORT_COMMONLY_USEDReady = true; } return _SHORT_COMMONLY_USEDContent; } }
        private static int _SHORT_COMMONLY_USEDContent = default;
        private static bool _SHORT_COMMONLY_USEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/TimeZone.html#SHORT_GENERIC"/>
        /// </summary>
        public static int SHORT_GENERIC { get { if (!_SHORT_GENERICReady) { _SHORT_GENERICContent = SGetField<int>(LocalBridgeClazz, "SHORT_GENERIC"); _SHORT_GENERICReady = true; } return _SHORT_GENERICContent; } }
        private static int _SHORT_GENERICContent = default;
        private static bool _SHORT_GENERICReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/TimeZone.html#SHORT_GMT"/>
        /// </summary>
        public static int SHORT_GMT { get { if (!_SHORT_GMTReady) { _SHORT_GMTContent = SGetField<int>(LocalBridgeClazz, "SHORT_GMT"); _SHORT_GMTReady = true; } return _SHORT_GMTContent; } }
        private static int _SHORT_GMTContent = default;
        private static bool _SHORT_GMTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/TimeZone.html#TIMEZONE_ICU"/>
        /// </summary>
        public static int TIMEZONE_ICU { get { if (!_TIMEZONE_ICUReady) { _TIMEZONE_ICUContent = SGetField<int>(LocalBridgeClazz, "TIMEZONE_ICU"); _TIMEZONE_ICUReady = true; } return _TIMEZONE_ICUContent; } }
        private static int _TIMEZONE_ICUContent = default;
        private static bool _TIMEZONE_ICUReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/TimeZone.html#TIMEZONE_JDK"/>
        /// </summary>
        public static int TIMEZONE_JDK { get { if (!_TIMEZONE_JDKReady) { _TIMEZONE_JDKContent = SGetField<int>(LocalBridgeClazz, "TIMEZONE_JDK"); _TIMEZONE_JDKReady = true; } return _TIMEZONE_JDKContent; } }
        private static int _TIMEZONE_JDKContent = default;
        private static bool _TIMEZONE_JDKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/TimeZone.html#UNKNOWN_ZONE_ID"/>
        /// </summary>
        public static Java.Lang.String UNKNOWN_ZONE_ID { get { if (!_UNKNOWN_ZONE_IDReady) { _UNKNOWN_ZONE_IDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "UNKNOWN_ZONE_ID"); _UNKNOWN_ZONE_IDReady = true; } return _UNKNOWN_ZONE_IDContent; } }
        private static Java.Lang.String _UNKNOWN_ZONE_IDContent = default;
        private static bool _UNKNOWN_ZONE_IDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/TimeZone.html#getDefault()"/>
        /// </summary>
        /// <returns><see cref="Android.Icu.Util.TimeZone"/></returns>
        public static Android.Icu.Util.TimeZone GetDefault()
        {
            return SExecuteWithSignature<Android.Icu.Util.TimeZone>(LocalBridgeClazz, "getDefault", "()Landroid/icu/util/TimeZone;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/TimeZone.html#getFrozenTimeZone(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Icu.Util.TimeZone"/></returns>
        public static Android.Icu.Util.TimeZone GetFrozenTimeZone(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Android.Icu.Util.TimeZone>(LocalBridgeClazz, "getFrozenTimeZone", "(Ljava/lang/String;)Landroid/icu/util/TimeZone;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/TimeZone.html#getTimeZone(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Android.Icu.Util.TimeZone"/></returns>
        public static Android.Icu.Util.TimeZone GetTimeZone(Java.Lang.String arg0, int arg1)
        {
            return SExecute<Android.Icu.Util.TimeZone>(LocalBridgeClazz, "getTimeZone", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/TimeZone.html#getTimeZone(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Icu.Util.TimeZone"/></returns>
        public static Android.Icu.Util.TimeZone GetTimeZone(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Android.Icu.Util.TimeZone>(LocalBridgeClazz, "getTimeZone", "(Ljava/lang/String;)Landroid/icu/util/TimeZone;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/TimeZone.html#countEquivalentIDs(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="int"/></returns>
        public static int CountEquivalentIDs(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "countEquivalentIDs", "(Ljava/lang/String;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/TimeZone.html#getCanonicalID(java.lang.String,boolean[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String GetCanonicalID(Java.Lang.String arg0, bool[] arg1)
        {
            return SExecute<Java.Lang.String>(LocalBridgeClazz, "getCanonicalID", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/TimeZone.html#getCanonicalID(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String GetCanonicalID(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "getCanonicalID", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/TimeZone.html#getEquivalentID(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String GetEquivalentID(Java.Lang.String arg0, int arg1)
        {
            return SExecute<Java.Lang.String>(LocalBridgeClazz, "getEquivalentID", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/TimeZone.html#getIDForWindowsID(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String GetIDForWindowsID(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return SExecute<Java.Lang.String>(LocalBridgeClazz, "getIDForWindowsID", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/TimeZone.html#getRegion(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String GetRegion(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "getRegion", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/TimeZone.html#getTZDataVersion()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String GetTZDataVersion()
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "getTZDataVersion", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/TimeZone.html#getWindowsID(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String GetWindowsID(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "getWindowsID", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/TimeZone.html#getAvailableIDs()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String[] GetAvailableIDs()
        {
            return SExecuteWithSignatureArray<Java.Lang.String>(LocalBridgeClazz, "getAvailableIDs", "()[Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/TimeZone.html#getAvailableIDs(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String[] GetAvailableIDs(int arg0)
        {
            return SExecuteWithSignatureArray<Java.Lang.String>(LocalBridgeClazz, "getAvailableIDs", "(I)[Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/TimeZone.html#getAvailableIDs(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String[] GetAvailableIDs(Java.Lang.String arg0)
        {
            return SExecuteWithSignatureArray<Java.Lang.String>(LocalBridgeClazz, "getAvailableIDs", "(Ljava/lang/String;)[Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/TimeZone.html#getAvailableIDs(android.icu.util.TimeZone.SystemTimeZoneType,java.lang.String,java.lang.Integer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Util.TimeZone.SystemTimeZoneType"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.Integer"/></param>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public static Java.Util.Set<Java.Lang.String> GetAvailableIDs(Android.Icu.Util.TimeZone.SystemTimeZoneType arg0, Java.Lang.String arg1, Java.Lang.Integer arg2)
        {
            return SExecute<Java.Util.Set<Java.Lang.String>>(LocalBridgeClazz, "getAvailableIDs", arg0, arg1, arg2);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/TimeZone.html#inDaylightTime(java.util.Date)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Date"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool InDaylightTime(Java.Util.Date arg0)
        {
            return IExecuteWithSignature<bool>("inDaylightTime", "(Ljava/util/Date;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/TimeZone.html#useDaylightTime()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool UseDaylightTime()
        {
            return IExecuteWithSignature<bool>("useDaylightTime", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/TimeZone.html#getOffset(int,int,int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetOffset(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5)
        {
            return IExecute<int>("getOffset", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/TimeZone.html#getRawOffset()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetRawOffset()
        {
            return IExecuteWithSignature<int>("getRawOffset", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/TimeZone.html#setRawOffset(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetRawOffset(int arg0)
        {
            IExecuteWithSignature("setRawOffset", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/TimeZone.html#hasSameRules(android.icu.util.TimeZone)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Util.TimeZone"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool HasSameRules(Android.Icu.Util.TimeZone arg0)
        {
            return IExecuteWithSignature<bool>("hasSameRules", "(Landroid/icu/util/TimeZone;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/TimeZone.html#isFrozen()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsFrozen()
        {
            return IExecuteWithSignature<bool>("isFrozen", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/TimeZone.html#observesDaylightTime()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool ObservesDaylightTime()
        {
            return IExecuteWithSignature<bool>("observesDaylightTime", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/TimeZone.html#getDisplayName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetDisplayName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getDisplayName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/TimeZone.html#getDisplayName(android.icu.util.ULocale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Util.ULocale"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetDisplayName(Android.Icu.Util.ULocale arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getDisplayName", "(Landroid/icu/util/ULocale;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/TimeZone.html#getDisplayName(boolean,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetDisplayName(bool arg0, int arg1)
        {
            return IExecute<Java.Lang.String>("getDisplayName", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/TimeZone.html#getDisplayName(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetDisplayName(Java.Util.Locale arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getDisplayName", "(Ljava/util/Locale;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/TimeZone.html#getDSTSavings()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetDSTSavings()
        {
            return IExecuteWithSignature<int>("getDSTSavings", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/TimeZone.html#getOffset(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetOffset(long arg0)
        {
            return IExecuteWithSignature<int>("getOffset", "(J)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/TimeZone.html#cloneAsThawed()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        public object CloneAsThawed()
        {
            return IExecuteWithSignature("cloneAsThawed", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/TimeZone.html#freeze()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        public object Freeze()
        {
            return IExecuteWithSignature("freeze", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/TimeZone.html#getDisplayName(boolean,int,android.icu.util.ULocale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Android.Icu.Util.ULocale"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetDisplayName(bool arg0, int arg1, Android.Icu.Util.ULocale arg2)
        {
            return IExecute<Java.Lang.String>("getDisplayName", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/TimeZone.html#getDisplayName(boolean,int,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetDisplayName(bool arg0, int arg1, Java.Util.Locale arg2)
        {
            return IExecute<Java.Lang.String>("getDisplayName", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/TimeZone.html#getID()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetID()
        {
            return IExecuteWithSignature<Java.Lang.String>("getID", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/TimeZone.html#getOffset(long,boolean,int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public void GetOffset(long arg0, bool arg1, int[] arg2)
        {
            IExecute("getOffset", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/TimeZone.html#setID(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetID(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setID", "(Ljava/lang/String;)V", arg0);
        }

        #endregion

        #region Nested classes
        #region SystemTimeZoneType
        public partial class SystemTimeZoneType
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/util/TimeZone.SystemTimeZoneType.html#ANY"/>
            /// </summary>
            public static Android.Icu.Util.TimeZone.SystemTimeZoneType ANY { get { if (!_ANYReady) { _ANYContent = SGetField<Android.Icu.Util.TimeZone.SystemTimeZoneType>(LocalBridgeClazz, "ANY"); _ANYReady = true; } return _ANYContent; } }
            private static Android.Icu.Util.TimeZone.SystemTimeZoneType _ANYContent = default;
            private static bool _ANYReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/util/TimeZone.SystemTimeZoneType.html#CANONICAL"/>
            /// </summary>
            public static Android.Icu.Util.TimeZone.SystemTimeZoneType CANONICAL { get { if (!_CANONICALReady) { _CANONICALContent = SGetField<Android.Icu.Util.TimeZone.SystemTimeZoneType>(LocalBridgeClazz, "CANONICAL"); _CANONICALReady = true; } return _CANONICALContent; } }
            private static Android.Icu.Util.TimeZone.SystemTimeZoneType _CANONICALContent = default;
            private static bool _CANONICALReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/util/TimeZone.SystemTimeZoneType.html#CANONICAL_LOCATION"/>
            /// </summary>
            public static Android.Icu.Util.TimeZone.SystemTimeZoneType CANONICAL_LOCATION { get { if (!_CANONICAL_LOCATIONReady) { _CANONICAL_LOCATIONContent = SGetField<Android.Icu.Util.TimeZone.SystemTimeZoneType>(LocalBridgeClazz, "CANONICAL_LOCATION"); _CANONICAL_LOCATIONReady = true; } return _CANONICAL_LOCATIONContent; } }
            private static Android.Icu.Util.TimeZone.SystemTimeZoneType _CANONICAL_LOCATIONContent = default;
            private static bool _CANONICAL_LOCATIONReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/util/TimeZone.SystemTimeZoneType.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Icu.Util.TimeZone.SystemTimeZoneType"/></returns>
            public static Android.Icu.Util.TimeZone.SystemTimeZoneType ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Android.Icu.Util.TimeZone.SystemTimeZoneType>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Landroid/icu/util/TimeZone$SystemTimeZoneType;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/util/TimeZone.SystemTimeZoneType.html#values()"/>
            /// </summary>
            /// <returns><see cref="Android.Icu.Util.TimeZone.SystemTimeZoneType"/></returns>
            public static Android.Icu.Util.TimeZone.SystemTimeZoneType[] Values()
            {
                return SExecuteWithSignatureArray<Android.Icu.Util.TimeZone.SystemTimeZoneType>(LocalBridgeClazz, "values", "()[Landroid/icu/util/TimeZone$SystemTimeZoneType;");
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