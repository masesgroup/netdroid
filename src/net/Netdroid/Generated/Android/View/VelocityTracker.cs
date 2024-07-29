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

namespace Android.View
{
    #region VelocityTracker
    public partial class VelocityTracker
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/VelocityTracker.html#obtain()"/>
        /// </summary>
        /// <returns><see cref="Android.View.VelocityTracker"/></returns>
        public static Android.View.VelocityTracker Obtain()
        {
            return SExecuteWithSignature<Android.View.VelocityTracker>(LocalBridgeClazz, "obtain", "()Landroid/view/VelocityTracker;");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/VelocityTracker.html#isAxisSupported(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsAxisSupported(int arg0)
        {
            return IExecuteWithSignature<bool>("isAxisSupported", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/VelocityTracker.html#getAxisVelocity(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="float"/></returns>
        public float GetAxisVelocity(int arg0, int arg1)
        {
            return IExecute<float>("getAxisVelocity", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/VelocityTracker.html#getAxisVelocity(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="float"/></returns>
        public float GetAxisVelocity(int arg0)
        {
            return IExecuteWithSignature<float>("getAxisVelocity", "(I)F", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/VelocityTracker.html#getXVelocity()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetXVelocity()
        {
            return IExecuteWithSignature<float>("getXVelocity", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/VelocityTracker.html#getXVelocity(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="float"/></returns>
        public float GetXVelocity(int arg0)
        {
            return IExecuteWithSignature<float>("getXVelocity", "(I)F", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/VelocityTracker.html#getYVelocity()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetYVelocity()
        {
            return IExecuteWithSignature<float>("getYVelocity", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/VelocityTracker.html#getYVelocity(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="float"/></returns>
        public float GetYVelocity(int arg0)
        {
            return IExecuteWithSignature<float>("getYVelocity", "(I)F", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/VelocityTracker.html#addMovement(android.view.MotionEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.MotionEvent"/></param>
        public void AddMovement(Android.View.MotionEvent arg0)
        {
            IExecuteWithSignature("addMovement", "(Landroid/view/MotionEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/VelocityTracker.html#clear()"/>
        /// </summary>
        public void Clear()
        {
            IExecuteWithSignature("clear", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/VelocityTracker.html#computeCurrentVelocity(int,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        public void ComputeCurrentVelocity(int arg0, float arg1)
        {
            IExecute("computeCurrentVelocity", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/VelocityTracker.html#computeCurrentVelocity(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void ComputeCurrentVelocity(int arg0)
        {
            IExecuteWithSignature("computeCurrentVelocity", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/VelocityTracker.html#recycle()"/>
        /// </summary>
        public void Recycle()
        {
            IExecuteWithSignature("recycle", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}