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

namespace Android.Health.Connect.Datatypes
{
    #region ExercisePerformanceGoal
    public partial class ExercisePerformanceGoal
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

        #endregion

        #region Nested classes
        #region AmrapGoal
        public partial class AmrapGoal
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/ExercisePerformanceGoal.AmrapGoal.html#INSTANCE"/>
            /// </summary>
            public static Android.Health.Connect.Datatypes.ExercisePerformanceGoal.AmrapGoal INSTANCE { get { if (!_INSTANCEReady) { _INSTANCEContent = SGetField<Android.Health.Connect.Datatypes.ExercisePerformanceGoal.AmrapGoal>(LocalBridgeClazz, "INSTANCE"); _INSTANCEReady = true; } return _INSTANCEContent; } }
            private static Android.Health.Connect.Datatypes.ExercisePerformanceGoal.AmrapGoal _INSTANCEContent = default;
            private static bool _INSTANCEReady = false; // this is used because in case of generics 

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

        #region CadenceGoal
        public partial class CadenceGoal
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/ExercisePerformanceGoal.CadenceGoal.html#%3Cinit%3E(double,double)"/>
            /// </summary>
            /// <param name="arg0"><see cref="double"/></param>
            /// <param name="arg1"><see cref="double"/></param>
            public CadenceGoal(double arg0, double arg1)
                : base(arg0, arg1)
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
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/ExercisePerformanceGoal.CadenceGoal.html#getMaxRpm()"/>
            /// </summary>
            /// <returns><see cref="double"/></returns>
            public double GetMaxRpm()
            {
                return IExecuteWithSignature<double>("getMaxRpm", "()D");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/ExercisePerformanceGoal.CadenceGoal.html#getMinRpm()"/>
            /// </summary>
            /// <returns><see cref="double"/></returns>
            public double GetMinRpm()
            {
                return IExecuteWithSignature<double>("getMinRpm", "()D");
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region HeartRateGoal
        public partial class HeartRateGoal
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/ExercisePerformanceGoal.HeartRateGoal.html#%3Cinit%3E(int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            public HeartRateGoal(int arg0, int arg1)
                : base(arg0, arg1)
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
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/ExercisePerformanceGoal.HeartRateGoal.html#getMaxBpm()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetMaxBpm()
            {
                return IExecuteWithSignature<int>("getMaxBpm", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/ExercisePerformanceGoal.HeartRateGoal.html#getMinBpm()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetMinBpm()
            {
                return IExecuteWithSignature<int>("getMinBpm", "()I");
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region PowerGoal
        public partial class PowerGoal
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/ExercisePerformanceGoal.PowerGoal.html#%3Cinit%3E(android.health.connect.datatypes.units.Power,android.health.connect.datatypes.units.Power)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Health.Connect.Datatypes.Units.Power"/></param>
            /// <param name="arg1"><see cref="Android.Health.Connect.Datatypes.Units.Power"/></param>
            public PowerGoal(Android.Health.Connect.Datatypes.Units.Power arg0, Android.Health.Connect.Datatypes.Units.Power arg1)
                : base(arg0, arg1)
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
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/ExercisePerformanceGoal.PowerGoal.html#getMaxPower()"/>
            /// </summary>
            /// <returns><see cref="Android.Health.Connect.Datatypes.Units.Power"/></returns>
            public Android.Health.Connect.Datatypes.Units.Power GetMaxPower()
            {
                return IExecuteWithSignature<Android.Health.Connect.Datatypes.Units.Power>("getMaxPower", "()Landroid/health/connect/datatypes/units/Power;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/ExercisePerformanceGoal.PowerGoal.html#getMinPower()"/>
            /// </summary>
            /// <returns><see cref="Android.Health.Connect.Datatypes.Units.Power"/></returns>
            public Android.Health.Connect.Datatypes.Units.Power GetMinPower()
            {
                return IExecuteWithSignature<Android.Health.Connect.Datatypes.Units.Power>("getMinPower", "()Landroid/health/connect/datatypes/units/Power;");
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region RateOfPerceivedExertionGoal
        public partial class RateOfPerceivedExertionGoal
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/ExercisePerformanceGoal.RateOfPerceivedExertionGoal.html#%3Cinit%3E(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            public RateOfPerceivedExertionGoal(int arg0)
                : base(arg0)
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
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/ExercisePerformanceGoal.RateOfPerceivedExertionGoal.html#getRpe()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetRpe()
            {
                return IExecuteWithSignature<int>("getRpe", "()I");
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region SpeedGoal
        public partial class SpeedGoal
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/ExercisePerformanceGoal.SpeedGoal.html#%3Cinit%3E(android.health.connect.datatypes.units.Velocity,android.health.connect.datatypes.units.Velocity)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Health.Connect.Datatypes.Units.Velocity"/></param>
            /// <param name="arg1"><see cref="Android.Health.Connect.Datatypes.Units.Velocity"/></param>
            public SpeedGoal(Android.Health.Connect.Datatypes.Units.Velocity arg0, Android.Health.Connect.Datatypes.Units.Velocity arg1)
                : base(arg0, arg1)
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
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/ExercisePerformanceGoal.SpeedGoal.html#getMaxSpeed()"/>
            /// </summary>
            /// <returns><see cref="Android.Health.Connect.Datatypes.Units.Velocity"/></returns>
            public Android.Health.Connect.Datatypes.Units.Velocity GetMaxSpeed()
            {
                return IExecuteWithSignature<Android.Health.Connect.Datatypes.Units.Velocity>("getMaxSpeed", "()Landroid/health/connect/datatypes/units/Velocity;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/ExercisePerformanceGoal.SpeedGoal.html#getMinSpeed()"/>
            /// </summary>
            /// <returns><see cref="Android.Health.Connect.Datatypes.Units.Velocity"/></returns>
            public Android.Health.Connect.Datatypes.Units.Velocity GetMinSpeed()
            {
                return IExecuteWithSignature<Android.Health.Connect.Datatypes.Units.Velocity>("getMinSpeed", "()Landroid/health/connect/datatypes/units/Velocity;");
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region UnknownGoal
        public partial class UnknownGoal
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/ExercisePerformanceGoal.UnknownGoal.html#INSTANCE"/>
            /// </summary>
            public static Android.Health.Connect.Datatypes.ExercisePerformanceGoal.UnknownGoal INSTANCE { get { if (!_INSTANCEReady) { _INSTANCEContent = SGetField<Android.Health.Connect.Datatypes.ExercisePerformanceGoal.UnknownGoal>(LocalBridgeClazz, "INSTANCE"); _INSTANCEReady = true; } return _INSTANCEContent; } }
            private static Android.Health.Connect.Datatypes.ExercisePerformanceGoal.UnknownGoal _INSTANCEContent = default;
            private static bool _INSTANCEReady = false; // this is used because in case of generics 

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

        #region WeightGoal
        public partial class WeightGoal
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/ExercisePerformanceGoal.WeightGoal.html#%3Cinit%3E(android.health.connect.datatypes.units.Mass)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Health.Connect.Datatypes.Units.Mass"/></param>
            public WeightGoal(Android.Health.Connect.Datatypes.Units.Mass arg0)
                : base(arg0)
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
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/ExercisePerformanceGoal.WeightGoal.html#getMass()"/>
            /// </summary>
            /// <returns><see cref="Android.Health.Connect.Datatypes.Units.Mass"/></returns>
            public Android.Health.Connect.Datatypes.Units.Mass GetMass()
            {
                return IExecuteWithSignature<Android.Health.Connect.Datatypes.Units.Mass>("getMass", "()Landroid/health/connect/datatypes/units/Mass;");
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