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
    #region HeaderViewListAdapter
    public partial class HeaderViewListAdapter : Android.Widget.IWrapperListAdapter, Android.Widget.IFilterable
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/HeaderViewListAdapter.html#%3Cinit%3E(java.util.ArrayList,java.util.ArrayList,android.widget.ListAdapter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.ArrayList"/></param>
        /// <param name="arg1"><see cref="Java.Util.ArrayList"/></param>
        /// <param name="arg2"><see cref="Android.Widget.ListAdapter"/></param>
        public HeaderViewListAdapter(Java.Util.ArrayList<Android.Widget.ListView.FixedViewInfo> arg0, Java.Util.ArrayList<Android.Widget.ListView.FixedViewInfo> arg1, Android.Widget.ListAdapter arg2)
            : base(arg0, arg1, arg2)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Android.Widget.HeaderViewListAdapter"/> to <see cref="Android.Widget.WrapperListAdapter"/>
        /// </summary>
        public static implicit operator Android.Widget.WrapperListAdapter(Android.Widget.HeaderViewListAdapter t) => t.Cast<Android.Widget.WrapperListAdapter>();
        /// <summary>
        /// Converter from <see cref="Android.Widget.HeaderViewListAdapter"/> to <see cref="Android.Widget.Filterable"/>
        /// </summary>
        public static implicit operator Android.Widget.Filterable(Android.Widget.HeaderViewListAdapter t) => t.Cast<Android.Widget.Filterable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/HeaderViewListAdapter.html#getView(int,android.view.View,android.view.ViewGroup)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.View.View"/></param>
        /// <param name="arg2"><see cref="Android.View.ViewGroup"/></param>
        /// <returns><see cref="Android.View.View"/></returns>
        public Android.View.View GetView(int arg0, Android.View.View arg1, Android.View.ViewGroup arg2)
        {
            return IExecute<Android.View.View>("getView", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/HeaderViewListAdapter.html#getFilter()"/>
        /// </summary>
        /// <returns><see cref="Android.Widget.Filter"/></returns>
        public Android.Widget.Filter GetFilter()
        {
            return IExecuteWithSignature<Android.Widget.Filter>("getFilter", "()Landroid/widget/Filter;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/HeaderViewListAdapter.html#getWrappedAdapter()"/>
        /// </summary>
        /// <returns><see cref="Android.Widget.ListAdapter"/></returns>
        public Android.Widget.ListAdapter GetWrappedAdapter()
        {
            return IExecuteWithSignature<Android.Widget.ListAdapter>("getWrappedAdapter", "()Landroid/widget/ListAdapter;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/HeaderViewListAdapter.html#getWrappedAdapter()"/>
        /// </summary>
        /// <returns><see cref="Android.Widget.ListAdapter"/></returns>
        public Android.Widget.ListAdapter GetWrappedAdapterDirect()
        {
            return IExecuteWithSignature<Android.Widget.ListAdapterDirect, Android.Widget.ListAdapter>("getWrappedAdapter", "()Landroid/widget/ListAdapter;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/HeaderViewListAdapter.html#areAllItemsEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool AreAllItemsEnabled()
        {
            return IExecuteWithSignature<bool>("areAllItemsEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/HeaderViewListAdapter.html#hasStableIds()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasStableIds()
        {
            return IExecuteWithSignature<bool>("hasStableIds", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/HeaderViewListAdapter.html#isEmpty()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsEmpty()
        {
            return IExecuteWithSignature<bool>("isEmpty", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/HeaderViewListAdapter.html#isEnabled(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsEnabled(int arg0)
        {
            return IExecuteWithSignature<bool>("isEnabled", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/HeaderViewListAdapter.html#removeFooter(android.view.View)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool RemoveFooter(Android.View.View arg0)
        {
            return IExecuteWithSignature<bool>("removeFooter", "(Landroid/view/View;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/HeaderViewListAdapter.html#removeHeader(android.view.View)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool RemoveHeader(Android.View.View arg0)
        {
            return IExecuteWithSignature<bool>("removeHeader", "(Landroid/view/View;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/HeaderViewListAdapter.html#getCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetCount()
        {
            return IExecuteWithSignature<int>("getCount", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/HeaderViewListAdapter.html#getFootersCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetFootersCount()
        {
            return IExecuteWithSignature<int>("getFootersCount", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/HeaderViewListAdapter.html#getHeadersCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetHeadersCount()
        {
            return IExecuteWithSignature<int>("getHeadersCount", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/HeaderViewListAdapter.html#getItemViewType(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetItemViewType(int arg0)
        {
            return IExecuteWithSignature<int>("getItemViewType", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/HeaderViewListAdapter.html#getViewTypeCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetViewTypeCount()
        {
            return IExecuteWithSignature<int>("getViewTypeCount", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/HeaderViewListAdapter.html#getItem(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetItem(int arg0)
        {
            return IExecuteWithSignature("getItem", "(I)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/HeaderViewListAdapter.html#getItemId(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="long"/></returns>
        public long GetItemId(int arg0)
        {
            return IExecuteWithSignature<long>("getItemId", "(I)J", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/HeaderViewListAdapter.html#registerDataSetObserver(android.database.DataSetObserver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Database.DataSetObserver"/></param>
        public void RegisterDataSetObserver(Android.Database.DataSetObserver arg0)
        {
            IExecuteWithSignature("registerDataSetObserver", "(Landroid/database/DataSetObserver;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/HeaderViewListAdapter.html#unregisterDataSetObserver(android.database.DataSetObserver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Database.DataSetObserver"/></param>
        public void UnregisterDataSetObserver(Android.Database.DataSetObserver arg0)
        {
            IExecuteWithSignature("unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}