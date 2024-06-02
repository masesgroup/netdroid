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

namespace Java.Util.Function
{
    #region ILongSupplier
    /// <summary>
    /// .NET interface for org.mases.netdroid.generated.java.util.function.LongSupplier implementing <see href="https://developer.android.com/reference/java/util/function/LongSupplier.html"/>
    /// </summary>
    public partial interface ILongSupplier
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region LongSupplier
    public partial class LongSupplier : Java.Util.Function.ILongSupplier
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
        /// Handlers initializer for <see cref="LongSupplier"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("getAsLong", new global::System.EventHandler<CLRListenerEventArgs<CLREventData>>(GetAsLongEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/java/util/function/LongSupplier.html#getAsLong()"/>
        /// </summary>
        /// <remarks>If <see cref="OnGetAsLong"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<long> OnGetAsLong { get; set; } = null;

        void GetAsLongEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnGetAsLong != null) ? OnGetAsLong : GetAsLong;
            var executionResult = methodToExecute.Invoke();
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/function/LongSupplier.html#getAsLong()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public virtual long GetAsLong()
        {
            return default;
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region LongSupplierDirect
    public partial class LongSupplierDirect : Java.Util.Function.ILongSupplier
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
        /// <see href="https://developer.android.com/reference/java/util/function/LongSupplier.html#getAsLong()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public override long GetAsLong()
        {
            return IExecuteWithSignature<long>("getAsLong", "()J");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}