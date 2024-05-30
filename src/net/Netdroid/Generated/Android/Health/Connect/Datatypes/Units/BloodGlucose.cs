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

namespace Android.Health.Connect.Datatypes.Units
{
    #region BloodGlucose
    public partial class BloodGlucose
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/units/BloodGlucose.html#fromMillimolesPerLiter(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="Android.Health.Connect.Datatypes.Units.BloodGlucose"/></returns>
        public static Android.Health.Connect.Datatypes.Units.BloodGlucose FromMillimolesPerLiter(double arg0)
        {
            return SExecuteWithSignature<Android.Health.Connect.Datatypes.Units.BloodGlucose>(LocalBridgeClazz, "fromMillimolesPerLiter", "(D)Landroid/health/connect/datatypes/units/BloodGlucose;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/units/BloodGlucose.html#getInMillimolesPerLiter()"/> 
        /// </summary>
        public double InMillimolesPerLiter
        {
            get { return IExecuteWithSignature<double>("getInMillimolesPerLiter", "()D"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/units/BloodGlucose.html#compareTo(android.health.connect.datatypes.units.BloodGlucose)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Health.Connect.Datatypes.Units.BloodGlucose"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(Android.Health.Connect.Datatypes.Units.BloodGlucose arg0)
        {
            return IExecuteWithSignature<int>("compareTo", "(Landroid/health/connect/datatypes/units/BloodGlucose;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/units/BloodGlucose.html#compareTo(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(object arg0)
        {
            return IExecuteWithSignature<int>("compareTo", "(Ljava/lang/Object;)I", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}