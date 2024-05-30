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

namespace Android.Hardware.Camera2.Params
{
    #region Capability
    public partial class Capability
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/Capability.html#%3Cinit%3E(int,android.util.Size,android.util.Range)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.Util.Size"/></param>
        /// <param name="arg2"><see cref="Android.Util.Range"/></param>
        public Capability(int arg0, Android.Util.Size arg1, Android.Util.Range<Java.Lang.Float> arg2)
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
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/Capability.html#getMaxStreamingSize()"/> 
        /// </summary>
        public Android.Util.Size MaxStreamingSize
        {
            get { return IExecuteWithSignature<Android.Util.Size>("getMaxStreamingSize", "()Landroid/util/Size;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/Capability.html#getMode()"/> 
        /// </summary>
        public int Mode
        {
            get { return IExecuteWithSignature<int>("getMode", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/Capability.html#getZoomRatioRange()"/> 
        /// </summary>
        public Android.Util.Range<Java.Lang.Float> ZoomRatioRange
        {
            get { return IExecuteWithSignature<Android.Util.Range<Java.Lang.Float>>("getZoomRatioRange", "()Landroid/util/Range;"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}