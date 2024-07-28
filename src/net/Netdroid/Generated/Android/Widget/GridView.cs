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
*  This file is generated by MASES.JNetReflector (ver. 2.5.5.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Widget
{
    #region GridView
    public partial class GridView
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/GridView.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public GridView(Android.Content.Context arg0, Android.Util.AttributeSet arg1, int arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/GridView.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public GridView(Android.Content.Context arg0, Android.Util.AttributeSet arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/GridView.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        public GridView(Android.Content.Context arg0, Android.Util.AttributeSet arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/GridView.html#%3Cinit%3E(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        public GridView(Android.Content.Context arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/GridView.html#AUTO_FIT"/>
        /// </summary>
        public static int AUTO_FIT { get { if (!_AUTO_FITReady) { _AUTO_FITContent = SGetField<int>(LocalBridgeClazz, "AUTO_FIT"); _AUTO_FITReady = true; } return _AUTO_FITContent; } }
        private static int _AUTO_FITContent = default;
        private static bool _AUTO_FITReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/GridView.html#NO_STRETCH"/>
        /// </summary>
        public static int NO_STRETCH { get { if (!_NO_STRETCHReady) { _NO_STRETCHContent = SGetField<int>(LocalBridgeClazz, "NO_STRETCH"); _NO_STRETCHReady = true; } return _NO_STRETCHContent; } }
        private static int _NO_STRETCHContent = default;
        private static bool _NO_STRETCHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/GridView.html#STRETCH_COLUMN_WIDTH"/>
        /// </summary>
        public static int STRETCH_COLUMN_WIDTH { get { if (!_STRETCH_COLUMN_WIDTHReady) { _STRETCH_COLUMN_WIDTHContent = SGetField<int>(LocalBridgeClazz, "STRETCH_COLUMN_WIDTH"); _STRETCH_COLUMN_WIDTHReady = true; } return _STRETCH_COLUMN_WIDTHContent; } }
        private static int _STRETCH_COLUMN_WIDTHContent = default;
        private static bool _STRETCH_COLUMN_WIDTHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/GridView.html#STRETCH_SPACING"/>
        /// </summary>
        public static int STRETCH_SPACING { get { if (!_STRETCH_SPACINGReady) { _STRETCH_SPACINGContent = SGetField<int>(LocalBridgeClazz, "STRETCH_SPACING"); _STRETCH_SPACINGReady = true; } return _STRETCH_SPACINGContent; } }
        private static int _STRETCH_SPACINGContent = default;
        private static bool _STRETCH_SPACINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/GridView.html#STRETCH_SPACING_UNIFORM"/>
        /// </summary>
        public static int STRETCH_SPACING_UNIFORM { get { if (!_STRETCH_SPACING_UNIFORMReady) { _STRETCH_SPACING_UNIFORMContent = SGetField<int>(LocalBridgeClazz, "STRETCH_SPACING_UNIFORM"); _STRETCH_SPACING_UNIFORMReady = true; } return _STRETCH_SPACING_UNIFORMContent; } }
        private static int _STRETCH_SPACING_UNIFORMContent = default;
        private static bool _STRETCH_SPACING_UNIFORMReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/GridView.html#getColumnWidth()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetColumnWidth()
        {
            return IExecuteWithSignature<int>("getColumnWidth", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/GridView.html#getGravity()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetGravity()
        {
            return IExecuteWithSignature<int>("getGravity", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/GridView.html#getHorizontalSpacing()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetHorizontalSpacing()
        {
            return IExecuteWithSignature<int>("getHorizontalSpacing", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/GridView.html#getNumColumns()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetNumColumns()
        {
            return IExecuteWithSignature<int>("getNumColumns", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/GridView.html#getRequestedColumnWidth()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetRequestedColumnWidth()
        {
            return IExecuteWithSignature<int>("getRequestedColumnWidth", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/GridView.html#getRequestedHorizontalSpacing()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetRequestedHorizontalSpacing()
        {
            return IExecuteWithSignature<int>("getRequestedHorizontalSpacing", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/GridView.html#getStretchMode()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetStretchMode()
        {
            return IExecuteWithSignature<int>("getStretchMode", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/GridView.html#getVerticalSpacing()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetVerticalSpacing()
        {
            return IExecuteWithSignature<int>("getVerticalSpacing", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/GridView.html#setColumnWidth(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetColumnWidth(int arg0)
        {
            IExecuteWithSignature("setColumnWidth", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/GridView.html#setGravity(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetGravity(int arg0)
        {
            IExecuteWithSignature("setGravity", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/GridView.html#setHorizontalSpacing(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetHorizontalSpacing(int arg0)
        {
            IExecuteWithSignature("setHorizontalSpacing", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/GridView.html#setNumColumns(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetNumColumns(int arg0)
        {
            IExecuteWithSignature("setNumColumns", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/GridView.html#setStretchMode(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetStretchMode(int arg0)
        {
            IExecuteWithSignature("setStretchMode", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/GridView.html#setVerticalSpacing(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetVerticalSpacing(int arg0)
        {
            IExecuteWithSignature("setVerticalSpacing", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/GridView.html#smoothScrollByOffset(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SmoothScrollByOffset(int arg0)
        {
            IExecuteWithSignature("smoothScrollByOffset", "(I)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}