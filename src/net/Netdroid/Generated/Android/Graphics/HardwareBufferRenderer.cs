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
*  This file is generated by MASES.JNetReflector (ver. 2.5.2.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Graphics
{
    #region HardwareBufferRenderer
    public partial class HardwareBufferRenderer
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/HardwareBufferRenderer.html#%3Cinit%3E(android.hardware.HardwareBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Hardware.HardwareBuffer"/></param>
        public HardwareBufferRenderer(Android.Hardware.HardwareBuffer arg0)
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
        /// <see href="https://developer.android.com/reference/android/graphics/HardwareBufferRenderer.html#obtainRenderRequest()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.HardwareBufferRenderer.RenderRequest"/></returns>
        public Android.Graphics.HardwareBufferRenderer.RenderRequest ObtainRenderRequest()
        {
            return IExecuteWithSignature<Android.Graphics.HardwareBufferRenderer.RenderRequest>("obtainRenderRequest", "()Landroid/graphics/HardwareBufferRenderer$RenderRequest;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/HardwareBufferRenderer.html#isClosed()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsClosed()
        {
            return IExecuteWithSignature<bool>("isClosed", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/HardwareBufferRenderer.html#close()"/>
        /// </summary>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/HardwareBufferRenderer.html#setContentRoot(android.graphics.RenderNode)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.RenderNode"/></param>
        public void SetContentRoot(Android.Graphics.RenderNode arg0)
        {
            IExecuteWithSignature("setContentRoot", "(Landroid/graphics/RenderNode;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/HardwareBufferRenderer.html#setLightSourceAlpha(float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        public void SetLightSourceAlpha(float arg0, float arg1)
        {
            IExecute("setLightSourceAlpha", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/HardwareBufferRenderer.html#setLightSourceGeometry(float,float,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="float"/></param>
        public void SetLightSourceGeometry(float arg0, float arg1, float arg2, float arg3)
        {
            IExecute("setLightSourceGeometry", arg0, arg1, arg2, arg3);
        }

        #endregion

        #region Nested classes
        #region RenderRequest
        public partial class RenderRequest
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
            /// <see href="https://developer.android.com/reference/android/graphics/HardwareBufferRenderer.RenderRequest.html#setBufferTransform(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Graphics.HardwareBufferRenderer.RenderRequest"/></returns>
            public Android.Graphics.HardwareBufferRenderer.RenderRequest SetBufferTransform(int arg0)
            {
                return IExecuteWithSignature<Android.Graphics.HardwareBufferRenderer.RenderRequest>("setBufferTransform", "(I)Landroid/graphics/HardwareBufferRenderer$RenderRequest;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/HardwareBufferRenderer.RenderRequest.html#setColorSpace(android.graphics.ColorSpace)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Graphics.ColorSpace"/></param>
            /// <returns><see cref="Android.Graphics.HardwareBufferRenderer.RenderRequest"/></returns>
            public Android.Graphics.HardwareBufferRenderer.RenderRequest SetColorSpace(Android.Graphics.ColorSpace arg0)
            {
                return IExecuteWithSignature<Android.Graphics.HardwareBufferRenderer.RenderRequest>("setColorSpace", "(Landroid/graphics/ColorSpace;)Landroid/graphics/HardwareBufferRenderer$RenderRequest;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/HardwareBufferRenderer.RenderRequest.html#draw(java.util.concurrent.Executor,java.util.function.Consumer)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Concurrent.Executor"/></param>
            /// <param name="arg1"><see cref="Java.Util.Function.Consumer"/></param>
            public void Draw(Java.Util.Concurrent.Executor arg0, Java.Util.Function.Consumer<Android.Graphics.HardwareBufferRenderer.RenderResult> arg1)
            {
                IExecute("draw", arg0, arg1);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region RenderResult
        public partial class RenderResult
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/HardwareBufferRenderer.RenderResult.html#ERROR_UNKNOWN"/>
            /// </summary>
            public static int ERROR_UNKNOWN { get { if (!_ERROR_UNKNOWNReady) { _ERROR_UNKNOWNContent = SGetField<int>(LocalBridgeClazz, "ERROR_UNKNOWN"); _ERROR_UNKNOWNReady = true; } return _ERROR_UNKNOWNContent; } }
            private static int _ERROR_UNKNOWNContent = default;
            private static bool _ERROR_UNKNOWNReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/HardwareBufferRenderer.RenderResult.html#SUCCESS"/>
            /// </summary>
            public static int SUCCESS { get { if (!_SUCCESSReady) { _SUCCESSContent = SGetField<int>(LocalBridgeClazz, "SUCCESS"); _SUCCESSReady = true; } return _SUCCESSContent; } }
            private static int _SUCCESSContent = default;
            private static bool _SUCCESSReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/HardwareBufferRenderer.RenderResult.html#getFence()"/>
            /// </summary>
            /// <returns><see cref="Android.Hardware.SyncFence"/></returns>
            public Android.Hardware.SyncFence GetFence()
            {
                return IExecuteWithSignature<Android.Hardware.SyncFence>("getFence", "()Landroid/hardware/SyncFence;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/HardwareBufferRenderer.RenderResult.html#getStatus()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetStatus()
            {
                return IExecuteWithSignature<int>("getStatus", "()I");
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