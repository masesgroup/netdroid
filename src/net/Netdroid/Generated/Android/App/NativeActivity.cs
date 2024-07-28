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

namespace Android.App
{
    #region NativeActivity
    public partial class NativeActivity
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/NativeActivity.html#META_DATA_FUNC_NAME"/>
        /// </summary>
        public static Java.Lang.String META_DATA_FUNC_NAME { get { if (!_META_DATA_FUNC_NAMEReady) { _META_DATA_FUNC_NAMEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "META_DATA_FUNC_NAME"); _META_DATA_FUNC_NAMEReady = true; } return _META_DATA_FUNC_NAMEContent; } }
        private static Java.Lang.String _META_DATA_FUNC_NAMEContent = default;
        private static bool _META_DATA_FUNC_NAMEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/NativeActivity.html#META_DATA_LIB_NAME"/>
        /// </summary>
        public static Java.Lang.String META_DATA_LIB_NAME { get { if (!_META_DATA_LIB_NAMEReady) { _META_DATA_LIB_NAMEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "META_DATA_LIB_NAME"); _META_DATA_LIB_NAMEReady = true; } return _META_DATA_LIB_NAMEContent; } }
        private static Java.Lang.String _META_DATA_LIB_NAMEContent = default;
        private static bool _META_DATA_LIB_NAMEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/NativeActivity.html#onGlobalLayout()"/>
        /// </summary>
        public void OnGlobalLayout()
        {
            IExecuteWithSignature("onGlobalLayout", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/NativeActivity.html#onInputQueueCreated(android.view.InputQueue)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.InputQueue"/></param>
        public void OnInputQueueCreated(Android.View.InputQueue arg0)
        {
            IExecuteWithSignature("onInputQueueCreated", "(Landroid/view/InputQueue;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/NativeActivity.html#onInputQueueDestroyed(android.view.InputQueue)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.InputQueue"/></param>
        public void OnInputQueueDestroyed(Android.View.InputQueue arg0)
        {
            IExecuteWithSignature("onInputQueueDestroyed", "(Landroid/view/InputQueue;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/NativeActivity.html#surfaceChanged(android.view.SurfaceHolder,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.SurfaceHolder"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public void SurfaceChanged(Android.View.SurfaceHolder arg0, int arg1, int arg2, int arg3)
        {
            IExecute("surfaceChanged", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/NativeActivity.html#surfaceCreated(android.view.SurfaceHolder)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.SurfaceHolder"/></param>
        public void SurfaceCreated(Android.View.SurfaceHolder arg0)
        {
            IExecuteWithSignature("surfaceCreated", "(Landroid/view/SurfaceHolder;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/NativeActivity.html#surfaceDestroyed(android.view.SurfaceHolder)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.SurfaceHolder"/></param>
        public void SurfaceDestroyed(Android.View.SurfaceHolder arg0)
        {
            IExecuteWithSignature("surfaceDestroyed", "(Landroid/view/SurfaceHolder;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/NativeActivity.html#surfaceRedrawNeeded(android.view.SurfaceHolder)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.SurfaceHolder"/></param>
        public void SurfaceRedrawNeeded(Android.View.SurfaceHolder arg0)
        {
            IExecuteWithSignature("surfaceRedrawNeeded", "(Landroid/view/SurfaceHolder;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}