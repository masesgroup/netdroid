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

namespace Android.Hardware.Camera2.Params
{
    #region ColorSpaceTransform
    public partial class ColorSpaceTransform
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/ColorSpaceTransform.html#%3Cinit%3E(android.util.Rational[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Util.Rational"/></param>
        public ColorSpaceTransform(Android.Util.Rational[] arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/ColorSpaceTransform.html#%3Cinit%3E(int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public ColorSpaceTransform(int[] arg0)
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
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/ColorSpaceTransform.html#getElement(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Android.Util.Rational"/></returns>
        public Android.Util.Rational GetElement(int arg0, int arg1)
        {
            return IExecute<Android.Util.Rational>("getElement", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/ColorSpaceTransform.html#copyElements(android.util.Rational[],int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Util.Rational"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void CopyElements(Android.Util.Rational[] arg0, int arg1)
        {
            IExecute("copyElements", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/ColorSpaceTransform.html#copyElements(int[],int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void CopyElements(int[] arg0, int arg1)
        {
            IExecute("copyElements", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}