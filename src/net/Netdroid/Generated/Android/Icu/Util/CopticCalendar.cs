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

namespace Android.Icu.Util
{
    #region CopticCalendar
    public partial class CopticCalendar
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/CopticCalendar.html#%3Cinit%3E(android.icu.util.TimeZone,android.icu.util.ULocale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Util.TimeZone"/></param>
        /// <param name="arg1"><see cref="Android.Icu.Util.ULocale"/></param>
        public CopticCalendar(Android.Icu.Util.TimeZone arg0, Android.Icu.Util.ULocale arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/CopticCalendar.html#%3Cinit%3E(android.icu.util.TimeZone,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Util.TimeZone"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        public CopticCalendar(Android.Icu.Util.TimeZone arg0, Java.Util.Locale arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/CopticCalendar.html#%3Cinit%3E(android.icu.util.TimeZone)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Util.TimeZone"/></param>
        public CopticCalendar(Android.Icu.Util.TimeZone arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/CopticCalendar.html#%3Cinit%3E(android.icu.util.ULocale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Util.ULocale"/></param>
        public CopticCalendar(Android.Icu.Util.ULocale arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/CopticCalendar.html#%3Cinit%3E(int,int,int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        public CopticCalendar(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5)
            : base(arg0, arg1, arg2, arg3, arg4, arg5)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/CopticCalendar.html#%3Cinit%3E(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public CopticCalendar(int arg0, int arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/CopticCalendar.html#%3Cinit%3E(java.util.Date)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Date"/></param>
        public CopticCalendar(Java.Util.Date arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/CopticCalendar.html#%3Cinit%3E(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        public CopticCalendar(Java.Util.Locale arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/CopticCalendar.html#AMSHIR"/>
        /// </summary>
        public static int AMSHIR { get { if (!_AMSHIRReady) { _AMSHIRContent = SGetField<int>(LocalBridgeClazz, "AMSHIR"); _AMSHIRReady = true; } return _AMSHIRContent; } }
        private static int _AMSHIRContent = default;
        private static bool _AMSHIRReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/CopticCalendar.html#BABA"/>
        /// </summary>
        public static int BABA { get { if (!_BABAReady) { _BABAContent = SGetField<int>(LocalBridgeClazz, "BABA"); _BABAReady = true; } return _BABAContent; } }
        private static int _BABAContent = default;
        private static bool _BABAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/CopticCalendar.html#BARAMHAT"/>
        /// </summary>
        public static int BARAMHAT { get { if (!_BARAMHATReady) { _BARAMHATContent = SGetField<int>(LocalBridgeClazz, "BARAMHAT"); _BARAMHATReady = true; } return _BARAMHATContent; } }
        private static int _BARAMHATContent = default;
        private static bool _BARAMHATReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/CopticCalendar.html#BARAMOUDA"/>
        /// </summary>
        public static int BARAMOUDA { get { if (!_BARAMOUDAReady) { _BARAMOUDAContent = SGetField<int>(LocalBridgeClazz, "BARAMOUDA"); _BARAMOUDAReady = true; } return _BARAMOUDAContent; } }
        private static int _BARAMOUDAContent = default;
        private static bool _BARAMOUDAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/CopticCalendar.html#BASHANS"/>
        /// </summary>
        public static int BASHANS { get { if (!_BASHANSReady) { _BASHANSContent = SGetField<int>(LocalBridgeClazz, "BASHANS"); _BASHANSReady = true; } return _BASHANSContent; } }
        private static int _BASHANSContent = default;
        private static bool _BASHANSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/CopticCalendar.html#EPEP"/>
        /// </summary>
        public static int EPEP { get { if (!_EPEPReady) { _EPEPContent = SGetField<int>(LocalBridgeClazz, "EPEP"); _EPEPReady = true; } return _EPEPContent; } }
        private static int _EPEPContent = default;
        private static bool _EPEPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/CopticCalendar.html#HATOR"/>
        /// </summary>
        public static int HATOR { get { if (!_HATORReady) { _HATORContent = SGetField<int>(LocalBridgeClazz, "HATOR"); _HATORReady = true; } return _HATORContent; } }
        private static int _HATORContent = default;
        private static bool _HATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/CopticCalendar.html#KIAHK"/>
        /// </summary>
        public static int KIAHK { get { if (!_KIAHKReady) { _KIAHKContent = SGetField<int>(LocalBridgeClazz, "KIAHK"); _KIAHKReady = true; } return _KIAHKContent; } }
        private static int _KIAHKContent = default;
        private static bool _KIAHKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/CopticCalendar.html#MESRA"/>
        /// </summary>
        public static int MESRA { get { if (!_MESRAReady) { _MESRAContent = SGetField<int>(LocalBridgeClazz, "MESRA"); _MESRAReady = true; } return _MESRAContent; } }
        private static int _MESRAContent = default;
        private static bool _MESRAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/CopticCalendar.html#NASIE"/>
        /// </summary>
        public static int NASIE { get { if (!_NASIEReady) { _NASIEContent = SGetField<int>(LocalBridgeClazz, "NASIE"); _NASIEReady = true; } return _NASIEContent; } }
        private static int _NASIEContent = default;
        private static bool _NASIEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/CopticCalendar.html#PAONA"/>
        /// </summary>
        public static int PAONA { get { if (!_PAONAReady) { _PAONAContent = SGetField<int>(LocalBridgeClazz, "PAONA"); _PAONAReady = true; } return _PAONAContent; } }
        private static int _PAONAContent = default;
        private static bool _PAONAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/CopticCalendar.html#TOBA"/>
        /// </summary>
        public static int TOBA { get { if (!_TOBAReady) { _TOBAContent = SGetField<int>(LocalBridgeClazz, "TOBA"); _TOBAReady = true; } return _TOBAContent; } }
        private static int _TOBAContent = default;
        private static bool _TOBAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/CopticCalendar.html#TOUT"/>
        /// </summary>
        public static int TOUT { get { if (!_TOUTReady) { _TOUTContent = SGetField<int>(LocalBridgeClazz, "TOUT"); _TOUTReady = true; } return _TOUTContent; } }
        private static int _TOUTContent = default;
        private static bool _TOUTReady = false; // this is used because in case of generics 

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
}