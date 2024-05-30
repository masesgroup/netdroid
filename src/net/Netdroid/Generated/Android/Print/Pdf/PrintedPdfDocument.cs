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

namespace Android.Print.Pdf
{
    #region PrintedPdfDocument
    public partial class PrintedPdfDocument
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/print/pdf/PrintedPdfDocument.html#%3Cinit%3E(android.content.Context,android.print.PrintAttributes)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Print.PrintAttributes"/></param>
        public PrintedPdfDocument(Android.Content.Context arg0, Android.Print.PrintAttributes arg1)
            : base(arg0, arg1)
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
        /// <see href="https://developer.android.com/reference/android/print/pdf/PrintedPdfDocument.html#getPageContentRect()"/> 
        /// </summary>
        public Android.Graphics.Rect PageContentRect
        {
            get { return IExecuteWithSignature<Android.Graphics.Rect>("getPageContentRect", "()Landroid/graphics/Rect;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/print/pdf/PrintedPdfDocument.html#getPageHeight()"/> 
        /// </summary>
        public int PageHeight
        {
            get { return IExecuteWithSignature<int>("getPageHeight", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/print/pdf/PrintedPdfDocument.html#getPageWidth()"/> 
        /// </summary>
        public int PageWidth
        {
            get { return IExecuteWithSignature<int>("getPageWidth", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/print/pdf/PrintedPdfDocument.html#startPage(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Graphics.Pdf.PdfDocument.Page"/></returns>
        public Android.Graphics.Pdf.PdfDocument.Page StartPage(int arg0)
        {
            return IExecuteWithSignature<Android.Graphics.Pdf.PdfDocument.Page>("startPage", "(I)Landroid/graphics/pdf/PdfDocument$Page;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}