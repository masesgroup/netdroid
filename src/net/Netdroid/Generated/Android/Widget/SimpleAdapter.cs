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
    #region SimpleAdapter
    public partial class SimpleAdapter : Android.Widget.IFilterable, Android.Widget.IThemedSpinnerAdapter
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
        /// Handlers initializer for <see cref="SimpleAdapter"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("getDropDownViewTheme", new global::System.EventHandler<CLRListenerEventArgs<CLREventData>>(GetDropDownViewThemeEventHandler));
            AddEventHandler("getFilter", new global::System.EventHandler<CLRListenerEventArgs<CLREventData>>(GetFilterEventHandler));
            AddEventHandler("getViewBinder", new global::System.EventHandler<CLRListenerEventArgs<CLREventData>>(GetViewBinderEventHandler));
            AddEventHandler("areAllItemsEnabled", new global::System.EventHandler<CLRListenerEventArgs<CLREventData>>(AreAllItemsEnabledEventHandler));
            AddEventHandler("hasStableIds", new global::System.EventHandler<CLRListenerEventArgs<CLREventData>>(HasStableIdsEventHandler));
            AddEventHandler("isEmpty", new global::System.EventHandler<CLRListenerEventArgs<CLREventData>>(IsEmptyEventHandler));
            AddEventHandler("isEnabled", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<int>>>(IsEnabledEventHandler));
            AddEventHandler("getItemViewType", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<int>>>(GetItemViewTypeEventHandler));
            AddEventHandler("getViewTypeCount", new global::System.EventHandler<CLRListenerEventArgs<CLREventData>>(GetViewTypeCountEventHandler));
            AddEventHandler("getAutofillOptions", new global::System.EventHandler<CLRListenerEventArgs<CLREventData>>(GetAutofillOptionsEventHandler));
            AddEventHandler("notifyDataSetChanged", new global::System.EventHandler<CLRListenerEventArgs<CLREventData>>(NotifyDataSetChangedEventHandler));
            AddEventHandler("notifyDataSetInvalidated", new global::System.EventHandler<CLRListenerEventArgs<CLREventData>>(NotifyDataSetInvalidatedEventHandler));
            AddEventHandler("registerDataSetObserver", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Android.Database.DataSetObserver>>>(RegisterDataSetObserverEventHandler));
            AddEventHandler("setAutofillOptions", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Lang.CharSequence[]>>>(SetAutofillOptionsEventHandler));
            AddEventHandler("unregisterDataSetObserver", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Android.Database.DataSetObserver>>>(UnregisterDataSetObserverEventHandler));
            AddEventHandler("setDropDownViewResource", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<int>>>(SetDropDownViewResourceEventHandler));
            AddEventHandler("setDropDownViewTheme", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Android.Content.Res.Resources.Theme>>>(SetDropDownViewThemeEventHandler));
            AddEventHandler("setViewBinder", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Android.Widget.SimpleAdapter.ViewBinder>>>(SetViewBinderEventHandler));
            AddEventHandler("setViewImage", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Android.Widget.ImageView>>>(SetViewImageEventHandler));
            AddEventHandler("setViewImage2", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Android.Widget.ImageView>>>(SetViewImage2EventHandler));
            AddEventHandler("setViewText", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Android.Widget.TextView>>>(SetViewTextEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/SimpleAdapter.html#getDropDownViewTheme()"/>
        /// </summary>
        /// <remarks>If <see cref="OnGetDropDownViewTheme"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<Android.Content.Res.Resources.Theme> OnGetDropDownViewTheme { get; set; } = null;

        void GetDropDownViewThemeEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnGetDropDownViewTheme != null) ? OnGetDropDownViewTheme : GetDropDownViewTheme;
            var executionResult = methodToExecute.Invoke();
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SimpleAdapter.html#getDropDownViewTheme()"/>
        /// </summary>
        /// <returns><see cref="Android.Content.Res.Resources.Theme"/></returns>
        public virtual Android.Content.Res.Resources.Theme GetDropDownViewTheme()
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/SimpleAdapter.html#getFilter()"/>
        /// </summary>
        /// <remarks>If <see cref="OnGetFilter"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<Android.Widget.Filter> OnGetFilter { get; set; } = null;

        void GetFilterEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnGetFilter != null) ? OnGetFilter : GetFilter;
            var executionResult = methodToExecute.Invoke();
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SimpleAdapter.html#getFilter()"/>
        /// </summary>
        /// <returns><see cref="Android.Widget.Filter"/></returns>
        public virtual Android.Widget.Filter GetFilter()
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/SimpleAdapter.html#getViewBinder()"/>
        /// </summary>
        /// <remarks>If <see cref="OnGetViewBinder"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<Android.Widget.SimpleAdapter.ViewBinder> OnGetViewBinder { get; set; } = null;

        void GetViewBinderEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnGetViewBinder != null) ? OnGetViewBinder : GetViewBinder;
            var executionResult = methodToExecute.Invoke();
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SimpleAdapter.html#getViewBinder()"/>
        /// </summary>
        /// <returns><see cref="Android.Widget.SimpleAdapter.ViewBinder"/></returns>
        public virtual Android.Widget.SimpleAdapter.ViewBinder GetViewBinder()
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/BaseAdapter.html#areAllItemsEnabled()"/>
        /// </summary>
        /// <remarks>If <see cref="OnAreAllItemsEnabled"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<bool> OnAreAllItemsEnabled { get; set; } = null;

        void AreAllItemsEnabledEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnAreAllItemsEnabled != null) ? OnAreAllItemsEnabled : AreAllItemsEnabled;
            var executionResult = methodToExecute.Invoke();
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/BaseAdapter.html#areAllItemsEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public virtual bool AreAllItemsEnabled()
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/BaseAdapter.html#hasStableIds()"/>
        /// </summary>
        /// <remarks>If <see cref="OnHasStableIds"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<bool> OnHasStableIds { get; set; } = null;

        void HasStableIdsEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnHasStableIds != null) ? OnHasStableIds : HasStableIds;
            var executionResult = methodToExecute.Invoke();
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/BaseAdapter.html#hasStableIds()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public virtual bool HasStableIds()
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/BaseAdapter.html#isEmpty()"/>
        /// </summary>
        /// <remarks>If <see cref="OnIsEmpty"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<bool> OnIsEmpty { get; set; } = null;

        void IsEmptyEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnIsEmpty != null) ? OnIsEmpty : IsEmpty;
            var executionResult = methodToExecute.Invoke();
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/BaseAdapter.html#isEmpty()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public virtual bool IsEmpty()
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/BaseAdapter.html#isEnabled(int)"/>
        /// </summary>
        /// <remarks>If <see cref="OnIsEnabled"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<int, bool> OnIsEnabled { get; set; } = null;

        void IsEnabledEventHandler(object sender, CLRListenerEventArgs<CLREventData<int>> data)
        {
            var methodToExecute = (OnIsEnabled != null) ? OnIsEnabled : IsEnabled;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData);
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/BaseAdapter.html#isEnabled(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public virtual bool IsEnabled(int arg0)
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/BaseAdapter.html#getItemViewType(int)"/>
        /// </summary>
        /// <remarks>If <see cref="OnGetItemViewType"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<int, int> OnGetItemViewType { get; set; } = null;

        void GetItemViewTypeEventHandler(object sender, CLRListenerEventArgs<CLREventData<int>> data)
        {
            var methodToExecute = (OnGetItemViewType != null) ? OnGetItemViewType : GetItemViewType;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData);
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/BaseAdapter.html#getItemViewType(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public virtual int GetItemViewType(int arg0)
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/BaseAdapter.html#getViewTypeCount()"/>
        /// </summary>
        /// <remarks>If <see cref="OnGetViewTypeCount"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<int> OnGetViewTypeCount { get; set; } = null;

        void GetViewTypeCountEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnGetViewTypeCount != null) ? OnGetViewTypeCount : GetViewTypeCount;
            var executionResult = methodToExecute.Invoke();
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/BaseAdapter.html#getViewTypeCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public virtual int GetViewTypeCount()
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/BaseAdapter.html#getAutofillOptions()"/>
        /// </summary>
        /// <remarks>If <see cref="OnGetAutofillOptions"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<Java.Lang.CharSequence[]> OnGetAutofillOptions { get; set; } = null;

        void GetAutofillOptionsEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnGetAutofillOptions != null) ? OnGetAutofillOptions : GetAutofillOptions;
            var executionResult = methodToExecute.Invoke();
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/BaseAdapter.html#getAutofillOptions()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public virtual Java.Lang.CharSequence[] GetAutofillOptions()
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/BaseAdapter.html#notifyDataSetChanged()"/>
        /// </summary>
        /// <remarks>If <see cref="OnNotifyDataSetChanged"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action OnNotifyDataSetChanged { get; set; } = null;

        void NotifyDataSetChangedEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnNotifyDataSetChanged != null) ? OnNotifyDataSetChanged : NotifyDataSetChanged;
            methodToExecute.Invoke();
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/BaseAdapter.html#notifyDataSetChanged()"/>
        /// </summary>
        public virtual void NotifyDataSetChanged()
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/BaseAdapter.html#notifyDataSetInvalidated()"/>
        /// </summary>
        /// <remarks>If <see cref="OnNotifyDataSetInvalidated"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action OnNotifyDataSetInvalidated { get; set; } = null;

        void NotifyDataSetInvalidatedEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnNotifyDataSetInvalidated != null) ? OnNotifyDataSetInvalidated : NotifyDataSetInvalidated;
            methodToExecute.Invoke();
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/BaseAdapter.html#notifyDataSetInvalidated()"/>
        /// </summary>
        public virtual void NotifyDataSetInvalidated()
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/BaseAdapter.html#registerDataSetObserver(android.database.DataSetObserver)"/>
        /// </summary>
        /// <remarks>If <see cref="OnRegisterDataSetObserver"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Android.Database.DataSetObserver> OnRegisterDataSetObserver { get; set; } = null;

        void RegisterDataSetObserverEventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.Database.DataSetObserver>> data)
        {
            var methodToExecute = (OnRegisterDataSetObserver != null) ? OnRegisterDataSetObserver : RegisterDataSetObserver;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/BaseAdapter.html#registerDataSetObserver(android.database.DataSetObserver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Database.DataSetObserver"/></param>
        public virtual void RegisterDataSetObserver(Android.Database.DataSetObserver arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/BaseAdapter.html#setAutofillOptions(java.lang.CharSequence[])"/>
        /// </summary>
        /// <remarks>If <see cref="OnSetAutofillOptions"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Lang.CharSequence[]> OnSetAutofillOptions { get; set; } = null;

        void SetAutofillOptionsEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Lang.CharSequence[]>> data)
        {
            var methodToExecute = (OnSetAutofillOptions != null) ? OnSetAutofillOptions : SetAutofillOptions;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/BaseAdapter.html#setAutofillOptions(java.lang.CharSequence[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        public virtual void SetAutofillOptions(params Java.Lang.CharSequence[] arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/BaseAdapter.html#unregisterDataSetObserver(android.database.DataSetObserver)"/>
        /// </summary>
        /// <remarks>If <see cref="OnUnregisterDataSetObserver"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Android.Database.DataSetObserver> OnUnregisterDataSetObserver { get; set; } = null;

        void UnregisterDataSetObserverEventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.Database.DataSetObserver>> data)
        {
            var methodToExecute = (OnUnregisterDataSetObserver != null) ? OnUnregisterDataSetObserver : UnregisterDataSetObserver;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/BaseAdapter.html#unregisterDataSetObserver(android.database.DataSetObserver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Database.DataSetObserver"/></param>
        public virtual void UnregisterDataSetObserver(Android.Database.DataSetObserver arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/SimpleAdapter.html#setDropDownViewResource(int)"/>
        /// </summary>
        /// <remarks>If <see cref="OnSetDropDownViewResource"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<int> OnSetDropDownViewResource { get; set; } = null;

        void SetDropDownViewResourceEventHandler(object sender, CLRListenerEventArgs<CLREventData<int>> data)
        {
            var methodToExecute = (OnSetDropDownViewResource != null) ? OnSetDropDownViewResource : SetDropDownViewResource;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SimpleAdapter.html#setDropDownViewResource(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public virtual void SetDropDownViewResource(int arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/SimpleAdapter.html#setDropDownViewTheme(android.content.res.Resources.Theme)"/>
        /// </summary>
        /// <remarks>If <see cref="OnSetDropDownViewTheme"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Android.Content.Res.Resources.Theme> OnSetDropDownViewTheme { get; set; } = null;

        void SetDropDownViewThemeEventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.Content.Res.Resources.Theme>> data)
        {
            var methodToExecute = (OnSetDropDownViewTheme != null) ? OnSetDropDownViewTheme : SetDropDownViewTheme;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SimpleAdapter.html#setDropDownViewTheme(android.content.res.Resources.Theme)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Res.Resources.Theme"/></param>
        public virtual void SetDropDownViewTheme(Android.Content.Res.Resources.Theme arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/SimpleAdapter.html#setViewBinder(android.widget.SimpleAdapter.ViewBinder)"/>
        /// </summary>
        /// <remarks>If <see cref="OnSetViewBinder"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Android.Widget.SimpleAdapter.ViewBinder> OnSetViewBinder { get; set; } = null;

        void SetViewBinderEventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.Widget.SimpleAdapter.ViewBinder>> data)
        {
            var methodToExecute = (OnSetViewBinder != null) ? OnSetViewBinder : SetViewBinder;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SimpleAdapter.html#setViewBinder(android.widget.SimpleAdapter.ViewBinder)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Widget.SimpleAdapter.ViewBinder"/></param>
        public virtual void SetViewBinder(Android.Widget.SimpleAdapter.ViewBinder arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/SimpleAdapter.html#setViewImage(android.widget.ImageView,int)"/>
        /// </summary>
        /// <remarks>If <see cref="OnSetViewImage"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Android.Widget.ImageView, int> OnSetViewImage { get; set; } = null;

        void SetViewImageEventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.Widget.ImageView>> data)
        {
            var methodToExecute = (OnSetViewImage != null) ? OnSetViewImage : SetViewImage;
            methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<int>(0));
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SimpleAdapter.html#setViewImage(android.widget.ImageView,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Widget.ImageView"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public virtual void SetViewImage(Android.Widget.ImageView arg0, int arg1)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/SimpleAdapter.html#setViewImage(android.widget.ImageView,java.lang.String)"/>
        /// </summary>
        /// <remarks>If <see cref="OnSetViewImage2"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Android.Widget.ImageView, Java.Lang.String> OnSetViewImage2 { get; set; } = null;

        void SetViewImage2EventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.Widget.ImageView>> data)
        {
            var methodToExecute = (OnSetViewImage2 != null) ? OnSetViewImage2 : SetViewImage;
            methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<Java.Lang.String>(0));
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SimpleAdapter.html#setViewImage(android.widget.ImageView,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Widget.ImageView"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public virtual void SetViewImage(Android.Widget.ImageView arg0, Java.Lang.String arg1)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/SimpleAdapter.html#setViewText(android.widget.TextView,java.lang.String)"/>
        /// </summary>
        /// <remarks>If <see cref="OnSetViewText"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Android.Widget.TextView, Java.Lang.String> OnSetViewText { get; set; } = null;

        void SetViewTextEventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.Widget.TextView>> data)
        {
            var methodToExecute = (OnSetViewText != null) ? OnSetViewText : SetViewText;
            methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<Java.Lang.String>(0));
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SimpleAdapter.html#setViewText(android.widget.TextView,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Widget.TextView"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public virtual void SetViewText(Android.Widget.TextView arg0, Java.Lang.String arg1)
        {
            
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
            /// <see href="https://developer.android.com/reference/android/widget/SimpleAdapter.ViewBinder.html#setViewValue(android.view.View,java.lang.Object,java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.View"/></param>
            /// <param name="arg1"><see cref="object"/></param>
            /// <param name="arg2"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="bool"/></returns>
            public bool SetViewValue(Android.View.View arg0, object arg1, Java.Lang.String arg2)
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

    #region SimpleAdapterDirect
    public partial class SimpleAdapterDirect : Android.Widget.IFilterable, Android.Widget.IThemedSpinnerAdapter
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
        /// <see href="https://developer.android.com/reference/android/widget/SimpleAdapter.html#getDropDownViewTheme()"/>
        /// </summary>
        /// <returns><see cref="Android.Content.Res.Resources.Theme"/></returns>
        public override Android.Content.Res.Resources.Theme GetDropDownViewTheme()
        {
            return IExecuteWithSignature<Android.Content.Res.Resources.Theme>("getDropDownViewTheme", "()Landroid/content/res/Resources$Theme;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SimpleAdapter.html#getFilter()"/>
        /// </summary>
        /// <returns><see cref="Android.Widget.Filter"/></returns>
        public override Android.Widget.Filter GetFilter()
        {
            return IExecuteWithSignature<Android.Widget.Filter>("getFilter", "()Landroid/widget/Filter;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SimpleAdapter.html#getViewBinder()"/>
        /// </summary>
        /// <returns><see cref="Android.Widget.SimpleAdapter.ViewBinder"/></returns>
        public override Android.Widget.SimpleAdapter.ViewBinder GetViewBinder()
        {
            return IExecuteWithSignature<Android.Widget.SimpleAdapter.ViewBinder>("getViewBinder", "()Landroid/widget/SimpleAdapter$ViewBinder;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/BaseAdapter.html#areAllItemsEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public override bool AreAllItemsEnabled()
        {
            return IExecute<bool>("areAllItemsEnabled");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/BaseAdapter.html#hasStableIds()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public override bool HasStableIds()
        {
            return IExecute<bool>("hasStableIds");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/BaseAdapter.html#isEmpty()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public override bool IsEmpty()
        {
            return IExecute<bool>("isEmpty");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/BaseAdapter.html#isEnabled(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public override bool IsEnabled(int arg0)
        {
            return IExecute<bool>("isEnabled", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/BaseAdapter.html#getItemViewType(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public override int GetItemViewType(int arg0)
        {
            return IExecute<int>("getItemViewType", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/BaseAdapter.html#getViewTypeCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public override int GetViewTypeCount()
        {
            return IExecute<int>("getViewTypeCount");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/BaseAdapter.html#getAutofillOptions()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public override Java.Lang.CharSequence[] GetAutofillOptions()
        {
            return IExecuteArray<Java.Lang.CharSequence>("getAutofillOptions");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/BaseAdapter.html#notifyDataSetChanged()"/>
        /// </summary>
        public override void NotifyDataSetChanged()
        {
            IExecute("notifyDataSetChanged");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/BaseAdapter.html#notifyDataSetInvalidated()"/>
        /// </summary>
        public override void NotifyDataSetInvalidated()
        {
            IExecute("notifyDataSetInvalidated");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/BaseAdapter.html#registerDataSetObserver(android.database.DataSetObserver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Database.DataSetObserver"/></param>
        public override void RegisterDataSetObserver(Android.Database.DataSetObserver arg0)
        {
            IExecute("registerDataSetObserver", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/BaseAdapter.html#setAutofillOptions(java.lang.CharSequence[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        public override void SetAutofillOptions(params Java.Lang.CharSequence[] arg0)
        {
            if (arg0.Length == 0) IExecute("setAutofillOptions"); else IExecute("setAutofillOptions", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/BaseAdapter.html#unregisterDataSetObserver(android.database.DataSetObserver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Database.DataSetObserver"/></param>
        public override void UnregisterDataSetObserver(Android.Database.DataSetObserver arg0)
        {
            IExecute("unregisterDataSetObserver", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SimpleAdapter.html#setDropDownViewResource(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public override void SetDropDownViewResource(int arg0)
        {
            IExecuteWithSignature("setDropDownViewResource", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SimpleAdapter.html#setDropDownViewTheme(android.content.res.Resources.Theme)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Res.Resources.Theme"/></param>
        public override void SetDropDownViewTheme(Android.Content.Res.Resources.Theme arg0)
        {
            IExecuteWithSignature("setDropDownViewTheme", "(Landroid/content/res/Resources$Theme;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SimpleAdapter.html#setViewBinder(android.widget.SimpleAdapter.ViewBinder)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Widget.SimpleAdapter.ViewBinder"/></param>
        public override void SetViewBinder(Android.Widget.SimpleAdapter.ViewBinder arg0)
        {
            IExecuteWithSignature("setViewBinder", "(Landroid/widget/SimpleAdapter$ViewBinder;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SimpleAdapter.html#setViewImage(android.widget.ImageView,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Widget.ImageView"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public override void SetViewImage(Android.Widget.ImageView arg0, int arg1)
        {
            IExecute("setViewImage", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SimpleAdapter.html#setViewImage(android.widget.ImageView,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Widget.ImageView"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public override void SetViewImage(Android.Widget.ImageView arg0, Java.Lang.String arg1)
        {
            IExecute("setViewImage", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SimpleAdapter.html#setViewText(android.widget.TextView,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Widget.TextView"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public override void SetViewText(Android.Widget.TextView arg0, Java.Lang.String arg1)
        {
            IExecute("setViewText", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}