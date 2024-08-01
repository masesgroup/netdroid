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

namespace Android.Widget
{
    #region ProgressBar
    public partial class ProgressBar
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ProgressBar.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public ProgressBar(Android.Content.Context arg0, Android.Util.AttributeSet arg1, int arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ProgressBar.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public ProgressBar(Android.Content.Context arg0, Android.Util.AttributeSet arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ProgressBar.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        public ProgressBar(Android.Content.Context arg0, Android.Util.AttributeSet arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ProgressBar.html#%3Cinit%3E(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        public ProgressBar(Android.Content.Context arg0)
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
        /// <see href="https://developer.android.com/reference/android/widget/ProgressBar.html#getIndeterminateTintList()"/>
        /// </summary>
        /// <returns><see cref="Android.Content.Res.ColorStateList"/></returns>
        public Android.Content.Res.ColorStateList GetIndeterminateTintList()
        {
            return IExecuteWithSignature<Android.Content.Res.ColorStateList>("getIndeterminateTintList", "()Landroid/content/res/ColorStateList;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ProgressBar.html#getProgressBackgroundTintList()"/>
        /// </summary>
        /// <returns><see cref="Android.Content.Res.ColorStateList"/></returns>
        public Android.Content.Res.ColorStateList GetProgressBackgroundTintList()
        {
            return IExecuteWithSignature<Android.Content.Res.ColorStateList>("getProgressBackgroundTintList", "()Landroid/content/res/ColorStateList;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ProgressBar.html#getProgressTintList()"/>
        /// </summary>
        /// <returns><see cref="Android.Content.Res.ColorStateList"/></returns>
        public Android.Content.Res.ColorStateList GetProgressTintList()
        {
            return IExecuteWithSignature<Android.Content.Res.ColorStateList>("getProgressTintList", "()Landroid/content/res/ColorStateList;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ProgressBar.html#getSecondaryProgressTintList()"/>
        /// </summary>
        /// <returns><see cref="Android.Content.Res.ColorStateList"/></returns>
        public Android.Content.Res.ColorStateList GetSecondaryProgressTintList()
        {
            return IExecuteWithSignature<Android.Content.Res.ColorStateList>("getSecondaryProgressTintList", "()Landroid/content/res/ColorStateList;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ProgressBar.html#getIndeterminateTintBlendMode()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.BlendMode"/></returns>
        public Android.Graphics.BlendMode GetIndeterminateTintBlendMode()
        {
            return IExecuteWithSignature<Android.Graphics.BlendMode>("getIndeterminateTintBlendMode", "()Landroid/graphics/BlendMode;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ProgressBar.html#getProgressBackgroundTintBlendMode()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.BlendMode"/></returns>
        public Android.Graphics.BlendMode GetProgressBackgroundTintBlendMode()
        {
            return IExecuteWithSignature<Android.Graphics.BlendMode>("getProgressBackgroundTintBlendMode", "()Landroid/graphics/BlendMode;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ProgressBar.html#getProgressTintBlendMode()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.BlendMode"/></returns>
        public Android.Graphics.BlendMode GetProgressTintBlendMode()
        {
            return IExecuteWithSignature<Android.Graphics.BlendMode>("getProgressTintBlendMode", "()Landroid/graphics/BlendMode;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ProgressBar.html#getSecondaryProgressTintBlendMode()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.BlendMode"/></returns>
        public Android.Graphics.BlendMode GetSecondaryProgressTintBlendMode()
        {
            return IExecuteWithSignature<Android.Graphics.BlendMode>("getSecondaryProgressTintBlendMode", "()Landroid/graphics/BlendMode;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ProgressBar.html#getCurrentDrawable()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.Drawable.Drawable"/></returns>
        public Android.Graphics.Drawable.Drawable GetCurrentDrawable()
        {
            return IExecuteWithSignature<Android.Graphics.Drawable.Drawable>("getCurrentDrawable", "()Landroid/graphics/drawable/Drawable;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ProgressBar.html#getIndeterminateDrawable()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.Drawable.Drawable"/></returns>
        public Android.Graphics.Drawable.Drawable GetIndeterminateDrawable()
        {
            return IExecuteWithSignature<Android.Graphics.Drawable.Drawable>("getIndeterminateDrawable", "()Landroid/graphics/drawable/Drawable;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ProgressBar.html#getProgressDrawable()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.Drawable.Drawable"/></returns>
        public Android.Graphics.Drawable.Drawable GetProgressDrawable()
        {
            return IExecuteWithSignature<Android.Graphics.Drawable.Drawable>("getProgressDrawable", "()Landroid/graphics/drawable/Drawable;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ProgressBar.html#getIndeterminateTintMode()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.PorterDuff.Mode"/></returns>
        public Android.Graphics.PorterDuff.Mode GetIndeterminateTintMode()
        {
            return IExecuteWithSignature<Android.Graphics.PorterDuff.Mode>("getIndeterminateTintMode", "()Landroid/graphics/PorterDuff$Mode;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ProgressBar.html#getProgressBackgroundTintMode()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.PorterDuff.Mode"/></returns>
        public Android.Graphics.PorterDuff.Mode GetProgressBackgroundTintMode()
        {
            return IExecuteWithSignature<Android.Graphics.PorterDuff.Mode>("getProgressBackgroundTintMode", "()Landroid/graphics/PorterDuff$Mode;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ProgressBar.html#getProgressTintMode()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.PorterDuff.Mode"/></returns>
        public Android.Graphics.PorterDuff.Mode GetProgressTintMode()
        {
            return IExecuteWithSignature<Android.Graphics.PorterDuff.Mode>("getProgressTintMode", "()Landroid/graphics/PorterDuff$Mode;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ProgressBar.html#getSecondaryProgressTintMode()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.PorterDuff.Mode"/></returns>
        public Android.Graphics.PorterDuff.Mode GetSecondaryProgressTintMode()
        {
            return IExecuteWithSignature<Android.Graphics.PorterDuff.Mode>("getSecondaryProgressTintMode", "()Landroid/graphics/PorterDuff$Mode;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ProgressBar.html#onSaveInstanceState()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.Parcelable"/></returns>
        public Android.Os.Parcelable OnSaveInstanceState()
        {
            return IExecuteWithSignature<Android.Os.Parcelable>("onSaveInstanceState", "()Landroid/os/Parcelable;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ProgressBar.html#getInterpolator()"/>
        /// </summary>
        /// <returns><see cref="Android.View.Animation.Interpolator"/></returns>
        public Android.View.Animation.Interpolator GetInterpolator()
        {
            return IExecuteWithSignature<Android.View.Animation.Interpolator>("getInterpolator", "()Landroid/view/animation/Interpolator;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ProgressBar.html#isAnimating()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsAnimating()
        {
            return IExecuteWithSignature<bool>("isAnimating", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ProgressBar.html#incrementProgressBy(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void IncrementProgressBy(int arg0)
        {
            IExecuteWithSignature("incrementProgressBy", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ProgressBar.html#incrementSecondaryProgressBy(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void IncrementSecondaryProgressBy(int arg0)
        {
            IExecuteWithSignature("incrementSecondaryProgressBy", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ProgressBar.html#getMaxHeight()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetMaxHeight()
        {
            return IExecuteWithSignature<int>("getMaxHeight", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ProgressBar.html#getMaxWidth()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetMaxWidth()
        {
            return IExecuteWithSignature<int>("getMaxWidth", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ProgressBar.html#getMinHeight()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetMinHeight()
        {
            return IExecuteWithSignature<int>("getMinHeight", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ProgressBar.html#getMinWidth()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetMinWidth()
        {
            return IExecuteWithSignature<int>("getMinWidth", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ProgressBar.html#isIndeterminate()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsIndeterminate()
        {
            return IExecuteWithSignature<bool>("isIndeterminate", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ProgressBar.html#getMax()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetMax()
        {
            return IExecuteWithSignature<int>("getMax", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ProgressBar.html#getMin()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetMin()
        {
            return IExecuteWithSignature<int>("getMin", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ProgressBar.html#getProgress()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetProgress()
        {
            return IExecuteWithSignature<int>("getProgress", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ProgressBar.html#getSecondaryProgress()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetSecondaryProgress()
        {
            return IExecuteWithSignature<int>("getSecondaryProgress", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ProgressBar.html#setIndeterminate(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetIndeterminate(bool arg0)
        {
            IExecuteWithSignature("setIndeterminate", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ProgressBar.html#setMax(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetMax(int arg0)
        {
            IExecuteWithSignature("setMax", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ProgressBar.html#setMin(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetMin(int arg0)
        {
            IExecuteWithSignature("setMin", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ProgressBar.html#setProgress(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetProgress(int arg0)
        {
            IExecuteWithSignature("setProgress", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ProgressBar.html#setSecondaryProgress(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetSecondaryProgress(int arg0)
        {
            IExecuteWithSignature("setSecondaryProgress", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ProgressBar.html#onRestoreInstanceState(android.os.Parcelable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcelable"/></param>
        public void OnRestoreInstanceState(Android.Os.Parcelable arg0)
        {
            IExecuteWithSignature("onRestoreInstanceState", "(Landroid/os/Parcelable;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ProgressBar.html#setIndeterminateDrawable(android.graphics.drawable.Drawable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Drawable.Drawable"/></param>
        public void SetIndeterminateDrawable(Android.Graphics.Drawable.Drawable arg0)
        {
            IExecuteWithSignature("setIndeterminateDrawable", "(Landroid/graphics/drawable/Drawable;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ProgressBar.html#setIndeterminateDrawableTiled(android.graphics.drawable.Drawable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Drawable.Drawable"/></param>
        public void SetIndeterminateDrawableTiled(Android.Graphics.Drawable.Drawable arg0)
        {
            IExecuteWithSignature("setIndeterminateDrawableTiled", "(Landroid/graphics/drawable/Drawable;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ProgressBar.html#setIndeterminateTintBlendMode(android.graphics.BlendMode)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.BlendMode"/></param>
        public void SetIndeterminateTintBlendMode(Android.Graphics.BlendMode arg0)
        {
            IExecuteWithSignature("setIndeterminateTintBlendMode", "(Landroid/graphics/BlendMode;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ProgressBar.html#setIndeterminateTintList(android.content.res.ColorStateList)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Res.ColorStateList"/></param>
        public void SetIndeterminateTintList(Android.Content.Res.ColorStateList arg0)
        {
            IExecuteWithSignature("setIndeterminateTintList", "(Landroid/content/res/ColorStateList;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ProgressBar.html#setIndeterminateTintMode(android.graphics.PorterDuff.Mode)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.PorterDuff.Mode"/></param>
        public void SetIndeterminateTintMode(Android.Graphics.PorterDuff.Mode arg0)
        {
            IExecuteWithSignature("setIndeterminateTintMode", "(Landroid/graphics/PorterDuff$Mode;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ProgressBar.html#setInterpolator(android.content.Context,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void SetInterpolator(Android.Content.Context arg0, int arg1)
        {
            IExecute("setInterpolator", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ProgressBar.html#setInterpolator(android.view.animation.Interpolator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Animation.Interpolator"/></param>
        public void SetInterpolator(Android.View.Animation.Interpolator arg0)
        {
            IExecuteWithSignature("setInterpolator", "(Landroid/view/animation/Interpolator;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ProgressBar.html#setMaxHeight(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetMaxHeight(int arg0)
        {
            IExecuteWithSignature("setMaxHeight", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ProgressBar.html#setMaxWidth(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetMaxWidth(int arg0)
        {
            IExecuteWithSignature("setMaxWidth", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ProgressBar.html#setMinHeight(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetMinHeight(int arg0)
        {
            IExecuteWithSignature("setMinHeight", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ProgressBar.html#setMinWidth(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetMinWidth(int arg0)
        {
            IExecuteWithSignature("setMinWidth", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ProgressBar.html#setProgress(int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public void SetProgress(int arg0, bool arg1)
        {
            IExecute("setProgress", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ProgressBar.html#setProgressBackgroundTintBlendMode(android.graphics.BlendMode)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.BlendMode"/></param>
        public void SetProgressBackgroundTintBlendMode(Android.Graphics.BlendMode arg0)
        {
            IExecuteWithSignature("setProgressBackgroundTintBlendMode", "(Landroid/graphics/BlendMode;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ProgressBar.html#setProgressBackgroundTintList(android.content.res.ColorStateList)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Res.ColorStateList"/></param>
        public void SetProgressBackgroundTintList(Android.Content.Res.ColorStateList arg0)
        {
            IExecuteWithSignature("setProgressBackgroundTintList", "(Landroid/content/res/ColorStateList;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ProgressBar.html#setProgressBackgroundTintMode(android.graphics.PorterDuff.Mode)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.PorterDuff.Mode"/></param>
        public void SetProgressBackgroundTintMode(Android.Graphics.PorterDuff.Mode arg0)
        {
            IExecuteWithSignature("setProgressBackgroundTintMode", "(Landroid/graphics/PorterDuff$Mode;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ProgressBar.html#setProgressDrawable(android.graphics.drawable.Drawable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Drawable.Drawable"/></param>
        public void SetProgressDrawable(Android.Graphics.Drawable.Drawable arg0)
        {
            IExecuteWithSignature("setProgressDrawable", "(Landroid/graphics/drawable/Drawable;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ProgressBar.html#setProgressDrawableTiled(android.graphics.drawable.Drawable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Drawable.Drawable"/></param>
        public void SetProgressDrawableTiled(Android.Graphics.Drawable.Drawable arg0)
        {
            IExecuteWithSignature("setProgressDrawableTiled", "(Landroid/graphics/drawable/Drawable;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ProgressBar.html#setProgressTintBlendMode(android.graphics.BlendMode)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.BlendMode"/></param>
        public void SetProgressTintBlendMode(Android.Graphics.BlendMode arg0)
        {
            IExecuteWithSignature("setProgressTintBlendMode", "(Landroid/graphics/BlendMode;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ProgressBar.html#setProgressTintList(android.content.res.ColorStateList)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Res.ColorStateList"/></param>
        public void SetProgressTintList(Android.Content.Res.ColorStateList arg0)
        {
            IExecuteWithSignature("setProgressTintList", "(Landroid/content/res/ColorStateList;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ProgressBar.html#setProgressTintMode(android.graphics.PorterDuff.Mode)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.PorterDuff.Mode"/></param>
        public void SetProgressTintMode(Android.Graphics.PorterDuff.Mode arg0)
        {
            IExecuteWithSignature("setProgressTintMode", "(Landroid/graphics/PorterDuff$Mode;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ProgressBar.html#setSecondaryProgressTintBlendMode(android.graphics.BlendMode)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.BlendMode"/></param>
        public void SetSecondaryProgressTintBlendMode(Android.Graphics.BlendMode arg0)
        {
            IExecuteWithSignature("setSecondaryProgressTintBlendMode", "(Landroid/graphics/BlendMode;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ProgressBar.html#setSecondaryProgressTintList(android.content.res.ColorStateList)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Res.ColorStateList"/></param>
        public void SetSecondaryProgressTintList(Android.Content.Res.ColorStateList arg0)
        {
            IExecuteWithSignature("setSecondaryProgressTintList", "(Landroid/content/res/ColorStateList;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ProgressBar.html#setSecondaryProgressTintMode(android.graphics.PorterDuff.Mode)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.PorterDuff.Mode"/></param>
        public void SetSecondaryProgressTintMode(Android.Graphics.PorterDuff.Mode arg0)
        {
            IExecuteWithSignature("setSecondaryProgressTintMode", "(Landroid/graphics/PorterDuff$Mode;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}