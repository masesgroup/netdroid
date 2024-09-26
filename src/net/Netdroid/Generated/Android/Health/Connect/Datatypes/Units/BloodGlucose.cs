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
*  This file is generated by MASES.JNetReflector (ver. 2.5.9.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Health.Connect.Datatypes.Units
{
    #region BloodGlucose declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/units/BloodGlucose.html"/>
    /// </summary>
    public partial class BloodGlucose : Java.Lang.Comparable<Android.Health.Connect.Datatypes.Units.BloodGlucose>
    {
        const string _bridgeClassName = "android.health.connect.datatypes.units.BloodGlucose";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public BloodGlucose() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public BloodGlucose(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region BloodGlucose implementation
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
        /// <returns><see cref="double"/></returns>
        public double GetInMillimolesPerLiter()
        {
            return IExecuteWithSignature<double>("getInMillimolesPerLiter", "()D");
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