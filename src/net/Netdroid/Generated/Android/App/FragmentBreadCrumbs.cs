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

namespace Android.App
{
    #region FragmentBreadCrumbs
    public partial class FragmentBreadCrumbs
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentBreadCrumbs.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        [global::System.Obsolete()]
        public FragmentBreadCrumbs(Android.Content.Context arg0, Android.Util.AttributeSet arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentBreadCrumbs.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        [global::System.Obsolete()]
        public FragmentBreadCrumbs(Android.Content.Context arg0, Android.Util.AttributeSet arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentBreadCrumbs.html#%3Cinit%3E(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        [global::System.Obsolete()]
        public FragmentBreadCrumbs(Android.Content.Context arg0)
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
        /// <see href="https://developer.android.com/reference/android/app/FragmentBreadCrumbs.html#onBackStackChanged()"/>
        /// </summary>
        [global::System.Obsolete()]
        public void OnBackStackChanged()
        {
            IExecuteWithSignature("onBackStackChanged", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentBreadCrumbs.html#setActivity(android.app.Activity)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.Activity"/></param>
        [global::System.Obsolete()]
        public void SetActivity(Android.App.Activity arg0)
        {
            IExecuteWithSignature("setActivity", "(Landroid/app/Activity;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentBreadCrumbs.html#setMaxVisible(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        [global::System.Obsolete()]
        public void SetMaxVisible(int arg0)
        {
            IExecuteWithSignature("setMaxVisible", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentBreadCrumbs.html#setOnBreadCrumbClickListener(android.app.FragmentBreadCrumbs.OnBreadCrumbClickListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.FragmentBreadCrumbs.OnBreadCrumbClickListener"/></param>
        [global::System.Obsolete()]
        public void SetOnBreadCrumbClickListener(Android.App.FragmentBreadCrumbs.OnBreadCrumbClickListener arg0)
        {
            IExecuteWithSignature("setOnBreadCrumbClickListener", "(Landroid/app/FragmentBreadCrumbs$OnBreadCrumbClickListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentBreadCrumbs.html#setParentTitle(java.lang.CharSequence,java.lang.CharSequence,android.view.View.OnClickListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg2"><see cref="Android.View.View.OnClickListener"/></param>
        [global::System.Obsolete()]
        public void SetParentTitle(Java.Lang.CharSequence arg0, Java.Lang.CharSequence arg1, Android.View.View.OnClickListener arg2)
        {
            IExecute("setParentTitle", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentBreadCrumbs.html#setTitle(java.lang.CharSequence,java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="Java.Lang.CharSequence"/></param>
        [global::System.Obsolete()]
        public void SetTitle(Java.Lang.CharSequence arg0, Java.Lang.CharSequence arg1)
        {
            IExecute("setTitle", arg0, arg1);
        }

        #endregion

        #region Nested classes
        #region OnBreadCrumbClickListener
        public partial class OnBreadCrumbClickListener
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
            /// Handlers initializer for <see cref="OnBreadCrumbClickListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onBreadCrumbClick", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Android.App.FragmentManager.BackStackEntry>>>(OnBreadCrumbClickEventHandler));

            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/app/FragmentBreadCrumbs.OnBreadCrumbClickListener.html#onBreadCrumbClick(android.app.FragmentManager.BackStackEntry,int)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnBreadCrumbClick"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Func<Android.App.FragmentManager.BackStackEntry, int, bool> OnOnBreadCrumbClick { get; set; } = null;

            void OnBreadCrumbClickEventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.App.FragmentManager.BackStackEntry>> data)
            {
                var methodToExecute = (OnOnBreadCrumbClick != null) ? OnOnBreadCrumbClick : OnBreadCrumbClick;
                var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<int>(0));
                data.SetReturnValue(executionResult);
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/FragmentBreadCrumbs.OnBreadCrumbClickListener.html#onBreadCrumbClick(android.app.FragmentManager.BackStackEntry,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.App.FragmentManager.BackStackEntry"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <returns><see cref="bool"/></returns>
            [global::System.Obsolete()]
            public virtual bool OnBreadCrumbClick(Android.App.FragmentManager.BackStackEntry arg0, int arg1)
            {
                return default;
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OnBreadCrumbClickListenerDirect
        public partial class OnBreadCrumbClickListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/app/FragmentBreadCrumbs.OnBreadCrumbClickListener.html#onBreadCrumbClick(android.app.FragmentManager.BackStackEntry,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.App.FragmentManager.BackStackEntry"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <returns><see cref="bool"/></returns>
            [global::System.Obsolete()]
            public override bool OnBreadCrumbClick(Android.App.FragmentManager.BackStackEntry arg0, int arg1)
            {
                return IExecute<bool>("onBreadCrumbClick", arg0, arg1);
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