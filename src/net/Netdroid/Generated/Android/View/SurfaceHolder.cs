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

namespace Android.View
{
    #region ISurfaceHolder
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ISurfaceHolder
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region SurfaceHolder
    public partial class SurfaceHolder : Android.View.ISurfaceHolder
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/SurfaceHolder.html#SURFACE_TYPE_GPU"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int SURFACE_TYPE_GPU { get { if (!_SURFACE_TYPE_GPUReady) { _SURFACE_TYPE_GPUContent = SGetField<int>(LocalBridgeClazz, "SURFACE_TYPE_GPU"); _SURFACE_TYPE_GPUReady = true; } return _SURFACE_TYPE_GPUContent; } }
        private static int _SURFACE_TYPE_GPUContent = default;
        private static bool _SURFACE_TYPE_GPUReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/SurfaceHolder.html#SURFACE_TYPE_HARDWARE"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int SURFACE_TYPE_HARDWARE { get { if (!_SURFACE_TYPE_HARDWAREReady) { _SURFACE_TYPE_HARDWAREContent = SGetField<int>(LocalBridgeClazz, "SURFACE_TYPE_HARDWARE"); _SURFACE_TYPE_HARDWAREReady = true; } return _SURFACE_TYPE_HARDWAREContent; } }
        private static int _SURFACE_TYPE_HARDWAREContent = default;
        private static bool _SURFACE_TYPE_HARDWAREReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/SurfaceHolder.html#SURFACE_TYPE_NORMAL"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int SURFACE_TYPE_NORMAL { get { if (!_SURFACE_TYPE_NORMALReady) { _SURFACE_TYPE_NORMALContent = SGetField<int>(LocalBridgeClazz, "SURFACE_TYPE_NORMAL"); _SURFACE_TYPE_NORMALReady = true; } return _SURFACE_TYPE_NORMALContent; } }
        private static int _SURFACE_TYPE_NORMALContent = default;
        private static bool _SURFACE_TYPE_NORMALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/SurfaceHolder.html#SURFACE_TYPE_PUSH_BUFFERS"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int SURFACE_TYPE_PUSH_BUFFERS { get { if (!_SURFACE_TYPE_PUSH_BUFFERSReady) { _SURFACE_TYPE_PUSH_BUFFERSContent = SGetField<int>(LocalBridgeClazz, "SURFACE_TYPE_PUSH_BUFFERS"); _SURFACE_TYPE_PUSH_BUFFERSReady = true; } return _SURFACE_TYPE_PUSH_BUFFERSContent; } }
        private static int _SURFACE_TYPE_PUSH_BUFFERSContent = default;
        private static bool _SURFACE_TYPE_PUSH_BUFFERSReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/SurfaceHolder.html#lockCanvas()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.Canvas"/></returns>
        public Android.Graphics.Canvas LockCanvas()
        {
            return IExecuteWithSignature<Android.Graphics.Canvas>("lockCanvas", "()Landroid/graphics/Canvas;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/SurfaceHolder.html#lockCanvas(android.graphics.Rect)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Rect"/></param>
        /// <returns><see cref="Android.Graphics.Canvas"/></returns>
        public Android.Graphics.Canvas LockCanvas(Android.Graphics.Rect arg0)
        {
            return IExecuteWithSignature<Android.Graphics.Canvas>("lockCanvas", "(Landroid/graphics/Rect;)Landroid/graphics/Canvas;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/SurfaceHolder.html#getSurfaceFrame()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.Rect"/></returns>
        public Android.Graphics.Rect GetSurfaceFrame()
        {
            return IExecuteWithSignature<Android.Graphics.Rect>("getSurfaceFrame", "()Landroid/graphics/Rect;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/SurfaceHolder.html#getSurface()"/>
        /// </summary>
        /// <returns><see cref="Android.View.Surface"/></returns>
        public Android.View.Surface GetSurface()
        {
            return IExecuteWithSignature<Android.View.Surface>("getSurface", "()Landroid/view/Surface;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/SurfaceHolder.html#isCreating()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsCreating()
        {
            return IExecuteWithSignature<bool>("isCreating", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/SurfaceHolder.html#addCallback(android.view.SurfaceHolder.Callback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.SurfaceHolder.Callback"/></param>
        public void AddCallback(Android.View.SurfaceHolder.Callback arg0)
        {
            IExecuteWithSignature("addCallback", "(Landroid/view/SurfaceHolder$Callback;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/SurfaceHolder.html#removeCallback(android.view.SurfaceHolder.Callback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.SurfaceHolder.Callback"/></param>
        public void RemoveCallback(Android.View.SurfaceHolder.Callback arg0)
        {
            IExecuteWithSignature("removeCallback", "(Landroid/view/SurfaceHolder$Callback;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/SurfaceHolder.html#setFixedSize(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void SetFixedSize(int arg0, int arg1)
        {
            IExecute("setFixedSize", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/SurfaceHolder.html#setFormat(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetFormat(int arg0)
        {
            IExecuteWithSignature("setFormat", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/SurfaceHolder.html#setKeepScreenOn(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetKeepScreenOn(bool arg0)
        {
            IExecuteWithSignature("setKeepScreenOn", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/SurfaceHolder.html#setSizeFromLayout()"/>
        /// </summary>
        public void SetSizeFromLayout()
        {
            IExecuteWithSignature("setSizeFromLayout", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/SurfaceHolder.html#setType(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        [global::System.Obsolete()]
        public void SetType(int arg0)
        {
            IExecuteWithSignature("setType", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/SurfaceHolder.html#unlockCanvasAndPost(android.graphics.Canvas)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Canvas"/></param>
        public void UnlockCanvasAndPost(Android.Graphics.Canvas arg0)
        {
            IExecuteWithSignature("unlockCanvasAndPost", "(Landroid/graphics/Canvas;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/SurfaceHolder.html#lockHardwareCanvas()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.Canvas"/></returns>
        public Android.Graphics.Canvas LockHardwareCanvas()
        {
            return IExecuteWithSignature<Android.Graphics.Canvas>("lockHardwareCanvas", "()Landroid/graphics/Canvas;");
        }

        #endregion

        #region Nested classes
        #region BadSurfaceTypeException
        public partial class BadSurfaceTypeException
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

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region Callback
        public partial class Callback
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
            /// <see href="https://developer.android.com/reference/android/view/SurfaceHolder.Callback.html#surfaceChanged(android.view.SurfaceHolder,int,int,int)"/>
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
            /// <see href="https://developer.android.com/reference/android/view/SurfaceHolder.Callback.html#surfaceCreated(android.view.SurfaceHolder)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.SurfaceHolder"/></param>
            public void SurfaceCreated(Android.View.SurfaceHolder arg0)
            {
                IExecuteWithSignature("surfaceCreated", "(Landroid/view/SurfaceHolder;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/SurfaceHolder.Callback.html#surfaceDestroyed(android.view.SurfaceHolder)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.SurfaceHolder"/></param>
            public void SurfaceDestroyed(Android.View.SurfaceHolder arg0)
            {
                IExecuteWithSignature("surfaceDestroyed", "(Landroid/view/SurfaceHolder;)V", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region Callback2
        public partial class Callback2
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
            /// <see href="https://developer.android.com/reference/android/view/SurfaceHolder.Callback2.html#surfaceRedrawNeeded(android.view.SurfaceHolder)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.SurfaceHolder"/></param>
            public void SurfaceRedrawNeeded(Android.View.SurfaceHolder arg0)
            {
                IExecuteWithSignature("surfaceRedrawNeeded", "(Landroid/view/SurfaceHolder;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/SurfaceHolder.Callback2.html#surfaceRedrawNeededAsync(android.view.SurfaceHolder,java.lang.Runnable)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.SurfaceHolder"/></param>
            /// <param name="arg1"><see cref="Java.Lang.Runnable"/></param>
            public void SurfaceRedrawNeededAsync(Android.View.SurfaceHolder arg0, Java.Lang.Runnable arg1)
            {
                IExecute("surfaceRedrawNeededAsync", arg0, arg1);
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