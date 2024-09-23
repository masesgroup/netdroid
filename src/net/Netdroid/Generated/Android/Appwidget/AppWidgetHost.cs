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

namespace Android.Appwidget
{
    #region AppWidgetHost declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetHost.html"/>
    /// </summary>
    public partial class AppWidgetHost : MASES.JCOBridge.C2JBridge.JVMBridgeBase<AppWidgetHost>
    {
        const string _bridgeClassName = "android.appwidget.AppWidgetHost";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public AppWidgetHost() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public AppWidgetHost(params object[] args) : base(args) { }
    
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

    #region AppWidgetHost implementation
    public partial class AppWidgetHost
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetHost.html#%3Cinit%3E(android.content.Context,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public AppWidgetHost(Android.Content.Context arg0, int arg1)
            : base(arg0, arg1)
        {
        }
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetHost.html#deleteAllHosts()"/>
        /// </summary>
        public static void DeleteAllHosts()
        {
            SExecuteWithSignature(LocalBridgeClazz, "deleteAllHosts", "()V");
        }
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetHost.html#createView(android.content.Context,int,android.appwidget.AppWidgetProviderInfo)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Android.Appwidget.AppWidgetProviderInfo"/></param>
        /// <returns><see cref="Android.Appwidget.AppWidgetHostView"/></returns>
        public Android.Appwidget.AppWidgetHostView CreateView(Android.Content.Context arg0, int arg1, Android.Appwidget.AppWidgetProviderInfo arg2)
        {
            return IExecute<Android.Appwidget.AppWidgetHostView>("createView", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetHost.html#startAppWidgetConfigureActivityForResult(android.app.Activity,int,int,int,android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.Activity"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="Android.Os.Bundle"/></param>
        public void StartAppWidgetConfigureActivityForResult(Android.App.Activity arg0, int arg1, int arg2, int arg3, Android.Os.Bundle arg4)
        {
            IExecute("startAppWidgetConfigureActivityForResult", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetHost.html#allocateAppWidgetId()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int AllocateAppWidgetId()
        {
            return IExecuteWithSignature<int>("allocateAppWidgetId", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetHost.html#getAppWidgetIds()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int[] GetAppWidgetIds()
        {
            return IExecuteWithSignatureArray<int>("getAppWidgetIds", "()[I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetHost.html#deleteAppWidgetId(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void DeleteAppWidgetId(int arg0)
        {
            IExecuteWithSignature("deleteAppWidgetId", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetHost.html#deleteHost()"/>
        /// </summary>
        public void DeleteHost()
        {
            IExecuteWithSignature("deleteHost", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetHost.html#onAppWidgetRemoved(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void OnAppWidgetRemoved(int arg0)
        {
            IExecuteWithSignature("onAppWidgetRemoved", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetHost.html#startListening()"/>
        /// </summary>
        public void StartListening()
        {
            IExecuteWithSignature("startListening", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetHost.html#stopListening()"/>
        /// </summary>
        public void StopListening()
        {
            IExecuteWithSignature("stopListening", "()V");
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}