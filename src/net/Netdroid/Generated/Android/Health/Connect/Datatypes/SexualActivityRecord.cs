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

namespace Android.Health.Connect.Datatypes
{
    #region SexualActivityRecord
    public partial class SexualActivityRecord
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
        /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/SexualActivityRecord.html#getProtectionUsed()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetProtectionUsed()
        {
            return IExecuteWithSignature<int>("getProtectionUsed", "()I");
        }

        #endregion

        #region Nested classes
        #region Builder
        public partial class Builder
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/SexualActivityRecord.Builder.html#%3Cinit%3E(android.health.connect.datatypes.Metadata,java.time.Instant,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Health.Connect.Datatypes.Metadata"/></param>
            /// <param name="arg1"><see cref="Java.Time.Instant"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            public Builder(Android.Health.Connect.Datatypes.Metadata arg0, Java.Time.Instant arg1, int arg2)
                : base(arg0, arg1, arg2)
            {
            }

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/SexualActivityRecord.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Health.Connect.Datatypes.SexualActivityRecord"/></returns>
            public Android.Health.Connect.Datatypes.SexualActivityRecord Build()
            {
                return IExecuteWithSignature<Android.Health.Connect.Datatypes.SexualActivityRecord>("build", "()Landroid/health/connect/datatypes/SexualActivityRecord;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/SexualActivityRecord.Builder.html#clearZoneOffset()"/>
            /// </summary>
            /// <returns><see cref="Android.Health.Connect.Datatypes.SexualActivityRecord.Builder"/></returns>
            public Android.Health.Connect.Datatypes.SexualActivityRecord.Builder ClearZoneOffset()
            {
                return IExecuteWithSignature<Android.Health.Connect.Datatypes.SexualActivityRecord.Builder>("clearZoneOffset", "()Landroid/health/connect/datatypes/SexualActivityRecord$Builder;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/SexualActivityRecord.Builder.html#setZoneOffset(java.time.ZoneOffset)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Time.ZoneOffset"/></param>
            /// <returns><see cref="Android.Health.Connect.Datatypes.SexualActivityRecord.Builder"/></returns>
            public Android.Health.Connect.Datatypes.SexualActivityRecord.Builder SetZoneOffset(Java.Time.ZoneOffset arg0)
            {
                return IExecuteWithSignature<Android.Health.Connect.Datatypes.SexualActivityRecord.Builder>("setZoneOffset", "(Ljava/time/ZoneOffset;)Landroid/health/connect/datatypes/SexualActivityRecord$Builder;", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region SexualActivityProtectionUsed
        public partial class SexualActivityProtectionUsed
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/SexualActivityRecord.SexualActivityProtectionUsed.html#PROTECTION_USED_PROTECTED"/>
            /// </summary>
            public static int PROTECTION_USED_PROTECTED { get { if (!_PROTECTION_USED_PROTECTEDReady) { _PROTECTION_USED_PROTECTEDContent = SGetField<int>(LocalBridgeClazz, "PROTECTION_USED_PROTECTED"); _PROTECTION_USED_PROTECTEDReady = true; } return _PROTECTION_USED_PROTECTEDContent; } }
            private static int _PROTECTION_USED_PROTECTEDContent = default;
            private static bool _PROTECTION_USED_PROTECTEDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/SexualActivityRecord.SexualActivityProtectionUsed.html#PROTECTION_USED_UNKNOWN"/>
            /// </summary>
            public static int PROTECTION_USED_UNKNOWN { get { if (!_PROTECTION_USED_UNKNOWNReady) { _PROTECTION_USED_UNKNOWNContent = SGetField<int>(LocalBridgeClazz, "PROTECTION_USED_UNKNOWN"); _PROTECTION_USED_UNKNOWNReady = true; } return _PROTECTION_USED_UNKNOWNContent; } }
            private static int _PROTECTION_USED_UNKNOWNContent = default;
            private static bool _PROTECTION_USED_UNKNOWNReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/SexualActivityRecord.SexualActivityProtectionUsed.html#PROTECTION_USED_UNPROTECTED"/>
            /// </summary>
            public static int PROTECTION_USED_UNPROTECTED { get { if (!_PROTECTION_USED_UNPROTECTEDReady) { _PROTECTION_USED_UNPROTECTEDContent = SGetField<int>(LocalBridgeClazz, "PROTECTION_USED_UNPROTECTED"); _PROTECTION_USED_UNPROTECTEDReady = true; } return _PROTECTION_USED_UNPROTECTEDContent; } }
            private static int _PROTECTION_USED_UNPROTECTEDContent = default;
            private static bool _PROTECTION_USED_UNPROTECTEDReady = false; // this is used because in case of generics 

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