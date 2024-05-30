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

namespace Android.Graphics.Drawable
{
    #region AnimationDrawable
    public partial class AnimationDrawable : Java.Lang.IRunnable, Android.Graphics.Drawable.IAnimatable
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Android.Graphics.Drawable.AnimationDrawable"/> to <see cref="Java.Lang.Runnable"/>
        /// </summary>
        public static implicit operator Java.Lang.Runnable(Android.Graphics.Drawable.AnimationDrawable t) => t.Cast<Java.Lang.Runnable>();
        /// <summary>
        /// Converter from <see cref="Android.Graphics.Drawable.AnimationDrawable"/> to <see cref="Android.Graphics.Drawable.Animatable"/>
        /// </summary>
        public static implicit operator Android.Graphics.Drawable.Animatable(Android.Graphics.Drawable.AnimationDrawable t) => t.Cast<Android.Graphics.Drawable.Animatable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/AnimationDrawable.html#getNumberOfFrames()"/> 
        /// </summary>
        public int NumberOfFrames
        {
            get { return IExecuteWithSignature<int>("getNumberOfFrames", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/AnimationDrawable.html#getFrame(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Graphics.Drawable.Drawable"/></returns>
        public Android.Graphics.Drawable.Drawable GetFrame(int arg0)
        {
            return IExecuteWithSignature<Android.Graphics.Drawable.Drawable>("getFrame", "(I)Landroid/graphics/drawable/Drawable;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/AnimationDrawable.html#isOneShot()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsOneShot()
        {
            return IExecuteWithSignature<bool>("isOneShot", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/AnimationDrawable.html#isRunning()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsRunning()
        {
            return IExecuteWithSignature<bool>("isRunning", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/AnimationDrawable.html#getDuration(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetDuration(int arg0)
        {
            return IExecuteWithSignature<int>("getDuration", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/AnimationDrawable.html#addFrame(android.graphics.drawable.Drawable,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Drawable.Drawable"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void AddFrame(Android.Graphics.Drawable.Drawable arg0, int arg1)
        {
            IExecute("addFrame", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/AnimationDrawable.html#run()"/>
        /// </summary>
        public void Run()
        {
            IExecuteWithSignature("run", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/AnimationDrawable.html#setOneShot(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetOneShot(bool arg0)
        {
            IExecuteWithSignature("setOneShot", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/AnimationDrawable.html#start()"/>
        /// </summary>
        public void Start()
        {
            IExecuteWithSignature("start", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/AnimationDrawable.html#stop()"/>
        /// </summary>
        public void Stop()
        {
            IExecuteWithSignature("stop", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}