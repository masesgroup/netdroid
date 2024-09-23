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
*  This file is generated by MASES.JNetReflector (ver. 2.5.9.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.App
{
    #region FragmentController declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/app/FragmentController.html"/>
    /// </summary>
    [global::System.Obsolete()]
    public partial class FragmentController : MASES.JCOBridge.C2JBridge.JVMBridgeBase<FragmentController>
    {
        const string _bridgeClassName = "android.app.FragmentController";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public FragmentController() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public FragmentController(params object[] args) : base(args) { }
    
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
    
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;
    
        // TODO: complete the class
    
    }
    #endregion

    #region FragmentController implementation
    public partial class FragmentController
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentController.html#createController(android.app.FragmentHostCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.FragmentHostCallback"/></param>
        /// <returns><see cref="Android.App.FragmentController"/></returns>
        [global::System.Obsolete()]
        public static Android.App.FragmentController CreateController(Android.App.FragmentHostCallback<object> arg0)
        {
            return SExecuteWithSignature<Android.App.FragmentController>(LocalBridgeClazz, "createController", "(Landroid/app/FragmentHostCallback;)Landroid/app/FragmentController;", arg0);
        }
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentController.html#findFragmentByWho(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.App.Fragment"/></returns>
        [global::System.Obsolete()]
        public Android.App.Fragment FindFragmentByWho(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Android.App.Fragment>("findFragmentByWho", "(Ljava/lang/String;)Landroid/app/Fragment;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentController.html#getFragmentManager()"/>
        /// </summary>
        /// <returns><see cref="Android.App.FragmentManager"/></returns>
        [global::System.Obsolete()]
        public Android.App.FragmentManager GetFragmentManager()
        {
            return IExecuteWithSignature<Android.App.FragmentManager>("getFragmentManager", "()Landroid/app/FragmentManager;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentController.html#retainNestedNonConfig()"/>
        /// </summary>
        /// <returns><see cref="Android.App.FragmentManagerNonConfig"/></returns>
        [global::System.Obsolete()]
        public Android.App.FragmentManagerNonConfig RetainNestedNonConfig()
        {
            return IExecuteWithSignature<Android.App.FragmentManagerNonConfig>("retainNestedNonConfig", "()Landroid/app/FragmentManagerNonConfig;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentController.html#getLoaderManager()"/>
        /// </summary>
        /// <returns><see cref="Android.App.LoaderManager"/></returns>
        [global::System.Obsolete()]
        public Android.App.LoaderManager GetLoaderManager()
        {
            return IExecuteWithSignature<Android.App.LoaderManager>("getLoaderManager", "()Landroid/app/LoaderManager;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentController.html#saveAllState()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.Parcelable"/></returns>
        [global::System.Obsolete()]
        public Android.Os.Parcelable SaveAllState()
        {
            return IExecuteWithSignature<Android.Os.Parcelable>("saveAllState", "()Landroid/os/Parcelable;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentController.html#retainLoaderNonConfig()"/>
        /// </summary>
        /// <returns><see cref="Android.Util.ArrayMap"/></returns>
        [global::System.Obsolete()]
        public Android.Util.ArrayMap<Java.Lang.String, Android.App.LoaderManager> RetainLoaderNonConfig()
        {
            return IExecuteWithSignature<Android.Util.ArrayMap<Java.Lang.String, Android.App.LoaderManager>>("retainLoaderNonConfig", "()Landroid/util/ArrayMap;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentController.html#onCreateView(android.view.View,java.lang.String,android.content.Context,android.util.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Android.Content.Context"/></param>
        /// <param name="arg3"><see cref="Android.Util.AttributeSet"/></param>
        /// <returns><see cref="Android.View.View"/></returns>
        [global::System.Obsolete()]
        public Android.View.View OnCreateView(Android.View.View arg0, Java.Lang.String arg1, Android.Content.Context arg2, Android.Util.AttributeSet arg3)
        {
            return IExecute<Android.View.View>("onCreateView", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentController.html#dispatchContextItemSelected(android.view.MenuItem)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.MenuItem"/></param>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool DispatchContextItemSelected(Android.View.MenuItem arg0)
        {
            return IExecuteWithSignature<bool>("dispatchContextItemSelected", "(Landroid/view/MenuItem;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentController.html#dispatchCreateOptionsMenu(android.view.Menu,android.view.MenuInflater)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Menu"/></param>
        /// <param name="arg1"><see cref="Android.View.MenuInflater"/></param>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool DispatchCreateOptionsMenu(Android.View.Menu arg0, Android.View.MenuInflater arg1)
        {
            return IExecute<bool>("dispatchCreateOptionsMenu", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentController.html#dispatchOptionsItemSelected(android.view.MenuItem)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.MenuItem"/></param>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool DispatchOptionsItemSelected(Android.View.MenuItem arg0)
        {
            return IExecuteWithSignature<bool>("dispatchOptionsItemSelected", "(Landroid/view/MenuItem;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentController.html#dispatchPrepareOptionsMenu(android.view.Menu)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Menu"/></param>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool DispatchPrepareOptionsMenu(Android.View.Menu arg0)
        {
            return IExecuteWithSignature<bool>("dispatchPrepareOptionsMenu", "(Landroid/view/Menu;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentController.html#execPendingActions()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool ExecPendingActions()
        {
            return IExecuteWithSignature<bool>("execPendingActions", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentController.html#retainNonConfig()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        [global::System.Obsolete()]
        public Java.Util.List<Android.App.Fragment> RetainNonConfig()
        {
            return IExecuteWithSignature<Java.Util.List<Android.App.Fragment>>("retainNonConfig", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentController.html#attachHost(android.app.Fragment)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.Fragment"/></param>
        [global::System.Obsolete()]
        public void AttachHost(Android.App.Fragment arg0)
        {
            IExecuteWithSignature("attachHost", "(Landroid/app/Fragment;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentController.html#dispatchActivityCreated()"/>
        /// </summary>
        [global::System.Obsolete()]
        public void DispatchActivityCreated()
        {
            IExecuteWithSignature("dispatchActivityCreated", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentController.html#dispatchConfigurationChanged(android.content.res.Configuration)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Res.Configuration"/></param>
        [global::System.Obsolete()]
        public void DispatchConfigurationChanged(Android.Content.Res.Configuration arg0)
        {
            IExecuteWithSignature("dispatchConfigurationChanged", "(Landroid/content/res/Configuration;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentController.html#dispatchCreate()"/>
        /// </summary>
        [global::System.Obsolete()]
        public void DispatchCreate()
        {
            IExecuteWithSignature("dispatchCreate", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentController.html#dispatchDestroy()"/>
        /// </summary>
        [global::System.Obsolete()]
        public void DispatchDestroy()
        {
            IExecuteWithSignature("dispatchDestroy", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentController.html#dispatchDestroyView()"/>
        /// </summary>
        [global::System.Obsolete()]
        public void DispatchDestroyView()
        {
            IExecuteWithSignature("dispatchDestroyView", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentController.html#dispatchLowMemory()"/>
        /// </summary>
        [global::System.Obsolete()]
        public void DispatchLowMemory()
        {
            IExecuteWithSignature("dispatchLowMemory", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentController.html#dispatchMultiWindowModeChanged(boolean,android.content.res.Configuration)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <param name="arg1"><see cref="Android.Content.Res.Configuration"/></param>
        [global::System.Obsolete()]
        public void DispatchMultiWindowModeChanged(bool arg0, Android.Content.Res.Configuration arg1)
        {
            IExecute("dispatchMultiWindowModeChanged", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentController.html#dispatchMultiWindowModeChanged(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        [global::System.Obsolete()]
        public void DispatchMultiWindowModeChanged(bool arg0)
        {
            IExecuteWithSignature("dispatchMultiWindowModeChanged", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentController.html#dispatchOptionsMenuClosed(android.view.Menu)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Menu"/></param>
        [global::System.Obsolete()]
        public void DispatchOptionsMenuClosed(Android.View.Menu arg0)
        {
            IExecuteWithSignature("dispatchOptionsMenuClosed", "(Landroid/view/Menu;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentController.html#dispatchPause()"/>
        /// </summary>
        [global::System.Obsolete()]
        public void DispatchPause()
        {
            IExecuteWithSignature("dispatchPause", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentController.html#dispatchPictureInPictureModeChanged(boolean,android.content.res.Configuration)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <param name="arg1"><see cref="Android.Content.Res.Configuration"/></param>
        [global::System.Obsolete()]
        public void DispatchPictureInPictureModeChanged(bool arg0, Android.Content.Res.Configuration arg1)
        {
            IExecute("dispatchPictureInPictureModeChanged", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentController.html#dispatchPictureInPictureModeChanged(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        [global::System.Obsolete()]
        public void DispatchPictureInPictureModeChanged(bool arg0)
        {
            IExecuteWithSignature("dispatchPictureInPictureModeChanged", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentController.html#dispatchResume()"/>
        /// </summary>
        [global::System.Obsolete()]
        public void DispatchResume()
        {
            IExecuteWithSignature("dispatchResume", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentController.html#dispatchStart()"/>
        /// </summary>
        [global::System.Obsolete()]
        public void DispatchStart()
        {
            IExecuteWithSignature("dispatchStart", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentController.html#dispatchStop()"/>
        /// </summary>
        [global::System.Obsolete()]
        public void DispatchStop()
        {
            IExecuteWithSignature("dispatchStop", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentController.html#dispatchTrimMemory(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        [global::System.Obsolete()]
        public void DispatchTrimMemory(int arg0)
        {
            IExecuteWithSignature("dispatchTrimMemory", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentController.html#doLoaderDestroy()"/>
        /// </summary>
        [global::System.Obsolete()]
        public void DoLoaderDestroy()
        {
            IExecuteWithSignature("doLoaderDestroy", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentController.html#doLoaderStart()"/>
        /// </summary>
        [global::System.Obsolete()]
        public void DoLoaderStart()
        {
            IExecuteWithSignature("doLoaderStart", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentController.html#doLoaderStop(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        [global::System.Obsolete()]
        public void DoLoaderStop(bool arg0)
        {
            IExecuteWithSignature("doLoaderStop", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentController.html#dumpLoaders(java.lang.String,java.io.FileDescriptor,java.io.PrintWriter,java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Io.FileDescriptor"/></param>
        /// <param name="arg2"><see cref="Java.Io.PrintWriter"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        [global::System.Obsolete()]
        public void DumpLoaders(Java.Lang.String arg0, Java.Io.FileDescriptor arg1, Java.Io.PrintWriter arg2, Java.Lang.String[] arg3)
        {
            IExecute("dumpLoaders", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentController.html#noteStateNotSaved()"/>
        /// </summary>
        [global::System.Obsolete()]
        public void NoteStateNotSaved()
        {
            IExecuteWithSignature("noteStateNotSaved", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentController.html#reportLoaderStart()"/>
        /// </summary>
        [global::System.Obsolete()]
        public void ReportLoaderStart()
        {
            IExecuteWithSignature("reportLoaderStart", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentController.html#restoreAllState(android.os.Parcelable,android.app.FragmentManagerNonConfig)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcelable"/></param>
        /// <param name="arg1"><see cref="Android.App.FragmentManagerNonConfig"/></param>
        [global::System.Obsolete()]
        public void RestoreAllState(Android.Os.Parcelable arg0, Android.App.FragmentManagerNonConfig arg1)
        {
            IExecute("restoreAllState", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentController.html#restoreAllState(android.os.Parcelable,java.util.List)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcelable"/></param>
        /// <param name="arg1"><see cref="Java.Util.List"/></param>
        [global::System.Obsolete()]
        public void RestoreAllState(Android.Os.Parcelable arg0, Java.Util.List<Android.App.Fragment> arg1)
        {
            IExecute("restoreAllState", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentController.html#restoreLoaderNonConfig(android.util.ArrayMap)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Util.ArrayMap"/></param>
        [global::System.Obsolete()]
        public void RestoreLoaderNonConfig(Android.Util.ArrayMap<Java.Lang.String, Android.App.LoaderManager> arg0)
        {
            IExecuteWithSignature("restoreLoaderNonConfig", "(Landroid/util/ArrayMap;)V", arg0);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}