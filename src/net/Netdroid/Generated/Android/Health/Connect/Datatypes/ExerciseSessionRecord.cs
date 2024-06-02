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

namespace Android.Health.Connect.Datatypes
{
    #region ExerciseSessionRecord
    public partial class ExerciseSessionRecord
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/ExerciseSessionRecord.html#EXERCISE_DURATION_TOTAL"/>
        /// </summary>
        public static Android.Health.Connect.Datatypes.AggregationType EXERCISE_DURATION_TOTAL { get { if (!_EXERCISE_DURATION_TOTALReady) { _EXERCISE_DURATION_TOTALContent = SGetField<Android.Health.Connect.Datatypes.AggregationType>(LocalBridgeClazz, "EXERCISE_DURATION_TOTAL"); _EXERCISE_DURATION_TOTALReady = true; } return _EXERCISE_DURATION_TOTALContent; } }
        private static Android.Health.Connect.Datatypes.AggregationType _EXERCISE_DURATION_TOTALContent = default;
        private static bool _EXERCISE_DURATION_TOTALReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/ExerciseSessionRecord.html#getRoute()"/>
        /// </summary>
        /// <returns><see cref="Android.Health.Connect.Datatypes.ExerciseRoute"/></returns>
        public Android.Health.Connect.Datatypes.ExerciseRoute GetRoute()
        {
            return IExecuteWithSignature<Android.Health.Connect.Datatypes.ExerciseRoute>("getRoute", "()Landroid/health/connect/datatypes/ExerciseRoute;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/ExerciseSessionRecord.html#hasRoute()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasRoute()
        {
            return IExecuteWithSignature<bool>("hasRoute", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/ExerciseSessionRecord.html#getExerciseType()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetExerciseType()
        {
            return IExecuteWithSignature<int>("getExerciseType", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/ExerciseSessionRecord.html#getNotes()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence GetNotes()
        {
            return IExecuteWithSignature<Java.Lang.CharSequence>("getNotes", "()Ljava/lang/CharSequence;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/ExerciseSessionRecord.html#getTitle()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence GetTitle()
        {
            return IExecuteWithSignature<Java.Lang.CharSequence>("getTitle", "()Ljava/lang/CharSequence;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/ExerciseSessionRecord.html#getLaps()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Health.Connect.Datatypes.ExerciseLap> GetLaps()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Health.Connect.Datatypes.ExerciseLap>>("getLaps", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/ExerciseSessionRecord.html#getSegments()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Health.Connect.Datatypes.ExerciseSegment> GetSegments()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Health.Connect.Datatypes.ExerciseSegment>>("getSegments", "()Ljava/util/List;");
        }

        #endregion

        #region Nested classes
        #region Builder
        public partial class Builder
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/ExerciseSessionRecord.Builder.html#%3Cinit%3E(android.health.connect.datatypes.Metadata,java.time.Instant,java.time.Instant,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Health.Connect.Datatypes.Metadata"/></param>
            /// <param name="arg1"><see cref="Java.Time.Instant"/></param>
            /// <param name="arg2"><see cref="Java.Time.Instant"/></param>
            /// <param name="arg3"><see cref="int"/></param>
            public Builder(Android.Health.Connect.Datatypes.Metadata arg0, Java.Time.Instant arg1, Java.Time.Instant arg2, int arg3)
                : base(arg0, arg1, arg2, arg3)
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
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/ExerciseSessionRecord.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Health.Connect.Datatypes.ExerciseSessionRecord"/></returns>
            public Android.Health.Connect.Datatypes.ExerciseSessionRecord Build()
            {
                return IExecuteWithSignature<Android.Health.Connect.Datatypes.ExerciseSessionRecord>("build", "()Landroid/health/connect/datatypes/ExerciseSessionRecord;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/ExerciseSessionRecord.Builder.html#clearEndZoneOffset()"/>
            /// </summary>
            /// <returns><see cref="Android.Health.Connect.Datatypes.ExerciseSessionRecord.Builder"/></returns>
            public Android.Health.Connect.Datatypes.ExerciseSessionRecord.Builder ClearEndZoneOffset()
            {
                return IExecuteWithSignature<Android.Health.Connect.Datatypes.ExerciseSessionRecord.Builder>("clearEndZoneOffset", "()Landroid/health/connect/datatypes/ExerciseSessionRecord$Builder;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/ExerciseSessionRecord.Builder.html#clearStartZoneOffset()"/>
            /// </summary>
            /// <returns><see cref="Android.Health.Connect.Datatypes.ExerciseSessionRecord.Builder"/></returns>
            public Android.Health.Connect.Datatypes.ExerciseSessionRecord.Builder ClearStartZoneOffset()
            {
                return IExecuteWithSignature<Android.Health.Connect.Datatypes.ExerciseSessionRecord.Builder>("clearStartZoneOffset", "()Landroid/health/connect/datatypes/ExerciseSessionRecord$Builder;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/ExerciseSessionRecord.Builder.html#setEndZoneOffset(java.time.ZoneOffset)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Time.ZoneOffset"/></param>
            /// <returns><see cref="Android.Health.Connect.Datatypes.ExerciseSessionRecord.Builder"/></returns>
            public Android.Health.Connect.Datatypes.ExerciseSessionRecord.Builder SetEndZoneOffset(Java.Time.ZoneOffset arg0)
            {
                return IExecuteWithSignature<Android.Health.Connect.Datatypes.ExerciseSessionRecord.Builder>("setEndZoneOffset", "(Ljava/time/ZoneOffset;)Landroid/health/connect/datatypes/ExerciseSessionRecord$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/ExerciseSessionRecord.Builder.html#setLaps(java.util.List)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.List"/></param>
            /// <returns><see cref="Android.Health.Connect.Datatypes.ExerciseSessionRecord.Builder"/></returns>
            public Android.Health.Connect.Datatypes.ExerciseSessionRecord.Builder SetLaps(Java.Util.List<Android.Health.Connect.Datatypes.ExerciseLap> arg0)
            {
                return IExecuteWithSignature<Android.Health.Connect.Datatypes.ExerciseSessionRecord.Builder>("setLaps", "(Ljava/util/List;)Landroid/health/connect/datatypes/ExerciseSessionRecord$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/ExerciseSessionRecord.Builder.html#setNotes(java.lang.CharSequence)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
            /// <returns><see cref="Android.Health.Connect.Datatypes.ExerciseSessionRecord.Builder"/></returns>
            public Android.Health.Connect.Datatypes.ExerciseSessionRecord.Builder SetNotes(Java.Lang.CharSequence arg0)
            {
                return IExecuteWithSignature<Android.Health.Connect.Datatypes.ExerciseSessionRecord.Builder>("setNotes", "(Ljava/lang/CharSequence;)Landroid/health/connect/datatypes/ExerciseSessionRecord$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/ExerciseSessionRecord.Builder.html#setRoute(android.health.connect.datatypes.ExerciseRoute)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Health.Connect.Datatypes.ExerciseRoute"/></param>
            /// <returns><see cref="Android.Health.Connect.Datatypes.ExerciseSessionRecord.Builder"/></returns>
            public Android.Health.Connect.Datatypes.ExerciseSessionRecord.Builder SetRoute(Android.Health.Connect.Datatypes.ExerciseRoute arg0)
            {
                return IExecuteWithSignature<Android.Health.Connect.Datatypes.ExerciseSessionRecord.Builder>("setRoute", "(Landroid/health/connect/datatypes/ExerciseRoute;)Landroid/health/connect/datatypes/ExerciseSessionRecord$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/ExerciseSessionRecord.Builder.html#setSegments(java.util.List)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.List"/></param>
            /// <returns><see cref="Android.Health.Connect.Datatypes.ExerciseSessionRecord.Builder"/></returns>
            public Android.Health.Connect.Datatypes.ExerciseSessionRecord.Builder SetSegments(Java.Util.List<Android.Health.Connect.Datatypes.ExerciseSegment> arg0)
            {
                return IExecuteWithSignature<Android.Health.Connect.Datatypes.ExerciseSessionRecord.Builder>("setSegments", "(Ljava/util/List;)Landroid/health/connect/datatypes/ExerciseSessionRecord$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/ExerciseSessionRecord.Builder.html#setStartZoneOffset(java.time.ZoneOffset)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Time.ZoneOffset"/></param>
            /// <returns><see cref="Android.Health.Connect.Datatypes.ExerciseSessionRecord.Builder"/></returns>
            public Android.Health.Connect.Datatypes.ExerciseSessionRecord.Builder SetStartZoneOffset(Java.Time.ZoneOffset arg0)
            {
                return IExecuteWithSignature<Android.Health.Connect.Datatypes.ExerciseSessionRecord.Builder>("setStartZoneOffset", "(Ljava/time/ZoneOffset;)Landroid/health/connect/datatypes/ExerciseSessionRecord$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/ExerciseSessionRecord.Builder.html#setTitle(java.lang.CharSequence)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
            /// <returns><see cref="Android.Health.Connect.Datatypes.ExerciseSessionRecord.Builder"/></returns>
            public Android.Health.Connect.Datatypes.ExerciseSessionRecord.Builder SetTitle(Java.Lang.CharSequence arg0)
            {
                return IExecuteWithSignature<Android.Health.Connect.Datatypes.ExerciseSessionRecord.Builder>("setTitle", "(Ljava/lang/CharSequence;)Landroid/health/connect/datatypes/ExerciseSessionRecord$Builder;", arg0);
            }

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