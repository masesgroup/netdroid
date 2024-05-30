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
    #region CursorTreeAdapter
    public partial class CursorTreeAdapter
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
        /// Handlers initializer for <see cref="CursorTreeAdapter"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("getCursor", new System.EventHandler<CLRListenerEventArgs<CLREventData>>(GetCursorEventHandler));
            AddEventHandler("runQueryOnBackgroundThread", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Lang.CharSequence>>>(RunQueryOnBackgroundThreadEventHandler));
            AddEventHandler("getFilter", new System.EventHandler<CLRListenerEventArgs<CLREventData>>(GetFilterEventHandler));
            AddEventHandler("getFilterQueryProvider", new System.EventHandler<CLRListenerEventArgs<CLREventData>>(GetFilterQueryProviderEventHandler));
            AddEventHandler("areAllItemsEnabled", new System.EventHandler<CLRListenerEventArgs<CLREventData>>(AreAllItemsEnabledEventHandler));
            AddEventHandler("isEmpty", new System.EventHandler<CLRListenerEventArgs<CLREventData>>(IsEmptyEventHandler));
            AddEventHandler("getChildType", new System.EventHandler<CLRListenerEventArgs<CLREventData<int>>>(GetChildTypeEventHandler));
            AddEventHandler("getChildTypeCount", new System.EventHandler<CLRListenerEventArgs<CLREventData>>(GetChildTypeCountEventHandler));
            AddEventHandler("getGroupType", new System.EventHandler<CLRListenerEventArgs<CLREventData<int>>>(GetGroupTypeEventHandler));
            AddEventHandler("getGroupTypeCount", new System.EventHandler<CLRListenerEventArgs<CLREventData>>(GetGroupTypeCountEventHandler));
            AddEventHandler("convertToString", new System.EventHandler<CLRListenerEventArgs<CLREventData<Android.Database.Cursor>>>(ConvertToStringEventHandler));
            AddEventHandler("getCombinedChildId", new System.EventHandler<CLRListenerEventArgs<CLREventData<long>>>(GetCombinedChildIdEventHandler));
            AddEventHandler("getCombinedGroupId", new System.EventHandler<CLRListenerEventArgs<CLREventData<long>>>(GetCombinedGroupIdEventHandler));
            AddEventHandler("onGroupExpanded", new System.EventHandler<CLRListenerEventArgs<CLREventData<int>>>(OnGroupExpandedEventHandler));
            AddEventHandler("registerDataSetObserver", new System.EventHandler<CLRListenerEventArgs<CLREventData<Android.Database.DataSetObserver>>>(RegisterDataSetObserverEventHandler));
            AddEventHandler("unregisterDataSetObserver", new System.EventHandler<CLRListenerEventArgs<CLREventData<Android.Database.DataSetObserver>>>(UnregisterDataSetObserverEventHandler));
            AddEventHandler("changeCursor", new System.EventHandler<CLRListenerEventArgs<CLREventData<Android.Database.Cursor>>>(ChangeCursorEventHandler));
            AddEventHandler("notifyDataSetChanged", new System.EventHandler<CLRListenerEventArgs<CLREventData<bool>>>(NotifyDataSetChangedEventHandler));
            AddEventHandler("setChildrenCursor", new System.EventHandler<CLRListenerEventArgs<CLREventData<int>>>(SetChildrenCursorEventHandler));
            AddEventHandler("setFilterQueryProvider", new System.EventHandler<CLRListenerEventArgs<CLREventData<Android.Widget.FilterQueryProvider>>>(SetFilterQueryProviderEventHandler));
            AddEventHandler("setGroupCursor", new System.EventHandler<CLRListenerEventArgs<CLREventData<Android.Database.Cursor>>>(SetGroupCursorEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/CursorTreeAdapter.html#getCursor()"/>
        /// </summary>
        /// <remarks>If <see cref="OnGetCursor"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<Android.Database.Cursor> OnGetCursor { get; set; } = null;

        void GetCursorEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnGetCursor != null) ? OnGetCursor : GetCursor;
            var executionResult = methodToExecute.Invoke();
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CursorTreeAdapter.html#getCursor()"/>
        /// </summary>
        /// <returns><see cref="Android.Database.Cursor"/></returns>
        public virtual Android.Database.Cursor GetCursor()
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/CursorTreeAdapter.html#runQueryOnBackgroundThread(java.lang.CharSequence)"/>
        /// </summary>
        /// <remarks>If <see cref="OnRunQueryOnBackgroundThread"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<Java.Lang.CharSequence, Android.Database.Cursor> OnRunQueryOnBackgroundThread { get; set; } = null;

        void RunQueryOnBackgroundThreadEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Lang.CharSequence>> data)
        {
            var methodToExecute = (OnRunQueryOnBackgroundThread != null) ? OnRunQueryOnBackgroundThread : RunQueryOnBackgroundThread;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData);
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CursorTreeAdapter.html#runQueryOnBackgroundThread(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="Android.Database.Cursor"/></returns>
        public virtual Android.Database.Cursor RunQueryOnBackgroundThread(Java.Lang.CharSequence arg0)
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/CursorTreeAdapter.html#getFilter()"/>
        /// </summary>
        /// <remarks>If <see cref="OnGetFilter"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<Android.Widget.Filter> OnGetFilter { get; set; } = null;

        void GetFilterEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnGetFilter != null) ? OnGetFilter : GetFilter;
            var executionResult = methodToExecute.Invoke();
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CursorTreeAdapter.html#getFilter()"/>
        /// </summary>
        /// <returns><see cref="Android.Widget.Filter"/></returns>
        public virtual Android.Widget.Filter GetFilter()
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/CursorTreeAdapter.html#getFilterQueryProvider()"/>
        /// </summary>
        /// <remarks>If <see cref="OnGetFilterQueryProvider"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<Android.Widget.FilterQueryProvider> OnGetFilterQueryProvider { get; set; } = null;

        void GetFilterQueryProviderEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnGetFilterQueryProvider != null) ? OnGetFilterQueryProvider : GetFilterQueryProvider;
            var executionResult = methodToExecute.Invoke();
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CursorTreeAdapter.html#getFilterQueryProvider()"/>
        /// </summary>
        /// <returns><see cref="Android.Widget.FilterQueryProvider"/></returns>
        public virtual Android.Widget.FilterQueryProvider GetFilterQueryProvider()
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/BaseExpandableListAdapter.html#areAllItemsEnabled()"/>
        /// </summary>
        /// <remarks>If <see cref="OnAreAllItemsEnabled"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<bool> OnAreAllItemsEnabled { get; set; } = null;

        void AreAllItemsEnabledEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnAreAllItemsEnabled != null) ? OnAreAllItemsEnabled : AreAllItemsEnabled;
            var executionResult = methodToExecute.Invoke();
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/BaseExpandableListAdapter.html#areAllItemsEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public virtual bool AreAllItemsEnabled()
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/BaseExpandableListAdapter.html#isEmpty()"/>
        /// </summary>
        /// <remarks>If <see cref="OnIsEmpty"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<bool> OnIsEmpty { get; set; } = null;

        void IsEmptyEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnIsEmpty != null) ? OnIsEmpty : IsEmpty;
            var executionResult = methodToExecute.Invoke();
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/BaseExpandableListAdapter.html#isEmpty()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public virtual bool IsEmpty()
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/BaseExpandableListAdapter.html#getChildType(int,int)"/>
        /// </summary>
        /// <remarks>If <see cref="OnGetChildType"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<int, int, int> OnGetChildType { get; set; } = null;

        void GetChildTypeEventHandler(object sender, CLRListenerEventArgs<CLREventData<int>> data)
        {
            var methodToExecute = (OnGetChildType != null) ? OnGetChildType : GetChildType;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<int>(0));
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/BaseExpandableListAdapter.html#getChildType(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public virtual int GetChildType(int arg0, int arg1)
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/BaseExpandableListAdapter.html#getChildTypeCount()"/>
        /// </summary>
        /// <remarks>If <see cref="OnGetChildTypeCount"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<int> OnGetChildTypeCount { get; set; } = null;

        void GetChildTypeCountEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnGetChildTypeCount != null) ? OnGetChildTypeCount : GetChildTypeCount;
            var executionResult = methodToExecute.Invoke();
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/BaseExpandableListAdapter.html#getChildTypeCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public virtual int GetChildTypeCount()
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/BaseExpandableListAdapter.html#getGroupType(int)"/>
        /// </summary>
        /// <remarks>If <see cref="OnGetGroupType"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<int, int> OnGetGroupType { get; set; } = null;

        void GetGroupTypeEventHandler(object sender, CLRListenerEventArgs<CLREventData<int>> data)
        {
            var methodToExecute = (OnGetGroupType != null) ? OnGetGroupType : GetGroupType;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData);
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/BaseExpandableListAdapter.html#getGroupType(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public virtual int GetGroupType(int arg0)
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/BaseExpandableListAdapter.html#getGroupTypeCount()"/>
        /// </summary>
        /// <remarks>If <see cref="OnGetGroupTypeCount"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<int> OnGetGroupTypeCount { get; set; } = null;

        void GetGroupTypeCountEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnGetGroupTypeCount != null) ? OnGetGroupTypeCount : GetGroupTypeCount;
            var executionResult = methodToExecute.Invoke();
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/BaseExpandableListAdapter.html#getGroupTypeCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public virtual int GetGroupTypeCount()
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/CursorTreeAdapter.html#convertToString(android.database.Cursor)"/>
        /// </summary>
        /// <remarks>If <see cref="OnConvertToString"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<Android.Database.Cursor, Java.Lang.String> OnConvertToString { get; set; } = null;

        void ConvertToStringEventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.Database.Cursor>> data)
        {
            var methodToExecute = (OnConvertToString != null) ? OnConvertToString : ConvertToString;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData);
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CursorTreeAdapter.html#convertToString(android.database.Cursor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Database.Cursor"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public virtual Java.Lang.String ConvertToString(Android.Database.Cursor arg0)
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/BaseExpandableListAdapter.html#getCombinedChildId(long,long)"/>
        /// </summary>
        /// <remarks>If <see cref="OnGetCombinedChildId"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<long, long, long> OnGetCombinedChildId { get; set; } = null;

        void GetCombinedChildIdEventHandler(object sender, CLRListenerEventArgs<CLREventData<long>> data)
        {
            var methodToExecute = (OnGetCombinedChildId != null) ? OnGetCombinedChildId : GetCombinedChildId;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<long>(0));
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/BaseExpandableListAdapter.html#getCombinedChildId(long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public virtual long GetCombinedChildId(long arg0, long arg1)
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/BaseExpandableListAdapter.html#getCombinedGroupId(long)"/>
        /// </summary>
        /// <remarks>If <see cref="OnGetCombinedGroupId"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<long, long> OnGetCombinedGroupId { get; set; } = null;

        void GetCombinedGroupIdEventHandler(object sender, CLRListenerEventArgs<CLREventData<long>> data)
        {
            var methodToExecute = (OnGetCombinedGroupId != null) ? OnGetCombinedGroupId : GetCombinedGroupId;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData);
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/BaseExpandableListAdapter.html#getCombinedGroupId(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public virtual long GetCombinedGroupId(long arg0)
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/BaseExpandableListAdapter.html#onGroupExpanded(int)"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnGroupExpanded"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<int> OnOnGroupExpanded { get; set; } = null;

        void OnGroupExpandedEventHandler(object sender, CLRListenerEventArgs<CLREventData<int>> data)
        {
            var methodToExecute = (OnOnGroupExpanded != null) ? OnOnGroupExpanded : OnGroupExpanded;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/BaseExpandableListAdapter.html#onGroupExpanded(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public virtual void OnGroupExpanded(int arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/BaseExpandableListAdapter.html#registerDataSetObserver(android.database.DataSetObserver)"/>
        /// </summary>
        /// <remarks>If <see cref="OnRegisterDataSetObserver"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Android.Database.DataSetObserver> OnRegisterDataSetObserver { get; set; } = null;

        void RegisterDataSetObserverEventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.Database.DataSetObserver>> data)
        {
            var methodToExecute = (OnRegisterDataSetObserver != null) ? OnRegisterDataSetObserver : RegisterDataSetObserver;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/BaseExpandableListAdapter.html#registerDataSetObserver(android.database.DataSetObserver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Database.DataSetObserver"/></param>
        public virtual void RegisterDataSetObserver(Android.Database.DataSetObserver arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/BaseExpandableListAdapter.html#unregisterDataSetObserver(android.database.DataSetObserver)"/>
        /// </summary>
        /// <remarks>If <see cref="OnUnregisterDataSetObserver"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Android.Database.DataSetObserver> OnUnregisterDataSetObserver { get; set; } = null;

        void UnregisterDataSetObserverEventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.Database.DataSetObserver>> data)
        {
            var methodToExecute = (OnUnregisterDataSetObserver != null) ? OnUnregisterDataSetObserver : UnregisterDataSetObserver;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/BaseExpandableListAdapter.html#unregisterDataSetObserver(android.database.DataSetObserver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Database.DataSetObserver"/></param>
        public virtual void UnregisterDataSetObserver(Android.Database.DataSetObserver arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/CursorTreeAdapter.html#changeCursor(android.database.Cursor)"/>
        /// </summary>
        /// <remarks>If <see cref="OnChangeCursor"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Android.Database.Cursor> OnChangeCursor { get; set; } = null;

        void ChangeCursorEventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.Database.Cursor>> data)
        {
            var methodToExecute = (OnChangeCursor != null) ? OnChangeCursor : ChangeCursor;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CursorTreeAdapter.html#changeCursor(android.database.Cursor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Database.Cursor"/></param>
        public virtual void ChangeCursor(Android.Database.Cursor arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/CursorTreeAdapter.html#notifyDataSetChanged(boolean)"/>
        /// </summary>
        /// <remarks>If <see cref="OnNotifyDataSetChanged"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<bool> OnNotifyDataSetChanged { get; set; } = null;

        void NotifyDataSetChangedEventHandler(object sender, CLRListenerEventArgs<CLREventData<bool>> data)
        {
            var methodToExecute = (OnNotifyDataSetChanged != null) ? OnNotifyDataSetChanged : NotifyDataSetChanged;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CursorTreeAdapter.html#notifyDataSetChanged(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public virtual void NotifyDataSetChanged(bool arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/CursorTreeAdapter.html#setChildrenCursor(int,android.database.Cursor)"/>
        /// </summary>
        /// <remarks>If <see cref="OnSetChildrenCursor"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<int, Android.Database.Cursor> OnSetChildrenCursor { get; set; } = null;

        void SetChildrenCursorEventHandler(object sender, CLRListenerEventArgs<CLREventData<int>> data)
        {
            var methodToExecute = (OnSetChildrenCursor != null) ? OnSetChildrenCursor : SetChildrenCursor;
            methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<Android.Database.Cursor>(0));
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CursorTreeAdapter.html#setChildrenCursor(int,android.database.Cursor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.Database.Cursor"/></param>
        public virtual void SetChildrenCursor(int arg0, Android.Database.Cursor arg1)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/CursorTreeAdapter.html#setFilterQueryProvider(android.widget.FilterQueryProvider)"/>
        /// </summary>
        /// <remarks>If <see cref="OnSetFilterQueryProvider"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Android.Widget.FilterQueryProvider> OnSetFilterQueryProvider { get; set; } = null;

        void SetFilterQueryProviderEventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.Widget.FilterQueryProvider>> data)
        {
            var methodToExecute = (OnSetFilterQueryProvider != null) ? OnSetFilterQueryProvider : SetFilterQueryProvider;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CursorTreeAdapter.html#setFilterQueryProvider(android.widget.FilterQueryProvider)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Widget.FilterQueryProvider"/></param>
        public virtual void SetFilterQueryProvider(Android.Widget.FilterQueryProvider arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/CursorTreeAdapter.html#setGroupCursor(android.database.Cursor)"/>
        /// </summary>
        /// <remarks>If <see cref="OnSetGroupCursor"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Android.Database.Cursor> OnSetGroupCursor { get; set; } = null;

        void SetGroupCursorEventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.Database.Cursor>> data)
        {
            var methodToExecute = (OnSetGroupCursor != null) ? OnSetGroupCursor : SetGroupCursor;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CursorTreeAdapter.html#setGroupCursor(android.database.Cursor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Database.Cursor"/></param>
        public virtual void SetGroupCursor(Android.Database.Cursor arg0)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region CursorTreeAdapterDirect
    public partial class CursorTreeAdapterDirect
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
        /// <see href="https://developer.android.com/reference/android/widget/BaseExpandableListAdapter.html#getChildTypeCount()"/> 
        /// </summary>
        public int ChildTypeCount
        {
            get { return IExecute<int>("getChildTypeCount"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CursorTreeAdapter.html#getCursor()"/> 
        /// </summary>
        public Android.Database.Cursor Cursor
        {
            get { return IExecuteWithSignature<Android.Database.Cursor>("getCursor", "()Landroid/database/Cursor;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CursorTreeAdapter.html#getFilter()"/> 
        /// </summary>
        public Android.Widget.Filter Filter
        {
            get { return IExecuteWithSignature<Android.Widget.Filter>("getFilter", "()Landroid/widget/Filter;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CursorTreeAdapter.html#getFilterQueryProvider()"/> <see href="https://developer.android.com/reference/android/widget/CursorTreeAdapter.html#setFilterQueryProvider(android.widget.FilterQueryProvider)"/>
        /// </summary>
        public Android.Widget.FilterQueryProvider FilterQueryProvider
        {
            get { return IExecuteWithSignature<Android.Widget.FilterQueryProvider>("getFilterQueryProvider", "()Landroid/widget/FilterQueryProvider;"); } set { IExecuteWithSignature("setFilterQueryProvider", "(Landroid/widget/FilterQueryProvider;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/BaseExpandableListAdapter.html#getGroupTypeCount()"/> 
        /// </summary>
        public int GroupTypeCount
        {
            get { return IExecute<int>("getGroupTypeCount"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CursorTreeAdapter.html#runQueryOnBackgroundThread(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="Android.Database.Cursor"/></returns>
        public override Android.Database.Cursor RunQueryOnBackgroundThread(Java.Lang.CharSequence arg0)
        {
            return IExecuteWithSignature<Android.Database.Cursor>("runQueryOnBackgroundThread", "(Ljava/lang/CharSequence;)Landroid/database/Cursor;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/BaseExpandableListAdapter.html#areAllItemsEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public override bool AreAllItemsEnabled()
        {
            return IExecute<bool>("areAllItemsEnabled");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/BaseExpandableListAdapter.html#isEmpty()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public override bool IsEmpty()
        {
            return IExecute<bool>("isEmpty");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/BaseExpandableListAdapter.html#getChildType(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public override int GetChildType(int arg0, int arg1)
        {
            return IExecute<int>("getChildType", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/BaseExpandableListAdapter.html#getGroupType(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public override int GetGroupType(int arg0)
        {
            return IExecute<int>("getGroupType", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CursorTreeAdapter.html#convertToString(android.database.Cursor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Database.Cursor"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public override Java.Lang.String ConvertToString(Android.Database.Cursor arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("convertToString", "(Landroid/database/Cursor;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/BaseExpandableListAdapter.html#getCombinedChildId(long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public override long GetCombinedChildId(long arg0, long arg1)
        {
            return IExecute<long>("getCombinedChildId", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/BaseExpandableListAdapter.html#getCombinedGroupId(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public override long GetCombinedGroupId(long arg0)
        {
            return IExecute<long>("getCombinedGroupId", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/BaseExpandableListAdapter.html#onGroupExpanded(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public override void OnGroupExpanded(int arg0)
        {
            IExecute("onGroupExpanded", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/BaseExpandableListAdapter.html#registerDataSetObserver(android.database.DataSetObserver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Database.DataSetObserver"/></param>
        public override void RegisterDataSetObserver(Android.Database.DataSetObserver arg0)
        {
            IExecute("registerDataSetObserver", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/BaseExpandableListAdapter.html#unregisterDataSetObserver(android.database.DataSetObserver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Database.DataSetObserver"/></param>
        public override void UnregisterDataSetObserver(Android.Database.DataSetObserver arg0)
        {
            IExecute("unregisterDataSetObserver", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CursorTreeAdapter.html#changeCursor(android.database.Cursor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Database.Cursor"/></param>
        public override void ChangeCursor(Android.Database.Cursor arg0)
        {
            IExecuteWithSignature("changeCursor", "(Landroid/database/Cursor;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CursorTreeAdapter.html#notifyDataSetChanged(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public override void NotifyDataSetChanged(bool arg0)
        {
            IExecuteWithSignature("notifyDataSetChanged", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CursorTreeAdapter.html#setChildrenCursor(int,android.database.Cursor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.Database.Cursor"/></param>
        public override void SetChildrenCursor(int arg0, Android.Database.Cursor arg1)
        {
            IExecute("setChildrenCursor", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CursorTreeAdapter.html#setGroupCursor(android.database.Cursor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Database.Cursor"/></param>
        public override void SetGroupCursor(Android.Database.Cursor arg0)
        {
            IExecuteWithSignature("setGroupCursor", "(Landroid/database/Cursor;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}