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

namespace Android.Appwidget
{
    #region AppWidgetHostView
    public partial class AppWidgetHostView
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetHostView.html#%3Cinit%3E(android.content.Context,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public AppWidgetHostView(Android.Content.Context arg0, int arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetHostView.html#%3Cinit%3E(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        public AppWidgetHostView(Android.Content.Context arg0)
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
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetHostView.html#getDefaultPaddingForWidget(android.content.Context,android.content.ComponentName,android.graphics.Rect)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Content.ComponentName"/></param>
        /// <param name="arg2"><see cref="Android.Graphics.Rect"/></param>
        /// <returns><see cref="Android.Graphics.Rect"/></returns>
        public static Android.Graphics.Rect GetDefaultPaddingForWidget(Android.Content.Context arg0, Android.Content.ComponentName arg1, Android.Graphics.Rect arg2)
        {
            return SExecute<Android.Graphics.Rect>(LocalBridgeClazz, "getDefaultPaddingForWidget", arg0, arg1, arg2);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetHostView.html#getAppWidgetInfo()"/>
        /// </summary>
        /// <returns><see cref="Android.Appwidget.AppWidgetProviderInfo"/></returns>
        public Android.Appwidget.AppWidgetProviderInfo GetAppWidgetInfo()
        {
            return IExecuteWithSignature<Android.Appwidget.AppWidgetProviderInfo>("getAppWidgetInfo", "()Landroid/appwidget/AppWidgetProviderInfo;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetHostView.html#getAppWidgetId()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetAppWidgetId()
        {
            return IExecuteWithSignature<int>("getAppWidgetId", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetHostView.html#resetColorResources()"/>
        /// </summary>
        public void ResetColorResources()
        {
            IExecuteWithSignature("resetColorResources", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetHostView.html#setAppWidget(int,android.appwidget.AppWidgetProviderInfo)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.Appwidget.AppWidgetProviderInfo"/></param>
        public void SetAppWidget(int arg0, Android.Appwidget.AppWidgetProviderInfo arg1)
        {
            IExecute("setAppWidget", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetHostView.html#setColorResources(android.util.SparseIntArray)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Util.SparseIntArray"/></param>
        public void SetColorResources(Android.Util.SparseIntArray arg0)
        {
            IExecuteWithSignature("setColorResources", "(Landroid/util/SparseIntArray;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetHostView.html#setExecutor(java.util.concurrent.Executor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Executor"/></param>
        public void SetExecutor(Java.Util.Concurrent.Executor arg0)
        {
            IExecuteWithSignature("setExecutor", "(Ljava/util/concurrent/Executor;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetHostView.html#setOnLightBackground(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetOnLightBackground(bool arg0)
        {
            IExecuteWithSignature("setOnLightBackground", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetHostView.html#updateAppWidget(android.widget.RemoteViews)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Widget.RemoteViews"/></param>
        public void UpdateAppWidget(Android.Widget.RemoteViews arg0)
        {
            IExecuteWithSignature("updateAppWidget", "(Landroid/widget/RemoteViews;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetHostView.html#updateAppWidgetOptions(android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
        public void UpdateAppWidgetOptions(Android.Os.Bundle arg0)
        {
            IExecuteWithSignature("updateAppWidgetOptions", "(Landroid/os/Bundle;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetHostView.html#updateAppWidgetSize(android.os.Bundle,int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        [global::System.Obsolete()]
        public void UpdateAppWidgetSize(Android.Os.Bundle arg0, int arg1, int arg2, int arg3, int arg4)
        {
            IExecute("updateAppWidgetSize", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetHostView.html#updateAppWidgetSize(android.os.Bundle,java.util.List)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
        /// <param name="arg1"><see cref="Java.Util.List"/></param>
        public void UpdateAppWidgetSize(Android.Os.Bundle arg0, Java.Util.List<Android.Util.SizeF> arg1)
        {
            IExecute("updateAppWidgetSize", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}