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

namespace Android.Accessibilityservice
{
    #region TouchInteractionController
    public partial class TouchInteractionController
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/TouchInteractionController.html#STATE_CLEAR"/>
        /// </summary>
        public static int STATE_CLEAR { get { if (!_STATE_CLEARReady) { _STATE_CLEARContent = SGetField<int>(LocalBridgeClazz, "STATE_CLEAR"); _STATE_CLEARReady = true; } return _STATE_CLEARContent; } }
        private static int _STATE_CLEARContent = default;
        private static bool _STATE_CLEARReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/TouchInteractionController.html#STATE_DELEGATING"/>
        /// </summary>
        public static int STATE_DELEGATING { get { if (!_STATE_DELEGATINGReady) { _STATE_DELEGATINGContent = SGetField<int>(LocalBridgeClazz, "STATE_DELEGATING"); _STATE_DELEGATINGReady = true; } return _STATE_DELEGATINGContent; } }
        private static int _STATE_DELEGATINGContent = default;
        private static bool _STATE_DELEGATINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/TouchInteractionController.html#STATE_DRAGGING"/>
        /// </summary>
        public static int STATE_DRAGGING { get { if (!_STATE_DRAGGINGReady) { _STATE_DRAGGINGContent = SGetField<int>(LocalBridgeClazz, "STATE_DRAGGING"); _STATE_DRAGGINGReady = true; } return _STATE_DRAGGINGContent; } }
        private static int _STATE_DRAGGINGContent = default;
        private static bool _STATE_DRAGGINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/TouchInteractionController.html#STATE_TOUCH_EXPLORING"/>
        /// </summary>
        public static int STATE_TOUCH_EXPLORING { get { if (!_STATE_TOUCH_EXPLORINGReady) { _STATE_TOUCH_EXPLORINGContent = SGetField<int>(LocalBridgeClazz, "STATE_TOUCH_EXPLORING"); _STATE_TOUCH_EXPLORINGReady = true; } return _STATE_TOUCH_EXPLORINGContent; } }
        private static int _STATE_TOUCH_EXPLORINGContent = default;
        private static bool _STATE_TOUCH_EXPLORINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/TouchInteractionController.html#STATE_TOUCH_INTERACTING"/>
        /// </summary>
        public static int STATE_TOUCH_INTERACTING { get { if (!_STATE_TOUCH_INTERACTINGReady) { _STATE_TOUCH_INTERACTINGContent = SGetField<int>(LocalBridgeClazz, "STATE_TOUCH_INTERACTING"); _STATE_TOUCH_INTERACTINGReady = true; } return _STATE_TOUCH_INTERACTINGContent; } }
        private static int _STATE_TOUCH_INTERACTINGContent = default;
        private static bool _STATE_TOUCH_INTERACTINGReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/TouchInteractionController.html#stateToString(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String StateToString(int arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "stateToString", "(I)Ljava/lang/String;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/TouchInteractionController.html#unregisterCallback(android.accessibilityservice.TouchInteractionController.Callback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Accessibilityservice.TouchInteractionController.Callback"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool UnregisterCallback(Android.Accessibilityservice.TouchInteractionController.Callback arg0)
        {
            return IExecuteWithSignature<bool>("unregisterCallback", "(Landroid/accessibilityservice/TouchInteractionController$Callback;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/TouchInteractionController.html#getDisplayId()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetDisplayId()
        {
            return IExecuteWithSignature<int>("getDisplayId", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/TouchInteractionController.html#getMaxPointerCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetMaxPointerCount()
        {
            return IExecuteWithSignature<int>("getMaxPointerCount", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/TouchInteractionController.html#getState()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetState()
        {
            return IExecuteWithSignature<int>("getState", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/TouchInteractionController.html#performClick()"/>
        /// </summary>
        public void PerformClick()
        {
            IExecuteWithSignature("performClick", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/TouchInteractionController.html#performLongClickAndStartDrag()"/>
        /// </summary>
        public void PerformLongClickAndStartDrag()
        {
            IExecuteWithSignature("performLongClickAndStartDrag", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/TouchInteractionController.html#registerCallback(java.util.concurrent.Executor,android.accessibilityservice.TouchInteractionController.Callback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg1"><see cref="Android.Accessibilityservice.TouchInteractionController.Callback"/></param>
        public void RegisterCallback(Java.Util.Concurrent.Executor arg0, Android.Accessibilityservice.TouchInteractionController.Callback arg1)
        {
            IExecute("registerCallback", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/TouchInteractionController.html#requestDelegating()"/>
        /// </summary>
        public void RequestDelegating()
        {
            IExecuteWithSignature("requestDelegating", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/TouchInteractionController.html#requestDragging(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void RequestDragging(int arg0)
        {
            IExecuteWithSignature("requestDragging", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/TouchInteractionController.html#requestTouchExploration()"/>
        /// </summary>
        public void RequestTouchExploration()
        {
            IExecuteWithSignature("requestTouchExploration", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/TouchInteractionController.html#unregisterAllCallbacks()"/>
        /// </summary>
        public void UnregisterAllCallbacks()
        {
            IExecuteWithSignature("unregisterAllCallbacks", "()V");
        }

        #endregion

        #region Nested classes
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
            /// <see href="https://developer.android.com/reference/android/accessibilityservice/TouchInteractionController.Callback.html#onMotionEvent(android.view.MotionEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.MotionEvent"/></param>
            public void OnMotionEvent(Android.View.MotionEvent arg0)
            {
                IExecuteWithSignature("onMotionEvent", "(Landroid/view/MotionEvent;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/accessibilityservice/TouchInteractionController.Callback.html#onStateChanged(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            public void OnStateChanged(int arg0)
            {
                IExecuteWithSignature("onStateChanged", "(I)V", arg0);
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