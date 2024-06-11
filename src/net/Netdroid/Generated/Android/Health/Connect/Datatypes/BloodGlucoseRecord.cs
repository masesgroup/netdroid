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

namespace Android.Health.Connect.Datatypes
{
    #region BloodGlucoseRecord
    public partial class BloodGlucoseRecord
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
        /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/BloodGlucoseRecord.html#getLevel()"/>
        /// </summary>
        /// <returns><see cref="Android.Health.Connect.Datatypes.Units.BloodGlucose"/></returns>
        public Android.Health.Connect.Datatypes.Units.BloodGlucose GetLevel()
        {
            return IExecuteWithSignature<Android.Health.Connect.Datatypes.Units.BloodGlucose>("getLevel", "()Landroid/health/connect/datatypes/units/BloodGlucose;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/BloodGlucoseRecord.html#getMealType()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetMealType()
        {
            return IExecuteWithSignature<int>("getMealType", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/BloodGlucoseRecord.html#getRelationToMeal()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetRelationToMeal()
        {
            return IExecuteWithSignature<int>("getRelationToMeal", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/BloodGlucoseRecord.html#getSpecimenSource()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetSpecimenSource()
        {
            return IExecuteWithSignature<int>("getSpecimenSource", "()I");
        }

        #endregion

        #region Nested classes
        #region Builder
        public partial class Builder
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/BloodGlucoseRecord.Builder.html#%3Cinit%3E(android.health.connect.datatypes.Metadata,java.time.Instant,int,android.health.connect.datatypes.units.BloodGlucose,int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Health.Connect.Datatypes.Metadata"/></param>
            /// <param name="arg1"><see cref="Java.Time.Instant"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            /// <param name="arg3"><see cref="Android.Health.Connect.Datatypes.Units.BloodGlucose"/></param>
            /// <param name="arg4"><see cref="int"/></param>
            /// <param name="arg5"><see cref="int"/></param>
            public Builder(Android.Health.Connect.Datatypes.Metadata arg0, Java.Time.Instant arg1, int arg2, Android.Health.Connect.Datatypes.Units.BloodGlucose arg3, int arg4, int arg5)
                : base(arg0, arg1, arg2, arg3, arg4, arg5)
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
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/BloodGlucoseRecord.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Health.Connect.Datatypes.BloodGlucoseRecord"/></returns>
            public Android.Health.Connect.Datatypes.BloodGlucoseRecord Build()
            {
                return IExecuteWithSignature<Android.Health.Connect.Datatypes.BloodGlucoseRecord>("build", "()Landroid/health/connect/datatypes/BloodGlucoseRecord;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/BloodGlucoseRecord.Builder.html#clearZoneOffset()"/>
            /// </summary>
            /// <returns><see cref="Android.Health.Connect.Datatypes.BloodGlucoseRecord.Builder"/></returns>
            public Android.Health.Connect.Datatypes.BloodGlucoseRecord.Builder ClearZoneOffset()
            {
                return IExecuteWithSignature<Android.Health.Connect.Datatypes.BloodGlucoseRecord.Builder>("clearZoneOffset", "()Landroid/health/connect/datatypes/BloodGlucoseRecord$Builder;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/BloodGlucoseRecord.Builder.html#setZoneOffset(java.time.ZoneOffset)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Time.ZoneOffset"/></param>
            /// <returns><see cref="Android.Health.Connect.Datatypes.BloodGlucoseRecord.Builder"/></returns>
            public Android.Health.Connect.Datatypes.BloodGlucoseRecord.Builder SetZoneOffset(Java.Time.ZoneOffset arg0)
            {
                return IExecuteWithSignature<Android.Health.Connect.Datatypes.BloodGlucoseRecord.Builder>("setZoneOffset", "(Ljava/time/ZoneOffset;)Landroid/health/connect/datatypes/BloodGlucoseRecord$Builder;", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region RelationToMealType
        public partial class RelationToMealType
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/BloodGlucoseRecord.RelationToMealType.html#RELATION_TO_MEAL_AFTER_MEAL"/>
            /// </summary>
            public static int RELATION_TO_MEAL_AFTER_MEAL { get { if (!_RELATION_TO_MEAL_AFTER_MEALReady) { _RELATION_TO_MEAL_AFTER_MEALContent = SGetField<int>(LocalBridgeClazz, "RELATION_TO_MEAL_AFTER_MEAL"); _RELATION_TO_MEAL_AFTER_MEALReady = true; } return _RELATION_TO_MEAL_AFTER_MEALContent; } }
            private static int _RELATION_TO_MEAL_AFTER_MEALContent = default;
            private static bool _RELATION_TO_MEAL_AFTER_MEALReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/BloodGlucoseRecord.RelationToMealType.html#RELATION_TO_MEAL_BEFORE_MEAL"/>
            /// </summary>
            public static int RELATION_TO_MEAL_BEFORE_MEAL { get { if (!_RELATION_TO_MEAL_BEFORE_MEALReady) { _RELATION_TO_MEAL_BEFORE_MEALContent = SGetField<int>(LocalBridgeClazz, "RELATION_TO_MEAL_BEFORE_MEAL"); _RELATION_TO_MEAL_BEFORE_MEALReady = true; } return _RELATION_TO_MEAL_BEFORE_MEALContent; } }
            private static int _RELATION_TO_MEAL_BEFORE_MEALContent = default;
            private static bool _RELATION_TO_MEAL_BEFORE_MEALReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/BloodGlucoseRecord.RelationToMealType.html#RELATION_TO_MEAL_FASTING"/>
            /// </summary>
            public static int RELATION_TO_MEAL_FASTING { get { if (!_RELATION_TO_MEAL_FASTINGReady) { _RELATION_TO_MEAL_FASTINGContent = SGetField<int>(LocalBridgeClazz, "RELATION_TO_MEAL_FASTING"); _RELATION_TO_MEAL_FASTINGReady = true; } return _RELATION_TO_MEAL_FASTINGContent; } }
            private static int _RELATION_TO_MEAL_FASTINGContent = default;
            private static bool _RELATION_TO_MEAL_FASTINGReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/BloodGlucoseRecord.RelationToMealType.html#RELATION_TO_MEAL_GENERAL"/>
            /// </summary>
            public static int RELATION_TO_MEAL_GENERAL { get { if (!_RELATION_TO_MEAL_GENERALReady) { _RELATION_TO_MEAL_GENERALContent = SGetField<int>(LocalBridgeClazz, "RELATION_TO_MEAL_GENERAL"); _RELATION_TO_MEAL_GENERALReady = true; } return _RELATION_TO_MEAL_GENERALContent; } }
            private static int _RELATION_TO_MEAL_GENERALContent = default;
            private static bool _RELATION_TO_MEAL_GENERALReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/BloodGlucoseRecord.RelationToMealType.html#RELATION_TO_MEAL_UNKNOWN"/>
            /// </summary>
            public static int RELATION_TO_MEAL_UNKNOWN { get { if (!_RELATION_TO_MEAL_UNKNOWNReady) { _RELATION_TO_MEAL_UNKNOWNContent = SGetField<int>(LocalBridgeClazz, "RELATION_TO_MEAL_UNKNOWN"); _RELATION_TO_MEAL_UNKNOWNReady = true; } return _RELATION_TO_MEAL_UNKNOWNContent; } }
            private static int _RELATION_TO_MEAL_UNKNOWNContent = default;
            private static bool _RELATION_TO_MEAL_UNKNOWNReady = false; // this is used because in case of generics 

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

        #region SpecimenSource
        public partial class SpecimenSource
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/BloodGlucoseRecord.SpecimenSource.html#SPECIMEN_SOURCE_CAPILLARY_BLOOD"/>
            /// </summary>
            public static int SPECIMEN_SOURCE_CAPILLARY_BLOOD { get { if (!_SPECIMEN_SOURCE_CAPILLARY_BLOODReady) { _SPECIMEN_SOURCE_CAPILLARY_BLOODContent = SGetField<int>(LocalBridgeClazz, "SPECIMEN_SOURCE_CAPILLARY_BLOOD"); _SPECIMEN_SOURCE_CAPILLARY_BLOODReady = true; } return _SPECIMEN_SOURCE_CAPILLARY_BLOODContent; } }
            private static int _SPECIMEN_SOURCE_CAPILLARY_BLOODContent = default;
            private static bool _SPECIMEN_SOURCE_CAPILLARY_BLOODReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/BloodGlucoseRecord.SpecimenSource.html#SPECIMEN_SOURCE_INTERSTITIAL_FLUID"/>
            /// </summary>
            public static int SPECIMEN_SOURCE_INTERSTITIAL_FLUID { get { if (!_SPECIMEN_SOURCE_INTERSTITIAL_FLUIDReady) { _SPECIMEN_SOURCE_INTERSTITIAL_FLUIDContent = SGetField<int>(LocalBridgeClazz, "SPECIMEN_SOURCE_INTERSTITIAL_FLUID"); _SPECIMEN_SOURCE_INTERSTITIAL_FLUIDReady = true; } return _SPECIMEN_SOURCE_INTERSTITIAL_FLUIDContent; } }
            private static int _SPECIMEN_SOURCE_INTERSTITIAL_FLUIDContent = default;
            private static bool _SPECIMEN_SOURCE_INTERSTITIAL_FLUIDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/BloodGlucoseRecord.SpecimenSource.html#SPECIMEN_SOURCE_PLASMA"/>
            /// </summary>
            public static int SPECIMEN_SOURCE_PLASMA { get { if (!_SPECIMEN_SOURCE_PLASMAReady) { _SPECIMEN_SOURCE_PLASMAContent = SGetField<int>(LocalBridgeClazz, "SPECIMEN_SOURCE_PLASMA"); _SPECIMEN_SOURCE_PLASMAReady = true; } return _SPECIMEN_SOURCE_PLASMAContent; } }
            private static int _SPECIMEN_SOURCE_PLASMAContent = default;
            private static bool _SPECIMEN_SOURCE_PLASMAReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/BloodGlucoseRecord.SpecimenSource.html#SPECIMEN_SOURCE_SERUM"/>
            /// </summary>
            public static int SPECIMEN_SOURCE_SERUM { get { if (!_SPECIMEN_SOURCE_SERUMReady) { _SPECIMEN_SOURCE_SERUMContent = SGetField<int>(LocalBridgeClazz, "SPECIMEN_SOURCE_SERUM"); _SPECIMEN_SOURCE_SERUMReady = true; } return _SPECIMEN_SOURCE_SERUMContent; } }
            private static int _SPECIMEN_SOURCE_SERUMContent = default;
            private static bool _SPECIMEN_SOURCE_SERUMReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/BloodGlucoseRecord.SpecimenSource.html#SPECIMEN_SOURCE_TEARS"/>
            /// </summary>
            public static int SPECIMEN_SOURCE_TEARS { get { if (!_SPECIMEN_SOURCE_TEARSReady) { _SPECIMEN_SOURCE_TEARSContent = SGetField<int>(LocalBridgeClazz, "SPECIMEN_SOURCE_TEARS"); _SPECIMEN_SOURCE_TEARSReady = true; } return _SPECIMEN_SOURCE_TEARSContent; } }
            private static int _SPECIMEN_SOURCE_TEARSContent = default;
            private static bool _SPECIMEN_SOURCE_TEARSReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/BloodGlucoseRecord.SpecimenSource.html#SPECIMEN_SOURCE_UNKNOWN"/>
            /// </summary>
            public static int SPECIMEN_SOURCE_UNKNOWN { get { if (!_SPECIMEN_SOURCE_UNKNOWNReady) { _SPECIMEN_SOURCE_UNKNOWNContent = SGetField<int>(LocalBridgeClazz, "SPECIMEN_SOURCE_UNKNOWN"); _SPECIMEN_SOURCE_UNKNOWNReady = true; } return _SPECIMEN_SOURCE_UNKNOWNContent; } }
            private static int _SPECIMEN_SOURCE_UNKNOWNContent = default;
            private static bool _SPECIMEN_SOURCE_UNKNOWNReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/BloodGlucoseRecord.SpecimenSource.html#SPECIMEN_SOURCE_WHOLE_BLOOD"/>
            /// </summary>
            public static int SPECIMEN_SOURCE_WHOLE_BLOOD { get { if (!_SPECIMEN_SOURCE_WHOLE_BLOODReady) { _SPECIMEN_SOURCE_WHOLE_BLOODContent = SGetField<int>(LocalBridgeClazz, "SPECIMEN_SOURCE_WHOLE_BLOOD"); _SPECIMEN_SOURCE_WHOLE_BLOODReady = true; } return _SPECIMEN_SOURCE_WHOLE_BLOODContent; } }
            private static int _SPECIMEN_SOURCE_WHOLE_BLOODContent = default;
            private static bool _SPECIMEN_SOURCE_WHOLE_BLOODReady = false; // this is used because in case of generics 

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