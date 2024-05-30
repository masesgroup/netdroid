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

namespace Android.Transition
{
    #region Scene
    public partial class Scene
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/transition/Scene.html#%3Cinit%3E(android.view.ViewGroup,android.view.View)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.ViewGroup"/></param>
        /// <param name="arg1"><see cref="Android.View.View"/></param>
        public Scene(Android.View.ViewGroup arg0, Android.View.View arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/transition/Scene.html#%3Cinit%3E(android.view.ViewGroup)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.ViewGroup"/></param>
        public Scene(Android.View.ViewGroup arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/transition/Scene.html#getCurrentScene(android.view.ViewGroup)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.ViewGroup"/></param>
        /// <returns><see cref="Android.Transition.Scene"/></returns>
        public static Android.Transition.Scene GetCurrentScene(Android.View.ViewGroup arg0)
        {
            return SExecuteWithSignature<Android.Transition.Scene>(LocalBridgeClazz, "getCurrentScene", "(Landroid/view/ViewGroup;)Landroid/transition/Scene;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/transition/Scene.html#getSceneForLayout(android.view.ViewGroup,int,android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.ViewGroup"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Android.Content.Context"/></param>
        /// <returns><see cref="Android.Transition.Scene"/></returns>
        public static Android.Transition.Scene GetSceneForLayout(Android.View.ViewGroup arg0, int arg1, Android.Content.Context arg2)
        {
            return SExecute<Android.Transition.Scene>(LocalBridgeClazz, "getSceneForLayout", arg0, arg1, arg2);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/transition/Scene.html#getSceneRoot()"/> 
        /// </summary>
        public Android.View.ViewGroup SceneRoot
        {
            get { return IExecuteWithSignature<Android.View.ViewGroup>("getSceneRoot", "()Landroid/view/ViewGroup;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/transition/Scene.html#enter()"/>
        /// </summary>
        public void Enter()
        {
            IExecuteWithSignature("enter", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/transition/Scene.html#exit()"/>
        /// </summary>
        public void Exit()
        {
            IExecuteWithSignature("exit", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/transition/Scene.html#setEnterAction(java.lang.Runnable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Runnable"/></param>
        public void SetEnterAction(Java.Lang.Runnable arg0)
        {
            IExecuteWithSignature("setEnterAction", "(Ljava/lang/Runnable;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/transition/Scene.html#setExitAction(java.lang.Runnable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Runnable"/></param>
        public void SetExitAction(Java.Lang.Runnable arg0)
        {
            IExecuteWithSignature("setExitAction", "(Ljava/lang/Runnable;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}