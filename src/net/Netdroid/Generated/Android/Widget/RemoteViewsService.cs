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

namespace Android.Widget
{
    #region RemoteViewsService
    public partial class RemoteViewsService
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
        /// <see href="https://developer.android.com/reference/android/widget/RemoteViewsService.html#onGetViewFactory(android.content.Intent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Intent"/></param>
        /// <returns><see cref="Android.Widget.RemoteViewsService.RemoteViewsFactory"/></returns>
        public Android.Widget.RemoteViewsService.RemoteViewsFactory OnGetViewFactory(Android.Content.Intent arg0)
        {
            return IExecuteWithSignature<Android.Widget.RemoteViewsService.RemoteViewsFactory>("onGetViewFactory", "(Landroid/content/Intent;)Landroid/widget/RemoteViewsService$RemoteViewsFactory;", arg0);
        }

        #endregion

        #region Nested classes
        #region RemoteViewsFactory
        public partial class RemoteViewsFactory
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
            /// <see href="https://developer.android.com/reference/android/widget/RemoteViewsService.RemoteViewsFactory.html#getLoadingView()"/>
            /// </summary>
            /// <returns><see cref="Android.Widget.RemoteViews"/></returns>
            public Android.Widget.RemoteViews GetLoadingView()
            {
                return IExecuteWithSignature<Android.Widget.RemoteViews>("getLoadingView", "()Landroid/widget/RemoteViews;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/RemoteViewsService.RemoteViewsFactory.html#getViewAt(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Widget.RemoteViews"/></returns>
            public Android.Widget.RemoteViews GetViewAt(int arg0)
            {
                return IExecuteWithSignature<Android.Widget.RemoteViews>("getViewAt", "(I)Landroid/widget/RemoteViews;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/RemoteViewsService.RemoteViewsFactory.html#hasStableIds()"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool HasStableIds()
            {
                return IExecuteWithSignature<bool>("hasStableIds", "()Z");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/RemoteViewsService.RemoteViewsFactory.html#getCount()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetCount()
            {
                return IExecuteWithSignature<int>("getCount", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/RemoteViewsService.RemoteViewsFactory.html#getViewTypeCount()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetViewTypeCount()
            {
                return IExecuteWithSignature<int>("getViewTypeCount", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/RemoteViewsService.RemoteViewsFactory.html#getItemId(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="long"/></returns>
            public long GetItemId(int arg0)
            {
                return IExecuteWithSignature<long>("getItemId", "(I)J", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/RemoteViewsService.RemoteViewsFactory.html#onCreate()"/>
            /// </summary>
            public void OnCreate()
            {
                IExecuteWithSignature("onCreate", "()V");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/RemoteViewsService.RemoteViewsFactory.html#onDataSetChanged()"/>
            /// </summary>
            public void OnDataSetChanged()
            {
                IExecuteWithSignature("onDataSetChanged", "()V");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/RemoteViewsService.RemoteViewsFactory.html#onDestroy()"/>
            /// </summary>
            public void OnDestroy()
            {
                IExecuteWithSignature("onDestroy", "()V");
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