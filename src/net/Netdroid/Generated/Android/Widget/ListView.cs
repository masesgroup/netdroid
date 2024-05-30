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
*  This file is generated by MASES.JNetReflector (ver. 2.5.1.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Widget
{
    #region ListView
    public partial class ListView
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListView.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public ListView(Android.Content.Context arg0, Android.Util.AttributeSet arg1, int arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListView.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public ListView(Android.Content.Context arg0, Android.Util.AttributeSet arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListView.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        public ListView(Android.Content.Context arg0, Android.Util.AttributeSet arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListView.html#%3Cinit%3E(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        public ListView(Android.Content.Context arg0)
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
        /// <see href="https://developer.android.com/reference/android/widget/ListView.html#getDivider()"/> <see href="https://developer.android.com/reference/android/widget/ListView.html#setDivider(android.graphics.drawable.Drawable)"/>
        /// </summary>
        public Android.Graphics.Drawable.Drawable Divider
        {
            get { return IExecuteWithSignature<Android.Graphics.Drawable.Drawable>("getDivider", "()Landroid/graphics/drawable/Drawable;"); } set { IExecuteWithSignature("setDivider", "(Landroid/graphics/drawable/Drawable;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListView.html#getDividerHeight()"/> <see href="https://developer.android.com/reference/android/widget/ListView.html#setDividerHeight(int)"/>
        /// </summary>
        public int DividerHeight
        {
            get { return IExecuteWithSignature<int>("getDividerHeight", "()I"); } set { IExecuteWithSignature("setDividerHeight", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListView.html#getFooterViewsCount()"/> 
        /// </summary>
        public int FooterViewsCount
        {
            get { return IExecuteWithSignature<int>("getFooterViewsCount", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListView.html#getHeaderViewsCount()"/> 
        /// </summary>
        public int HeaderViewsCount
        {
            get { return IExecuteWithSignature<int>("getHeaderViewsCount", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListView.html#getItemsCanFocus()"/> <see href="https://developer.android.com/reference/android/widget/ListView.html#setItemsCanFocus(boolean)"/>
        /// </summary>
        public bool ItemsCanFocus
        {
            get { return IExecuteWithSignature<bool>("getItemsCanFocus", "()Z"); } set { IExecuteWithSignature("setItemsCanFocus", "(Z)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListView.html#getMaxScrollAmount()"/> 
        /// </summary>
        public int MaxScrollAmount
        {
            get { return IExecuteWithSignature<int>("getMaxScrollAmount", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListView.html#getOverscrollFooter()"/> <see href="https://developer.android.com/reference/android/widget/ListView.html#setOverscrollFooter(android.graphics.drawable.Drawable)"/>
        /// </summary>
        public Android.Graphics.Drawable.Drawable OverscrollFooter
        {
            get { return IExecuteWithSignature<Android.Graphics.Drawable.Drawable>("getOverscrollFooter", "()Landroid/graphics/drawable/Drawable;"); } set { IExecuteWithSignature("setOverscrollFooter", "(Landroid/graphics/drawable/Drawable;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListView.html#getOverscrollHeader()"/> <see href="https://developer.android.com/reference/android/widget/ListView.html#setOverscrollHeader(android.graphics.drawable.Drawable)"/>
        /// </summary>
        public Android.Graphics.Drawable.Drawable OverscrollHeader
        {
            get { return IExecuteWithSignature<Android.Graphics.Drawable.Drawable>("getOverscrollHeader", "()Landroid/graphics/drawable/Drawable;"); } set { IExecuteWithSignature("setOverscrollHeader", "(Landroid/graphics/drawable/Drawable;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListView.html#areFooterDividersEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool AreFooterDividersEnabled()
        {
            return IExecuteWithSignature<bool>("areFooterDividersEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListView.html#areHeaderDividersEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool AreHeaderDividersEnabled()
        {
            return IExecuteWithSignature<bool>("areHeaderDividersEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListView.html#removeFooterView(android.view.View)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool RemoveFooterView(Android.View.View arg0)
        {
            return IExecuteWithSignature<bool>("removeFooterView", "(Landroid/view/View;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListView.html#removeHeaderView(android.view.View)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool RemoveHeaderView(Android.View.View arg0)
        {
            return IExecuteWithSignature<bool>("removeHeaderView", "(Landroid/view/View;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListView.html#addFooterView(android.view.View,java.lang.Object,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        public void AddFooterView(Android.View.View arg0, object arg1, bool arg2)
        {
            IExecute("addFooterView", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListView.html#addFooterView(android.view.View)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        public void AddFooterView(Android.View.View arg0)
        {
            IExecuteWithSignature("addFooterView", "(Landroid/view/View;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListView.html#addHeaderView(android.view.View,java.lang.Object,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        public void AddHeaderView(Android.View.View arg0, object arg1, bool arg2)
        {
            IExecute("addHeaderView", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListView.html#addHeaderView(android.view.View)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        public void AddHeaderView(Android.View.View arg0)
        {
            IExecuteWithSignature("addHeaderView", "(Landroid/view/View;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListView.html#setFooterDividersEnabled(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetFooterDividersEnabled(bool arg0)
        {
            IExecuteWithSignature("setFooterDividersEnabled", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListView.html#setHeaderDividersEnabled(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetHeaderDividersEnabled(bool arg0)
        {
            IExecuteWithSignature("setHeaderDividersEnabled", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListView.html#setSelectionAfterHeaderView()"/>
        /// </summary>
        public void SetSelectionAfterHeaderView()
        {
            IExecuteWithSignature("setSelectionAfterHeaderView", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListView.html#smoothScrollByOffset(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SmoothScrollByOffset(int arg0)
        {
            IExecuteWithSignature("smoothScrollByOffset", "(I)V", arg0);
        }

        #endregion

        #region Nested classes
        #region FixedViewInfo
        public partial class FixedViewInfo
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/ListView.FixedViewInfo.html#%3Cinit%3E(android.widget.ListView)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Widget.ListView"/></param>
            public FixedViewInfo(Android.Widget.ListView arg0)
                : base(arg0)
            {
            }

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/ListView.FixedViewInfo.html#view"/>
            /// </summary>
            public Android.View.View view { get { return IGetField<Android.View.View>("view"); } set { ISetField("view", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/ListView.FixedViewInfo.html#isSelectable"/>
            /// </summary>
            public bool isSelectable { get { return IGetField<bool>("isSelectable"); } set { ISetField("isSelectable", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/ListView.FixedViewInfo.html#data"/>
            /// </summary>
            public object data { get { return IGetField("data"); } set { ISetField("data", value); } }

            #endregion

            #region Static methods

            #endregion

            #region Instance methods

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