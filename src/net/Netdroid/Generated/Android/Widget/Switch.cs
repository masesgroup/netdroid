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

namespace Android.Widget
{
    #region Switch
    public partial class Switch
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Switch.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public Switch(Android.Content.Context arg0, Android.Util.AttributeSet arg1, int arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Switch.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public Switch(Android.Content.Context arg0, Android.Util.AttributeSet arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Switch.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        public Switch(Android.Content.Context arg0, Android.Util.AttributeSet arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Switch.html#%3Cinit%3E(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        public Switch(Android.Content.Context arg0)
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
        /// <see href="https://developer.android.com/reference/android/widget/Switch.html#getShowText()"/> <see href="https://developer.android.com/reference/android/widget/Switch.html#setShowText(boolean)"/>
        /// </summary>
        public bool ShowText
        {
            get { return IExecuteWithSignature<bool>("getShowText", "()Z"); } set { IExecuteWithSignature("setShowText", "(Z)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Switch.html#getSplitTrack()"/> <see href="https://developer.android.com/reference/android/widget/Switch.html#setSplitTrack(boolean)"/>
        /// </summary>
        public bool SplitTrack
        {
            get { return IExecuteWithSignature<bool>("getSplitTrack", "()Z"); } set { IExecuteWithSignature("setSplitTrack", "(Z)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Switch.html#getSwitchMinWidth()"/> <see href="https://developer.android.com/reference/android/widget/Switch.html#setSwitchMinWidth(int)"/>
        /// </summary>
        public int SwitchMinWidth
        {
            get { return IExecuteWithSignature<int>("getSwitchMinWidth", "()I"); } set { IExecuteWithSignature("setSwitchMinWidth", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Switch.html#getSwitchPadding()"/> <see href="https://developer.android.com/reference/android/widget/Switch.html#setSwitchPadding(int)"/>
        /// </summary>
        public int SwitchPadding
        {
            get { return IExecuteWithSignature<int>("getSwitchPadding", "()I"); } set { IExecuteWithSignature("setSwitchPadding", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Switch.html#getTextOff()"/> <see href="https://developer.android.com/reference/android/widget/Switch.html#setTextOff(java.lang.CharSequence)"/>
        /// </summary>
        public Java.Lang.CharSequence TextOff
        {
            get { return IExecuteWithSignature<Java.Lang.CharSequence>("getTextOff", "()Ljava/lang/CharSequence;"); } set { IExecuteWithSignature("setTextOff", "(Ljava/lang/CharSequence;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Switch.html#getTextOn()"/> <see href="https://developer.android.com/reference/android/widget/Switch.html#setTextOn(java.lang.CharSequence)"/>
        /// </summary>
        public Java.Lang.CharSequence TextOn
        {
            get { return IExecuteWithSignature<Java.Lang.CharSequence>("getTextOn", "()Ljava/lang/CharSequence;"); } set { IExecuteWithSignature("setTextOn", "(Ljava/lang/CharSequence;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Switch.html#getThumbDrawable()"/> <see href="https://developer.android.com/reference/android/widget/Switch.html#setThumbDrawable(android.graphics.drawable.Drawable)"/>
        /// </summary>
        public Android.Graphics.Drawable.Drawable ThumbDrawable
        {
            get { return IExecuteWithSignature<Android.Graphics.Drawable.Drawable>("getThumbDrawable", "()Landroid/graphics/drawable/Drawable;"); } set { IExecuteWithSignature("setThumbDrawable", "(Landroid/graphics/drawable/Drawable;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Switch.html#getThumbTextPadding()"/> <see href="https://developer.android.com/reference/android/widget/Switch.html#setThumbTextPadding(int)"/>
        /// </summary>
        public int ThumbTextPadding
        {
            get { return IExecuteWithSignature<int>("getThumbTextPadding", "()I"); } set { IExecuteWithSignature("setThumbTextPadding", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Switch.html#getThumbTintBlendMode()"/> <see href="https://developer.android.com/reference/android/widget/Switch.html#setThumbTintBlendMode(android.graphics.BlendMode)"/>
        /// </summary>
        public Android.Graphics.BlendMode ThumbTintBlendMode
        {
            get { return IExecuteWithSignature<Android.Graphics.BlendMode>("getThumbTintBlendMode", "()Landroid/graphics/BlendMode;"); } set { IExecuteWithSignature("setThumbTintBlendMode", "(Landroid/graphics/BlendMode;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Switch.html#getThumbTintList()"/> <see href="https://developer.android.com/reference/android/widget/Switch.html#setThumbTintList(android.content.res.ColorStateList)"/>
        /// </summary>
        public Android.Content.Res.ColorStateList ThumbTintList
        {
            get { return IExecuteWithSignature<Android.Content.Res.ColorStateList>("getThumbTintList", "()Landroid/content/res/ColorStateList;"); } set { IExecuteWithSignature("setThumbTintList", "(Landroid/content/res/ColorStateList;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Switch.html#getThumbTintMode()"/> <see href="https://developer.android.com/reference/android/widget/Switch.html#setThumbTintMode(android.graphics.PorterDuff.Mode)"/>
        /// </summary>
        public Android.Graphics.PorterDuff.Mode ThumbTintMode
        {
            get { return IExecuteWithSignature<Android.Graphics.PorterDuff.Mode>("getThumbTintMode", "()Landroid/graphics/PorterDuff$Mode;"); } set { IExecuteWithSignature("setThumbTintMode", "(Landroid/graphics/PorterDuff$Mode;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Switch.html#getTrackDrawable()"/> <see href="https://developer.android.com/reference/android/widget/Switch.html#setTrackDrawable(android.graphics.drawable.Drawable)"/>
        /// </summary>
        public Android.Graphics.Drawable.Drawable TrackDrawable
        {
            get { return IExecuteWithSignature<Android.Graphics.Drawable.Drawable>("getTrackDrawable", "()Landroid/graphics/drawable/Drawable;"); } set { IExecuteWithSignature("setTrackDrawable", "(Landroid/graphics/drawable/Drawable;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Switch.html#getTrackTintBlendMode()"/> <see href="https://developer.android.com/reference/android/widget/Switch.html#setTrackTintBlendMode(android.graphics.BlendMode)"/>
        /// </summary>
        public Android.Graphics.BlendMode TrackTintBlendMode
        {
            get { return IExecuteWithSignature<Android.Graphics.BlendMode>("getTrackTintBlendMode", "()Landroid/graphics/BlendMode;"); } set { IExecuteWithSignature("setTrackTintBlendMode", "(Landroid/graphics/BlendMode;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Switch.html#getTrackTintList()"/> <see href="https://developer.android.com/reference/android/widget/Switch.html#setTrackTintList(android.content.res.ColorStateList)"/>
        /// </summary>
        public Android.Content.Res.ColorStateList TrackTintList
        {
            get { return IExecuteWithSignature<Android.Content.Res.ColorStateList>("getTrackTintList", "()Landroid/content/res/ColorStateList;"); } set { IExecuteWithSignature("setTrackTintList", "(Landroid/content/res/ColorStateList;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Switch.html#getTrackTintMode()"/> <see href="https://developer.android.com/reference/android/widget/Switch.html#setTrackTintMode(android.graphics.PorterDuff.Mode)"/>
        /// </summary>
        public Android.Graphics.PorterDuff.Mode TrackTintMode
        {
            get { return IExecuteWithSignature<Android.Graphics.PorterDuff.Mode>("getTrackTintMode", "()Landroid/graphics/PorterDuff$Mode;"); } set { IExecuteWithSignature("setTrackTintMode", "(Landroid/graphics/PorterDuff$Mode;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Switch.html#onMeasure(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void OnMeasure(int arg0, int arg1)
        {
            IExecute("onMeasure", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Switch.html#setSwitchTextAppearance(android.content.Context,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void SetSwitchTextAppearance(Android.Content.Context arg0, int arg1)
        {
            IExecute("setSwitchTextAppearance", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Switch.html#setSwitchTypeface(android.graphics.Typeface,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Typeface"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void SetSwitchTypeface(Android.Graphics.Typeface arg0, int arg1)
        {
            IExecute("setSwitchTypeface", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Switch.html#setSwitchTypeface(android.graphics.Typeface)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Typeface"/></param>
        public void SetSwitchTypeface(Android.Graphics.Typeface arg0)
        {
            IExecuteWithSignature("setSwitchTypeface", "(Landroid/graphics/Typeface;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Switch.html#setThumbIcon(android.graphics.drawable.Icon)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Drawable.Icon"/></param>
        public void SetThumbIcon(Android.Graphics.Drawable.Icon arg0)
        {
            IExecuteWithSignature("setThumbIcon", "(Landroid/graphics/drawable/Icon;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Switch.html#setThumbResource(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetThumbResource(int arg0)
        {
            IExecuteWithSignature("setThumbResource", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Switch.html#setTrackIcon(android.graphics.drawable.Icon)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Drawable.Icon"/></param>
        public void SetTrackIcon(Android.Graphics.Drawable.Icon arg0)
        {
            IExecuteWithSignature("setTrackIcon", "(Landroid/graphics/drawable/Icon;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Switch.html#setTrackResource(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetTrackResource(int arg0)
        {
            IExecuteWithSignature("setTrackResource", "(I)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}