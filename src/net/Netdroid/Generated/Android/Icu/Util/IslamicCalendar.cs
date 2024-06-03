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

namespace Android.Icu.Util
{
    #region IslamicCalendar
    public partial class IslamicCalendar
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/IslamicCalendar.html#%3Cinit%3E(android.icu.util.TimeZone,android.icu.util.ULocale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Util.TimeZone"/></param>
        /// <param name="arg1"><see cref="Android.Icu.Util.ULocale"/></param>
        public IslamicCalendar(Android.Icu.Util.TimeZone arg0, Android.Icu.Util.ULocale arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/IslamicCalendar.html#%3Cinit%3E(android.icu.util.TimeZone,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Util.TimeZone"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        public IslamicCalendar(Android.Icu.Util.TimeZone arg0, Java.Util.Locale arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/IslamicCalendar.html#%3Cinit%3E(android.icu.util.TimeZone)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Util.TimeZone"/></param>
        public IslamicCalendar(Android.Icu.Util.TimeZone arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/IslamicCalendar.html#%3Cinit%3E(android.icu.util.ULocale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Util.ULocale"/></param>
        public IslamicCalendar(Android.Icu.Util.ULocale arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/IslamicCalendar.html#%3Cinit%3E(int,int,int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        public IslamicCalendar(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5)
            : base(arg0, arg1, arg2, arg3, arg4, arg5)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/IslamicCalendar.html#%3Cinit%3E(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public IslamicCalendar(int arg0, int arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/IslamicCalendar.html#%3Cinit%3E(java.util.Date)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Date"/></param>
        public IslamicCalendar(Java.Util.Date arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/IslamicCalendar.html#%3Cinit%3E(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        public IslamicCalendar(Java.Util.Locale arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/IslamicCalendar.html#DHU_AL_HIJJAH"/>
        /// </summary>
        public static int DHU_AL_HIJJAH { get { if (!_DHU_AL_HIJJAHReady) { _DHU_AL_HIJJAHContent = SGetField<int>(LocalBridgeClazz, "DHU_AL_HIJJAH"); _DHU_AL_HIJJAHReady = true; } return _DHU_AL_HIJJAHContent; } }
        private static int _DHU_AL_HIJJAHContent = default;
        private static bool _DHU_AL_HIJJAHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/IslamicCalendar.html#DHU_AL_QIDAH"/>
        /// </summary>
        public static int DHU_AL_QIDAH { get { if (!_DHU_AL_QIDAHReady) { _DHU_AL_QIDAHContent = SGetField<int>(LocalBridgeClazz, "DHU_AL_QIDAH"); _DHU_AL_QIDAHReady = true; } return _DHU_AL_QIDAHContent; } }
        private static int _DHU_AL_QIDAHContent = default;
        private static bool _DHU_AL_QIDAHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/IslamicCalendar.html#JUMADA_1"/>
        /// </summary>
        public static int JUMADA_1 { get { if (!_JUMADA_1Ready) { _JUMADA_1Content = SGetField<int>(LocalBridgeClazz, "JUMADA_1"); _JUMADA_1Ready = true; } return _JUMADA_1Content; } }
        private static int _JUMADA_1Content = default;
        private static bool _JUMADA_1Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/IslamicCalendar.html#JUMADA_2"/>
        /// </summary>
        public static int JUMADA_2 { get { if (!_JUMADA_2Ready) { _JUMADA_2Content = SGetField<int>(LocalBridgeClazz, "JUMADA_2"); _JUMADA_2Ready = true; } return _JUMADA_2Content; } }
        private static int _JUMADA_2Content = default;
        private static bool _JUMADA_2Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/IslamicCalendar.html#MUHARRAM"/>
        /// </summary>
        public static int MUHARRAM { get { if (!_MUHARRAMReady) { _MUHARRAMContent = SGetField<int>(LocalBridgeClazz, "MUHARRAM"); _MUHARRAMReady = true; } return _MUHARRAMContent; } }
        private static int _MUHARRAMContent = default;
        private static bool _MUHARRAMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/IslamicCalendar.html#RABI_1"/>
        /// </summary>
        public static int RABI_1 { get { if (!_RABI_1Ready) { _RABI_1Content = SGetField<int>(LocalBridgeClazz, "RABI_1"); _RABI_1Ready = true; } return _RABI_1Content; } }
        private static int _RABI_1Content = default;
        private static bool _RABI_1Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/IslamicCalendar.html#RABI_2"/>
        /// </summary>
        public static int RABI_2 { get { if (!_RABI_2Ready) { _RABI_2Content = SGetField<int>(LocalBridgeClazz, "RABI_2"); _RABI_2Ready = true; } return _RABI_2Content; } }
        private static int _RABI_2Content = default;
        private static bool _RABI_2Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/IslamicCalendar.html#RAJAB"/>
        /// </summary>
        public static int RAJAB { get { if (!_RAJABReady) { _RAJABContent = SGetField<int>(LocalBridgeClazz, "RAJAB"); _RAJABReady = true; } return _RAJABContent; } }
        private static int _RAJABContent = default;
        private static bool _RAJABReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/IslamicCalendar.html#RAMADAN"/>
        /// </summary>
        public static int RAMADAN { get { if (!_RAMADANReady) { _RAMADANContent = SGetField<int>(LocalBridgeClazz, "RAMADAN"); _RAMADANReady = true; } return _RAMADANContent; } }
        private static int _RAMADANContent = default;
        private static bool _RAMADANReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/IslamicCalendar.html#SAFAR"/>
        /// </summary>
        public static int SAFAR { get { if (!_SAFARReady) { _SAFARContent = SGetField<int>(LocalBridgeClazz, "SAFAR"); _SAFARReady = true; } return _SAFARContent; } }
        private static int _SAFARContent = default;
        private static bool _SAFARReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/IslamicCalendar.html#SHABAN"/>
        /// </summary>
        public static int SHABAN { get { if (!_SHABANReady) { _SHABANContent = SGetField<int>(LocalBridgeClazz, "SHABAN"); _SHABANReady = true; } return _SHABANContent; } }
        private static int _SHABANContent = default;
        private static bool _SHABANReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/IslamicCalendar.html#SHAWWAL"/>
        /// </summary>
        public static int SHAWWAL { get { if (!_SHAWWALReady) { _SHAWWALContent = SGetField<int>(LocalBridgeClazz, "SHAWWAL"); _SHAWWALReady = true; } return _SHAWWALContent; } }
        private static int _SHAWWALContent = default;
        private static bool _SHAWWALReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/IslamicCalendar.html#getCalculationType()"/>
        /// </summary>
        /// <returns><see cref="Android.Icu.Util.IslamicCalendar.CalculationType"/></returns>
        public Android.Icu.Util.IslamicCalendar.CalculationType GetCalculationType()
        {
            return IExecuteWithSignature<Android.Icu.Util.IslamicCalendar.CalculationType>("getCalculationType", "()Landroid/icu/util/IslamicCalendar$CalculationType;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/IslamicCalendar.html#setCalculationType(android.icu.util.IslamicCalendar.CalculationType)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Util.IslamicCalendar.CalculationType"/></param>
        public void SetCalculationType(Android.Icu.Util.IslamicCalendar.CalculationType arg0)
        {
            IExecuteWithSignature("setCalculationType", "(Landroid/icu/util/IslamicCalendar$CalculationType;)V", arg0);
        }

        #endregion

        #region Nested classes
        #region CalculationType
        public partial class CalculationType
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/util/IslamicCalendar.CalculationType.html#ISLAMIC"/>
            /// </summary>
            public static Android.Icu.Util.IslamicCalendar.CalculationType ISLAMIC { get { if (!_ISLAMICReady) { _ISLAMICContent = SGetField<Android.Icu.Util.IslamicCalendar.CalculationType>(LocalBridgeClazz, "ISLAMIC"); _ISLAMICReady = true; } return _ISLAMICContent; } }
            private static Android.Icu.Util.IslamicCalendar.CalculationType _ISLAMICContent = default;
            private static bool _ISLAMICReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/util/IslamicCalendar.CalculationType.html#ISLAMIC_CIVIL"/>
            /// </summary>
            public static Android.Icu.Util.IslamicCalendar.CalculationType ISLAMIC_CIVIL { get { if (!_ISLAMIC_CIVILReady) { _ISLAMIC_CIVILContent = SGetField<Android.Icu.Util.IslamicCalendar.CalculationType>(LocalBridgeClazz, "ISLAMIC_CIVIL"); _ISLAMIC_CIVILReady = true; } return _ISLAMIC_CIVILContent; } }
            private static Android.Icu.Util.IslamicCalendar.CalculationType _ISLAMIC_CIVILContent = default;
            private static bool _ISLAMIC_CIVILReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/util/IslamicCalendar.CalculationType.html#ISLAMIC_TBLA"/>
            /// </summary>
            public static Android.Icu.Util.IslamicCalendar.CalculationType ISLAMIC_TBLA { get { if (!_ISLAMIC_TBLAReady) { _ISLAMIC_TBLAContent = SGetField<Android.Icu.Util.IslamicCalendar.CalculationType>(LocalBridgeClazz, "ISLAMIC_TBLA"); _ISLAMIC_TBLAReady = true; } return _ISLAMIC_TBLAContent; } }
            private static Android.Icu.Util.IslamicCalendar.CalculationType _ISLAMIC_TBLAContent = default;
            private static bool _ISLAMIC_TBLAReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/util/IslamicCalendar.CalculationType.html#ISLAMIC_UMALQURA"/>
            /// </summary>
            public static Android.Icu.Util.IslamicCalendar.CalculationType ISLAMIC_UMALQURA { get { if (!_ISLAMIC_UMALQURAReady) { _ISLAMIC_UMALQURAContent = SGetField<Android.Icu.Util.IslamicCalendar.CalculationType>(LocalBridgeClazz, "ISLAMIC_UMALQURA"); _ISLAMIC_UMALQURAReady = true; } return _ISLAMIC_UMALQURAContent; } }
            private static Android.Icu.Util.IslamicCalendar.CalculationType _ISLAMIC_UMALQURAContent = default;
            private static bool _ISLAMIC_UMALQURAReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/util/IslamicCalendar.CalculationType.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Icu.Util.IslamicCalendar.CalculationType"/></returns>
            public static Android.Icu.Util.IslamicCalendar.CalculationType ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Android.Icu.Util.IslamicCalendar.CalculationType>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Landroid/icu/util/IslamicCalendar$CalculationType;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/util/IslamicCalendar.CalculationType.html#values()"/>
            /// </summary>
            /// <returns><see cref="Android.Icu.Util.IslamicCalendar.CalculationType"/></returns>
            public static Android.Icu.Util.IslamicCalendar.CalculationType[] Values()
            {
                return SExecuteWithSignatureArray<Android.Icu.Util.IslamicCalendar.CalculationType>(LocalBridgeClazz, "values", "()[Landroid/icu/util/IslamicCalendar$CalculationType;");
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