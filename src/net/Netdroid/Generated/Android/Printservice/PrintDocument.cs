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

namespace Android.Printservice
{
    #region PrintDocument
    public partial class PrintDocument
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
        /// <see href="https://developer.android.com/reference/android/printservice/PrintDocument.html#getData()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.ParcelFileDescriptor"/></returns>
        public Android.Os.ParcelFileDescriptor GetData()
        {
            return IExecuteWithSignature<Android.Os.ParcelFileDescriptor>("getData", "()Landroid/os/ParcelFileDescriptor;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/printservice/PrintDocument.html#getInfo()"/>
        /// </summary>
        /// <returns><see cref="Android.Print.PrintDocumentInfo"/></returns>
        public Android.Print.PrintDocumentInfo GetInfo()
        {
            return IExecuteWithSignature<Android.Print.PrintDocumentInfo>("getInfo", "()Landroid/print/PrintDocumentInfo;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}