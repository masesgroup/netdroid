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

namespace Android.View.Animation
{
    #region GridLayoutAnimationController
    public partial class GridLayoutAnimationController
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/GridLayoutAnimationController.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        public GridLayoutAnimationController(Android.Content.Context arg0, Android.Util.AttributeSet arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/GridLayoutAnimationController.html#%3Cinit%3E(android.view.animation.Animation,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Animation.Animation"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        public GridLayoutAnimationController(Android.View.Animation.Animation arg0, float arg1, float arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/GridLayoutAnimationController.html#%3Cinit%3E(android.view.animation.Animation)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Animation.Animation"/></param>
        public GridLayoutAnimationController(Android.View.Animation.Animation arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/GridLayoutAnimationController.html#DIRECTION_BOTTOM_TO_TOP"/>
        /// </summary>
        public static int DIRECTION_BOTTOM_TO_TOP { get { if (!_DIRECTION_BOTTOM_TO_TOPReady) { _DIRECTION_BOTTOM_TO_TOPContent = SGetField<int>(LocalBridgeClazz, "DIRECTION_BOTTOM_TO_TOP"); _DIRECTION_BOTTOM_TO_TOPReady = true; } return _DIRECTION_BOTTOM_TO_TOPContent; } }
        private static int _DIRECTION_BOTTOM_TO_TOPContent = default;
        private static bool _DIRECTION_BOTTOM_TO_TOPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/GridLayoutAnimationController.html#DIRECTION_HORIZONTAL_MASK"/>
        /// </summary>
        public static int DIRECTION_HORIZONTAL_MASK { get { if (!_DIRECTION_HORIZONTAL_MASKReady) { _DIRECTION_HORIZONTAL_MASKContent = SGetField<int>(LocalBridgeClazz, "DIRECTION_HORIZONTAL_MASK"); _DIRECTION_HORIZONTAL_MASKReady = true; } return _DIRECTION_HORIZONTAL_MASKContent; } }
        private static int _DIRECTION_HORIZONTAL_MASKContent = default;
        private static bool _DIRECTION_HORIZONTAL_MASKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/GridLayoutAnimationController.html#DIRECTION_LEFT_TO_RIGHT"/>
        /// </summary>
        public static int DIRECTION_LEFT_TO_RIGHT { get { if (!_DIRECTION_LEFT_TO_RIGHTReady) { _DIRECTION_LEFT_TO_RIGHTContent = SGetField<int>(LocalBridgeClazz, "DIRECTION_LEFT_TO_RIGHT"); _DIRECTION_LEFT_TO_RIGHTReady = true; } return _DIRECTION_LEFT_TO_RIGHTContent; } }
        private static int _DIRECTION_LEFT_TO_RIGHTContent = default;
        private static bool _DIRECTION_LEFT_TO_RIGHTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/GridLayoutAnimationController.html#DIRECTION_RIGHT_TO_LEFT"/>
        /// </summary>
        public static int DIRECTION_RIGHT_TO_LEFT { get { if (!_DIRECTION_RIGHT_TO_LEFTReady) { _DIRECTION_RIGHT_TO_LEFTContent = SGetField<int>(LocalBridgeClazz, "DIRECTION_RIGHT_TO_LEFT"); _DIRECTION_RIGHT_TO_LEFTReady = true; } return _DIRECTION_RIGHT_TO_LEFTContent; } }
        private static int _DIRECTION_RIGHT_TO_LEFTContent = default;
        private static bool _DIRECTION_RIGHT_TO_LEFTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/GridLayoutAnimationController.html#DIRECTION_TOP_TO_BOTTOM"/>
        /// </summary>
        public static int DIRECTION_TOP_TO_BOTTOM { get { if (!_DIRECTION_TOP_TO_BOTTOMReady) { _DIRECTION_TOP_TO_BOTTOMContent = SGetField<int>(LocalBridgeClazz, "DIRECTION_TOP_TO_BOTTOM"); _DIRECTION_TOP_TO_BOTTOMReady = true; } return _DIRECTION_TOP_TO_BOTTOMContent; } }
        private static int _DIRECTION_TOP_TO_BOTTOMContent = default;
        private static bool _DIRECTION_TOP_TO_BOTTOMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/GridLayoutAnimationController.html#DIRECTION_VERTICAL_MASK"/>
        /// </summary>
        public static int DIRECTION_VERTICAL_MASK { get { if (!_DIRECTION_VERTICAL_MASKReady) { _DIRECTION_VERTICAL_MASKContent = SGetField<int>(LocalBridgeClazz, "DIRECTION_VERTICAL_MASK"); _DIRECTION_VERTICAL_MASKReady = true; } return _DIRECTION_VERTICAL_MASKContent; } }
        private static int _DIRECTION_VERTICAL_MASKContent = default;
        private static bool _DIRECTION_VERTICAL_MASKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/GridLayoutAnimationController.html#PRIORITY_COLUMN"/>
        /// </summary>
        public static int PRIORITY_COLUMN { get { if (!_PRIORITY_COLUMNReady) { _PRIORITY_COLUMNContent = SGetField<int>(LocalBridgeClazz, "PRIORITY_COLUMN"); _PRIORITY_COLUMNReady = true; } return _PRIORITY_COLUMNContent; } }
        private static int _PRIORITY_COLUMNContent = default;
        private static bool _PRIORITY_COLUMNReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/GridLayoutAnimationController.html#PRIORITY_NONE"/>
        /// </summary>
        public static int PRIORITY_NONE { get { if (!_PRIORITY_NONEReady) { _PRIORITY_NONEContent = SGetField<int>(LocalBridgeClazz, "PRIORITY_NONE"); _PRIORITY_NONEReady = true; } return _PRIORITY_NONEContent; } }
        private static int _PRIORITY_NONEContent = default;
        private static bool _PRIORITY_NONEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/GridLayoutAnimationController.html#PRIORITY_ROW"/>
        /// </summary>
        public static int PRIORITY_ROW { get { if (!_PRIORITY_ROWReady) { _PRIORITY_ROWContent = SGetField<int>(LocalBridgeClazz, "PRIORITY_ROW"); _PRIORITY_ROWReady = true; } return _PRIORITY_ROWContent; } }
        private static int _PRIORITY_ROWContent = default;
        private static bool _PRIORITY_ROWReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/GridLayoutAnimationController.html#getColumnDelay()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetColumnDelay()
        {
            return IExecuteWithSignature<float>("getColumnDelay", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/GridLayoutAnimationController.html#getRowDelay()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetRowDelay()
        {
            return IExecuteWithSignature<float>("getRowDelay", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/GridLayoutAnimationController.html#getDirection()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetDirection()
        {
            return IExecuteWithSignature<int>("getDirection", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/GridLayoutAnimationController.html#getDirectionPriority()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetDirectionPriority()
        {
            return IExecuteWithSignature<int>("getDirectionPriority", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/GridLayoutAnimationController.html#setColumnDelay(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        public void SetColumnDelay(float arg0)
        {
            IExecuteWithSignature("setColumnDelay", "(F)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/GridLayoutAnimationController.html#setDirection(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetDirection(int arg0)
        {
            IExecuteWithSignature("setDirection", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/GridLayoutAnimationController.html#setDirectionPriority(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetDirectionPriority(int arg0)
        {
            IExecuteWithSignature("setDirectionPriority", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/GridLayoutAnimationController.html#setRowDelay(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        public void SetRowDelay(float arg0)
        {
            IExecuteWithSignature("setRowDelay", "(F)V", arg0);
        }

        #endregion

        #region Nested classes
        #region AnimationParameters
        public partial class AnimationParameters
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/animation/GridLayoutAnimationController.AnimationParameters.html#column"/>
            /// </summary>
            public int column { get { return IGetField<int>("column"); } set { ISetField("column", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/animation/GridLayoutAnimationController.AnimationParameters.html#columnsCount"/>
            /// </summary>
            public int columnsCount { get { return IGetField<int>("columnsCount"); } set { ISetField("columnsCount", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/animation/GridLayoutAnimationController.AnimationParameters.html#row"/>
            /// </summary>
            public int row { get { return IGetField<int>("row"); } set { ISetField("row", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/animation/GridLayoutAnimationController.AnimationParameters.html#rowsCount"/>
            /// </summary>
            public int rowsCount { get { return IGetField<int>("rowsCount"); } set { ISetField("rowsCount", value); } }

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

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}