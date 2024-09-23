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
    #region AppWidgetProvider declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetProvider.html"/>
    /// </summary>
    public partial class AppWidgetProvider : Android.Content.BroadcastReceiver
    {
        const string _bridgeClassName = "android.appwidget.AppWidgetProvider";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public AppWidgetProvider() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public AppWidgetProvider(params object[] args) : base(args) { }
    
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

    #region AppWidgetProvider implementation
    public partial class AppWidgetProvider
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
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetProvider.html#onAppWidgetOptionsChanged(android.content.Context,android.appwidget.AppWidgetManager,int,android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Appwidget.AppWidgetManager"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Android.Os.Bundle"/></param>
        public void OnAppWidgetOptionsChanged(Android.Content.Context arg0, Android.Appwidget.AppWidgetManager arg1, int arg2, Android.Os.Bundle arg3)
        {
            IExecute("onAppWidgetOptionsChanged", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetProvider.html#onDeleted(android.content.Context,int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void OnDeleted(Android.Content.Context arg0, int[] arg1)
        {
            IExecute("onDeleted", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetProvider.html#onDisabled(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        public void OnDisabled(Android.Content.Context arg0)
        {
            IExecuteWithSignature("onDisabled", "(Landroid/content/Context;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetProvider.html#onEnabled(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        public void OnEnabled(Android.Content.Context arg0)
        {
            IExecuteWithSignature("onEnabled", "(Landroid/content/Context;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetProvider.html#onRestored(android.content.Context,int[],int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public void OnRestored(Android.Content.Context arg0, int[] arg1, int[] arg2)
        {
            IExecute("onRestored", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetProvider.html#onUpdate(android.content.Context,android.appwidget.AppWidgetManager,int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Appwidget.AppWidgetManager"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public void OnUpdate(Android.Content.Context arg0, Android.Appwidget.AppWidgetManager arg1, int[] arg2)
        {
            IExecute("onUpdate", arg0, arg1, arg2);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}