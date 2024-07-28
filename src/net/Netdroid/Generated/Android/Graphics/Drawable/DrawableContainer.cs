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

namespace Android.Graphics.Drawable
{
    #region DrawableContainer
    public partial class DrawableContainer
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
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/DrawableContainer.html#selectDrawable(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SelectDrawable(int arg0)
        {
            return IExecuteWithSignature<bool>("selectDrawable", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/DrawableContainer.html#invalidateDrawable(android.graphics.drawable.Drawable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Drawable.Drawable"/></param>
        public void InvalidateDrawable(Android.Graphics.Drawable.Drawable arg0)
        {
            IExecuteWithSignature("invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/DrawableContainer.html#scheduleDrawable(android.graphics.drawable.Drawable,java.lang.Runnable,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Drawable.Drawable"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Runnable"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        public void ScheduleDrawable(Android.Graphics.Drawable.Drawable arg0, Java.Lang.Runnable arg1, long arg2)
        {
            IExecute("scheduleDrawable", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/DrawableContainer.html#setEnterFadeDuration(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetEnterFadeDuration(int arg0)
        {
            IExecuteWithSignature("setEnterFadeDuration", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/DrawableContainer.html#setExitFadeDuration(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetExitFadeDuration(int arg0)
        {
            IExecuteWithSignature("setExitFadeDuration", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/DrawableContainer.html#unscheduleDrawable(android.graphics.drawable.Drawable,java.lang.Runnable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Drawable.Drawable"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Runnable"/></param>
        public void UnscheduleDrawable(Android.Graphics.Drawable.Drawable arg0, Java.Lang.Runnable arg1)
        {
            IExecute("unscheduleDrawable", arg0, arg1);
        }

        #endregion

        #region Nested classes
        #region DrawableContainerState
        public partial class DrawableContainerState
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
            /// <see href="https://developer.android.com/reference/android/graphics/drawable/DrawableContainer.DrawableContainerState.html#getChild(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Graphics.Drawable.Drawable"/></returns>
            public Android.Graphics.Drawable.Drawable GetChild(int arg0)
            {
                return IExecuteWithSignature<Android.Graphics.Drawable.Drawable>("getChild", "(I)Landroid/graphics/drawable/Drawable;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/drawable/DrawableContainer.DrawableContainerState.html#getChildren()"/>
            /// </summary>
            /// <returns><see cref="Android.Graphics.Drawable.Drawable"/></returns>
            public Android.Graphics.Drawable.Drawable[] GetChildren()
            {
                return IExecuteWithSignatureArray<Android.Graphics.Drawable.Drawable>("getChildren", "()[Landroid/graphics/drawable/Drawable;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/drawable/DrawableContainer.DrawableContainerState.html#getConstantPadding()"/>
            /// </summary>
            /// <returns><see cref="Android.Graphics.Rect"/></returns>
            public Android.Graphics.Rect GetConstantPadding()
            {
                return IExecuteWithSignature<Android.Graphics.Rect>("getConstantPadding", "()Landroid/graphics/Rect;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/drawable/DrawableContainer.DrawableContainerState.html#isConstantSize()"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool IsConstantSize()
            {
                return IExecuteWithSignature<bool>("isConstantSize", "()Z");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/drawable/DrawableContainer.DrawableContainerState.html#isStateful()"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool IsStateful()
            {
                return IExecuteWithSignature<bool>("isStateful", "()Z");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/drawable/DrawableContainer.DrawableContainerState.html#addChild(android.graphics.drawable.Drawable)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Graphics.Drawable.Drawable"/></param>
            /// <returns><see cref="int"/></returns>
            public int AddChild(Android.Graphics.Drawable.Drawable arg0)
            {
                return IExecuteWithSignature<int>("addChild", "(Landroid/graphics/drawable/Drawable;)I", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/drawable/DrawableContainer.DrawableContainerState.html#getChildCount()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetChildCount()
            {
                return IExecuteWithSignature<int>("getChildCount", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/drawable/DrawableContainer.DrawableContainerState.html#getConstantHeight()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetConstantHeight()
            {
                return IExecuteWithSignature<int>("getConstantHeight", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/drawable/DrawableContainer.DrawableContainerState.html#getConstantMinimumHeight()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetConstantMinimumHeight()
            {
                return IExecuteWithSignature<int>("getConstantMinimumHeight", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/drawable/DrawableContainer.DrawableContainerState.html#getConstantMinimumWidth()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetConstantMinimumWidth()
            {
                return IExecuteWithSignature<int>("getConstantMinimumWidth", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/drawable/DrawableContainer.DrawableContainerState.html#getConstantWidth()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetConstantWidth()
            {
                return IExecuteWithSignature<int>("getConstantWidth", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/drawable/DrawableContainer.DrawableContainerState.html#getEnterFadeDuration()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetEnterFadeDuration()
            {
                return IExecuteWithSignature<int>("getEnterFadeDuration", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/drawable/DrawableContainer.DrawableContainerState.html#getExitFadeDuration()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetExitFadeDuration()
            {
                return IExecuteWithSignature<int>("getExitFadeDuration", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/drawable/DrawableContainer.DrawableContainerState.html#getOpacity()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetOpacity()
            {
                return IExecuteWithSignature<int>("getOpacity", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/drawable/DrawableContainer.DrawableContainerState.html#setConstantSize(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            public void SetConstantSize(bool arg0)
            {
                IExecuteWithSignature("setConstantSize", "(Z)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/drawable/DrawableContainer.DrawableContainerState.html#setEnterFadeDuration(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            public void SetEnterFadeDuration(int arg0)
            {
                IExecuteWithSignature("setEnterFadeDuration", "(I)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/drawable/DrawableContainer.DrawableContainerState.html#setExitFadeDuration(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            public void SetExitFadeDuration(int arg0)
            {
                IExecuteWithSignature("setExitFadeDuration", "(I)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/drawable/DrawableContainer.DrawableContainerState.html#setVariablePadding(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            public void SetVariablePadding(bool arg0)
            {
                IExecuteWithSignature("setVariablePadding", "(Z)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/drawable/DrawableContainer.DrawableContainerState.html#canConstantState()"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool CanConstantState()
            {
                return IExecuteWithSignature<bool>("canConstantState", "()Z");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/drawable/DrawableContainer.DrawableContainerState.html#growArray(int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            public void GrowArray(int arg0, int arg1)
            {
                IExecute("growArray", arg0, arg1);
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