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

namespace Android.App
{
    #region FragmentManager
    public partial class FragmentManager
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentManager.html#POP_BACK_STACK_INCLUSIVE"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int POP_BACK_STACK_INCLUSIVE { get { if (!_POP_BACK_STACK_INCLUSIVEReady) { _POP_BACK_STACK_INCLUSIVEContent = SGetField<int>(LocalBridgeClazz, "POP_BACK_STACK_INCLUSIVE"); _POP_BACK_STACK_INCLUSIVEReady = true; } return _POP_BACK_STACK_INCLUSIVEContent; } }
        private static int _POP_BACK_STACK_INCLUSIVEContent = default;
        private static bool _POP_BACK_STACK_INCLUSIVEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentManager.html#enableDebugLogging(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        [global::System.Obsolete()]
        public static void EnableDebugLogging(bool arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "enableDebugLogging", "(Z)V", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentManager.html#findFragmentById(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.App.Fragment"/></returns>
        [global::System.Obsolete()]
        public Android.App.Fragment FindFragmentById(int arg0)
        {
            return IExecuteWithSignature<Android.App.Fragment>("findFragmentById", "(I)Landroid/app/Fragment;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentManager.html#findFragmentByTag(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.App.Fragment"/></returns>
        [global::System.Obsolete()]
        public Android.App.Fragment FindFragmentByTag(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Android.App.Fragment>("findFragmentByTag", "(Ljava/lang/String;)Landroid/app/Fragment;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentManager.html#getFragment(android.os.Bundle,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.App.Fragment"/></returns>
        [global::System.Obsolete()]
        public Android.App.Fragment GetFragment(Android.Os.Bundle arg0, Java.Lang.String arg1)
        {
            return IExecute<Android.App.Fragment>("getFragment", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentManager.html#getPrimaryNavigationFragment()"/>
        /// </summary>
        /// <returns><see cref="Android.App.Fragment"/></returns>
        [global::System.Obsolete()]
        public Android.App.Fragment GetPrimaryNavigationFragment()
        {
            return IExecuteWithSignature<Android.App.Fragment>("getPrimaryNavigationFragment", "()Landroid/app/Fragment;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentManager.html#saveFragmentInstanceState(android.app.Fragment)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.Fragment"/></param>
        /// <returns><see cref="Android.App.Fragment.SavedState"/></returns>
        [global::System.Obsolete()]
        public Android.App.Fragment.SavedState SaveFragmentInstanceState(Android.App.Fragment arg0)
        {
            return IExecuteWithSignature<Android.App.Fragment.SavedState>("saveFragmentInstanceState", "(Landroid/app/Fragment;)Landroid/app/Fragment$SavedState;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentManager.html#getBackStackEntryAt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.App.FragmentManager.BackStackEntry"/></returns>
        [global::System.Obsolete()]
        public Android.App.FragmentManager.BackStackEntry GetBackStackEntryAt(int arg0)
        {
            return IExecuteWithSignature<Android.App.FragmentManager.BackStackEntry>("getBackStackEntryAt", "(I)Landroid/app/FragmentManager$BackStackEntry;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentManager.html#beginTransaction()"/>
        /// </summary>
        /// <returns><see cref="Android.App.FragmentTransaction"/></returns>
        [global::System.Obsolete()]
        public Android.App.FragmentTransaction BeginTransaction()
        {
            return IExecuteWithSignature<Android.App.FragmentTransaction>("beginTransaction", "()Landroid/app/FragmentTransaction;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentManager.html#executePendingTransactions()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool ExecutePendingTransactions()
        {
            return IExecuteWithSignature<bool>("executePendingTransactions", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentManager.html#isDestroyed()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool IsDestroyed()
        {
            return IExecuteWithSignature<bool>("isDestroyed", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentManager.html#isStateSaved()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool IsStateSaved()
        {
            return IExecuteWithSignature<bool>("isStateSaved", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentManager.html#popBackStackImmediate()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool PopBackStackImmediate()
        {
            return IExecuteWithSignature<bool>("popBackStackImmediate", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentManager.html#popBackStackImmediate(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool PopBackStackImmediate(int arg0, int arg1)
        {
            return IExecute<bool>("popBackStackImmediate", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentManager.html#popBackStackImmediate(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool PopBackStackImmediate(Java.Lang.String arg0, int arg1)
        {
            return IExecute<bool>("popBackStackImmediate", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentManager.html#getBackStackEntryCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int GetBackStackEntryCount()
        {
            return IExecuteWithSignature<int>("getBackStackEntryCount", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentManager.html#getFragments()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        [global::System.Obsolete()]
        public Java.Util.List<Android.App.Fragment> GetFragments()
        {
            return IExecuteWithSignature<Java.Util.List<Android.App.Fragment>>("getFragments", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentManager.html#addOnBackStackChangedListener(android.app.FragmentManager.OnBackStackChangedListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.FragmentManager.OnBackStackChangedListener"/></param>
        [global::System.Obsolete()]
        public void AddOnBackStackChangedListener(Android.App.FragmentManager.OnBackStackChangedListener arg0)
        {
            IExecuteWithSignature("addOnBackStackChangedListener", "(Landroid/app/FragmentManager$OnBackStackChangedListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentManager.html#dump(java.lang.String,java.io.FileDescriptor,java.io.PrintWriter,java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Io.FileDescriptor"/></param>
        /// <param name="arg2"><see cref="Java.Io.PrintWriter"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        [global::System.Obsolete()]
        public void Dump(Java.Lang.String arg0, Java.Io.FileDescriptor arg1, Java.Io.PrintWriter arg2, Java.Lang.String[] arg3)
        {
            IExecute("dump", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentManager.html#popBackStack()"/>
        /// </summary>
        [global::System.Obsolete()]
        public void PopBackStack()
        {
            IExecuteWithSignature("popBackStack", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentManager.html#popBackStack(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        [global::System.Obsolete()]
        public void PopBackStack(int arg0, int arg1)
        {
            IExecute("popBackStack", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentManager.html#popBackStack(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        [global::System.Obsolete()]
        public void PopBackStack(Java.Lang.String arg0, int arg1)
        {
            IExecute("popBackStack", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentManager.html#putFragment(android.os.Bundle,java.lang.String,android.app.Fragment)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Android.App.Fragment"/></param>
        [global::System.Obsolete()]
        public void PutFragment(Android.Os.Bundle arg0, Java.Lang.String arg1, Android.App.Fragment arg2)
        {
            IExecute("putFragment", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentManager.html#registerFragmentLifecycleCallbacks(android.app.FragmentManager.FragmentLifecycleCallbacks,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.FragmentManager.FragmentLifecycleCallbacks"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        [global::System.Obsolete()]
        public void RegisterFragmentLifecycleCallbacks(Android.App.FragmentManager.FragmentLifecycleCallbacks arg0, bool arg1)
        {
            IExecute("registerFragmentLifecycleCallbacks", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentManager.html#removeOnBackStackChangedListener(android.app.FragmentManager.OnBackStackChangedListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.FragmentManager.OnBackStackChangedListener"/></param>
        [global::System.Obsolete()]
        public void RemoveOnBackStackChangedListener(Android.App.FragmentManager.OnBackStackChangedListener arg0)
        {
            IExecuteWithSignature("removeOnBackStackChangedListener", "(Landroid/app/FragmentManager$OnBackStackChangedListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentManager.html#unregisterFragmentLifecycleCallbacks(android.app.FragmentManager.FragmentLifecycleCallbacks)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.FragmentManager.FragmentLifecycleCallbacks"/></param>
        [global::System.Obsolete()]
        public void UnregisterFragmentLifecycleCallbacks(Android.App.FragmentManager.FragmentLifecycleCallbacks arg0)
        {
            IExecuteWithSignature("unregisterFragmentLifecycleCallbacks", "(Landroid/app/FragmentManager$FragmentLifecycleCallbacks;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentManager.html#invalidateOptionsMenu()"/>
        /// </summary>
        [global::System.Obsolete()]
        public void InvalidateOptionsMenu()
        {
            IExecuteWithSignature("invalidateOptionsMenu", "()V");
        }

        #endregion

        #region Nested classes
        #region BackStackEntry
        public partial class BackStackEntry
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
            /// <see href="https://developer.android.com/reference/android/app/FragmentManager.BackStackEntry.html#getBreadCrumbShortTitleRes()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            [global::System.Obsolete()]
            public int GetBreadCrumbShortTitleRes()
            {
                return IExecuteWithSignature<int>("getBreadCrumbShortTitleRes", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/FragmentManager.BackStackEntry.html#getBreadCrumbTitleRes()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            [global::System.Obsolete()]
            public int GetBreadCrumbTitleRes()
            {
                return IExecuteWithSignature<int>("getBreadCrumbTitleRes", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/FragmentManager.BackStackEntry.html#getId()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            [global::System.Obsolete()]
            public int GetId()
            {
                return IExecuteWithSignature<int>("getId", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/FragmentManager.BackStackEntry.html#getBreadCrumbShortTitle()"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.CharSequence"/></returns>
            [global::System.Obsolete()]
            public Java.Lang.CharSequence GetBreadCrumbShortTitle()
            {
                return IExecuteWithSignature<Java.Lang.CharSequence>("getBreadCrumbShortTitle", "()Ljava/lang/CharSequence;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/FragmentManager.BackStackEntry.html#getBreadCrumbTitle()"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.CharSequence"/></returns>
            [global::System.Obsolete()]
            public Java.Lang.CharSequence GetBreadCrumbTitle()
            {
                return IExecuteWithSignature<Java.Lang.CharSequence>("getBreadCrumbTitle", "()Ljava/lang/CharSequence;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/FragmentManager.BackStackEntry.html#getName()"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.String"/></returns>
            [global::System.Obsolete()]
            public Java.Lang.String GetName()
            {
                return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;");
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region FragmentLifecycleCallbacks
        public partial class FragmentLifecycleCallbacks
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
            /// <see href="https://developer.android.com/reference/android/app/FragmentManager.FragmentLifecycleCallbacks.html#onFragmentActivityCreated(android.app.FragmentManager,android.app.Fragment,android.os.Bundle)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.App.FragmentManager"/></param>
            /// <param name="arg1"><see cref="Android.App.Fragment"/></param>
            /// <param name="arg2"><see cref="Android.Os.Bundle"/></param>
            [global::System.Obsolete()]
            public void OnFragmentActivityCreated(Android.App.FragmentManager arg0, Android.App.Fragment arg1, Android.Os.Bundle arg2)
            {
                IExecute("onFragmentActivityCreated", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/FragmentManager.FragmentLifecycleCallbacks.html#onFragmentAttached(android.app.FragmentManager,android.app.Fragment,android.content.Context)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.App.FragmentManager"/></param>
            /// <param name="arg1"><see cref="Android.App.Fragment"/></param>
            /// <param name="arg2"><see cref="Android.Content.Context"/></param>
            [global::System.Obsolete()]
            public void OnFragmentAttached(Android.App.FragmentManager arg0, Android.App.Fragment arg1, Android.Content.Context arg2)
            {
                IExecute("onFragmentAttached", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/FragmentManager.FragmentLifecycleCallbacks.html#onFragmentCreated(android.app.FragmentManager,android.app.Fragment,android.os.Bundle)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.App.FragmentManager"/></param>
            /// <param name="arg1"><see cref="Android.App.Fragment"/></param>
            /// <param name="arg2"><see cref="Android.Os.Bundle"/></param>
            [global::System.Obsolete()]
            public void OnFragmentCreated(Android.App.FragmentManager arg0, Android.App.Fragment arg1, Android.Os.Bundle arg2)
            {
                IExecute("onFragmentCreated", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/FragmentManager.FragmentLifecycleCallbacks.html#onFragmentDestroyed(android.app.FragmentManager,android.app.Fragment)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.App.FragmentManager"/></param>
            /// <param name="arg1"><see cref="Android.App.Fragment"/></param>
            [global::System.Obsolete()]
            public void OnFragmentDestroyed(Android.App.FragmentManager arg0, Android.App.Fragment arg1)
            {
                IExecute("onFragmentDestroyed", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/FragmentManager.FragmentLifecycleCallbacks.html#onFragmentDetached(android.app.FragmentManager,android.app.Fragment)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.App.FragmentManager"/></param>
            /// <param name="arg1"><see cref="Android.App.Fragment"/></param>
            [global::System.Obsolete()]
            public void OnFragmentDetached(Android.App.FragmentManager arg0, Android.App.Fragment arg1)
            {
                IExecute("onFragmentDetached", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/FragmentManager.FragmentLifecycleCallbacks.html#onFragmentPaused(android.app.FragmentManager,android.app.Fragment)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.App.FragmentManager"/></param>
            /// <param name="arg1"><see cref="Android.App.Fragment"/></param>
            [global::System.Obsolete()]
            public void OnFragmentPaused(Android.App.FragmentManager arg0, Android.App.Fragment arg1)
            {
                IExecute("onFragmentPaused", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/FragmentManager.FragmentLifecycleCallbacks.html#onFragmentPreAttached(android.app.FragmentManager,android.app.Fragment,android.content.Context)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.App.FragmentManager"/></param>
            /// <param name="arg1"><see cref="Android.App.Fragment"/></param>
            /// <param name="arg2"><see cref="Android.Content.Context"/></param>
            [global::System.Obsolete()]
            public void OnFragmentPreAttached(Android.App.FragmentManager arg0, Android.App.Fragment arg1, Android.Content.Context arg2)
            {
                IExecute("onFragmentPreAttached", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/FragmentManager.FragmentLifecycleCallbacks.html#onFragmentPreCreated(android.app.FragmentManager,android.app.Fragment,android.os.Bundle)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.App.FragmentManager"/></param>
            /// <param name="arg1"><see cref="Android.App.Fragment"/></param>
            /// <param name="arg2"><see cref="Android.Os.Bundle"/></param>
            [global::System.Obsolete()]
            public void OnFragmentPreCreated(Android.App.FragmentManager arg0, Android.App.Fragment arg1, Android.Os.Bundle arg2)
            {
                IExecute("onFragmentPreCreated", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/FragmentManager.FragmentLifecycleCallbacks.html#onFragmentResumed(android.app.FragmentManager,android.app.Fragment)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.App.FragmentManager"/></param>
            /// <param name="arg1"><see cref="Android.App.Fragment"/></param>
            [global::System.Obsolete()]
            public void OnFragmentResumed(Android.App.FragmentManager arg0, Android.App.Fragment arg1)
            {
                IExecute("onFragmentResumed", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/FragmentManager.FragmentLifecycleCallbacks.html#onFragmentSaveInstanceState(android.app.FragmentManager,android.app.Fragment,android.os.Bundle)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.App.FragmentManager"/></param>
            /// <param name="arg1"><see cref="Android.App.Fragment"/></param>
            /// <param name="arg2"><see cref="Android.Os.Bundle"/></param>
            [global::System.Obsolete()]
            public void OnFragmentSaveInstanceState(Android.App.FragmentManager arg0, Android.App.Fragment arg1, Android.Os.Bundle arg2)
            {
                IExecute("onFragmentSaveInstanceState", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/FragmentManager.FragmentLifecycleCallbacks.html#onFragmentStarted(android.app.FragmentManager,android.app.Fragment)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.App.FragmentManager"/></param>
            /// <param name="arg1"><see cref="Android.App.Fragment"/></param>
            [global::System.Obsolete()]
            public void OnFragmentStarted(Android.App.FragmentManager arg0, Android.App.Fragment arg1)
            {
                IExecute("onFragmentStarted", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/FragmentManager.FragmentLifecycleCallbacks.html#onFragmentStopped(android.app.FragmentManager,android.app.Fragment)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.App.FragmentManager"/></param>
            /// <param name="arg1"><see cref="Android.App.Fragment"/></param>
            [global::System.Obsolete()]
            public void OnFragmentStopped(Android.App.FragmentManager arg0, Android.App.Fragment arg1)
            {
                IExecute("onFragmentStopped", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/FragmentManager.FragmentLifecycleCallbacks.html#onFragmentViewCreated(android.app.FragmentManager,android.app.Fragment,android.view.View,android.os.Bundle)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.App.FragmentManager"/></param>
            /// <param name="arg1"><see cref="Android.App.Fragment"/></param>
            /// <param name="arg2"><see cref="Android.View.View"/></param>
            /// <param name="arg3"><see cref="Android.Os.Bundle"/></param>
            [global::System.Obsolete()]
            public void OnFragmentViewCreated(Android.App.FragmentManager arg0, Android.App.Fragment arg1, Android.View.View arg2, Android.Os.Bundle arg3)
            {
                IExecute("onFragmentViewCreated", arg0, arg1, arg2, arg3);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/FragmentManager.FragmentLifecycleCallbacks.html#onFragmentViewDestroyed(android.app.FragmentManager,android.app.Fragment)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.App.FragmentManager"/></param>
            /// <param name="arg1"><see cref="Android.App.Fragment"/></param>
            [global::System.Obsolete()]
            public void OnFragmentViewDestroyed(Android.App.FragmentManager arg0, Android.App.Fragment arg1)
            {
                IExecute("onFragmentViewDestroyed", arg0, arg1);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OnBackStackChangedListener
        public partial class OnBackStackChangedListener
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
            /// Handlers initializer for <see cref="OnBackStackChangedListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onBackStackChanged", new global::System.EventHandler<CLRListenerEventArgs<CLREventData>>(OnBackStackChangedEventHandler));

            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/app/FragmentManager.OnBackStackChangedListener.html#onBackStackChanged()"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnBackStackChanged"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action OnOnBackStackChanged { get; set; } = null;

            void OnBackStackChangedEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
            {
                var methodToExecute = (OnOnBackStackChanged != null) ? OnOnBackStackChanged : OnBackStackChanged;
                methodToExecute.Invoke();
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/FragmentManager.OnBackStackChangedListener.html#onBackStackChanged()"/>
            /// </summary>
            [global::System.Obsolete()]
            public virtual void OnBackStackChanged()
            {
                
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OnBackStackChangedListenerDirect
        public partial class OnBackStackChangedListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/app/FragmentManager.OnBackStackChangedListener.html#onBackStackChanged()"/>
            /// </summary>
            [global::System.Obsolete()]
            public override void OnBackStackChanged()
            {
                IExecuteWithSignature("onBackStackChanged", "()V");
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