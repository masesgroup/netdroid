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

namespace Android.Hardware.Camera2.Params
{
    #region MultiResolutionStreamInfo
    public partial class MultiResolutionStreamInfo
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/MultiResolutionStreamInfo.html#%3Cinit%3E(int,int,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        public MultiResolutionStreamInfo(int arg0, int arg1, Java.Lang.String arg2)
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
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/MultiResolutionStreamInfo.html#getHeight()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetHeight()
        {
            return IExecuteWithSignature<int>("getHeight", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/MultiResolutionStreamInfo.html#getWidth()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetWidth()
        {
            return IExecuteWithSignature<int>("getWidth", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/MultiResolutionStreamInfo.html#getPhysicalCameraId()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetPhysicalCameraId()
        {
            return IExecuteWithSignature<Java.Lang.String>("getPhysicalCameraId", "()Ljava/lang/String;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}