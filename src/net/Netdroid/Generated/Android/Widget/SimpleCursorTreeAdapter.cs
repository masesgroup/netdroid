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

namespace Android.Widget
{
    #region SimpleCursorTreeAdapter
    public partial class SimpleCursorTreeAdapter
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SimpleCursorTreeAdapter.html#%3Cinit%3E(android.content.Context,android.database.Cursor,int,int,java.lang.String[],int[],int,int,java.lang.String[],int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Database.Cursor"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="Java.Lang.String"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        /// <param name="arg7"><see cref="int"/></param>
        /// <param name="arg8"><see cref="Java.Lang.String"/></param>
        /// <param name="arg9"><see cref="int"/></param>
        public SimpleCursorTreeAdapter(Android.Content.Context arg0, Android.Database.Cursor arg1, int arg2, int arg3, Java.Lang.String[] arg4, int[] arg5, int arg6, int arg7, Java.Lang.String[] arg8, int[] arg9)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SimpleCursorTreeAdapter.html#%3Cinit%3E(android.content.Context,android.database.Cursor,int,int,java.lang.String[],int[],int,java.lang.String[],int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Database.Cursor"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="Java.Lang.String"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        /// <param name="arg7"><see cref="Java.Lang.String"/></param>
        /// <param name="arg8"><see cref="int"/></param>
        public SimpleCursorTreeAdapter(Android.Content.Context arg0, Android.Database.Cursor arg1, int arg2, int arg3, Java.Lang.String[] arg4, int[] arg5, int arg6, Java.Lang.String[] arg7, int[] arg8)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SimpleCursorTreeAdapter.html#%3Cinit%3E(android.content.Context,android.database.Cursor,int,java.lang.String[],int[],int,java.lang.String[],int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Database.Cursor"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="Java.Lang.String"/></param>
        /// <param name="arg7"><see cref="int"/></param>
        public SimpleCursorTreeAdapter(Android.Content.Context arg0, Android.Database.Cursor arg1, int arg2, Java.Lang.String[] arg3, int[] arg4, int arg5, Java.Lang.String[] arg6, int[] arg7)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7)
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
        /// <see href="https://developer.android.com/reference/android/widget/SimpleCursorTreeAdapter.html#getViewBinder()"/>
        /// </summary>
        /// <returns><see cref="Android.Widget.SimpleCursorTreeAdapter.ViewBinder"/></returns>
        public Android.Widget.SimpleCursorTreeAdapter.ViewBinder GetViewBinder()
        {
            return IExecuteWithSignature<Android.Widget.SimpleCursorTreeAdapter.ViewBinder>("getViewBinder", "()Landroid/widget/SimpleCursorTreeAdapter$ViewBinder;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SimpleCursorTreeAdapter.html#setViewBinder(android.widget.SimpleCursorTreeAdapter.ViewBinder)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Widget.SimpleCursorTreeAdapter.ViewBinder"/></param>
        public void SetViewBinder(Android.Widget.SimpleCursorTreeAdapter.ViewBinder arg0)
        {
            IExecuteWithSignature("setViewBinder", "(Landroid/widget/SimpleCursorTreeAdapter$ViewBinder;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SimpleCursorTreeAdapter.html#setViewText(android.widget.TextView,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Widget.TextView"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public void SetViewText(Android.Widget.TextView arg0, Java.Lang.String arg1)
        {
            IExecute("setViewText", arg0, arg1);
        }

        #endregion

        #region Nested classes
        #region ViewBinder
        public partial class ViewBinder
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
            /// <see href="https://developer.android.com/reference/android/widget/SimpleCursorTreeAdapter.ViewBinder.html#setViewValue(android.view.View,android.database.Cursor,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.View"/></param>
            /// <param name="arg1"><see cref="Android.Database.Cursor"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            /// <returns><see cref="bool"/></returns>
            public bool SetViewValue(Android.View.View arg0, Android.Database.Cursor arg1, int arg2)
            {
                return IExecute<bool>("setViewValue", arg0, arg1, arg2);
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