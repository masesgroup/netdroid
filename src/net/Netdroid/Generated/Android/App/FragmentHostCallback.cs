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

namespace Android.App
{
    #region FragmentHostCallback
    public partial class FragmentHostCallback
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentHostCallback.html#%3Cinit%3E(android.content.Context,android.os.Handler,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Os.Handler"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        [global::System.Obsolete()]
        public FragmentHostCallback(Android.Content.Context arg0, Android.Os.Handler arg1, int arg2)
            : base(arg0, arg1, arg2)
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
        /// <see href="https://developer.android.com/reference/android/app/FragmentHostCallback.html#onGetHost()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        [global::System.Obsolete()]
        public object OnGetHost()
        {
            return IExecuteWithSignature("onGetHost", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentHostCallback.html#onGetLayoutInflater()"/>
        /// </summary>
        /// <returns><see cref="Android.View.LayoutInflater"/></returns>
        [global::System.Obsolete()]
        public Android.View.LayoutInflater OnGetLayoutInflater()
        {
            return IExecuteWithSignature<Android.View.LayoutInflater>("onGetLayoutInflater", "()Landroid/view/LayoutInflater;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentHostCallback.html#onHasWindowAnimations()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool OnHasWindowAnimations()
        {
            return IExecuteWithSignature<bool>("onHasWindowAnimations", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentHostCallback.html#onShouldSaveFragmentState(android.app.Fragment)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.Fragment"/></param>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool OnShouldSaveFragmentState(Android.App.Fragment arg0)
        {
            return IExecuteWithSignature<bool>("onShouldSaveFragmentState", "(Landroid/app/Fragment;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentHostCallback.html#onUseFragmentManagerInflaterFactory()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool OnUseFragmentManagerInflaterFactory()
        {
            return IExecuteWithSignature<bool>("onUseFragmentManagerInflaterFactory", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentHostCallback.html#onGetWindowAnimations()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int OnGetWindowAnimations()
        {
            return IExecuteWithSignature<int>("onGetWindowAnimations", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentHostCallback.html#onAttachFragment(android.app.Fragment)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.Fragment"/></param>
        [global::System.Obsolete()]
        public void OnAttachFragment(Android.App.Fragment arg0)
        {
            IExecuteWithSignature("onAttachFragment", "(Landroid/app/Fragment;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentHostCallback.html#onDump(java.lang.String,java.io.FileDescriptor,java.io.PrintWriter,java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Io.FileDescriptor"/></param>
        /// <param name="arg2"><see cref="Java.Io.PrintWriter"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        [global::System.Obsolete()]
        public void OnDump(Java.Lang.String arg0, Java.Io.FileDescriptor arg1, Java.Io.PrintWriter arg2, Java.Lang.String[] arg3)
        {
            IExecute("onDump", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentHostCallback.html#onInvalidateOptionsMenu()"/>
        /// </summary>
        [global::System.Obsolete()]
        public void OnInvalidateOptionsMenu()
        {
            IExecuteWithSignature("onInvalidateOptionsMenu", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentHostCallback.html#onRequestPermissionsFromFragment(android.app.Fragment,java.lang.String[],int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.Fragment"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        [global::System.Obsolete()]
        public void OnRequestPermissionsFromFragment(Android.App.Fragment arg0, Java.Lang.String[] arg1, int arg2)
        {
            IExecute("onRequestPermissionsFromFragment", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentHostCallback.html#onStartActivityFromFragment(android.app.Fragment,android.content.Intent,int,android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.Fragment"/></param>
        /// <param name="arg1"><see cref="Android.Content.Intent"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Android.Os.Bundle"/></param>
        [global::System.Obsolete()]
        public void OnStartActivityFromFragment(Android.App.Fragment arg0, Android.Content.Intent arg1, int arg2, Android.Os.Bundle arg3)
        {
            IExecute("onStartActivityFromFragment", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentHostCallback.html#onStartIntentSenderFromFragment(android.app.Fragment,android.content.IntentSender,int,android.content.Intent,int,int,int,android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.Fragment"/></param>
        /// <param name="arg1"><see cref="Android.Content.IntentSender"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Android.Content.Intent"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        /// <param name="arg7"><see cref="Android.Os.Bundle"/></param>
        /// <exception cref="Android.Content.IntentSender.SendIntentException"/>
        [global::System.Obsolete()]
        public void OnStartIntentSenderFromFragment(Android.App.Fragment arg0, Android.Content.IntentSender arg1, int arg2, Android.Content.Intent arg3, int arg4, int arg5, int arg6, Android.Os.Bundle arg7)
        {
            IExecute("onStartIntentSenderFromFragment", arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region FragmentHostCallback<E>
    public partial class FragmentHostCallback<E>
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentHostCallback.html#%3Cinit%3E(android.content.Context,android.os.Handler,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Os.Handler"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        [global::System.Obsolete()]
        public FragmentHostCallback(Android.Content.Context arg0, Android.Os.Handler arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Android.App.FragmentHostCallback{E}"/> to <see cref="Android.App.FragmentHostCallback"/>
        /// </summary>
        public static implicit operator Android.App.FragmentHostCallback(Android.App.FragmentHostCallback<E> t) => t.Cast<Android.App.FragmentHostCallback>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentHostCallback.html#onGetHost()"/>
        /// </summary>
        /// <returns><typeparamref name="E"/></returns>
        [global::System.Obsolete()]
        public E OnGetHost()
        {
            return IExecuteWithSignature<E>("onGetHost", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentHostCallback.html#onGetLayoutInflater()"/>
        /// </summary>
        /// <returns><see cref="Android.View.LayoutInflater"/></returns>
        [global::System.Obsolete()]
        public Android.View.LayoutInflater OnGetLayoutInflater()
        {
            return IExecuteWithSignature<Android.View.LayoutInflater>("onGetLayoutInflater", "()Landroid/view/LayoutInflater;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentHostCallback.html#onHasWindowAnimations()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool OnHasWindowAnimations()
        {
            return IExecuteWithSignature<bool>("onHasWindowAnimations", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentHostCallback.html#onShouldSaveFragmentState(android.app.Fragment)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.Fragment"/></param>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool OnShouldSaveFragmentState(Android.App.Fragment arg0)
        {
            return IExecuteWithSignature<bool>("onShouldSaveFragmentState", "(Landroid/app/Fragment;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentHostCallback.html#onUseFragmentManagerInflaterFactory()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool OnUseFragmentManagerInflaterFactory()
        {
            return IExecuteWithSignature<bool>("onUseFragmentManagerInflaterFactory", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentHostCallback.html#onGetWindowAnimations()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int OnGetWindowAnimations()
        {
            return IExecuteWithSignature<int>("onGetWindowAnimations", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentHostCallback.html#onAttachFragment(android.app.Fragment)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.Fragment"/></param>
        [global::System.Obsolete()]
        public void OnAttachFragment(Android.App.Fragment arg0)
        {
            IExecuteWithSignature("onAttachFragment", "(Landroid/app/Fragment;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentHostCallback.html#onDump(java.lang.String,java.io.FileDescriptor,java.io.PrintWriter,java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Io.FileDescriptor"/></param>
        /// <param name="arg2"><see cref="Java.Io.PrintWriter"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        [global::System.Obsolete()]
        public void OnDump(Java.Lang.String arg0, Java.Io.FileDescriptor arg1, Java.Io.PrintWriter arg2, Java.Lang.String[] arg3)
        {
            IExecute("onDump", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentHostCallback.html#onInvalidateOptionsMenu()"/>
        /// </summary>
        [global::System.Obsolete()]
        public void OnInvalidateOptionsMenu()
        {
            IExecuteWithSignature("onInvalidateOptionsMenu", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentHostCallback.html#onRequestPermissionsFromFragment(android.app.Fragment,java.lang.String[],int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.Fragment"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        [global::System.Obsolete()]
        public void OnRequestPermissionsFromFragment(Android.App.Fragment arg0, Java.Lang.String[] arg1, int arg2)
        {
            IExecute("onRequestPermissionsFromFragment", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentHostCallback.html#onStartActivityFromFragment(android.app.Fragment,android.content.Intent,int,android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.Fragment"/></param>
        /// <param name="arg1"><see cref="Android.Content.Intent"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Android.Os.Bundle"/></param>
        [global::System.Obsolete()]
        public void OnStartActivityFromFragment(Android.App.Fragment arg0, Android.Content.Intent arg1, int arg2, Android.Os.Bundle arg3)
        {
            IExecute("onStartActivityFromFragment", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentHostCallback.html#onStartIntentSenderFromFragment(android.app.Fragment,android.content.IntentSender,int,android.content.Intent,int,int,int,android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.Fragment"/></param>
        /// <param name="arg1"><see cref="Android.Content.IntentSender"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Android.Content.Intent"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        /// <param name="arg7"><see cref="Android.Os.Bundle"/></param>
        /// <exception cref="Android.Content.IntentSender.SendIntentException"/>
        [global::System.Obsolete()]
        public void OnStartIntentSenderFromFragment(Android.App.Fragment arg0, Android.Content.IntentSender arg1, int arg2, Android.Content.Intent arg3, int arg4, int arg5, int arg6, Android.Os.Bundle arg7)
        {
            IExecute("onStartIntentSenderFromFragment", arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}